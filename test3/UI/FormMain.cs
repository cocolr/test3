using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClass frm = new AddClass();
            frm.ShowDialog();
        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterSudent frm = new RegisterSudent();
            frm.ShowDialog();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeClass frm = new ChangeClass();
            frm.ShowDialog();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnregisterStudent frm = new UnregisterStudent();
            frm.ShowDialog();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckClass frm = new CheckClass();
            frm.ShowDialog();
        }

        private void 转班ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeStudentclass frm = new ChangeStudentclass();
            frm.ShowDialog();
        }

        private void 查看ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckStudent frm = new CheckStudent();
            frm.ShowDialog();
        }
    }
}
