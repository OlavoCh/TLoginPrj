namespace TLoginPrj
{
    partial class T1
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
            BtnResPass = new Button();
            SuspendLayout();
            // 
            // BtnResPass
            // 
            BtnResPass.Anchor = AnchorStyles.None;
            BtnResPass.AutoSize = true;
            BtnResPass.Location = new Point(356, 191);
            BtnResPass.Name = "BtnResPass";
            BtnResPass.Size = new Size(98, 25);
            BtnResPass.TabIndex = 0;
            BtnResPass.Text = "Reset Password";
            BtnResPass.UseVisualStyleBackColor = true;
            BtnResPass.Click += BtnResPass_Click;
            // 
            // T1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnResPass);
            Name = "T1";
            Text = "T1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnResPass;
    }
}