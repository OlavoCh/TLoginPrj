namespace TLoginPrj
{
    partial class TLogin
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
            BtnRes = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtUser = new TextBox();
            TxtPass = new TextBox();
            BtnLogin = new Button();
            label4 = new Label();
            label5 = new Label();
            TxtMail = new TextBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // BtnRes
            // 
            BtnRes.Anchor = AnchorStyles.None;
            BtnRes.FlatStyle = FlatStyle.Popup;
            BtnRes.Location = new Point(379, 276);
            BtnRes.Name = "BtnRes";
            BtnRes.Size = new Size(75, 23);
            BtnRes.TabIndex = 0;
            BtnRes.Text = "Register";
            BtnRes.UseVisualStyleBackColor = true;
            BtnRes.Visible = false;
            BtnRes.Click += BtnRes_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(333, 149);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(309, 183);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(372, 35);
            label3.Name = "label3";
            label3.Size = new Size(82, 29);
            label3.TabIndex = 3;
            label3.Text = "LOGIN";
            // 
            // TxtUser
            // 
            TxtUser.Anchor = AnchorStyles.None;
            TxtUser.BorderStyle = BorderStyle.FixedSingle;
            TxtUser.Location = new Point(372, 146);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(100, 23);
            TxtUser.TabIndex = 4;
            // 
            // TxtPass
            // 
            TxtPass.Anchor = AnchorStyles.None;
            TxtPass.BorderStyle = BorderStyle.FixedSingle;
            TxtPass.Location = new Point(372, 175);
            TxtPass.Name = "TxtPass";
            TxtPass.PasswordChar = '*';
            TxtPass.Size = new Size(100, 23);
            TxtPass.TabIndex = 5;
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.None;
            BtnLogin.FlatStyle = FlatStyle.Popup;
            BtnLogin.Location = new Point(379, 232);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 23);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Menu;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(364, 258);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 7;
            label4.Text = "Don't have a login?";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(372, 229);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 17;
            label5.Text = "forgot password?";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // TxtMail
            // 
            TxtMail.Anchor = AnchorStyles.None;
            TxtMail.BorderStyle = BorderStyle.FixedSingle;
            TxtMail.Location = new Point(372, 204);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(100, 23);
            TxtMail.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(327, 206);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 18;
            label6.Text = "Email";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(455, 180);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 20;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // TLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(TxtMail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPass);
            Controls.Add(TxtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnRes);
            Name = "TLogin";
            Text = "Login";
            Load += TLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRes;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtUser;
        private TextBox TxtPass;
        private Button BtnLogin;
        private Label label4;
        private Label label5;
        private TextBox TxtMail;
        private Label label6;
        private CheckBox checkBox1;
    }
}
