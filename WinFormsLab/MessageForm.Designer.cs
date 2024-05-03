namespace WinFormsLab
{
    partial class MessageForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userLabel = new Label();
            timeLabel = new Label();
            messageText = new TextBox();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLabel.ForeColor = SystemColors.ControlLightLight;
            userLabel.Location = new Point(3, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(83, 20);
            userLabel.TabIndex = 0;
            userLabel.Text = "UserName";
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = SystemColors.ButtonShadow;
            timeLabel.Location = new Point(294, 52);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(39, 17);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "17:44";
            // 
            // messageText
            // 
            messageText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageText.BackColor = Color.FromArgb(192, 64, 0);
            messageText.BorderStyle = BorderStyle.None;
            messageText.ForeColor = SystemColors.ControlLightLight;
            messageText.Location = new Point(3, 23);
            messageText.Multiline = true;
            messageText.Name = "messageText";
            messageText.ReadOnly = true;
            messageText.Size = new Size(330, 27);
            messageText.TabIndex = 4;
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            Controls.Add(messageText);
            Controls.Add(timeLabel);
            Controls.Add(userLabel);
            Name = "MessageForm";
            Size = new Size(341, 72);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userLabel;
        private Label timeLabel;
        private TextBox messageText;
    }
}
