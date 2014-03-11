using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EnvDTE;
using System.Text;

namespace FileIncludeControl
{
    public partial class Form1 : Form
    {
        private List<DTE> DTES = new List<DTE>();
        private DTE CurrentDTE = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarkSureDTE();

            IncludeNewFiles();
        }

        private void MarkSureDTE()
        {
            if (CurrentDTE == null)
            {
                var dte2 = EnvDTEHelper.GetAllInstances();

                var dteNameList = new List<string>();
                DTES.Clear();

                foreach (var dte in dte2)
                {
                    if (!dte.Solution.IsOpen)
                        continue;

                    dteNameList.Add(dte.Solution.FullName);

                    DTES.Add(dte);
                }

                if (dteNameList.Count == 0)
                {
                    MessageBox.Show("请打开Visual Studio");
                    return;
                }

                if (dteNameList.Count > 1)
                {
                    var frm = new FrmSolutions(dteNameList);
                    frm.ShowDialog();
                    if (frm.SelectIndex == -1)
                        return;

                    CurrentDTE = DTES[frm.SelectIndex];
                }
                else
                {
                    CurrentDTE = DTES[0];
                }
            }
        }

        public void IncludeNewFiles()
        {
            int count = 0;
            EnvDTE.DTE dte2;
            List<string> newfiles;

            dte2 = CurrentDTE;

            if (CurrentDTE == null)
            {
                MessageBox.Show("请选择解决方案");
                return;
            }

            Log("操作解决方案为：" + CurrentDTE.Solution.FullName);

            var fileList = GetFileList();
            var expList = GetExpList();
            var dirList = GetDirList();

            var projects = GetAllProjects();
            if (projects.Count == 0)
            {
                MessageBox.Show("解决方案中未找到加载的项目");
                return;
            }

            Log("解决方案中共找到 " + projects.Count + " 个有效项目");

            foreach (Project project in projects)
            {
                if (project.UniqueName.EndsWith(".csproj"))
                {
                    newfiles = GetFilesNotInProject(project);

                    foreach (var file in newfiles)
                    {
                        //检查文件
                        if (fileList.Count > 0)
                        {
                            if (fileList.All(n => file.IndexOf(n, StringComparison.OrdinalIgnoreCase) == -1))
                                continue;
                        }

                        //排除文件
                        if (expList.Count > 0)
                        {
                            if (expList.Any(n => file.IndexOf(n, StringComparison.OrdinalIgnoreCase) > -1))
                                continue;
                        }

                        //排除目录
                        if (dirList.Count > 0)
                        {
                            var path = Path.GetDirectoryName(file);

                            if (!string.IsNullOrEmpty(path))
                            {
                                if (dirList.Any(n => path.IndexOf(n, StringComparison.OrdinalIgnoreCase) > -1))
                                    continue;
                            }
                        }

                        project.ProjectItems.AddFromFile(file);
                        count++;
                    }
                }
            }

            MessageBox.Show(string.Format("共操作 {0} 个文件", count));
        }

        public List<string> GetAllProjectFiles(ProjectItems projectItems, string extension)
        {
            var returnValue = new List<string>();

            foreach (ProjectItem projectItem in projectItems)
            {
                for (short i = 1; i <= projectItems.Count; i++)
                {
                    string fileName = projectItem.FileNames[i];
                    var s = Path.GetExtension(fileName);
                    if (s != null && s.ToLower() == extension)
                        returnValue.Add(fileName);
                }
                returnValue.AddRange(GetAllProjectFiles(projectItem.ProjectItems, extension));
            }

            return returnValue;
        }

        public List<string> GetFilesInProject(Project project)
        {
            var ret = GetAllProjectFiles(project.ProjectItems, ".cs");

            if (ret == null || ret.Count == 0)
                return new List<string>();

            return ret.Distinct().ToList();
        }

        public List<string> GetFilesNotInProject(Project project)
        {
            var returnValue = new List<string>();
            var startPath = Path.GetDirectoryName(project.FullName);
            var projectFiles = GetAllProjectFiles(project.ProjectItems, ".cs");

            foreach (var file in Directory.GetFiles(startPath, "*.cs", SearchOption.AllDirectories))
                if (!projectFiles.Contains(file)) returnValue.Add(file);

            return returnValue;
        }

        private List<string> GetFileList()
        {
            var t = txtFileName.Text;
            if (!string.IsNullOrEmpty(t))
                return t.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            return new List<string>();
        }

        private List<string> GetDirList()
        {
            var t = txtExpDir.Text;
            if (!string.IsNullOrEmpty(t))
                return t.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            return new List<string>();
        }

        private List<string> GetExpList()
        {
            var t = txtExpFile.Text;
            if (!string.IsNullOrEmpty(t))
                return t.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            return new List<string>();
        }

        public List<Project> GetAllProjects()
        {
            var projects = CurrentDTE.Solution.Projects;

            var list = new List<Project>();

            foreach (Project project in projects)
            {
                var subItems = GetProjects(project);

                if (subItems.Count > 0)
                    list.AddRange(subItems);
            }

            return list;
        }

        private List<Project> GetProjects(Project project)
        {
            var list = new List<Project>();

            if (project.UniqueName.EndsWith(".csproj"))
            {
                list.Add(project);
            }
            else if (project.ProjectItems != null && project.ProjectItems.Count > 0)
            {
                //可能是虚拟文件夹
                var subItems = GetSubProject(project.ProjectItems);
                if (subItems.Count > 0)
                {
                    list.AddRange(subItems);
                }
            }

            return list;
        }

        private List<Project> GetSubProject(ProjectItems projectItems)
        {
            var list = new List<Project>();

            foreach (ProjectItem projectItem in projectItems)
            {
                if (projectItem.SubProject != null)
                {
                    var sub = GetProjects(projectItem.SubProject);

                    if (sub != null)
                    {
                        list.AddRange(sub);
                    }
                }
            }

            return list;
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            MarkSureDTE();

            if (CurrentDTE == null)
            {
                MessageBox.Show("请选择解决方案");
                return;
            }

            Log("操作解决方案为：" + CurrentDTE.Solution.FullName);

            var projects = GetAllProjects();
            if (projects.Count == 0)
            {
                MessageBox.Show("解决方案中未找到加载的项目");
                return;
            }

            Log("解决方案中共找到 " + projects.Count + " 个有效项目");

            foreach (Project project in projects)
            {
                if (project.UniqueName.EndsWith(".csproj"))
                {
                    var files = GetFilesInProject(project);

                    if (files != null && files.Count > 0)
                    {
                        Group(project, files);
                    }
                }
            }
        }

        private void Group(Project project, List<string> files)
        {
            var dict = new Dictionary<string, List<string>>();

            var fileA = string.IsNullOrEmpty(txtFileA.Text) ? "" : txtFileA.Text.ToLower();
            var fileB = string.IsNullOrEmpty(txtFileB.Text) ? "" : txtFileB.Text.ToLower();

            var regA = fileA.Replace("[file]", "\\s*");

            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);

                if (string.IsNullOrEmpty(fileName))
                {
                    Log("文件：" + file + "获取文件名失败");
                    continue;
                }

                var maybeFileName = Regex.Replace(fileName, regA, "", RegexOptions.IgnoreCase);

                var maybeFileB = fileB.Replace("[file]", maybeFileName).ToLower();

                var belongB = files.FindAll(n => n.ToLower().EndsWith(maybeFileB));

                if (belongB.Count > 0)
                {
                    //如果自己已经是别人的包含文件，那么把自己加入到那个LIST中
                    var ext = dict.FirstOrDefault(n => n.Value.Any(m => m == file));
                    if (string.IsNullOrEmpty(ext.Key))
                    {
                        dict.Add(file, belongB);
                    }
                    else
                    {
                        ext.Value.AddRange(belongB);
                    }
                }
            }

            if (dict.Count > 0)
            {
                foreach (var kv in dict)
                {
                    Group(project, kv.Key, kv.Value);
                }
            }
        }

        private void Group(Project project, string rootFile, List<string> belongFiles)
        {
            var fileName = Path.GetFileName(rootFile);
            ProjectItem rootItem = null;

            try
            {
                rootItem = project.ProjectItems.Item(fileName);
            }
            catch
            {
                Log("项目中不包含文件：" + rootFile);
            }

            if (rootItem == null)
            {
                return;
            }

            foreach (var file in belongFiles)
            {
                rootItem.ProjectItems.AddFromFile(file);
            }

            Log("文件：" + rootFile + "成功包含" + string.Join(",", belongFiles));
        }

        private void Log(string msg)
        {
            var log = txtLog.Text;
            if (!string.IsNullOrEmpty(log))
            {
                msg = msg + "\r\n";
            }

            txtLog.Text = msg + log;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AboutBox1();
            frm.ShowDialog();
        }
    }
}
