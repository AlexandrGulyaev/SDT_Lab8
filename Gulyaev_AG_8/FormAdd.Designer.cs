namespace Gulyaev_AG_8
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.labelYear = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelRecordbook = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.textBoxRecordbook = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.Location = new System.Drawing.Point(12, 24);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(58, 22);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "Курс";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(12, 94);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(82, 22);
            this.labelGroup.TabIndex = 0;
            this.labelGroup.Text = "Группа";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(12, 161);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(94, 22);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelRecordbook
            // 
            this.labelRecordbook.AutoSize = true;
            this.labelRecordbook.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecordbook.Location = new System.Drawing.Point(8, 236);
            this.labelRecordbook.Name = "labelRecordbook";
            this.labelRecordbook.Size = new System.Drawing.Size(262, 22);
            this.labelRecordbook.TabIndex = 0;
            this.labelRecordbook.Text = "Номер зачетной книжки";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(12, 306);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(130, 22);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "Дисциплина";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrade.Location = new System.Drawing.Point(12, 378);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(82, 22);
            this.labelGrade.TabIndex = 0;
            this.labelGrade.Text = "Оценка";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(12, 331);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(199, 30);
            this.comboBoxSubject.TabIndex = 1;
            // 
            // textBoxRecordbook
            // 
            this.textBoxRecordbook.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBoxRecordbook.Location = new System.Drawing.Point(12, 261);
            this.textBoxRecordbook.Name = "textBoxRecordbook";
            this.textBoxRecordbook.Size = new System.Drawing.Size(258, 30);
            this.textBoxRecordbook.TabIndex = 2;
            this.textBoxRecordbook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRecordbook_KeyPress);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBoxLastName.Location = new System.Drawing.Point(12, 186);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(258, 30);
            this.textBoxLastName.TabIndex = 2;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Font = new System.Drawing.Font("Courier New", 12F);
            this.numericUpDownYear.Location = new System.Drawing.Point(12, 49);
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
            this.numericUpDownYear.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownYear.TabIndex = 3;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownGrade
            // 
            this.numericUpDownGrade.Font = new System.Drawing.Font("Courier New", 12F);
            this.numericUpDownGrade.Location = new System.Drawing.Point(12, 403);
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
            this.numericUpDownGrade.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownGrade.TabIndex = 3;
            this.numericUpDownGrade.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(294, 408);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(226, 25);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(562, 408);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(226, 25);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(12, 119);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(199, 30);
            this.comboBoxGroup.TabIndex = 1;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDownGrade);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxRecordbook);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelRecordbook);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelYear);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormAdd";
            this.Text = "Добавить новую запись";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelRecordbook;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.TextBox textBoxRecordbook;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownGrade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxGroup;
    }
}