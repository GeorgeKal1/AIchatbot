namespace AIChatBot
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
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            saveChattxtToolStripMenuItem = new ToolStripMenuItem();
            SaveChatToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            databaseToolStripMenuItem = new ToolStripMenuItem();
            saveAnswerToDBToolStripMenuItem = new ToolStripMenuItem();
            loadDBToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            showInfoToolStripMenuItem = new ToolStripMenuItem();
            termsOfUseToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(50, 48, 50);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            richTextBox1.ForeColor = SystemColors.ActiveBorder;
            richTextBox1.Location = new Point(32, 45);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(900, 491);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.MouseDown += richTextBox1_MouseDown;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 48, 50);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            textBox1.ForeColor = SystemColors.ActiveBorder;
            textBox1.Location = new Point(32, 551);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(713, 54);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 48, 50);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            button1.ForeColor = SystemColors.ActiveBorder;
            button1.Location = new Point(772, 551);
            button1.Name = "button1";
            button1.Size = new Size(160, 54);
            button1.TabIndex = 2;
            button1.Text = "send";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, databaseToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1105, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, saveChattxtToolStripMenuItem, SaveChatToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(222, 26);
            toolStripMenuItem1.Text = "New Chat";
            toolStripMenuItem1.Click += NewChatMenuItem1_Click;
            // 
            // saveChattxtToolStripMenuItem
            // 
            saveChattxtToolStripMenuItem.Name = "saveChattxtToolStripMenuItem";
            saveChattxtToolStripMenuItem.Size = new Size(222, 26);
            saveChattxtToolStripMenuItem.Text = "Insert Question (txt)";
            saveChattxtToolStripMenuItem.Click += saveChattxtToolStripMenuItem_Click;
            // 
            // SaveChatToolStripMenuItem
            // 
            SaveChatToolStripMenuItem.Name = "SaveChatToolStripMenuItem";
            SaveChatToolStripMenuItem.Size = new Size(222, 26);
            SaveChatToolStripMenuItem.Text = "Save Chat (txt)";
            SaveChatToolStripMenuItem.Click += SaveChatToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(222, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // databaseToolStripMenuItem
            // 
            databaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAnswerToDBToolStripMenuItem, loadDBToolStripMenuItem });
            databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            databaseToolStripMenuItem.Size = new Size(86, 24);
            databaseToolStripMenuItem.Text = "Database";
            // 
            // saveAnswerToDBToolStripMenuItem
            // 
            saveAnswerToDBToolStripMenuItem.Name = "saveAnswerToDBToolStripMenuItem";
            saveAnswerToDBToolStripMenuItem.Size = new Size(217, 26);
            saveAnswerToDBToolStripMenuItem.Text = "Save Answer to DB";
            saveAnswerToDBToolStripMenuItem.Click += saveAnswerToDBToolStripMenuItem_Click;
            // 
            // loadDBToolStripMenuItem
            // 
            loadDBToolStripMenuItem.Name = "loadDBToolStripMenuItem";
            loadDBToolStripMenuItem.Size = new Size(217, 26);
            loadDBToolStripMenuItem.Text = "Load DB";
            loadDBToolStripMenuItem.Click += loadDBToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showInfoToolStripMenuItem, termsOfUseToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // showInfoToolStripMenuItem
            // 
            showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            showInfoToolStripMenuItem.Size = new Size(179, 26);
            showInfoToolStripMenuItem.Text = "Show Info";
            showInfoToolStripMenuItem.Click += showInfoToolStripMenuItem_Click;
            // 
            // termsOfUseToolStripMenuItem
            // 
            termsOfUseToolStripMenuItem.Name = "termsOfUseToolStripMenuItem";
            termsOfUseToolStripMenuItem.Size = new Size(179, 26);
            termsOfUseToolStripMenuItem.Text = "Terms Of Use";
            termsOfUseToolStripMenuItem.Click += termsOfUseToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo11;
            pictureBox1.Location = new Point(955, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 30);
            ClientSize = new Size(1105, 647);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem databaseToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem saveChattxtToolStripMenuItem;
        private ToolStripMenuItem SaveChatToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem showInfoToolStripMenuItem;
        private ToolStripMenuItem termsOfUseToolStripMenuItem;
        private ToolStripMenuItem saveAnswerToDBToolStripMenuItem;
        private ToolStripMenuItem loadDBToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
    }
}
