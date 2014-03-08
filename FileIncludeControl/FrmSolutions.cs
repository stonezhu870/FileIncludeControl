using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileIncludeControl
{
    public partial class FrmSolutions : Form
    {
        public int SelectIndex { get; private set; }

        public FrmSolutions(List<string> items)
        {
            InitializeComponent();

            this.listBox1.Items.AddRange(items.Cast<object>().ToArray());

            SelectIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectIndex = listBox1.SelectedIndex;
            this.Close();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectIndex = listBox1.SelectedIndex;

            if (SelectIndex == -1)
            {
                MessageBox.Show("请选择项");
                return;
            }

            this.Close();
        }
    }
}
