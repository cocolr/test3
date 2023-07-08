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
    }
}
