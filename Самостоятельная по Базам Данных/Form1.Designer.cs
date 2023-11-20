namespace Самостоятельная_по_Базам_Данных
{
    partial class DgStore
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБДToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТаблиуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьТаблицToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.йййToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataSet1 = new System.Data.DataSet();
            this.DgGrid = new System.Windows.Forms.DataGridView();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSelect1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьБДToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьБДToolStripMenuItem
            // 
            this.создатьБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьБДToolStripMenuItem1,
            this.открытьБДToolStripMenuItem,
            this.выбратьБДToolStripMenuItem});
            this.создатьБДToolStripMenuItem.Name = "создатьБДToolStripMenuItem";
            this.создатьБДToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.создатьБДToolStripMenuItem.Text = "Файл";
            // 
            // создатьБДToolStripMenuItem1
            // 
            this.создатьБДToolStripMenuItem1.Name = "создатьБДToolStripMenuItem1";
            this.создатьБДToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.создатьБДToolStripMenuItem1.Text = "Создать БД";
            this.создатьБДToolStripMenuItem1.Click += new System.EventHandler(this.создатьБДToolStripMenuItem1_Click);
            // 
            // открытьБДToolStripMenuItem
            // 
            this.открытьБДToolStripMenuItem.Name = "открытьБДToolStripMenuItem";
            this.открытьБДToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            // 
            // выбратьБДToolStripMenuItem
            // 
            this.выбратьБДToolStripMenuItem.Name = "выбратьБДToolStripMenuItem";
            this.выбратьБДToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.выбратьБДToolStripMenuItem.Text = "Выбрать БД";
            this.выбратьБДToolStripMenuItem.Click += new System.EventHandler(this.выбратьБДToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьТаблицуToolStripMenuItem,
            this.сохранитьИзмененияToolStripMenuItem,
            this.сохранитьТаблиуToolStripMenuItem,
            this.сохранитьТаблицуToolStripMenuItem,
            this.создатьТаблицToolStripMenuItem,
            this.выбратьТаблицуToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // создатьТаблицуToolStripMenuItem
            // 
            this.создатьТаблицуToolStripMenuItem.Name = "создатьТаблицуToolStripMenuItem";
            this.создатьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            // 
            // сохранитьТаблиуToolStripMenuItem
            // 
            this.сохранитьТаблиуToolStripMenuItem.Name = "сохранитьТаблиуToolStripMenuItem";
            this.сохранитьТаблиуToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            // 
            // сохранитьТаблицуToolStripMenuItem
            // 
            this.сохранитьТаблицуToolStripMenuItem.Name = "сохранитьТаблицуToolStripMenuItem";
            this.сохранитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.сохранитьТаблицуToolStripMenuItem.Text = "Сохранить таблицу";
            this.сохранитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТаблицуToolStripMenuItem_Click);
            // 
            // создатьТаблицToolStripMenuItem
            // 
            this.создатьТаблицToolStripMenuItem.Name = "создатьТаблицToolStripMenuItem";
            this.создатьТаблицToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            // 
            // выбратьТаблицуToolStripMenuItem
            // 
            this.выбратьТаблицуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.йййToolStripMenuItem,
            this.nameGoodsToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.storesToolStripMenuItem,
            this.typeGoodsToolStripMenuItem});
            this.выбратьТаблицуToolStripMenuItem.Name = "выбратьТаблицуToolStripMenuItem";
            this.выбратьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.выбратьТаблицуToolStripMenuItem.Text = "Выбрать таблицу";
            this.выбратьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.выбратьТаблицуToolStripMenuItem_Click);
            // 
            // йййToolStripMenuItem
            // 
            this.йййToolStripMenuItem.Name = "йййToolStripMenuItem";
            this.йййToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            // 
            // nameGoodsToolStripMenuItem
            // 
            this.nameGoodsToolStripMenuItem.Name = "nameGoodsToolStripMenuItem";
            this.nameGoodsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.nameGoodsToolStripMenuItem.Text = "NameGoods";
            this.nameGoodsToolStripMenuItem.Click += new System.EventHandler(this.nameGoodsToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.storesToolStripMenuItem.Text = "Stores";
            this.storesToolStripMenuItem.Click += new System.EventHandler(this.storesToolStripMenuItem_Click);
            // 
            // typeGoodsToolStripMenuItem
            // 
            this.typeGoodsToolStripMenuItem.Name = "typeGoodsToolStripMenuItem";
            this.typeGoodsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.typeGoodsToolStripMenuItem.Text = "TypeGoods";
            this.typeGoodsToolStripMenuItem.Click += new System.EventHandler(this.typeGoodsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // DgGrid
            // 
            this.DgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgGrid.Location = new System.Drawing.Point(12, 27);
            this.DgGrid.Name = "DgGrid";
            this.DgGrid.Size = new System.Drawing.Size(611, 278);
            this.DgGrid.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(629, 27);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(84, 38);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Подключить";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(629, 71);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(84, 38);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Отключить";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(629, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(84, 43);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(611, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonSelect1
            // 
            this.buttonSelect1.Location = new System.Drawing.Point(629, 321);
            this.buttonSelect1.Name = "buttonSelect1";
            this.buttonSelect1.Size = new System.Drawing.Size(84, 28);
            this.buttonSelect1.TabIndex = 5;
            this.buttonSelect1.Text = "Запрос";
            this.buttonSelect1.UseVisualStyleBackColor = true;
            this.buttonSelect1.Click += new System.EventHandler(this.buttonSelect1_Click);
            // 
            // DgStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 476);
            this.Controls.Add(this.buttonSelect1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.DgGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DgStore";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DgStore_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьБДToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView DgGrid;
        private System.Windows.Forms.ToolStripMenuItem выбратьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТаблиуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьТаблицToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem йййToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeGoodsToolStripMenuItem;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSelect1;
    }
}

