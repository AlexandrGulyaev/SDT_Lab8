namespace Gulyaev_AG_8
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.textBoxRecordbook = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.checkBoxGrade = new System.Windows.Forms.CheckBox();
            this.checkBoxRecordbook = new System.Windows.Forms.CheckBox();
            this.checkBoxSubject = new System.Windows.Forms.CheckBox();
            this.checkBoxLastName = new System.Windows.Forms.CheckBox();
            this.checkBoxGroup = new System.Windows.Forms.CheckBox();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAVGGrade = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(782, 204);
            this.listBox1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.buttonSearch.Location = new System.Drawing.Point(597, 229);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(191, 39);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.buttonBack.Location = new System.Drawing.Point(597, 399);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(191, 39);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.buttonSave.Location = new System.Drawing.Point(597, 351);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(191, 39);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить отчёт";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.buttonShowAll.Location = new System.Drawing.Point(597, 274);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(191, 39);
            this.buttonShowAll.TabIndex = 1;
            this.buttonShowAll.Text = "Показать все";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.comboBoxSubject);
            this.groupBoxParams.Controls.Add(this.comboBoxGroup);
            this.groupBoxParams.Controls.Add(this.textBoxRecordbook);
            this.groupBoxParams.Controls.Add(this.textBoxLastName);
            this.groupBoxParams.Controls.Add(this.numericUpDownGrade);
            this.groupBoxParams.Controls.Add(this.numericUpDownYear);
            this.groupBoxParams.Controls.Add(this.checkBoxGrade);
            this.groupBoxParams.Controls.Add(this.checkBoxRecordbook);
            this.groupBoxParams.Controls.Add(this.checkBoxSubject);
            this.groupBoxParams.Controls.Add(this.checkBoxLastName);
            this.groupBoxParams.Controls.Add(this.checkBoxGroup);
            this.groupBoxParams.Controls.Add(this.checkBoxYear);
            this.groupBoxParams.Font = new System.Drawing.Font("Courier New", 10F);
            this.groupBoxParams.Location = new System.Drawing.Point(6, 217);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(400, 221);
            this.groupBoxParams.TabIndex = 2;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(196, 145);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(191, 28);
            this.comboBoxSubject.TabIndex = 3;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(196, 55);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(191, 28);
            this.comboBoxGroup.TabIndex = 3;
            // 
            // textBoxRecordbook
            // 
            this.textBoxRecordbook.Location = new System.Drawing.Point(196, 117);
            this.textBoxRecordbook.Name = "textBoxRecordbook";
            this.textBoxRecordbook.Size = new System.Drawing.Size(191, 26);
            this.textBoxRecordbook.TabIndex = 2;
            this.textBoxRecordbook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRecordbook_KeyPress);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(196, 85);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(191, 26);
            this.textBoxLastName.TabIndex = 2;
            // 
            // numericUpDownGrade
            // 
            this.numericUpDownGrade.Location = new System.Drawing.Point(196, 177);
            this.numericUpDownGrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownGrade.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownGrade.Name = "numericUpDownGrade";
            this.numericUpDownGrade.Size = new System.Drawing.Size(44, 26);
            this.numericUpDownGrade.TabIndex = 1;
            this.numericUpDownGrade.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(196, 27);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(44, 26);
            this.numericUpDownYear.TabIndex = 1;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxGrade
            // 
            this.checkBoxGrade.AutoSize = true;
            this.checkBoxGrade.Location = new System.Drawing.Point(6, 179);
            this.checkBoxGrade.Name = "checkBoxGrade";
            this.checkBoxGrade.Size = new System.Drawing.Size(91, 24);
            this.checkBoxGrade.TabIndex = 0;
            this.checkBoxGrade.Text = "Оценка";
            this.checkBoxGrade.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecordbook
            // 
            this.checkBoxRecordbook.AutoSize = true;
            this.checkBoxRecordbook.Location = new System.Drawing.Point(6, 119);
            this.checkBoxRecordbook.Name = "checkBoxRecordbook";
            this.checkBoxRecordbook.Size = new System.Drawing.Size(181, 24);
            this.checkBoxRecordbook.TabIndex = 0;
            this.checkBoxRecordbook.Text = "Зачетная книжка";
            this.checkBoxRecordbook.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubject
            // 
            this.checkBoxSubject.AutoSize = true;
            this.checkBoxSubject.Location = new System.Drawing.Point(6, 149);
            this.checkBoxSubject.Name = "checkBoxSubject";
            this.checkBoxSubject.Size = new System.Drawing.Size(131, 24);
            this.checkBoxSubject.TabIndex = 0;
            this.checkBoxSubject.Text = "Дисциплина";
            this.checkBoxSubject.UseVisualStyleBackColor = true;
            // 
            // checkBoxLastName
            // 
            this.checkBoxLastName.AutoSize = true;
            this.checkBoxLastName.Location = new System.Drawing.Point(6, 89);
            this.checkBoxLastName.Name = "checkBoxLastName";
            this.checkBoxLastName.Size = new System.Drawing.Size(101, 24);
            this.checkBoxLastName.TabIndex = 0;
            this.checkBoxLastName.Text = "Фамилия";
            this.checkBoxLastName.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.AutoSize = true;
            this.checkBoxGroup.Location = new System.Drawing.Point(6, 59);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(91, 24);
            this.checkBoxGroup.TabIndex = 0;
            this.checkBoxGroup.Text = "Группа";
            this.checkBoxGroup.UseVisualStyleBackColor = true;
            // 
            // checkBoxYear
            // 
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Location = new System.Drawing.Point(6, 27);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(71, 24);
            this.checkBoxYear.TabIndex = 0;
            this.checkBoxYear.Text = "Курс";
            this.checkBoxYear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(412, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Средняя оценка:";
            // 
            // labelAVGGrade
            // 
            this.labelAVGGrade.AutoSize = true;
            this.labelAVGGrade.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelAVGGrade.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAVGGrade.Location = new System.Drawing.Point(443, 249);
            this.labelAVGGrade.Name = "labelAVGGrade";
            this.labelAVGGrade.Size = new System.Drawing.Size(96, 27);
            this.labelAVGGrade.TabIndex = 4;
            this.labelAVGGrade.Text = "label2";
            this.labelAVGGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAVGGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.CheckBox checkBoxLastName;
        private System.Windows.Forms.CheckBox checkBoxGroup;
        private System.Windows.Forms.CheckBox checkBoxGrade;
        private System.Windows.Forms.CheckBox checkBoxSubject;
        private System.Windows.Forms.CheckBox checkBoxRecordbook;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.TextBox textBoxRecordbook;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.NumericUpDown numericUpDownGrade;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAVGGrade;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}