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
    public partial class UnregisterStudent : Form
    {
        Model1 context = new Model1();
        public UnregisterStudent()
        {
            InitializeComponent();
        }
        private void UnregisterStudent_Load(object sender, EventArgs e)
        {
            showAll();
        }
        void showAll()
        {
            var entities = context.Student.ToList();

            dataGridView1.DataSource = entities;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sno = textBox1.Text.Trim();
                Student _student = StudentService.defaultInstance.findSudentBysno(sno);
                if (MessageBox.Show(string.Format("确定注销学生\n学号:{0} 姓名:{1}", _student.sno, _student.sname), "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StudentService.defaultInstance.UnregisterStudent(textBox1.Text.Trim(), comboBox1.Text.Trim());
                    MessageBox.Show("注销成功");
                    showAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            showAll();
        }


    }
}
