namespace LastTask
{
    partial class AddMenuItemForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.topLevelMenu = new System.Windows.Forms.TextBox();
            this.subItem = new System.Windows.Forms.TextBox();
            this.addMenuButton = new System.Windows.Forms.Button();
            this.addSubItemButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLevelMenu
            // 
            this.topLevelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topLevelMenu.Location = new System.Drawing.Point(75, 62);
            this.topLevelMenu.Name = "topLevelMenu";
            this.topLevelMenu.Size = new System.Drawing.Size(124, 20);
            this.topLevelMenu.TabIndex = 0;
            // 
            // subItem
            // 
            this.subItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subItem.Location = new System.Drawing.Point(220, 62);
            this.subItem.Name = "subItem";
            this.subItem.Size = new System.Drawing.Size(124, 20);
            this.subItem.TabIndex = 1;
            // 
            // addMenuButton
            // 
            this.addMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMenuButton.Location = new System.Drawing.Point(75, 100);
            this.addMenuButton.Name = "addMenuButton";
            this.addMenuButton.Size = new System.Drawing.Size(124, 34);
            this.addMenuButton.TabIndex = 2;
            this.addMenuButton.Text = "Добавить меню";
            this.addMenuButton.UseVisualStyleBackColor = true;
            this.addMenuButton.Click += new System.EventHandler(this.AddMenuButton_Click);
            // 
            // addSubItemButton
            // 
            this.addSubItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addSubItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSubItemButton.Location = new System.Drawing.Point(220, 100);
            this.addSubItemButton.Name = "addSubItemButton";
            this.addSubItemButton.Size = new System.Drawing.Size(124, 34);
            this.addSubItemButton.TabIndex = 3;
            this.addSubItemButton.Text = "Добавить подменю";
            this.addSubItemButton.UseVisualStyleBackColor = true;
            this.addSubItemButton.Click += new System.EventHandler(this.AddSubItemButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(421, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem.Text = "File";
            // 
            // AddMenuItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 177);
            this.Controls.Add(this.addSubItemButton);
            this.Controls.Add(this.addMenuButton);
            this.Controls.Add(this.subItem);
            this.Controls.Add(this.topLevelMenu);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(437, 216);
            this.MinimumSize = new System.Drawing.Size(437, 216);
            this.Name = "AddMenuItemForm";
            this.Text = "Add menu item";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox topLevelMenu;
        private System.Windows.Forms.TextBox subItem;
        private System.Windows.Forms.Button addMenuButton;
        private System.Windows.Forms.Button addSubItemButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
    }
}

