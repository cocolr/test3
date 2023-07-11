﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test3.BLL;

namespace test3.UI
{
    public partial class ChangeStudentclass : Form
    {
        public ChangeStudentclass()
        {
            InitializeComponent();
        }

        private void ChangeStudentclass_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet3.Class”中。您可以根据需要移动或删除它。
            this.classTableAdapter.Fill(this.studentDataSet3.Class);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    throw new Exception("必须填写学号");
                }
                StudentService.defaultInstance.StuChangeclass(textBox1.Text.Trim(), comboBox1.Text.Trim());
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
