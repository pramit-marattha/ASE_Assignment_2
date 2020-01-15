namespace PramitASEcomp2
{/// <summary>
/// creating class form1
/// </summary>
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Artboard = new System.Windows.Forms.Panel();
            this.Runtextbox = new System.Windows.Forms.TextBox();
            this.Grouptextcmd = new System.Windows.Forms.RichTextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.Grouptextrunbutton = new System.Windows.Forms.Button();
            this.Cleargrouptext = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.black = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(983, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.helpToolStripMenuItem1.Text = "About";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.BackColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Artboard
            // 
            this.Artboard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Artboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Artboard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Artboard.Location = new System.Drawing.Point(19, 409);
            this.Artboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Artboard.Name = "Artboard";
            this.Artboard.Size = new System.Drawing.Size(687, 286);
            this.Artboard.TabIndex = 1;
            this.Artboard.Paint += new System.Windows.Forms.PaintEventHandler(this.Artboard_Paint);
            this.Artboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Artboard_MouseClick);
            // 
            // Runtextbox
            // 
            this.Runtextbox.Location = new System.Drawing.Point(18, 699);
            this.Runtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Runtextbox.Name = "Runtextbox";
            this.Runtextbox.Size = new System.Drawing.Size(372, 22);
            this.Runtextbox.TabIndex = 2;
            this.Runtextbox.TextChanged += new System.EventHandler(this.Runtextbox_TextChanged);
            // 
            // Grouptextcmd
            // 
            this.Grouptextcmd.Location = new System.Drawing.Point(712, 409);
            this.Grouptextcmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grouptextcmd.Name = "Grouptextcmd";
            this.Grouptextcmd.Size = new System.Drawing.Size(259, 286);
            this.Grouptextcmd.TabIndex = 3;
            this.Grouptextcmd.Text = "";
            this.Grouptextcmd.TextChanged += new System.EventHandler(this.Grouptextcmd_TextChanged);
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.PaleGreen;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RunButton.Location = new System.Drawing.Point(19, 725);
            this.RunButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 34);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Grouptextrunbutton
            // 
            this.Grouptextrunbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.Grouptextrunbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Grouptextrunbutton.Location = new System.Drawing.Point(845, 699);
            this.Grouptextrunbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grouptextrunbutton.Name = "Grouptextrunbutton";
            this.Grouptextrunbutton.Size = new System.Drawing.Size(116, 34);
            this.Grouptextrunbutton.TabIndex = 6;
            this.Grouptextrunbutton.Text = "Run";
            this.Grouptextrunbutton.UseVisualStyleBackColor = false;
            this.Grouptextrunbutton.Click += new System.EventHandler(this.Grouptextrunbutton_Click);
            // 
            // Cleargrouptext
            // 
            this.Cleargrouptext.BackColor = System.Drawing.Color.Red;
            this.Cleargrouptext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cleargrouptext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cleargrouptext.Location = new System.Drawing.Point(19, 374);
            this.Cleargrouptext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cleargrouptext.Name = "Cleargrouptext";
            this.Cleargrouptext.Size = new System.Drawing.Size(135, 30);
            this.Cleargrouptext.TabIndex = 7;
            this.Cleargrouptext.Text = "Clear Drawing";
            this.Cleargrouptext.UseVisualStyleBackColor = false;
            this.Cleargrouptext.Click += new System.EventHandler(this.Cleargrouptext_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.Color.Firebrick;
            this.Resetbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Resetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Resetbutton.Location = new System.Drawing.Point(156, 375);
            this.Resetbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(136, 30);
            this.Resetbutton.TabIndex = 8;
            this.Resetbutton.Text = "Reset position";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Loadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loadbtn.Location = new System.Drawing.Point(805, 373);
            this.Loadbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(75, 32);
            this.Loadbtn.TabIndex = 9;
            this.Loadbtn.Text = "Open";
            this.Loadbtn.UseVisualStyleBackColor = false;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Savebtn.Location = new System.Drawing.Point(886, 372);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 32);
            this.Savebtn.TabIndex = 10;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(13, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 106);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(712, 699);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear Code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(105, 725);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear Code";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Location = new System.Drawing.Point(19, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 80);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Artboard_MouseClick);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "circle",
            "Rectangle",
            "Square"});
            this.listBox1.Location = new System.Drawing.Point(827, 283);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 84);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(890, 141);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(57, 53);
            this.red.TabIndex = 11;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(890, 200);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(57, 53);
            this.blue.TabIndex = 11;
            this.blue.TabStop = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Lime;
            this.green.Location = new System.Drawing.Point(827, 200);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(57, 53);
            this.green.TabIndex = 11;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(827, 141);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(57, 53);
            this.black.TabIndex = 11;
            this.black.TabStop = false;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 763);
            this.Controls.Add(this.Cleargrouptext);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.green);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.black);
            this.Controls.Add(this.Artboard);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.red);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grouptextrunbutton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.Grouptextcmd);
            this.Controls.Add(this.Runtextbox);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Graphical Programming Language Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel Artboard;
        private System.Windows.Forms.TextBox Runtextbox;
        private System.Windows.Forms.RichTextBox Grouptextcmd;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button Grouptextrunbutton;
        private System.Windows.Forms.Button Cleargrouptext;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox black;
    }
}

