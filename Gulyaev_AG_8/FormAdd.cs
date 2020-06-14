using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gulyaev_AG_8
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            string pathGroups = "Groups.txt";
            using (StreamReader sr = new StreamReader(pathGroups, System.Text.Encoding.UTF8))
            {
                string group;
                while ((group = sr.ReadLine()) != null)
                {
                    comboBoxGroup.Items.Add(group);
                }
            }

            string pathSubjects = "Subjects.txt";
            using (StreamReader sr = new StreamReader(pathSubjects, System.Text.Encoding.UTF8))
            {
                string subject;
                while ((subject = sr.ReadLine()) != null)
                {
                    comboBoxSubject.Items.Add(subject);
                }
            }

            comboBoxGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGroup.SelectedIndex = 0;
            comboBoxSubject.SelectedIndex = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form1.AddingCanceled = true;
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxLastName.Text.Trim(' ');
            textBoxRecordbook.Text.Trim(' ');
            if (textBoxLastName.Text != "" || textBoxRecordbook.Text != "")
            {
                Record record = new Record(UInt16.Parse(numericUpDownYear.Value.ToString()), comboBoxGroup.Text, textBoxLastName.Text, UInt64.Parse(textBoxRecordbook.Text), comboBoxSubject.Text, UInt16.Parse(numericUpDownGrade.Value.ToString()));
                Form1.magazine.Add(record);
                Form1.AddingCanceled = false;
                this.Close();
            }
            else { MessageBox.Show("Некорректное заполнение полей."); }
        }

        private void textBoxRecordbook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

    }
}
