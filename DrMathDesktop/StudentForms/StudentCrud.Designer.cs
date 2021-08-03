namespace DrMathDesktop.StudentForms
{
    partial class StudentCrud
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAgeRange = new System.Windows.Forms.ComboBox();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.cmbTrainerName = new System.Windows.Forms.ComboBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblGovernate = new System.Windows.Forms.Label();
            this.txtGovernate = new System.Windows.Forms.TextBox();
            this.lblExamLanguage = new System.Windows.Forms.Label();
            this.cmbExamLanguage = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.lblNameEnglish = new System.Windows.Forms.Label();
            this.lblNameArabic = new System.Windows.Forms.Label();
            this.txtNameEnglish = new System.Windows.Forms.TextBox();
            this.txtNameArabic = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpContestDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpContestDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbAgeRange);
            this.groupBox1.Controls.Add(this.lblTrainerName);
            this.groupBox1.Controls.Add(this.cmbTrainerName);
            this.groupBox1.Controls.Add(this.lblBirthDate);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Controls.Add(this.lblGovernate);
            this.groupBox1.Controls.Add(this.txtGovernate);
            this.groupBox1.Controls.Add(this.lblExamLanguage);
            this.groupBox1.Controls.Add(this.cmbExamLanguage);
            this.groupBox1.Controls.Add(this.lblLevel);
            this.groupBox1.Controls.Add(this.cmbLevel);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnAddEdit);
            this.groupBox1.Controls.Add(this.lblNameEnglish);
            this.groupBox1.Controls.Add(this.lblNameArabic);
            this.groupBox1.Controls.Add(this.txtNameEnglish);
            this.groupBox1.Controls.Add(this.txtNameArabic);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(327, 619);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة او تعديل طالب";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "المرحلة";
            // 
            // cmbAgeRange
            // 
            this.cmbAgeRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAgeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgeRange.FormattingEnabled = true;
            this.cmbAgeRange.Location = new System.Drawing.Point(14, 402);
            this.cmbAgeRange.Name = "cmbAgeRange";
            this.cmbAgeRange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAgeRange.Size = new System.Drawing.Size(307, 26);
            this.cmbAgeRange.TabIndex = 13;
            this.cmbAgeRange.TabStop = false;
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Location = new System.Drawing.Point(244, 143);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(77, 19);
            this.lblTrainerName.TabIndex = 4;
            this.lblTrainerName.Text = "اسم المدرب";
            // 
            // cmbTrainerName
            // 
            this.cmbTrainerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTrainerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTrainerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTrainerName.FormattingEnabled = true;
            this.cmbTrainerName.Location = new System.Drawing.Point(14, 165);
            this.cmbTrainerName.Name = "cmbTrainerName";
            this.cmbTrainerName.Size = new System.Drawing.Size(307, 26);
            this.cmbTrainerName.TabIndex = 5;
            this.cmbTrainerName.TabStop = false;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(247, 206);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(74, 19);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "تاريخ الميلاد";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(14, 228);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(307, 26);
            this.dtpBirthDate.TabIndex = 7;
            this.dtpBirthDate.TabStop = false;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.DatesChanging);
            // 
            // lblGovernate
            // 
            this.lblGovernate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGovernate.AutoSize = true;
            this.lblGovernate.Location = new System.Drawing.Point(255, 509);
            this.lblGovernate.Name = "lblGovernate";
            this.lblGovernate.Size = new System.Drawing.Size(66, 19);
            this.lblGovernate.TabIndex = 16;
            this.lblGovernate.Text = "المحافظة";
            // 
            // txtGovernate
            // 
            this.txtGovernate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGovernate.Location = new System.Drawing.Point(14, 531);
            this.txtGovernate.Name = "txtGovernate";
            this.txtGovernate.Size = new System.Drawing.Size(307, 26);
            this.txtGovernate.TabIndex = 17;
            // 
            // lblExamLanguage
            // 
            this.lblExamLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExamLanguage.AutoSize = true;
            this.lblExamLanguage.Location = new System.Drawing.Point(250, 446);
            this.lblExamLanguage.Name = "lblExamLanguage";
            this.lblExamLanguage.Size = new System.Drawing.Size(71, 19);
            this.lblExamLanguage.TabIndex = 14;
            this.lblExamLanguage.Text = "لغة الاختبار";
            // 
            // cmbExamLanguage
            // 
            this.cmbExamLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExamLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExamLanguage.FormattingEnabled = true;
            this.cmbExamLanguage.Location = new System.Drawing.Point(14, 468);
            this.cmbExamLanguage.Name = "cmbExamLanguage";
            this.cmbExamLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbExamLanguage.Size = new System.Drawing.Size(307, 26);
            this.cmbExamLanguage.TabIndex = 15;
            this.cmbExamLanguage.TabStop = false;
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(259, 321);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(62, 19);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "المستوى";
            // 
            // cmbLevel
            // 
            this.cmbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(14, 343);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbLevel.Size = new System.Drawing.Size(307, 26);
            this.cmbLevel.TabIndex = 11;
            this.cmbLevel.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(14, 575);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 37);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEdit.Location = new System.Drawing.Point(230, 575);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(91, 37);
            this.btnAddEdit.TabIndex = 18;
            this.btnAddEdit.Text = "اضافة";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // lblNameEnglish
            // 
            this.lblNameEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameEnglish.AutoSize = true;
            this.lblNameEnglish.Location = new System.Drawing.Point(224, 87);
            this.lblNameEnglish.Name = "lblNameEnglish";
            this.lblNameEnglish.Size = new System.Drawing.Size(97, 19);
            this.lblNameEnglish.TabIndex = 2;
            this.lblNameEnglish.Text = "الاسم الانجليزي";
            // 
            // lblNameArabic
            // 
            this.lblNameArabic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameArabic.AutoSize = true;
            this.lblNameArabic.Location = new System.Drawing.Point(234, 28);
            this.lblNameArabic.Name = "lblNameArabic";
            this.lblNameArabic.Size = new System.Drawing.Size(87, 19);
            this.lblNameArabic.TabIndex = 0;
            this.lblNameArabic.Text = "الاسم بالعربي";
            // 
            // txtNameEnglish
            // 
            this.txtNameEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameEnglish.Location = new System.Drawing.Point(14, 109);
            this.txtNameEnglish.Name = "txtNameEnglish";
            this.txtNameEnglish.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNameEnglish.Size = new System.Drawing.Size(307, 26);
            this.txtNameEnglish.TabIndex = 3;
            // 
            // txtNameArabic
            // 
            this.txtNameArabic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameArabic.Location = new System.Drawing.Point(14, 50);
            this.txtNameArabic.Name = "txtNameArabic";
            this.txtNameArabic.Size = new System.Drawing.Size(307, 26);
            this.txtNameArabic.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "تاريخ البطولة";
            // 
            // dtpContestDate
            // 
            this.dtpContestDate.CustomFormat = "dd-MM-yyyy";
            this.dtpContestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpContestDate.Location = new System.Drawing.Point(14, 292);
            this.dtpContestDate.Name = "dtpContestDate";
            this.dtpContestDate.Size = new System.Drawing.Size(307, 26);
            this.dtpContestDate.TabIndex = 9;
            this.dtpContestDate.TabStop = false;
            this.dtpContestDate.ValueChanged += new System.EventHandler(this.DatesChanging);
            // 
            // StudentCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(351, 645);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tajawal", 10F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طالب";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Label lblNameEnglish;
        private System.Windows.Forms.Label lblNameArabic;
        private System.Windows.Forms.TextBox txtNameEnglish;
        private System.Windows.Forms.TextBox txtNameArabic;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblExamLanguage;
        private System.Windows.Forms.ComboBox cmbExamLanguage;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Label lblGovernate;
        private System.Windows.Forms.TextBox txtGovernate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.ComboBox cmbTrainerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAgeRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpContestDate;
    }
}