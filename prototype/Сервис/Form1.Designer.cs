namespace Сервис
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вашаОрганизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеВашегоОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.связатьсяСНамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОРаботеСПриложениемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.связатьсяСНамиToolStripMenuItem,
            this.информацияОРаботеСПриложениемToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запросToolStripMenuItem
            // 
            this.запросToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЗапросToolStripMenuItem,
            this.найтиЗапросToolStripMenuItem});
            this.запросToolStripMenuItem.Name = "запросToolStripMenuItem";
            this.запросToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.запросToolStripMenuItem.Text = "Запрос";
            // 
            // создатьЗапросToolStripMenuItem
            // 
            this.создатьЗапросToolStripMenuItem.Name = "создатьЗапросToolStripMenuItem";
            this.создатьЗапросToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьЗапросToolStripMenuItem.Text = "Создать запрос";
            this.создатьЗапросToolStripMenuItem.Click += new System.EventHandler(this.СоздатьЗапросToolStripMenuItem_Click);
            // 
            // найтиЗапросToolStripMenuItem
            // 
            this.найтиЗапросToolStripMenuItem.Name = "найтиЗапросToolStripMenuItem";
            this.найтиЗапросToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.найтиЗапросToolStripMenuItem.Text = "Найти запрос";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вашаОрганизацияToolStripMenuItem,
            this.описаниеВашегоОборудованияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // вашаОрганизацияToolStripMenuItem
            // 
            this.вашаОрганизацияToolStripMenuItem.Name = "вашаОрганизацияToolStripMenuItem";
            this.вашаОрганизацияToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.вашаОрганизацияToolStripMenuItem.Text = "Ваша организация";
            this.вашаОрганизацияToolStripMenuItem.Click += new System.EventHandler(this.ВашаОрганизацияToolStripMenuItem_Click);
            // 
            // описаниеВашегоОборудованияToolStripMenuItem
            // 
            this.описаниеВашегоОборудованияToolStripMenuItem.Name = "описаниеВашегоОборудованияToolStripMenuItem";
            this.описаниеВашегоОборудованияToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.описаниеВашегоОборудованияToolStripMenuItem.Text = "Описание вашего оборудования";
            this.описаниеВашегоОборудованияToolStripMenuItem.Click += new System.EventHandler(this.ОписаниеВашегоОборудованияToolStripMenuItem_Click);
            // 
            // связатьсяСНамиToolStripMenuItem
            // 
            this.связатьсяСНамиToolStripMenuItem.Name = "связатьсяСНамиToolStripMenuItem";
            this.связатьсяСНамиToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.связатьсяСНамиToolStripMenuItem.Text = "Связаться с нами";
            this.связатьсяСНамиToolStripMenuItem.Click += new System.EventHandler(this.СвязатьсяСНамиToolStripMenuItem_Click);
            // 
            // информацияОРаботеСПриложениемToolStripMenuItem
            // 
            this.информацияОРаботеСПриложениемToolStripMenuItem.Name = "информацияОРаботеСПриложениемToolStripMenuItem";
            this.информацияОРаботеСПриложениемToolStripMenuItem.Size = new System.Drawing.Size(235, 20);
            this.информацияОРаботеСПриложениемToolStripMenuItem.Text = "Информация о работе с приложением";
            this.информацияОРаботеСПриложениемToolStripMenuItem.Click += new System.EventHandler(this.ИнформацияОРаботеСПриложениемToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Сервис";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вашаОрганизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеВашегоОборудованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связатьсяСНамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОРаботеСПриложениемToolStripMenuItem;
    }
}

