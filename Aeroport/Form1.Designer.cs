namespace Aeroport
{
    partial class Aero
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aero));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Файл = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgrammMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add = new System.Windows.Forms.ToolStripButton();
            this.Change = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Файл,
            this.toolStripMenuItem2,
            this.Tools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Файл
            // 
            this.Файл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.Файл.Name = "Файл";
            this.Файл.Size = new System.Drawing.Size(48, 20);
            this.Файл.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.ChangeMenu,
            this.toolStripSeparator1,
            this.DeleteMenu});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem2.Text = "Правка";
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(128, 22);
            this.AddMenu.Text = "Добавить";
            this.AddMenu.Click += new System.EventHandler(this.AddMenu_Click_1);
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.Enabled = false;
            this.ChangeMenu.Name = "ChangeMenu";
            this.ChangeMenu.Size = new System.Drawing.Size(128, 22);
            this.ChangeMenu.Text = "Изменить";
            this.ChangeMenu.Click += new System.EventHandler(this.ChangeMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // DeleteMenu
            // 
            this.DeleteMenu.Enabled = false;
            this.DeleteMenu.Name = "DeleteMenu";
            this.DeleteMenu.Size = new System.Drawing.Size(128, 22);
            this.DeleteMenu.Text = "Удалить";
            this.DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // Tools
            // 
            this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgrammMenu});
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(65, 20);
            this.Tools.Text = "Справка";
            // 
            // AboutProgrammMenu
            // 
            this.AboutProgrammMenu.Name = "AboutProgrammMenu";
            this.AboutProgrammMenu.Size = new System.Drawing.Size(149, 22);
            this.AboutProgrammMenu.Text = "О программе";
            this.AboutProgrammMenu.Click += new System.EventHandler(this.AboutProgrammMenu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Change,
            this.toolStripSeparator2,
            this.Delete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Кол-во рейсов: 0";
            // 
            // Add
            // 
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(79, 22);
            this.Add.Text = "Добавить";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Change
            // 
            this.Change.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Change.Enabled = false;
            this.Change.Image = ((System.Drawing.Image)(resources.GetObject("Change.Image")));
            this.Change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(65, 22);
            this.Change.Text = "Изменить";
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Delete
            // 
            this.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Delete.Enabled = false;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(55, 22);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(842, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel1.Text = "Кол-во рейсов: 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel2.Text = "Кол-во пассажиров: 0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel3.Text = "Кол-во экипажа: 0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(136, 17);
            this.toolStripStatusLabel4.Text = "Сумма всей выручки: 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nu,
            this.Type,
            this.Time,
            this.Col,
            this.Pas,
            this.Cob,
            this.Buil,
            this.Perc});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(842, 380);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nu
            // 
            this.nu.DataPropertyName = "Numfl";
            this.nu.HeaderText = "Номер рейса";
            this.nu.Name = "nu";
            this.nu.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "TypeAir";
            this.Type.HeaderText = "Тип самолёта";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "TimeIn";
            this.Time.HeaderText = "Время прибытия";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Col
            // 
            this.Col.DataPropertyName = "ColPas";
            this.Col.HeaderText = "Количество пассажиров";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            // 
            // Pas
            // 
            this.Pas.DataPropertyName = "Pass";
            this.Pas.HeaderText = "Сбор на пассажира";
            this.Pas.Name = "Pas";
            this.Pas.ReadOnly = true;
            // 
            // Cob
            // 
            this.Cob.DataPropertyName = "ColBuil";
            this.Cob.HeaderText = "Количество экипажа";
            this.Cob.Name = "Cob";
            this.Cob.ReadOnly = true;
            // 
            // Buil
            // 
            this.Buil.DataPropertyName = "Build";
            this.Buil.HeaderText = "Сбор на экипаж";
            this.Buil.Name = "Buil";
            this.Buil.ReadOnly = true;
            // 
            // Perc
            // 
            this.Perc.DataPropertyName = "Percent";
            this.Perc.HeaderText = "Процент надбавки за обслуживание";
            this.Perc.Name = "Perc";
            this.Perc.ReadOnly = true;
            // 
            // Aero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Aero";
            this.Text = "Аэропорт";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Файл;
        private ToolStripMenuItem Exit;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem AddMenu;
        private ToolStripMenuItem ChangeMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem DeleteMenu;
        private ToolStripMenuItem Tools;
        private ToolStripMenuItem AboutProgrammMenu;
        private ToolStrip toolStrip1;
        private ToolStripButton Add;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Delete;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private DataGridView dataGridView1;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripButton Change;
        private DataGridViewTextBoxColumn nu;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Col;
        private DataGridViewTextBoxColumn Pas;
        private DataGridViewTextBoxColumn Cob;
        private DataGridViewTextBoxColumn Buil;
        private DataGridViewTextBoxColumn Perc;
    }
}