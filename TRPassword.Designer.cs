namespace TLoginPrj
{
    partial class TRPassword
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
            label4 = new Label();
            BtnResg = new Button();
            TxtPass = new TextBox();
            TxtOldPass = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnReturn = new Button();
            TxtUser = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = SystemColors.Menu;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(401, 276);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 23;
            label4.Text = "Return";
            label4.Click += label4_Click;
            // 
            // BtnResg
            // 
            BtnResg.Anchor = AnchorStyles.None;
            BtnResg.AutoSize = true;
            BtnResg.FlatStyle = FlatStyle.Popup;
            BtnResg.Location = new Point(378, 250);
            BtnResg.Name = "BtnResg";
            BtnResg.Size = new Size(86, 25);
            BtnResg.TabIndex = 22;
            BtnResg.Text = "Set Password";
            BtnResg.UseVisualStyleBackColor = true;
            BtnResg.Click += BtnResg_Click;
            // 
            // TxtPass
            // 
            TxtPass.Anchor = AnchorStyles.None;
            TxtPass.BorderStyle = BorderStyle.FixedSingle;
            TxtPass.Location = new Point(378, 221);
            TxtPass.Name = "TxtPass";
            TxtPass.PasswordChar = '*';
            TxtPass.Size = new Size(100, 23);
            TxtPass.TabIndex = 21;
            // 
            // TxtOldPass
            // 
            TxtOldPass.Anchor = AnchorStyles.None;
            TxtOldPass.BorderStyle = BorderStyle.FixedSingle;
            TxtOldPass.Location = new Point(378, 192);
            TxtOldPass.Name = "TxtOldPass";
            TxtOldPass.PasswordChar = '*';
            TxtOldPass.Size = new Size(100, 23);
            TxtOldPass.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(339, 56);
            label3.Name = "label3";
            label3.Size = new Size(188, 29);
            label3.TabIndex = 19;
            label3.Text = "Reset password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(288, 223);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 18;
            label2.Text = "New Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(315, 194);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 17;
            label1.Text = "Password";
            // 
            // BtnReturn
            // 
            BtnReturn.Anchor = AnchorStyles.None;
            BtnReturn.FlatStyle = FlatStyle.Popup;
            BtnReturn.Location = new Point(382, 294);
            BtnReturn.Name = "BtnReturn";
            BtnReturn.Size = new Size(75, 23);
            BtnReturn.TabIndex = 16;
            BtnReturn.Text = "Return";
            BtnReturn.UseVisualStyleBackColor = true;
            BtnReturn.Visible = false;
            BtnReturn.Click += BtnReturn_Click;
            // 
            // TxtUser
            // 
            TxtUser.Anchor = AnchorStyles.None;
            TxtUser.BorderStyle = BorderStyle.FixedSingle;
            TxtUser.Location = new Point(378, 163);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(100, 23);
            TxtUser.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(339, 166);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 24;
            label5.Text = "User";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(460, 227);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 26;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.None;
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(460, 197);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 27;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // TRPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(TxtUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BtnResg);
            Controls.Add(TxtPass);
            Controls.Add(TxtOldPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnReturn);
            Name = "TRPassword";
            Text = "TFPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button BtnResg;
        private TextBox TxtPass;
        private TextBox TxtOldPass;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnReturn;
        private TextBox TxtUser;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}