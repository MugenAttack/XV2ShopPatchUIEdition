namespace AllinShopPatch
{
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtZeni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.chklstIDB = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegShop = new System.Windows.Forms.ToolStripMenuItem();
            this.IgnoreZeni = new System.Windows.Forms.ToolStripMenuItem();
            this.IgnoreTP = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addToShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.applyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(471, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chklstIDB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtZeni);
            this.groupBox1.Location = new System.Drawing.Point(5, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 270);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clothing";
            // 
            // txtZeni
            // 
            this.txtZeni.Location = new System.Drawing.Point(91, 26);
            this.txtZeni.Name = "txtZeni";
            this.txtZeni.Size = new System.Drawing.Size(140, 20);
            this.txtZeni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zeni Formula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TP Formula";
            // 
            // txtTP
            // 
            this.txtTP.Location = new System.Drawing.Point(91, 52);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(140, 20);
            this.txtTP.TabIndex = 4;
            // 
            // chklstIDB
            // 
            this.chklstIDB.FormattingEnabled = true;
            this.chklstIDB.Items.AddRange(new object[] {
            "Costume Top",
            "Costume Bottom",
            "Costum Shoes",
            "Costume Gloves",
            "Accessories",
            "Skills",
            "Super Souls",
            "Battle Items",
            "Material",
            "HC Items (TP Only)",
            "HC Character Skills (TP Only)"});
            this.chklstIDB.Location = new System.Drawing.Point(6, 78);
            this.chklstIDB.Name = "chklstIDB";
            this.chklstIDB.Size = new System.Drawing.Size(225, 169);
            this.chklstIDB.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(248, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 270);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "How to Use";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToShopToolStripMenuItem,
            this.RegShop,
            this.IgnoreZeni,
            this.IgnoreTP});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // RegShop
            // 
            this.RegShop.Checked = true;
            this.RegShop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RegShop.Name = "RegShop";
            this.RegShop.Size = new System.Drawing.Size(227, 22);
            this.RegShop.Text = "Add to Reg. Shop";
            this.RegShop.Click += new System.EventHandler(this.RegShop_Click);
            // 
            // IgnoreZeni
            // 
            this.IgnoreZeni.Name = "IgnoreZeni";
            this.IgnoreZeni.Size = new System.Drawing.Size(227, 22);
            this.IgnoreZeni.Text = "Ignore if has buy value (Zeni)";
            this.IgnoreZeni.Click += new System.EventHandler(this.IgnoreZeni_Click);
            // 
            // IgnoreTP
            // 
            this.IgnoreTP.Name = "IgnoreTP";
            this.IgnoreTP.Size = new System.Drawing.Size(227, 22);
            this.IgnoreTP.Text = "Ignore if has buy value (TP)";
            this.IgnoreTP.Click += new System.EventHandler(this.IgnoreTP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 91);
            this.label3.TabIndex = 0;
            this.label3.Text = "Formula Variables:\r\nID = id value of shop item.\r\nSTAR = star value of shop item.\r" +
    "\nTYPE = type value of shop item.\r\nBUY = buy value of shop item.\r\nSELL = sell val" +
    "ue of shop item.\r\nTP = tp value\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 169);
            this.label4.TabIndex = 1;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // addToShopToolStripMenuItem
            // 
            this.addToShopToolStripMenuItem.Checked = true;
            this.addToShopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addToShopToolStripMenuItem.Name = "addToShopToolStripMenuItem";
            this.addToShopToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.addToShopToolStripMenuItem.Text = "Add to Shop";
            this.addToShopToolStripMenuItem.Click += new System.EventHandler(this.addToShopToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "All in Shop Patcher UI Edition";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegShop;
        private System.Windows.Forms.ToolStripMenuItem IgnoreZeni;
        private System.Windows.Forms.ToolStripMenuItem IgnoreTP;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chklstIDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZeni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem addToShopToolStripMenuItem;
    }
}

