namespace WinFormsLab
{
    partial class ConnectionForm
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
            AddressLabel = new Label();
            AddressText = new TextBox();
            PortLabel = new Label();
            PortText = new TextBox();
            UserLabel = new Label();
            UserText = new TextBox();
            KeyLabel = new Label();
            KeyText = new TextBox();
            ShowKeyBox = new CheckBox();
            ConnectButton = new Button();
            ConnectionBar = new ProgressBar();
            SuspendLayout();
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(25, 13);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(65, 20);
            AddressLabel.TabIndex = 0;
            AddressLabel.Text = "Address:";
            // 
            // AddressText
            // 
            AddressText.Location = new Point(97, 6);
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(153, 27);
            AddressText.TabIndex = 1;
            // 
            // PortLabel
            // 
            PortLabel.AutoSize = true;
            PortLabel.Location = new Point(283, 13);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new Size(38, 20);
            PortLabel.TabIndex = 2;
            PortLabel.Text = "Port:";
            // 
            // PortText
            // 
            PortText.Location = new Point(327, 6);
            PortText.Name = "PortText";
            PortText.Size = new Size(143, 27);
            PortText.TabIndex = 3;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(12, 51);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(78, 20);
            UserLabel.TabIndex = 4;
            UserLabel.Text = "Username:";
            // 
            // UserText
            // 
            UserText.Location = new Point(97, 44);
            UserText.Name = "UserText";
            UserText.Size = new Size(153, 27);
            UserText.TabIndex = 5;
            // 
            // KeyLabel
            // 
            KeyLabel.AutoSize = true;
            KeyLabel.Location = new Point(285, 51);
            KeyLabel.Name = "KeyLabel";
            KeyLabel.Size = new Size(36, 20);
            KeyLabel.TabIndex = 6;
            KeyLabel.Text = "Key:";
            // 
            // KeyText
            // 
            KeyText.Location = new Point(327, 44);
            KeyText.Name = "KeyText";
            KeyText.Size = new Size(143, 27);
            KeyText.TabIndex = 7;
            KeyText.UseSystemPasswordChar = true;
            // 
            // ShowKeyBox
            // 
            ShowKeyBox.AutoSize = true;
            ShowKeyBox.Location = new Point(377, 77);
            ShowKeyBox.Name = "ShowKeyBox";
            ShowKeyBox.Size = new Size(93, 24);
            ShowKeyBox.TabIndex = 8;
            ShowKeyBox.Text = "Show key";
            ShowKeyBox.UseVisualStyleBackColor = true;
            ShowKeyBox.CheckedChanged += ShowKeyBox_CheckedChanged;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(376, 112);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(94, 29);
            ConnectButton.TabIndex = 9;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // ConnectionBar
            // 
            ConnectionBar.Location = new Point(12, 112);
            ConnectionBar.Name = "ConnectionBar";
            ConnectionBar.Size = new Size(358, 29);
            ConnectionBar.TabIndex = 10;
            // 
            // ConnectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 153);
            Controls.Add(ConnectionBar);
            Controls.Add(ConnectButton);
            Controls.Add(ShowKeyBox);
            Controls.Add(KeyText);
            Controls.Add(KeyLabel);
            Controls.Add(UserText);
            Controls.Add(UserLabel);
            Controls.Add(PortText);
            Controls.Add(PortLabel);
            Controls.Add(AddressText);
            Controls.Add(AddressLabel);
            MaximumSize = new Size(515, 200);
            MinimumSize = new Size(515, 200);
            Name = "ConnectionForm";
            Text = "Connect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddressLabel;
        private TextBox AddressText;
        private Label PortLabel;
        private TextBox PortText;
        private Label UserLabel;
        private TextBox UserText;
        private Label KeyLabel;
        private TextBox KeyText;
        private CheckBox ShowKeyBox;
        private Button ConnectButton;
        private ProgressBar ConnectionBar;
    }
}