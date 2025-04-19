namespace TLoginPrj
{
    partial class TResg
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
            TxtPass = new TextBox();
            TxtUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnReturn = new Button();
            BtnResg = new Button();
            TxtMail = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Menu;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(384, 274);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 15;
            label4.Text = "Have a Login?";
            label4.Click += label4_Click;
            // 
            // TxtPass
            // 
            TxtPass.Anchor = AnchorStyles.None;
            TxtPass.BorderStyle = BorderStyle.FixedSingle;
            TxtPass.Location = new Point(382, 186);
            TxtPass.Name = "TxtPass";
            TxtPass.PasswordChar = '*';
            TxtPass.Size = new Size(100, 23);
            TxtPass.TabIndex = 13;
            // 
            // TxtUser
            // 
            TxtUser.Anchor = AnchorStyles.None;
            TxtUser.BorderStyle = BorderStyle.FixedSingle;
            TxtUser.Location = new Point(382, 157);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(100, 23);
            TxtUser.TabIndex = 12;
            TxtUser.TextChanged += TxtUser_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(383, 53);
            label3.Name = "label3";
            label3.Size = new Size(105, 29);
            label3.TabIndex = 11;
            label3.Text = "Register";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(319, 194);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(343, 160);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 9;
            label1.Text = "User";
            // 
            // BtnReturn
            // 
            BtnReturn.Anchor = AnchorStyles.None;
            BtnReturn.FlatStyle = FlatStyle.Popup;
            BtnReturn.Location = new Point(390, 292);
            BtnReturn.Name = "BtnReturn";
            BtnReturn.Size = new Size(75, 23);
            BtnReturn.TabIndex = 8;
            BtnReturn.Text = "Return";
            BtnReturn.UseVisualStyleBackColor = true;
            BtnReturn.Visible = false;
            BtnReturn.Click += BtnReturn_Click;
            // 
            // BtnResg
            // 
            BtnResg.Anchor = AnchorStyles.None;
            BtnResg.FlatStyle = FlatStyle.Popup;
            BtnResg.Location = new Point(390, 248);
            BtnResg.Name = "BtnResg";
            BtnResg.Size = new Size(75, 23);
            BtnResg.TabIndex = 14;
            BtnResg.Text = "Register";
            BtnResg.UseVisualStyleBackColor = true;
            BtnResg.Click += BtnResg_Click;
            // 
            // TxtMail
            // 
            TxtMail.Anchor = AnchorStyles.None;
            TxtMail.BorderStyle = BorderStyle.FixedSingle;
            TxtMail.Location = new Point(382, 219);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(100, 23);
            TxtMail.TabIndex = 17;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(337, 221);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(465, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 18;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // TResg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(TxtMail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BtnResg);
            Controls.Add(TxtPass);
            Controls.Add(TxtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnReturn);
            Name = "TResg";
            Text = "TResg";
            Load += TResg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox TxtPass;
        private TextBox TxtUser;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnReturn;
        private Button BtnResg;
        private TextBox TxtMail;
        private Label label5;
        private CheckBox checkBox1;
    }
}