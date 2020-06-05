namespace Сервис
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОРаботеСоСправочникомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.связьСНамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиеОборудованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеПроблемыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дополнительнаяИнформацияОбОборудованииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.песситDataSet = new Сервис.ПесситDataSet();
            this.оборудованиеTableAdapter = new Сервис.ПесситDataSetTableAdapters.ОборудованиеTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.песситDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникToolStripMenuItem,
            this.главнаяToolStripMenuItem,
            this.информацияОРаботеСоСправочникомToolStripMenuItem,
            this.связьСНамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            this.главнаяToolStripMenuItem.Click += new System.EventHandler(this.ГлавнаяToolStripMenuItem_Click);
            // 
            // информацияОРаботеСоСправочникомToolStripMenuItem
            // 
            this.информацияОРаботеСоСправочникомToolStripMenuItem.Name = "информацияОРаботеСоСправочникомToolStripMenuItem";
            this.информацияОРаботеСоСправочникомToolStripMenuItem.Size = new System.Drawing.Size(245, 20);
            this.информацияОРаботеСоСправочникомToolStripMenuItem.Text = "Информация о работе со справочником";
            this.информацияОРаботеСоСправочникомToolStripMenuItem.Click += new System.EventHandler(this.ИнформацияОРаботеСоСправочникомToolStripMenuItem_Click);
            // 
            // связьСНамиToolStripMenuItem
            // 
            this.связьСНамиToolStripMenuItem.Name = "связьСНамиToolStripMenuItem";
            this.связьСНамиToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.связьСНамиToolStripMenuItem.Text = "Связь с нами";
            this.связьСНамиToolStripMenuItem.Click += new System.EventHandler(this.СвязьСНамиToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеОборудованиеDataGridViewTextBoxColumn,
            this.описаниеПроблемыDataGridViewTextBoxColumn,
            this.дополнительнаяИнформацияОбОборудованииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.оборудованиеBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // названиеОборудованиеDataGridViewTextBoxColumn
            // 
            this.названиеОборудованиеDataGridViewTextBoxColumn.DataPropertyName = "Название оборудование";
            this.названиеОборудованиеDataGridViewTextBoxColumn.HeaderText = "Название оборудование";
            this.названиеОборудованиеDataGridViewTextBoxColumn.Name = "названиеОборудованиеDataGridViewTextBoxColumn";
            // 
            // описаниеПроблемыDataGridViewTextBoxColumn
            // 
            this.описаниеПроблемыDataGridViewTextBoxColumn.DataPropertyName = "Описание проблемы";
            this.описаниеПроблемыDataGridViewTextBoxColumn.HeaderText = "Описание проблемы";
            this.описаниеПроблемыDataGridViewTextBoxColumn.Name = "описаниеПроблемыDataGridViewTextBoxColumn";
            // 
            // дополнительнаяИнформацияОбОборудованииDataGridViewTextBoxColumn
            // 
            this.дополнительнаяИнформацияОбОборудованииDataGridViewTextBoxColumn.DataPropertyName = "Дополнительная информация об оборудовании";
            this.дополнительнаяИнформацияОбОборудованииDataGridViewTextBoxColumn.HeaderText = "Дополнительная информация об оборудовании";
            this.дополнительнаяИнформацияОбОборудованииDataGridViewTextBoxColumn.Name = "дополнительнаяИнформацияОбОборудованииDataGridViewTextBoxColumn";
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.песситDataSet;
            // 
            // песситDataSet
            // 
            this.песситDataSet.DataSetName = "ПесситDataSet";
            this.песситDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оборудованиеTableAdapter
            // 
            this.оборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Справочник оборудования";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.песситDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОРаботеСоСправочникомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связьСНамиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ПесситDataSet песситDataSet;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        private ПесситDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеОборудованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеПроблемыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дополнительнаяИнформацияОбОборудованииDataGridViewTextBoxColumn;
    }
}