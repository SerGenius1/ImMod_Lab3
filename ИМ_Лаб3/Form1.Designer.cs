namespace ИМ_Лаб3
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
            this.components = new System.ComponentModel.Container();
            this.bt_Start = new System.Windows.Forms.Button();
            this.l_Rule = new System.Windows.Forms.Label();
            this.el_Rule = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.el_Rule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(14, 57);
            this.bt_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(176, 41);
            this.bt_Start.TabIndex = 0;
            this.bt_Start.Text = "Старт/Стоп";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // l_Rule
            // 
            this.l_Rule.AutoSize = true;
            this.l_Rule.Location = new System.Drawing.Point(11, 33);
            this.l_Rule.Name = "l_Rule";
            this.l_Rule.Size = new System.Drawing.Size(65, 17);
            this.l_Rule.TabIndex = 1;
            this.l_Rule.Text = "Правило";
            // 
            // el_Rule
            // 
            this.el_Rule.Location = new System.Drawing.Point(84, 31);
            this.el_Rule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.el_Rule.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.el_Rule.Name = "el_Rule";
            this.el_Rule.Size = new System.Drawing.Size(107, 22);
            this.el_Rule.TabIndex = 2;
            this.el_Rule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.el_Rule.ValueChanged += new System.EventHandler(this.el_Rule_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Grid.ColumnHeadersHeight = 28;
            this.Grid.ColumnHeadersVisible = false;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(207, 0);
            this.Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidth = 28;
            this.Grid.RowTemplate.Height = 28;
            this.Grid.Size = new System.Drawing.Size(540, 383);
            this.Grid.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 383);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(747, 383);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.el_Rule);
            this.Controls.Add(this.l_Rule);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(765, 430);
            this.Name = "Form1";
            this.Text = "Клеточный автомат";
            ((System.ComponentModel.ISupportInitialize)(this.el_Rule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Label l_Rule;
        private System.Windows.Forms.NumericUpDown el_Rule;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel panel1;
    }
}

