namespace Lab4.View
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCertainDebtorBut = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllDebtorsAndDebtsBut = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitBut = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgBut = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.deleteBut = new System.Windows.Forms.Button();
            this.editBut = new System.Windows.Forms.Button();
            this.searchBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.noSearchBut = new System.Windows.Forms.Button();
            this.Table = new Lab4.View.NestedTable.NestedTable();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.AboutProgBut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1304, 36);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.ExitBut});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 32);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportCertainDebtorBut,
            this.exportAllDebtorsAndDebtsBut});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 34);
            this.toolStripMenuItem2.Text = "Экспорт";
            // 
            // exportCertainDebtorBut
            // 
            this.exportCertainDebtorBut.Name = "exportCertainDebtorBut";
            this.exportCertainDebtorBut.Size = new System.Drawing.Size(455, 34);
            this.exportCertainDebtorBut.Text = "Выделенный(ые) должник(и) и его долг(и)";
            // 
            // exportAllDebtorsAndDebtsBut
            // 
            this.exportAllDebtorsAndDebtsBut.Name = "exportAllDebtorsAndDebtsBut";
            this.exportAllDebtorsAndDebtsBut.Size = new System.Drawing.Size(455, 34);
            this.exportAllDebtorsAndDebtsBut.Text = "Все должники и долги";
            // 
            // ExitBut
            // 
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(181, 34);
            this.ExitBut.Text = "Выход";
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // AboutProgBut
            // 
            this.AboutProgBut.Name = "AboutProgBut";
            this.AboutProgBut.Size = new System.Drawing.Size(141, 32);
            this.AboutProgBut.Text = "О программе";
            this.AboutProgBut.Click += new System.EventHandler(this.AboutProgBut_Click);
            // 
            // refreshBut
            // 
            this.refreshBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBut.BackgroundImage")));
            this.refreshBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBut.Location = new System.Drawing.Point(12, 38);
            this.refreshBut.Name = "refreshBut";
            this.refreshBut.Size = new System.Drawing.Size(107, 82);
            this.refreshBut.TabIndex = 1;
            this.refreshBut.Text = "Сброс";
            this.refreshBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.refreshBut.UseVisualStyleBackColor = false;
            // 
            // saveBut
            // 
            this.saveBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBut.BackgroundImage")));
            this.saveBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBut.Location = new System.Drawing.Point(682, 39);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(107, 82);
            this.saveBut.TabIndex = 6;
            this.saveBut.Text = "Сохранить";
            this.saveBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveBut.UseVisualStyleBackColor = false;
            // 
            // deleteBut
            // 
            this.deleteBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBut.BackgroundImage")));
            this.deleteBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBut.Location = new System.Drawing.Point(569, 39);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(107, 82);
            this.deleteBut.TabIndex = 5;
            this.deleteBut.Text = "Удалить";
            this.deleteBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteBut.UseVisualStyleBackColor = false;
            // 
            // editBut
            // 
            this.editBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editBut.BackgroundImage")));
            this.editBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBut.Location = new System.Drawing.Point(456, 39);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(107, 82);
            this.editBut.TabIndex = 4;
            this.editBut.Text = "Изменить";
            this.editBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editBut.UseVisualStyleBackColor = false;
            // 
            // searchBut
            // 
            this.searchBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBut.BackgroundImage")));
            this.searchBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBut.Location = new System.Drawing.Point(238, 39);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(107, 82);
            this.searchBut.TabIndex = 3;
            this.searchBut.Text = "Поиск";
            this.searchBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchBut.UseVisualStyleBackColor = false;
            // 
            // addBut
            // 
            this.addBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBut.BackgroundImage")));
            this.addBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBut.Location = new System.Drawing.Point(126, 39);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(107, 82);
            this.addBut.TabIndex = 2;
            this.addBut.Text = "Добавить";
            this.addBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addBut.UseVisualStyleBackColor = false;
            // 
            // noSearchBut
            // 
            this.noSearchBut.BackgroundImage = global::Lab4.Properties.Resources.NoSearch;
            this.noSearchBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noSearchBut.Location = new System.Drawing.Point(347, 39);
            this.noSearchBut.Name = "noSearchBut";
            this.noSearchBut.Size = new System.Drawing.Size(107, 82);
            this.noSearchBut.TabIndex = 10;
            this.noSearchBut.Text = "Без поиска";
            this.noSearchBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noSearchBut.UseVisualStyleBackColor = false;
            // 
            // table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Table.ChildDataSource = null;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(12, 127);
            this.Table.Name = "table";
            this.Table.ParentDataSource = null;
            this.Table.ReadOnly = true;
            this.Table.RowHeadersVisible = false;
            this.Table.RowHeadersWidth = 62;
            this.Table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Table.RowTemplate.Height = 28;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.Size = new System.Drawing.Size(1280, 490);
            this.Table.TabIndex = 11;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файлы Microsoft Excel|*.xlsx";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1304, 629);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.noSearchBut);
            this.Controls.Add(this.refreshBut);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.editBut);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button searchBut;
        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.Button deleteBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Button refreshBut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportCertainDebtorBut;
        private System.Windows.Forms.ToolStripMenuItem exportAllDebtorsAndDebtsBut;
        private System.Windows.Forms.ToolStripMenuItem ExitBut;
        private System.Windows.Forms.ToolStripMenuItem AboutProgBut;
        private System.Windows.Forms.Button noSearchBut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}