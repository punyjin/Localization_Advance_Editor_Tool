namespace Localization_Editor
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Editor_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS_1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_export = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Export_Decrypted_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS_2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Save_Encrypted = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Save_Decrypted = new System.Windows.Forms.ToolStripMenuItem();
            this.editModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_HEX_COLOR = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Ingame_Input = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_XML_FILE_LOADER = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Helper = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CMS.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(935, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.AutoSize = true;
            this.btnLoadFile.Location = new System.Drawing.Point(1043, 498);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(102, 50);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Export Raw";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 464);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localization";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1121, 439);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.Location = new System.Drawing.Point(827, 498);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(102, 50);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 498);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 47);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Open,
            this.TSMI_Editor_Mode,
            this.TSS_1,
            this.TSMI_export,
            this.TSMI_Export_Decrypted_File,
            this.TSS_2,
            this.TSMI_About,
            this.TSMI_Exit});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(187, 148);
            this.CMS.Text = "Localization";
            // 
            // TSMI_Open
            // 
            this.TSMI_Open.Name = "TSMI_Open";
            this.TSMI_Open.Size = new System.Drawing.Size(186, 22);
            this.TSMI_Open.Text = "Open";
            // 
            // TSMI_Editor_Mode
            // 
            this.TSMI_Editor_Mode.Name = "TSMI_Editor_Mode";
            this.TSMI_Editor_Mode.Size = new System.Drawing.Size(186, 22);
            this.TSMI_Editor_Mode.Text = "Edit";
            // 
            // TSS_1
            // 
            this.TSS_1.Name = "TSS_1";
            this.TSS_1.Size = new System.Drawing.Size(183, 6);
            // 
            // TSMI_export
            // 
            this.TSMI_export.Name = "TSMI_export";
            this.TSMI_export.Size = new System.Drawing.Size(186, 22);
            this.TSMI_export.Text = "Export";
            // 
            // TSMI_Export_Decrypted_File
            // 
            this.TSMI_Export_Decrypted_File.Name = "TSMI_Export_Decrypted_File";
            this.TSMI_Export_Decrypted_File.Size = new System.Drawing.Size(186, 22);
            this.TSMI_Export_Decrypted_File.Text = "Export Decrypted File";
            // 
            // TSS_2
            // 
            this.TSS_2.Name = "TSS_2";
            this.TSS_2.Size = new System.Drawing.Size(183, 6);
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(186, 22);
            this.TSMI_About.Text = "About ";
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(186, 22);
            this.TSMI_Exit.Text = "Exit";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.editModeToolStripMenuItem,
            this.TSMI_Helper,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.TSMI_Open_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Save_Encrypted,
            this.TSMI_Save_Decrypted});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.exportToolStripMenuItem.Text = "Save";
            // 
            // TSMI_Save_Encrypted
            // 
            this.TSMI_Save_Encrypted.Name = "TSMI_Save_Encrypted";
            this.TSMI_Save_Encrypted.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Save_Encrypted.Text = "Save as Encrypted";
            this.TSMI_Save_Encrypted.Click += new System.EventHandler(this.TSMI_Save_Encrypted_Click);
            // 
            // TSMI_Save_Decrypted
            // 
            this.TSMI_Save_Decrypted.Name = "TSMI_Save_Decrypted";
            this.TSMI_Save_Decrypted.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Save_Decrypted.Text = "Save as Decrypted";
            this.TSMI_Save_Decrypted.Click += new System.EventHandler(this.TSMI_Save_Decrypted_Click);
            // 
            // editModeToolStripMenuItem
            // 
            this.editModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_HEX_COLOR,
            this.TSMI_Ingame_Input,
            this.TSMI_XML_FILE_LOADER});
            this.editModeToolStripMenuItem.Name = "editModeToolStripMenuItem";
            this.editModeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.editModeToolStripMenuItem.Text = "Edit Mode";
            // 
            // TSMI_HEX_COLOR
            // 
            this.TSMI_HEX_COLOR.Name = "TSMI_HEX_COLOR";
            this.TSMI_HEX_COLOR.Size = new System.Drawing.Size(180, 22);
            this.TSMI_HEX_COLOR.Text = "Color Menu";
            this.TSMI_HEX_COLOR.Click += new System.EventHandler(this.TSMI_HEX_COLOR_Click);
            // 
            // TSMI_Ingame_Input
            // 
            this.TSMI_Ingame_Input.Name = "TSMI_Ingame_Input";
            this.TSMI_Ingame_Input.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Ingame_Input.Text = "Ingame Input Menu";
            this.TSMI_Ingame_Input.Click += new System.EventHandler(this.TSMI_Ingame_Input_Click);
            // 
            // TSMI_XML_FILE_LOADER
            // 
            this.TSMI_XML_FILE_LOADER.Name = "TSMI_XML_FILE_LOADER";
            this.TSMI_XML_FILE_LOADER.Size = new System.Drawing.Size(180, 22);
            this.TSMI_XML_FILE_LOADER.Text = "XML File Menu";
            this.TSMI_XML_FILE_LOADER.Click += new System.EventHandler(this.TSMI_XML_FILE_LOADER_Click);
            // 
            // TSMI_Helper
            // 
            this.TSMI_Helper.Name = "TSMI_Helper";
            this.TSMI_Helper.Size = new System.Drawing.Size(44, 20);
            this.TSMI_Helper.Text = "Help";
            this.TSMI_Helper.Click += new System.EventHandler(this.TSMI_Helper_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 555);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1173, 594);
            this.MinimumSize = new System.Drawing.Size(1173, 594);
            this.Name = "Main";
            this.Text = "7DayToDie - Localization editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CMS.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Open;
        private System.Windows.Forms.ToolStripMenuItem TSMI_export;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Export_Decrypted_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Editor_Mode;
        private System.Windows.Forms.ToolStripSeparator TSS_1;
        private System.Windows.Forms.ToolStripSeparator TSS_2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Save_Encrypted;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Save_Decrypted;
        private System.Windows.Forms.ToolStripMenuItem editModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_HEX_COLOR;
        private System.Windows.Forms.ToolStripMenuItem TSMI_XML_FILE_LOADER;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Ingame_Input;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Helper;
    }
}

