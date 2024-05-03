namespace WinFormsLabServer
{
    partial class Form2
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
            AddressLabel = new Label();
            UserLabel = new Label();
            PortLabel = new Label();
            KeyLabel = new Label();
            AddressText = new TextBox();
            UserText = new TextBox();
            PortText = new TextBox();
            KeyText = new TextBox();
            StartStopButton = new Button();
            ClearButton = new Button();
            DisconnectButton = new Button();
            LogLabel = new Label();
            LogText = new TextBox();
            SendText = new TextBox();
            SendButton = new Button();
            KeyCheck = new CheckBox();
            listView1 = new ListView();
            IDColumn = new ColumnHeader();
            NameColumn = new ColumnHeader();
            DisconnectColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // AddressLabel
            // 
            AddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(128, 19);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(65, 20);
            AddressLabel.TabIndex = 0;
            AddressLabel.Text = "Address:";
            // 
            // UserLabel
            // 
            UserLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(152, 52);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(41, 20);
            UserLabel.TabIndex = 1;
            UserLabel.Text = "User:";
            // 
            // PortLabel
            // 
            PortLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PortLabel.AutoSize = true;
            PortLabel.Location = new Point(306, 21);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new Size(38, 20);
            PortLabel.TabIndex = 2;
            PortLabel.Text = "Port:";
            // 
            // KeyLabel
            // 
            KeyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KeyLabel.AutoSize = true;
            KeyLabel.Location = new Point(306, 52);
            KeyLabel.Name = "KeyLabel";
            KeyLabel.Size = new Size(36, 20);
            KeyLabel.TabIndex = 3;
            KeyLabel.Text = "Key:";
            // 
            // AddressText
            // 
            AddressText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddressText.Location = new Point(199, 15);
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(101, 27);
            AddressText.TabIndex = 4;
            AddressText.Text = "localhost";
            // 
            // UserText
            // 
            UserText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserText.Location = new Point(199, 45);
            UserText.Name = "UserText";
            UserText.Size = new Size(101, 27);
            UserText.TabIndex = 5;
            UserText.Text = "Server";
            // 
            // PortText
            // 
            PortText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PortText.Location = new Point(350, 15);
            PortText.Name = "PortText";
            PortText.Size = new Size(106, 27);
            PortText.TabIndex = 6;
            PortText.Text = "9000";
            // 
            // KeyText
            // 
            KeyText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KeyText.Location = new Point(350, 45);
            KeyText.Name = "KeyText";
            KeyText.Size = new Size(106, 27);
            KeyText.TabIndex = 7;
            KeyText.UseSystemPasswordChar = true;
            // 
            // StartStopButton
            // 
            StartStopButton.Location = new Point(11, 15);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(94, 29);
            StartStopButton.TabIndex = 8;
            StartStopButton.Text = "Start";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(11, 123);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 9;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DisconnectButton
            // 
            DisconnectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DisconnectButton.Location = new Point(333, 123);
            DisconnectButton.Name = "DisconnectButton";
            DisconnectButton.Size = new Size(123, 29);
            DisconnectButton.TabIndex = 10;
            DisconnectButton.Text = "Disconnect all";
            DisconnectButton.UseVisualStyleBackColor = true;
            DisconnectButton.Click += DisconnectButton_Click;
            // 
            // LogLabel
            // 
            LogLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LogLabel.AutoSize = true;
            LogLabel.Location = new Point(218, 125);
            LogLabel.Name = "LogLabel";
            LogLabel.Size = new Size(34, 20);
            LogLabel.TabIndex = 11;
            LogLabel.Text = "Log";
            // 
            // LogText
            // 
            LogText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogText.Location = new Point(11, 160);
            LogText.Multiline = true;
            LogText.Name = "LogText";
            LogText.ReadOnly = true;
            LogText.Size = new Size(444, 215);
            LogText.TabIndex = 12;
            // 
            // SendText
            // 
            SendText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SendText.Location = new Point(11, 381);
            SendText.Name = "SendText";
            SendText.Size = new Size(347, 27);
            SendText.TabIndex = 13;
            // 
            // SendButton
            // 
            SendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SendButton.Location = new Point(365, 379);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 29);
            SendButton.TabIndex = 14;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // KeyCheck
            // 
            KeyCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KeyCheck.AutoSize = true;
            KeyCheck.Location = new Point(363, 77);
            KeyCheck.Name = "KeyCheck";
            KeyCheck.Size = new Size(93, 24);
            KeyCheck.TabIndex = 15;
            KeyCheck.Text = "Show key";
            KeyCheck.UseVisualStyleBackColor = true;
            KeyCheck.CheckedChanged += KeyCheck_CheckedChanged;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { IDColumn, NameColumn, DisconnectColumn });
            listView1.Location = new Point(465, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(276, 404);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // IDColumn
            // 
            IDColumn.Text = "ID";
            // 
            // NameColumn
            // 
            NameColumn.Text = "Name";
            NameColumn.TextAlign = HorizontalAlignment.Center;
            NameColumn.Width = 120;
            // 
            // DisconnectColumn
            // 
            DisconnectColumn.Text = "Disconnect";
            DisconnectColumn.TextAlign = HorizontalAlignment.Center;
            DisconnectColumn.Width = 100;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 428);
            Controls.Add(listView1);
            Controls.Add(KeyCheck);
            Controls.Add(SendButton);
            Controls.Add(SendText);
            Controls.Add(LogText);
            Controls.Add(LogLabel);
            Controls.Add(DisconnectButton);
            Controls.Add(ClearButton);
            Controls.Add(StartStopButton);
            Controls.Add(KeyText);
            Controls.Add(PortText);
            Controls.Add(UserText);
            Controls.Add(AddressText);
            Controls.Add(KeyLabel);
            Controls.Add(PortLabel);
            Controls.Add(UserLabel);
            Controls.Add(AddressLabel);
            MinimumSize = new Size(764, 464);
            Name = "Form2";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddressLabel;
        private Label UserLabel;
        private Label PortLabel;
        private Label KeyLabel;
        private TextBox AddressText;
        private TextBox UserText;
        private TextBox PortText;
        private TextBox KeyText;
        private Button StartStopButton;
        private Button ClearButton;
        private Button DisconnectButton;
        private Label LogLabel;
        private TextBox LogText;
        private TextBox SendText;
        private Button SendButton;
        private CheckBox KeyCheck;
        private ListView listView1;
        private ColumnHeader IDColumn;
        private ColumnHeader NameColumn;
        private ColumnHeader DisconnectColumn;
    }
}
