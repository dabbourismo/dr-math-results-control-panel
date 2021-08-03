namespace DrMathDesktop.ResultForms
{
    partial class ResultCrud
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.lblSecret = new System.Windows.Forms.Label();
            this.lblAgeRange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(14, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEdit.Location = new System.Drawing.Point(191, 234);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(91, 37);
            this.btnAddEdit.TabIndex = 5;
            this.btnAddEdit.Text = "اضافة";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(235, 180);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(47, 19);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "النتيجة";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAgeRange);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.lblLevel);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtSecret);
            this.groupBox1.Controls.Add(this.lblSecret);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnAddEdit);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(288, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة او تعديل نتيجة";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(14, 202);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(264, 26);
            this.txtResult.TabIndex = 12;
            this.txtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResult_KeyDown);
            this.txtResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResult_KeyPress);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(81, 109);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(62, 19);
            this.lblLevel.TabIndex = 11;
            this.lblLevel.Text = "المستوى";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(90, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 19);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "الاسم";
            // 
            // txtSecret
            // 
            this.txtSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecret.Location = new System.Drawing.Point(14, 45);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(264, 26);
            this.txtSecret.TabIndex = 9;
            this.txtSecret.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSecret_KeyDown);
            this.txtSecret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecret_KeyPress);
            // 
            // lblSecret
            // 
            this.lblSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(204, 23);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(78, 19);
            this.lblSecret.TabIndex = 8;
            this.lblSecret.Text = "الرقم السري";
            // 
            // lblAgeRange
            // 
            this.lblAgeRange.AutoSize = true;
            this.lblAgeRange.Location = new System.Drawing.Point(87, 142);
            this.lblAgeRange.Name = "lblAgeRange";
            this.lblAgeRange.Size = new System.Drawing.Size(50, 19);
            this.lblAgeRange.TabIndex = 13;
            this.lblAgeRange.Text = "المرحلة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "المرحلة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "المستوى";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "الاسم";
            // 
            // ResultCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(312, 304);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tajawal", 10F);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ResultCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "النتائج";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblAgeRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}