namespace TLoginPrj
{
    partial class TFPassword
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
            TxtNPass = new TextBox();
            lblNewpss = new Label();
            LblReturn = new Label();
            BtnConfirmC = new Button();
            TxtCodigo = new TextBox();
            TxtEmail = new TextBox();
            label3 = new Label();
            LblCodigo = new Label();
            LbLMail = new Label();
            BtnCodigo = new Button();
            BtnConfirmP = new Button();
            SuspendLayout();
            // 
            // TxtNPass
            // 
            TxtNPass.Anchor = AnchorStyles.None;
            TxtNPass.BorderStyle = BorderStyle.FixedSingle;
            TxtNPass.Location = new Point(380, 274);
            TxtNPass.Name = "TxtNPass";
            TxtNPass.Size = new Size(100, 23);
            TxtNPass.TabIndex = 30;
            TxtNPass.Visible = false;
            // 
            // lblNewpss
            // 
            lblNewpss.Anchor = AnchorStyles.None;
            lblNewpss.AutoSize = true;
            lblNewpss.Location = new Point(290, 276);
            lblNewpss.Name = "lblNewpss";
            lblNewpss.Size = new Size(84, 15);
            lblNewpss.TabIndex = 29;
            lblNewpss.Text = "New Password";
            lblNewpss.Visible = false;
            // 
            // LblReturn
            // 
            LblReturn.Anchor = AnchorStyles.None;
            LblReturn.AutoSize = true;
            LblReturn.ForeColor = SystemColors.Highlight;
            LblReturn.Location = new Point(746, 9);
            LblReturn.Name = "LblReturn";
            LblReturn.Size = new Size(42, 15);
            LblReturn.TabIndex = 28;
            LblReturn.Text = "Return";
            LblReturn.Visible = false;
            // 
            // BtnConfirmC
            // 
            BtnConfirmC.Anchor = AnchorStyles.None;
            BtnConfirmC.FlatStyle = FlatStyle.Popup;
            BtnConfirmC.Location = new Point(380, 245);
            BtnConfirmC.Name = "BtnConfirmC";
            BtnConfirmC.Size = new Size(75, 23);
            BtnConfirmC.TabIndex = 26;
            BtnConfirmC.Text = "Confirm";
            BtnConfirmC.UseVisualStyleBackColor = true;
            BtnConfirmC.Visible = false;
            BtnConfirmC.Click += BtnConfirmC_Click;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Anchor = AnchorStyles.None;
            TxtCodigo.BorderStyle = BorderStyle.FixedSingle;
            TxtCodigo.Location = new Point(380, 216);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.PasswordChar = '*';
            TxtCodigo.Size = new Size(100, 23);
            TxtCodigo.TabIndex = 25;
            TxtCodigo.Visible = false;
            // 
            // TxtEmail
            // 
            TxtEmail.Anchor = AnchorStyles.None;
            TxtEmail.BorderStyle = BorderStyle.FixedSingle;
            TxtEmail.Location = new Point(380, 160);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(100, 23);
            TxtEmail.TabIndex = 24;
            TxtEmail.TextChanged += TxtEmail_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(351, 43);
            label3.Name = "label3";
            label3.Size = new Size(174, 29);
            label3.TabIndex = 23;
            label3.Text = "New Password";
            // 
            // LblCodigo
            // 
            LblCodigo.Anchor = AnchorStyles.None;
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(328, 218);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(46, 15);
            LblCodigo.TabIndex = 22;
            LblCodigo.Text = "Codigo";
            LblCodigo.Visible = false;
            // 
            // LbLMail
            // 
            LbLMail.Anchor = AnchorStyles.None;
            LbLMail.AutoSize = true;
            LbLMail.Location = new Point(338, 162);
            LbLMail.Name = "LbLMail";
            LbLMail.Size = new Size(36, 15);
            LbLMail.TabIndex = 21;
            LbLMail.Text = "Email";
            // 
            // BtnCodigo
            // 
            BtnCodigo.Anchor = AnchorStyles.None;
            BtnCodigo.AutoSize = true;
            BtnCodigo.FlatStyle = FlatStyle.Popup;
            BtnCodigo.Location = new Point(380, 185);
            BtnCodigo.Name = "BtnCodigo";
            BtnCodigo.Size = new Size(91, 25);
            BtnCodigo.TabIndex = 20;
            BtnCodigo.Text = "Enviar Codigo";
            BtnCodigo.UseVisualStyleBackColor = true;
            BtnCodigo.Click += BtnCodigo_Click;
            // 
            // BtnConfirmP
            // 
            BtnConfirmP.Anchor = AnchorStyles.None;
            BtnConfirmP.FlatStyle = FlatStyle.Popup;
            BtnConfirmP.Location = new Point(380, 303);
            BtnConfirmP.Name = "BtnConfirmP";
            BtnConfirmP.Size = new Size(75, 23);
            BtnConfirmP.TabIndex = 31;
            BtnConfirmP.Text = "Confirm";
            BtnConfirmP.UseVisualStyleBackColor = true;
            BtnConfirmP.Visible = false;
            BtnConfirmP.Click += BtnConfirmP_Click;
            // 
            // TFPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnConfirmP);
            Controls.Add(TxtNPass);
            Controls.Add(lblNewpss);
            Controls.Add(LblReturn);
            Controls.Add(BtnConfirmC);
            Controls.Add(TxtCodigo);
            Controls.Add(TxtEmail);
            Controls.Add(label3);
            Controls.Add(LblCodigo);
            Controls.Add(LbLMail);
            Controls.Add(BtnCodigo);
            Name = "TFPassword";
            Text = "T1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNPass;
        private Label lblNewpss;
        private Label LblReturn;

        public TFPassword(Label lblReturn)
        {
            LblReturn = lblReturn;
        }

        private Button BtnConfirmC;
        private TextBox TxtCodigo;
        private TextBox TxtEmail;
        private Label label3;
        private Label LblCodigo;
        private Label LbLMail;
        private Button BtnCodigo;
        private Button BtnConfirmP;
    }
}