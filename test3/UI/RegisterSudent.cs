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
    public partial class RegisterSudent : Form
    {
        Model1 context = new Model1();
        public RegisterSudent()
        {
            InitializeComponent();
        }

        void showAll()
        {
            var entities = context.Student.ToList();
            dataGridView1.DataSource = entities;
        }
        private void RegisterSudent_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet.Class”中。您可以根据需要移动或删除它。
            this.classTableAdapter.Fill(this.studentDataSet.Class);

            showAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == ""&& comboBox2.Text == "")
                {
                    throw new Exception("必须填写学号和班级");
                }
                StudentService.defaultInstance.RegisterSudent(textBox1.Text, textBox2.Text, comboBox1.Text, dateTimePicker1.Value,comboBox2.Text);
                MessageBox.Show("注册成功！");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
