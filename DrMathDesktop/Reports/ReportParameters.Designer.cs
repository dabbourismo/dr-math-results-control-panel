namespace DrMathDesktop.Reports
{
    partial class ReportParameters
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTrainerName = new System.Windows.Forms.ComboBox();
            this.btnShowInRange = new System.Windows.Forms.Button();
            this.btnShowOutOfRange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.txtResultTo);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.txtResultFrom);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.cmbTrainerName);
            this.groupbox1.Location = new System.Drawing.Point(12, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupbox1.Size = new System.Drawing.Size(909, 87);
            this.groupbox1.TabIndex = 29;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "بحث";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "الى";
            // 
            // txtResultTo
            // 
            this.txtResultTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultTo.Location = new System.Drawing.Point(526, 46);
            this.txtResultTo.Name = "txtResultTo";
            this.txtResultTo.Size = new System.Drawing.Size(87, 26);
            this.txtResultTo.TabIndex = 33;
            this.txtResultTo.Text = "0";
            this.txtResultTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultTo_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "من";
            // 
            // txtResultFrom
            // 
            this.txtResultFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultFrom.Location = new System.Drawing.Point(619, 46);
            this.txtResultFrom.Name = "txtResultFrom";
            this.txtResultFrom.Size = new System.Drawing.Size(91, 26);
            this.txtResultFrom.TabIndex = 31;
            this.txtResultFrom.Text = "0";
            this.txtResultFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultFrom_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 24);
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
            this.cmbTrainerName.Location = new System.Drawing.Point(716, 46);
            this.cmbTrainerName.Name = "cmbTrainerName";
            this.cmbTrainerName.Size = new System.Drawing.Size(187, 26);
            this.cmbTrainerName.TabIndex = 29;
            this.cmbTrainerName.TabStop = false;
            // 
            // btnShowInRange
            // 
            this.btnShowInRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowInRange.Location = new System.Drawing.Point(750, 105);
            this.btnShowInRange.Name = "btnShowInRange";
            this.btnShowInRange.Size = new System.Drawing.Size(165, 37);
            this.btnShowInRange.TabIndex = 18;
            this.btnShowInRange.Text = "عرض تقرير داخل النطاق";
            this.btnShowInRange.UseVisualStyleBackColor = true;
            this.btnShowInRange.Click += new System.EventHandler(this.btnShowInRange_Click);
            // 
            // btnShowOutOfRange
            // 
            this.btnShowOutOfRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowOutOfRange.Location = new System.Drawing.Point(750, 148);
            this.btnShowOutOfRange.Name = "btnShowOutOfRange";
            this.btnShowOutOfRange.Size = new System.Drawing.Size(165, 37);
            this.btnShowOutOfRange.TabIndex = 30;
            this.btnShowOutOfRange.Text = "عرض تقرير خارج النطاق";
            this.btnShowOutOfRange.UseVisualStyleBackColor = true;
            this.btnShowOutOfRange.Click += new System.EventHandler(this.btnShowOutOfRange_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(750, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 31;
            this.button1.Text = "عرض تقرير باعلى درجات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowOutOfRange);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.btnShowInRange);
            this.Font = new System.Drawing.Font("Tajawal", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportParameters";
            this.Text = "ReportParameters";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTrainerName;
        private System.Windows.Forms.Button btnShowInRange;
        private System.Windows.Forms.Button btnShowOutOfRange;
        private System.Windows.Forms.Button button1;
    }
}