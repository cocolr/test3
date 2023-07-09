using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test3.BLL;
using test3.Model;

namespace test3.UI
{
    public partial class CheckClass : Form
    {
        Model1 context = new Model1();
        public CheckClass()
        {
            InitializeComponent();
        }

        void showAll()
        {
            var entities = context.Class.ToList();
            dataGridView1.DataSource = entities;
        }
        private void CheckClass_Load(object sender, EventArgs e)
        {
            showAll();
        }
    }
}
