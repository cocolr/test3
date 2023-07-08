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
    public partial class AddClass : Form
    {
        Model1 context = new Model1();
        public AddClass()
        {
            InitializeComponent();
        }
        void showAll()
        {
            var entities = context.Class.ToList();
            dataGridView1.DataSource = entities;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    throw new Exception("必须填写学号和班级");
                }
                StudentService.defaultInstance.AddClass(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), dateTimePicker1.Value);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            showAll();
        }
    }
}
