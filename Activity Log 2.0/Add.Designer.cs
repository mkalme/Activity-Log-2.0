namespace Activity_Log_2._0
{
    partial class Add
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
            this.components = new System.ComponentModel.Container();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cashBankCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.TextBox();
            this.commentsText = new System.Windows.Forms.TextBox();
            this.addText = new System.Windows.Forms.TextBox();
            this.addButton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountText = new System.Windows.Forms.TextBox();
            this.addRemoveCombo = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(237, 317);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 25);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(151, 317);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 25);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cashBankCombo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateText);
            this.groupBox1.Controls.Add(this.commentsText);
            this.groupBox1.Controls.Add(this.addText);
            this.groupBox1.Controls.Add(this.addButton1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.typeCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.amountText);
            this.groupBox1.Controls.Add(this.addRemoveCombo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 278);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cash / Bank";
            // 
            // cashBankCombo
            // 
            this.cashBankCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cashBankCombo.FormattingEnabled = true;
            this.cashBankCombo.Location = new System.Drawing.Point(174, 243);
            this.cashBankCombo.Name = "cashBankCombo";
            this.cashBankCombo.Size = new System.Drawing.Size(119, 21);
            this.cashBankCombo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comments";
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(14, 244);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(119, 20);
            this.dateText.TabIndex = 9;
            // 
            // commentsText
            // 
            this.commentsText.Location = new System.Drawing.Point(13, 193);
            this.commentsText.Name = "commentsText";
            this.commentsText.Size = new System.Drawing.Size(280, 20);
            this.commentsText.TabIndex = 8;
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(191, 140);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(102, 20);
            this.addText.TabIndex = 7;
            // 
            // addButton1
            // 
            this.addButton1.Enabled = false;
            this.addButton1.Location = new System.Drawing.Point(141, 137);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(44, 25);
            this.addButton1.TabIndex = 6;
            this.addButton1.Text = "Add";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // typeCombo
            // 
            this.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.IntegralHeight = false;
            this.typeCombo.Location = new System.Drawing.Point(12, 139);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(121, 21);
            this.typeCombo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add / Remove";
            // 
            // amountText
            // 
            this.amountText.Location = new System.Drawing.Point(12, 88);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(121, 20);
            this.amountText.TabIndex = 1;
            // 
            // addRemoveCombo
            // 
            this.addRemoveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addRemoveCombo.FormattingEnabled = true;
            this.addRemoveCombo.Location = new System.Drawing.Point(12, 38);
            this.addRemoveCombo.Name = "addRemoveCombo";
            this.addRemoveCombo.Size = new System.Drawing.Size(121, 21);
            this.addRemoveCombo.TabIndex = 0;
            this.addRemoveCombo.SelectedIndexChanged += new System.EventHandler(this.addRemoveCombo_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 354);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cashBankCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.TextBox commentsText;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.ComboBox addRemoveCombo;
        private System.Windows.Forms.Timer timer1;
    }
}