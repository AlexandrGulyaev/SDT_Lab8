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
using System.Xml.Serialization;


namespace Gulyaev_AG_8
{
    public partial class FormSearch : Form
    {
        // Журнал со всеми записями
        static public List<Record> magazine = new List<Record>();
        // Выборка из журнала
        static public List<Record> SaveRecords = new List<Record>();

        public FormSearch(List<Record> p_magazine)
        {
            InitializeComponent();
            magazine = p_magazine;
        }

        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            foreach (Record rec in magazine)
                listBox1.Items.Add(rec.Year + " " + rec.Group + " " + rec.LastName + " " + rec.RecordBook + " " + rec.Subject + " " + rec.Grade);

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
            AVG_Calc();
        }

        private List<Record> MakeSelection()
        {
            List<Record> SearchRecords = new List<Record>();
            try
            {
                listBox1.Items.Clear();
                SaveRecords.Clear();
                SearchRecords.AddRange(magazine);
                if (checkBoxLastName.Checked && textBoxLastName.Text != "")
                {
                    IEnumerable<Record> evens = from i in SearchRecords
                                                where i.LastName.Equals(textBoxLastName.Text)
                                                select i;
                    SearchRecords = new List<Record>(evens);

                }
                if (checkBoxRecordbook.Checked && textBoxRecordbook.Text != "")
                {
                    IEnumerable<Record> evens = from i in SearchRecords
                                                where i.RecordBook.Equals(UInt64.Parse(textBoxRecordbook.Text))
                                                select i;
                    SearchRecords = new List<Record>(evens);
                }
                if (checkBoxYear.Checked)
                {
                    IEnumerable<Record> evens = from i in SearchRecords
                                                where i.Year.Equals(ushort.Parse(numericUpDownYear.Value.ToString()))
                                                select i;
                    SearchRecords = new List<Record>(evens);
                }
                if (checkBoxGroup.Checked)
                {
                    IEnumerable<Record> evens = from i in SearchRecords
                                                where i.Group.Equals(comboBoxGroup.Text)
                                                select i;
                    SearchRecords = new List<Record>(evens);
                }
                if (checkBoxSubject.Checked)
                {
                    IEnumerable<Record> evens = from i in SearchRecords
                                                where i.Subject.Equals(comboBoxSubject.Text)
                                                select i;
                    SearchRecords = new List<Record>(evens);
                }
                if (checkBoxGrade.Checked)
                {
                    IEnumerable<Record> evens = from i in SearchRecords
                                                where i.Grade.Equals(UInt16.Parse(numericUpDownGrade.Value.ToString()))
                                                select i;
                    Record rec = SearchRecords.First();
                    SearchRecords = new List<Record>(evens);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return SearchRecords;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Record> SearchRecords = MakeSelection();
            foreach (Record rec in SearchRecords)
                listBox1.Items.Add(rec.Year + " " + rec.Group + " " + rec.LastName + " " + rec.RecordBook + " " + rec.Subject + " " + rec.Grade);
            SaveRecords.AddRange(SearchRecords);
            AVG_Calc();
        }

        private void textBoxRecordbook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            XmlSerializer formatter = new XmlSerializer(typeof(List<Record>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(fs, SaveRecords);
                MessageBox.Show("Файл сохранён.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Record rec in magazine)
                listBox1.Items.Add(rec.Year + " " + rec.Group + " " + rec.LastName + " " + rec.RecordBook + " " + rec.Subject + " " + rec.Grade);
            checkBoxLastName.Checked = false;
            checkBoxRecordbook.Checked = false;
            checkBoxYear.Checked = false;
            checkBoxGroup.Checked = false;
            checkBoxSubject.Checked = false;
            checkBoxGrade.Checked = false;
            AVG_Calc();
        }

        private void AVG_Calc()
        {
            try
            {
                List<Record> SearchRecords = MakeSelection();
                foreach (Record rec in SearchRecords)
                    listBox1.Items.Add(rec.Year + " " + rec.Group + " " + rec.LastName + " " + rec.RecordBook + " " + rec.Subject + " " + rec.Grade);
                SaveRecords.AddRange(SearchRecords);
                double AVG = 0;
                foreach (Record rec in SaveRecords)
                {
                    AVG += rec.Grade;
                }
                AVG = AVG / SaveRecords.Count;
                labelAVGGrade.Text = String.Format("{0:f3}", AVG);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
