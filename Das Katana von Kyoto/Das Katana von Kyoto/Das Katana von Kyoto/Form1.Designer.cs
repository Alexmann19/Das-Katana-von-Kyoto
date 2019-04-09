namespace Das_Katana_von_Kyoto
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbtext = new System.Windows.Forms.RichTextBox();
            this.rbwahl1 = new System.Windows.Forms.RadioButton();
            this.rbwahl2 = new System.Windows.Forms.RadioButton();
            this.tbwahl1 = new System.Windows.Forms.TextBox();
            this.tbwahl2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbwurfgegner = new System.Windows.Forms.TextBox();
            this.tbwurfdu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbleben = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbangriff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbstärkegeg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbtext
            // 
            this.rtbtext.Location = new System.Drawing.Point(12, 12);
            this.rtbtext.Name = "rtbtext";
            this.rtbtext.ReadOnly = true;
            this.rtbtext.ShortcutsEnabled = false;
            this.rtbtext.Size = new System.Drawing.Size(479, 220);
            this.rtbtext.TabIndex = 0;
            this.rtbtext.Text = "";
            // 
            // rbwahl1
            // 
            this.rbwahl1.AutoSize = true;
            this.rbwahl1.Location = new System.Drawing.Point(12, 239);
            this.rbwahl1.Name = "rbwahl1";
            this.rbwahl1.Size = new System.Drawing.Size(62, 17);
            this.rbwahl1.TabIndex = 1;
            this.rbwahl1.TabStop = true;
            this.rbwahl1.Text = "Wahl 1:";
            this.rbwahl1.UseVisualStyleBackColor = true;
            // 
            // rbwahl2
            // 
            this.rbwahl2.AutoSize = true;
            this.rbwahl2.Location = new System.Drawing.Point(12, 284);
            this.rbwahl2.Name = "rbwahl2";
            this.rbwahl2.Size = new System.Drawing.Size(62, 17);
            this.rbwahl2.TabIndex = 2;
            this.rbwahl2.TabStop = true;
            this.rbwahl2.Text = "Wahl 2:";
            this.rbwahl2.UseVisualStyleBackColor = true;
            // 
            // tbwahl1
            // 
            this.tbwahl1.Location = new System.Drawing.Point(81, 238);
            this.tbwahl1.Multiline = true;
            this.tbwahl1.Name = "tbwahl1";
            this.tbwahl1.ReadOnly = true;
            this.tbwahl1.ShortcutsEnabled = false;
            this.tbwahl1.Size = new System.Drawing.Size(410, 39);
            this.tbwahl1.TabIndex = 3;
            // 
            // tbwahl2
            // 
            this.tbwahl2.Location = new System.Drawing.Point(81, 283);
            this.tbwahl2.Multiline = true;
            this.tbwahl2.Name = "tbwahl2";
            this.tbwahl2.ReadOnly = true;
            this.tbwahl2.ShortcutsEnabled = false;
            this.tbwahl2.Size = new System.Drawing.Size(410, 37);
            this.tbwahl2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Wählen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Würfeln";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbyen
            // 
            this.tbyen.Location = new System.Drawing.Point(391, 489);
            this.tbyen.Name = "tbyen";
            this.tbyen.ReadOnly = true;
            this.tbyen.ShortcutsEnabled = false;
            this.tbyen.Size = new System.Drawing.Size(100, 20);
            this.tbyen.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Yen (¥):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbstärkegeg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbangriff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbwurfgegner);
            this.groupBox1.Controls.Add(this.tbwurfdu);
            this.groupBox1.Location = new System.Drawing.Point(311, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 131);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Würfeln";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gegner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Du:";
            // 
            // tbwurfgegner
            // 
            this.tbwurfgegner.Location = new System.Drawing.Point(74, 46);
            this.tbwurfgegner.Name = "tbwurfgegner";
            this.tbwurfgegner.ReadOnly = true;
            this.tbwurfgegner.ShortcutsEnabled = false;
            this.tbwurfgegner.Size = new System.Drawing.Size(100, 20);
            this.tbwurfgegner.TabIndex = 1;
            // 
            // tbwurfdu
            // 
            this.tbwurfdu.Location = new System.Drawing.Point(74, 20);
            this.tbwurfdu.Name = "tbwurfdu";
            this.tbwurfdu.ReadOnly = true;
            this.tbwurfdu.ShortcutsEnabled = false;
            this.tbwurfdu.Size = new System.Drawing.Size(100, 20);
            this.tbwurfdu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbleben
            // 
            this.tbleben.Location = new System.Drawing.Point(391, 463);
            this.tbleben.Name = "tbleben";
            this.tbleben.ReadOnly = true;
            this.tbleben.ShortcutsEnabled = false;
            this.tbleben.Size = new System.Drawing.Size(100, 20);
            this.tbleben.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gesundheit:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbangriff
            // 
            this.tbangriff.Location = new System.Drawing.Point(74, 99);
            this.tbangriff.Name = "tbangriff";
            this.tbangriff.ReadOnly = true;
            this.tbangriff.ShortcutsEnabled = false;
            this.tbangriff.Size = new System.Drawing.Size(100, 20);
            this.tbangriff.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dein Angriff:";
            // 
            // tbstärkegeg
            // 
            this.tbstärkegeg.Location = new System.Drawing.Point(74, 73);
            this.tbstärkegeg.Name = "tbstärkegeg";
            this.tbstärkegeg.ReadOnly = true;
            this.tbstärkegeg.ShortcutsEnabled = false;
            this.tbstärkegeg.Size = new System.Drawing.Size(100, 20);
            this.tbstärkegeg.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stärke Geg.:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 521);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbleben);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbyen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbwahl2);
            this.Controls.Add(this.tbwahl1);
            this.Controls.Add(this.rbwahl2);
            this.Controls.Add(this.rbwahl1);
            this.Controls.Add(this.rtbtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Das Katana von Kyoto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbtext;
        private System.Windows.Forms.RadioButton rbwahl1;
        private System.Windows.Forms.RadioButton rbwahl2;
        private System.Windows.Forms.TextBox tbwahl1;
        private System.Windows.Forms.TextBox tbwahl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbwurfgegner;
        private System.Windows.Forms.TextBox tbwurfdu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbleben;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbstärkegeg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbangriff;
        private System.Windows.Forms.Button button4;
    }
}

