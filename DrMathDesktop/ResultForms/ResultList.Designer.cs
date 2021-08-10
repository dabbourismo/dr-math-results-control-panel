namespace DrMathDesktop.ResultForms
{
    partial class ResultList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAgeRange = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTrainerName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox1.Controls.Add(this.btnShowAll);
            this.groupbox1.Controls.Add(this.label5);
            this.groupbox1.Controls.Add(this.cmbAgeRange);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.cmbLevel);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.txtResultTo);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.txtResultFrom);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.cmbTrainerName);
            this.groupbox1.Controls.Add(this.btnSearch);
            this.groupbox1.Controls.Add(this.lblTrainerName);
            this.groupbox1.Controls.Add(this.txtSearch);
            this.groupbox1.Location = new System.Drawing.Point(146, 9);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupbox1.Size = new System.Drawing.Size(870, 149);
            this.groupbox1.TabIndex = 28;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "بحث";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowAll.Location = new System.Drawing.Point(6, 72);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(91, 37);
            this.btnShowAll.TabIndex = 39;
            this.btnShowAll.Text = "عرض الكل";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "المرحلة";
            // 
            // cmbAgeRange
            // 
            this.cmbAgeRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAgeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgeRange.FormattingEnabled = true;
            this.cmbAgeRange.Location = new System.Drawing.Point(294, 46);
            this.cmbAgeRange.Name = "cmbAgeRange";
            this.cmbAgeRange.Size = new System.Drawing.Size(115, 26);
            this.cmbAgeRange.TabIndex = 37;
            this.cmbAgeRange.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "المستوى";
            // 
            // cmbLevel
            // 
            this.cmbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(415, 46);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(115, 26);
            this.cmbLevel.TabIndex = 35;
            this.cmbLevel.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "الى";
            // 
            // txtResultTo
            // 
            this.txtResultTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultTo.Location = new System.Drawing.Point(677, 104);
            this.txtResultTo.Name = "txtResultTo";
            this.txtResultTo.Size = new System.Drawing.Size(87, 26);
            this.txtResultTo.TabIndex = 33;
            this.txtResultTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResultRangeKeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(834, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "من";
            // 
            // txtResultFrom
            // 
            this.txtResultFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultFrom.Location = new System.Drawing.Point(770, 104);
            this.txtResultFrom.Name = "txtResultFrom";
            this.txtResultFrom.Size = new System.Drawing.Size(91, 26);
            this.txtResultFrom.TabIndex = 31;
            this.txtResultFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResultRangeKeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "اسم المدرب";
            // 
            // cmbTrainerName
            // 
            this.cmbTrainerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTrainerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTrainerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTrainerName.FormattingEnabled = true;
            this.cmbTrainerName.Location = new System.Drawing.Point(536, 46);
            this.cmbTrainerName.Name = "cmbTrainerName";
            this.cmbTrainerName.Size = new System.Drawing.Size(187, 26);
            this.cmbTrainerName.TabIndex = 29;
            this.cmbTrainerName.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(6, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 37);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Location = new System.Drawing.Point(786, 24);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(79, 19);
            this.lblTrainerName.TabIndex = 17;
            this.lblTrainerName.Text = "اسم الطالب";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(729, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(134, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tajawal", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(17, 171);
            this.dgv.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(999, 483);
            this.dgv.TabIndex = 27;
            this.dgv.VirtualMode = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(17, 667);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 37);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "مسح";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(14, 57);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 37);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 37);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 712);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Tajawal", 10F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ResultList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultList";
            this.Activated += new System.EventHandler(this.ResultList_Activated);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTrainerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAgeRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Button btnShowAll;
    }
}