namespace Images
{
    partial class CopyDataTable
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
            this.openFolder = new System.Windows.Forms.Button();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.listDatabase = new System.Windows.Forms.ListBox();
            this.RootPath = new System.Windows.Forms.Label();
            this.rc_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFolder
            // 
            this.openFolder.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.openFolder.Location = new System.Drawing.Point(580, 59);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(112, 32);
            this.openFolder.TabIndex = 0;
            this.openFolder.Text = "Choose file(.db)";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // folderPath
            // 
            this.folderPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderPath.Location = new System.Drawing.Point(2, 59);
            this.folderPath.Margin = new System.Windows.Forms.Padding(10, 7, 3, 3);
            this.folderPath.Multiline = true;
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(557, 32);
            this.folderPath.TabIndex = 1;
            // 
            // listDatabase
            // 
            this.listDatabase.BackColor = System.Drawing.Color.Black;
            this.listDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDatabase.ForeColor = System.Drawing.Color.White;
            this.listDatabase.FormattingEnabled = true;
            this.listDatabase.ItemHeight = 16;
            this.listDatabase.Location = new System.Drawing.Point(2, 214);
            this.listDatabase.Name = "listDatabase";
            this.listDatabase.Size = new System.Drawing.Size(690, 532);
            this.listDatabase.TabIndex = 2;
            this.listDatabase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listDatabase_MouseDown);
            // 
            // RootPath
            // 
            this.RootPath.AutoSize = true;
            this.RootPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RootPath.ForeColor = System.Drawing.Color.White;
            this.RootPath.Location = new System.Drawing.Point(-2, 177);
            this.RootPath.Name = "RootPath";
            this.RootPath.Size = new System.Drawing.Size(91, 19);
            this.RootPath.TabIndex = 3;
            this.RootPath.Text = "Path : ( none)";
            // 
            // rc_Menu
            // 
            this.rc_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.rc_Menu.Name = "rc_Menu";
            this.rc_Menu.Size = new System.Drawing.Size(108, 26);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Images.Properties.Resources.database_50px;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // CopyDataTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1553, 758);
            this.Controls.Add(this.RootPath);
            this.Controls.Add(this.listDatabase);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.openFolder);
            this.Name = "CopyDataTable";
            this.Text = "CopyDataTable";
            this.rc_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.ListBox listDatabase;
        private System.Windows.Forms.Label RootPath;
        private System.Windows.Forms.ContextMenuStrip rc_Menu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}