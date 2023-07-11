using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test3.Model;

namespace test3.UI
{
    public partial class CheckStudent : Form
    {
        Model1 context = new Model1();
        public CheckStudent()
        {
            InitializeComponent();
        }
        void showAll()
        {
            var entities = context.Student.ToList();
            dataGridView1.DataSource = entities;
        }
        private void CheckStudent_Load(object sender, EventArgs e)
        {
            showAll();
        }
    }
}
