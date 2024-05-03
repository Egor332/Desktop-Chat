namespace WinFormsLab
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
            sendTextBox = new TextBox();
            sendButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            msgArea = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            Menu = new ToolStripMenuItem();
            ConnectOption = new ToolStripMenuItem();
            DisconnectOption = new ToolStripMenuItem();
            ExitOption = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sendTextBox
            // 
            sendTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sendTextBox.Location = new Point(12, 512);
            sendTextBox.Multiline = true;
            sendTextBox.Name = "sendTextBox";
            sendTextBox.Size = new Size(258, 29);
            sendTextBox.TabIndex = 0;
            sendTextBox.KeyPress += CheckEnterKeyPress;
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendButton.Location = new Point(276, 512);
            sendButton.MaximumSize = new Size(94, 29);
            sendButton.MinimumSize = new Size(94, 29);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(94, 29);
            sendButton.TabIndex = 1;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // msgArea
            // 
            msgArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            msgArea.AutoScroll = true;
            msgArea.BackColor = SystemColors.ButtonHighlight;
            msgArea.Location = new Point(12, 31);
            msgArea.Name = "msgArea";
            msgArea.Size = new Size(358, 475);
            msgArea.TabIndex = 2;
            msgArea.ControlAdded += msgArea_ControlAdded;
            msgArea.Resize += msgArea_Resize;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(382, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            Menu.DropDownItems.AddRange(new ToolStripItem[] { ConnectOption, DisconnectOption, ExitOption });
            Menu.Name = "Menu";
            Menu.Size = new Size(60, 24);
            Menu.Text = "Menu";
            // 
            // ConnectOption
            // 
            ConnectOption.Name = "ConnectOption";
            ConnectOption.Size = new Size(165, 26);
            ConnectOption.Text = "Connect";
            ConnectOption.Click += ConnectOption_Click;
            // 
            // DisconnectOption
            // 
            DisconnectOption.Name = "DisconnectOption";
            DisconnectOption.Size = new Size(165, 26);
            DisconnectOption.Text = "Disconnect";
            DisconnectOption.Click += DisconnectOption_Click;
            // 
            // ExitOption
            // 
            ExitOption.Name = "ExitOption";
            ExitOption.Size = new Size(165, 26);
            ExitOption.Text = "Exit";
            ExitOption.Click += ExitOption_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 553);
            Controls.Add(msgArea);
            Controls.Add(sendButton);
            Controls.Add(sendTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(320, 480);
            Name = "Form1";
            Text = "Group Chat";
            
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox sendTextBox;
        private Button sendButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel msgArea;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu;
        private ToolStripMenuItem ConnectOption;
        private ToolStripMenuItem DisconnectOption;
        private ToolStripMenuItem ExitOption;
    }
}
