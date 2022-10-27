namespace winforms_checkpassword
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdCheckPassword = new System.Windows.Forms.Button();
            this.cboPassword = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.LblSonderzeichen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdClose.BackColor = System.Drawing.Color.RosyBrown;
            this.CmdClose.Font = new System.Drawing.Font("Tempus Sans ITC", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CmdClose.ForeColor = System.Drawing.Color.Transparent;
            this.CmdClose.Location = new System.Drawing.Point(641, 431);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(89, 41);
            this.CmdClose.TabIndex = 0;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdCheckPassword
            // 
            this.CmdCheckPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdCheckPassword.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdCheckPassword.Location = new System.Drawing.Point(556, 98);
            this.CmdCheckPassword.Name = "CmdCheckPassword";
            this.CmdCheckPassword.Size = new System.Drawing.Size(174, 35);
            this.CmdCheckPassword.TabIndex = 1;
            this.CmdCheckPassword.Text = "Check Passwort";
            this.CmdCheckPassword.UseVisualStyleBackColor = true;
            this.CmdCheckPassword.Click += new System.EventHandler(this.CmdCheckPassword_Click);
            // 
            // cboPassword
            // 
            this.cboPassword.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPassword.FormattingEnabled = true;
            this.cboPassword.Items.AddRange(new object[] {
            "3aB&GH456",
            "34jdesh",
            "34H§nkiO12"});
            this.cboPassword.Location = new System.Drawing.Point(159, 104);
            this.cboPassword.Name = "cboPassword";
            this.cboPassword.Size = new System.Drawing.Size(289, 29);
            this.cboPassword.TabIndex = 2;
            this.cboPassword.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(93, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(637, 229);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAusgabe.Location = new System.Drawing.Point(454, 108);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(0, 20);
            this.LblAusgabe.TabIndex = 4;
            // 
            // LblSonderzeichen
            // 
            this.LblSonderzeichen.AutoSize = true;
            this.LblSonderzeichen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSonderzeichen.ForeColor = System.Drawing.Color.Red;
            this.LblSonderzeichen.Location = new System.Drawing.Point(93, 401);
            this.LblSonderzeichen.Name = "LblSonderzeichen";
            this.LblSonderzeichen.Size = new System.Drawing.Size(0, 15);
            this.LblSonderzeichen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(159, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "min. 1 Ziffer, 1 Kleinbuchstaben, 1 Großbuchstaben, 1 Sonderzeichen, Mindestlänge" +
    ": 8 Zeichen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Passwort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSonderzeichen);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cboPassword);
            this.Controls.Add(this.CmdCheckPassword);
            this.Controls.Add(this.CmdClose);
            this.Name = "Form1";
            this.Text = "Aufgabe 03: WindowsForms (CheckPassword)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdClose;
        private Button CmdCheckPassword;
        private ComboBox cboPassword;
        private ListBox listBox1;
        private Label LblAusgabe;
        private Label LblSonderzeichen;
        private Label label1;
        private Label label2;
    }
}