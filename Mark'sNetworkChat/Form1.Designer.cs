namespace TCP_Chat
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chatBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.chatInput = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.namePanel = new System.Windows.Forms.Panel();
            this.saveNameBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.serverStatusLbl = new System.Windows.Forms.Label();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.conncetionPanel = new System.Windows.Forms.Panel();
            this.connectingLbl = new System.Windows.Forms.Label();
            this.serverStartBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.localhostBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.chatPanel.SuspendLayout();
            this.conncetionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.chatBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 629);
            this.panel1.TabIndex = 0;
            // 
            // chatBtn
            // 
            this.chatBtn.FlatAppearance.BorderSize = 0;
            this.chatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatBtn.Image = ((System.Drawing.Image)(resources.GetObject("chatBtn.Image")));
            this.chatBtn.Location = new System.Drawing.Point(3, 106);
            this.chatBtn.Name = "chatBtn";
            this.chatBtn.Size = new System.Drawing.Size(153, 65);
            this.chatBtn.TabIndex = 1;
            this.chatBtn.Text = "Chat";
            this.chatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chatBtn.UseVisualStyleBackColor = true;
            this.chatBtn.Click += new System.EventHandler(this.chatBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCP Chat";
            // 
            // messagePanel
            // 
            this.messagePanel.Controls.Add(this.chatInput);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messagePanel.Location = new System.Drawing.Point(162, 556);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(814, 73);
            this.messagePanel.TabIndex = 1;
            // 
            // chatInput
            // 
            this.chatInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.chatInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatInput.ForeColor = System.Drawing.SystemColors.Window;
            this.chatInput.Location = new System.Drawing.Point(46, 25);
            this.chatInput.Name = "chatInput";
            this.chatInput.Size = new System.Drawing.Size(718, 27);
            this.chatInput.TabIndex = 0;
            this.chatInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatInput_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.topPanel);
            this.panel4.Controls.Add(this.conncetionPanel);
            this.panel4.Controls.Add(this.namePanel);
            this.panel4.Controls.Add(this.chatPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(162, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(814, 556);
            this.panel4.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(805, 36);
            this.topPanel.TabIndex = 3;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeBtn.Location = new System.Drawing.Point(750, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(55, 36);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.saveNameBtn);
            this.namePanel.Controls.Add(this.label3);
            this.namePanel.Controls.Add(this.nameInput);
            this.namePanel.Location = new System.Drawing.Point(7, 45);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(795, 505);
            this.namePanel.TabIndex = 5;
            // 
            // saveNameBtn
            // 
            this.saveNameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.saveNameBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.saveNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNameBtn.ForeColor = System.Drawing.Color.White;
            this.saveNameBtn.Location = new System.Drawing.Point(347, 236);
            this.saveNameBtn.Name = "saveNameBtn";
            this.saveNameBtn.Size = new System.Drawing.Size(115, 32);
            this.saveNameBtn.TabIndex = 2;
            this.saveNameBtn.Text = "Uložit jméno";
            this.saveNameBtn.UseVisualStyleBackColor = false;
            this.saveNameBtn.Click += new System.EventHandler(this.saveNameBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.nameInput.ForeColor = System.Drawing.SystemColors.Window;
            this.nameInput.Location = new System.Drawing.Point(330, 192);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(170, 27);
            this.nameInput.TabIndex = 0;
            // 
            // chatPanel
            // 
            this.chatPanel.Controls.Add(this.serverStatusLbl);
            this.chatPanel.Controls.Add(this.chatBox);
            this.chatPanel.Location = new System.Drawing.Point(7, 45);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(796, 502);
            this.chatPanel.TabIndex = 7;
            // 
            // serverStatusLbl
            // 
            this.serverStatusLbl.AutoSize = true;
            this.serverStatusLbl.Location = new System.Drawing.Point(76, 31);
            this.serverStatusLbl.Name = "serverStatusLbl";
            this.serverStatusLbl.Size = new System.Drawing.Size(215, 21);
            this.serverStatusLbl.TabIndex = 7;
            this.serverStatusLbl.Text = "Server byl úspěšně spuštěn";
            this.serverStatusLbl.Visible = false;
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.chatBox.ForeColor = System.Drawing.SystemColors.Window;
            this.chatBox.Location = new System.Drawing.Point(76, 73);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(664, 392);
            this.chatBox.TabIndex = 6;
            this.chatBox.Text = "";
            // 
            // conncetionPanel
            // 
            this.conncetionPanel.Controls.Add(this.connectingLbl);
            this.conncetionPanel.Controls.Add(this.serverStartBtn);
            this.conncetionPanel.Controls.Add(this.label5);
            this.conncetionPanel.Controls.Add(this.label4);
            this.conncetionPanel.Controls.Add(this.connectBtn);
            this.conncetionPanel.Controls.Add(this.ipInput);
            this.conncetionPanel.Controls.Add(this.localhostBtn);
            this.conncetionPanel.Location = new System.Drawing.Point(7, 45);
            this.conncetionPanel.Name = "conncetionPanel";
            this.conncetionPanel.Size = new System.Drawing.Size(796, 502);
            this.conncetionPanel.TabIndex = 6;
            // 
            // connectingLbl
            // 
            this.connectingLbl.AutoSize = true;
            this.connectingLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectingLbl.Location = new System.Drawing.Point(297, 444);
            this.connectingLbl.Name = "connectingLbl";
            this.connectingLbl.Size = new System.Drawing.Size(216, 23);
            this.connectingLbl.TabIndex = 6;
            this.connectingLbl.Text = "Připojování k serveru...";
            // 
            // serverStartBtn
            // 
            this.serverStartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.serverStartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.serverStartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverStartBtn.ForeColor = System.Drawing.Color.White;
            this.serverStartBtn.Location = new System.Drawing.Point(331, 332);
            this.serverStartBtn.Name = "serverStartBtn";
            this.serverStartBtn.Size = new System.Drawing.Size(149, 32);
            this.serverStartBtn.TabIndex = 5;
            this.serverStartBtn.Text = "Spustit Server";
            this.serverStartBtn.UseVisualStyleBackColor = false;
            this.serverStartBtn.Click += new System.EventHandler(this.serverStartBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(286, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vytvoření Serveru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(293, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Připojení k Serveru";
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.connectBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.ForeColor = System.Drawing.Color.White;
            this.connectBtn.Location = new System.Drawing.Point(420, 94);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(97, 32);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Připojit";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // ipInput
            // 
            this.ipInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.ipInput.ForeColor = System.Drawing.Color.White;
            this.ipInput.Location = new System.Drawing.Point(291, 97);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(107, 27);
            this.ipInput.TabIndex = 1;
            // 
            // localhostBtn
            // 
            this.localhostBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.localhostBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.localhostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localhostBtn.ForeColor = System.Drawing.Color.White;
            this.localhostBtn.Location = new System.Drawing.Point(357, 137);
            this.localhostBtn.Name = "localhostBtn";
            this.localhostBtn.Size = new System.Drawing.Size(97, 32);
            this.localhostBtn.TabIndex = 0;
            this.localhostBtn.Text = "Localhost";
            this.localhostBtn.UseVisualStyleBackColor = false;
            this.localhostBtn.Click += new System.EventHandler(this.localhostBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(976, 629);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.chatPanel.ResumeLayout(false);
            this.chatPanel.PerformLayout();
            this.conncetionPanel.ResumeLayout(false);
            this.conncetionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Button chatBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox chatInput;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Panel conncetionPanel;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.Button localhostBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox ipInput;
        private System.Windows.Forms.Button serverStartBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label connectingLbl;
        private System.Windows.Forms.Button saveNameBtn;
        private System.Windows.Forms.Label serverStatusLbl;
    }
}

