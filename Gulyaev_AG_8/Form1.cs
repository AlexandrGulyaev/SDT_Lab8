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
using System.Xml;
using System.Xml.Serialization;

namespace Gulyaev_AG_8
{
    public partial class Form1 : Form
    {
        public static bool AddingCanceled = false;
        static public List<Record> magazine = new List<Record>();

        public Form1()
        {
            InitializeComponent();
        }

        public static void SelectFile(string filename)
        {
            int errorInXml = 0;
            int cnt_rec = 1;
            magazine.Clear();
            try
            {
                XmlDocument xDoc = new XmlDocument();
                errorInXml = 7;
                xDoc.Load(filename);
                // Корневой элемент
                XmlElement xRoot = xDoc.DocumentElement;

                // обход всех узлов в корневом элементе
                foreach (XmlNode xnode in xRoot)
                {
                    string Element = "";
                    Record record = new Record();

                    // обход всех дочерних узлов элемента
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        // year
                        if (childnode.Name.ToLower() == "year")
                        {
                            errorInXml = 1;
                            record.Year = UInt16.Parse(childnode.InnerText);
                            if (record.Year > 6) record.Year = 6;
                            if (record.Year == 0) record.Year = 1;
                        }
                        // group
                        if (childnode.Name.ToLower() == "group")
                        {
                            errorInXml = 2;
                            record.Group = childnode.InnerText;
                            record.Group = record.Group.Replace(" ", string.Empty);
                        }
                        // lastName
                        if (childnode.Name.ToLower() == "lastname")
                        {
                            errorInXml = 3;
                            record.LastName = childnode.InnerText;
                            record.LastName = record.LastName.Replace(" ", string.Empty);
                        }
                        // recordBook
                        if (childnode.Name.ToLower() == "recordbook")
                        {
                            errorInXml = 4;
                            record.RecordBook = UInt64.Parse(childnode.InnerText);
                            if (record.RecordBook == 0) record.RecordBook = 1;
                        }
                        // subject
                        if (childnode.Name.ToLower() == "subject")
                        {
                            errorInXml = 5;
                            record.Subject = childnode.InnerText;
                            record.Subject = record.Subject.Replace(" ", string.Empty);
                        }
                        // grade
                        if (childnode.Name.ToLower() == "grade")
                        {
                            errorInXml = 6;
                            record.Grade = UInt16.Parse(childnode.InnerText);
                            if (record.Grade > 5) record.Grade = 5;
                            if (record.Grade < 2) record.Grade = 2;
                        }
                    }
                    cnt_rec++;
                    magazine.Add(record);
                }

            }
            catch (Exception ex)
            {
                switch (errorInXml)
                {
                    case 0: MessageBox.Show(filename + " не найден"); break;
                    case 1: MessageBox.Show("В записи " + cnt_rec + " некорректное поле year"); break;
                    case 2: MessageBox.Show("В записи " + cnt_rec + " некорректное поле group"); break;
                    case 3: MessageBox.Show("В записи " + cnt_rec + " некорректное поле lastName"); break;
                    case 4: MessageBox.Show("В записи " + cnt_rec + " некорректное поле recordBook"); break;
                    case 5: MessageBox.Show("В записи " + cnt_rec + " некорректное поле subject"); break;
                    case 6: MessageBox.Show("В записи " + cnt_rec + " некорректное поле grade"); break;
                    case 7: MessageBox.Show(ex.Message); break;
                    default: MessageBox.Show(ex.Message); errorInXml = 8; break;
                }
                MessageBox.Show("Загрузка последующих записей остановлена");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        { 
            string filename = "Magazine.xml";
            int errorInXml = 0;
            int cnt_rec = 1;
            SelectFile(filename);
            foreach (Record rec in magazine)
                listBox1.Items.Add(rec.Year + " " + rec.Group + " " + rec.LastName + " " + rec.RecordBook + " " + rec.Subject + " " + rec.Grade);
            if (listBox1.Items.Count == 0)
            {
                buttonSearch.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
            if (!AddingCanceled)
            {
                Record rec = magazine.Last();
                listBox1.Items.Add(rec.Year + " " + rec.Group + " " + rec.LastName + " " + rec.RecordBook + " " + rec.Subject + " " + rec.Grade);
            }
            AddingCanceled = false;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try { 
            magazine.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch Search = new FormSearch(magazine);
            Search.Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            XmlSerializer formatter = new XmlSerializer(typeof(List<Record>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(fs, magazine);
                MessageBox.Show("Файл успешно сохранен");
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            SelectFile(filename);
            listBox1.Items.Clear();
            foreach (Record rec in magazine)
                listBox1.Items.Add(rec.Year + " " + rec.Group + " " + rec.LastName + " " + rec.RecordBook + " " + rec.Subject + " " + rec.Grade);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDel.Enabled = true;
            buttonSearch.Enabled = true;
            if (listBox1.SelectedIndex == -1)
            {
                buttonDel.Enabled = false;
                //buttonSearch.Enabled = false;
            }
        }
    }
}
