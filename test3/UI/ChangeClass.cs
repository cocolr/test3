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
    public partial class ChangeClass : Form
    {
        Model1 context = new Model1();
        public ChangeClass()
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
                if (textBox3.Text == "" && textBox1.Text == "")
                {
                    throw new Exception("必须填写班级编号和班级");
                }
                StudentService.defaultInstance.ChangeClass(textBox3.Text.Trim(), textBox1.Text.Trim(), textBox2.Text.Trim(),  dateTimePicker1.Value);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }

        }

        private void ChangeClass_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet2.Class”中。您可以根据需要移动或删除它。
            this.classTableAdapter.Fill(this.studentDataSet2.Class);
            showAll();

        }
    }
}
