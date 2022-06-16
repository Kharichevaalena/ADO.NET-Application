
namespace Lab_4
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
            this.Places = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SELECT = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tableofFlightsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.cashbox_AeroflotDataSet2 = new Lab_4.cashbox_AeroflotDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashbox_AeroflotDataSet3 = new Lab_4.cashbox_AeroflotDataSet3();
            this.tableofFlightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashbox_AeroflotDataSet = new Lab_4.cashbox_AeroflotDataSet();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.INSERT_button = new System.Windows.Forms.Button();
            this.Days_box = new System.Windows.Forms.TextBox();
            this.Time_box = new System.Windows.Forms.TextBox();
            this.Stops_box = new System.Windows.Forms.TextBox();
            this.Direction_box = new System.Windows.Forms.TextBox();
            this.Number_box = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.table_of_FlightsTableAdapter = new Lab_4.cashbox_AeroflotDataSetTableAdapters.Table_of_FlightsTableAdapter();
            this.cashbox_AeroflotDataSet1 = new Lab_4.cashbox_AeroflotDataSet1();
            this.tableofFlightsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table_of_FlightsTableAdapter1 = new Lab_4.cashbox_AeroflotDataSet1TableAdapters.Table_of_FlightsTableAdapter();
            this.tableofFlightsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableofFlightsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tableofFlightsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.table_of_FlightsTableAdapter2 = new Lab_4.cashbox_AeroflotDataSet2TableAdapters.Table_of_FlightsTableAdapter();
            this.tableTableAdapter = new Lab_4.cashbox_AeroflotDataSet3TableAdapters.TableTableAdapter();
            this.tableofFlightsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.cashbox_AeroflotDataSet4 = new Lab_4.cashbox_AeroflotDataSet4();
            this.tableofFlightsBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.table_of_FlightsTableAdapter3 = new Lab_4.cashbox_AeroflotDataSet4TableAdapters.Table_of_FlightsTableAdapter();
            this.Places.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashbox_AeroflotDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashbox_AeroflotDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashbox_AeroflotDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashbox_AeroflotDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashbox_AeroflotDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // Places
            // 
            this.Places.Controls.Add(this.tableLayoutPanel1);
            this.Places.Location = new System.Drawing.Point(4, 25);
            this.Places.Name = "Places";
            this.Places.Padding = new System.Windows.Forms.Padding(3);
            this.Places.Size = new System.Drawing.Size(1083, 421);
            this.Places.TabIndex = 1;
            this.Places.Text = "SELECT";
            this.Places.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Cyan;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SELECT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1077, 415);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 294);
            this.dataGridView1.TabIndex = 1;
            // 
            // SELECT
            // 
            this.SELECT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SELECT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SELECT.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SELECT.Location = new System.Drawing.Point(3, 303);
            this.SELECT.Name = "SELECT";
            this.SELECT.Size = new System.Drawing.Size(747, 69);
            this.SELECT.TabIndex = 0;
            this.SELECT.Text = "ПОКАЗАТЬ РЕЙСЫ";
            this.SELECT.UseVisualStyleBackColor = false;
            this.SELECT.Click += new System.EventHandler(this.SELECT_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tableofFlightsBindingSource5, "Place", true));
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox2.Location = new System.Drawing.Point(756, 378);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(318, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "ВЫБЕРИТЕ МЕСТО В САМОЛЕТЕ";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tableofFlightsBindingSource5
            // 
            this.tableofFlightsBindingSource5.DataMember = "Table_of_Flights";
            this.tableofFlightsBindingSource5.DataSource = this.cashbox_AeroflotDataSet2;
            // 
            // cashbox_AeroflotDataSet2
            // 
            this.cashbox_AeroflotDataSet2.DataSetName = "cashbox_AeroflotDataSet2";
            this.cashbox_AeroflotDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(756, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "ПЕЧАТАТЬ ЧЕК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tableBindingSource, "City", true));
            this.comboBox1.DataSource = this.tableBindingSource;
            this.comboBox1.DisplayMember = "City";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 378);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(747, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "City";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.cashbox_AeroflotDataSet3;
            // 
            // cashbox_AeroflotDataSet3
            // 
            this.cashbox_AeroflotDataSet3.DataSetName = "cashbox_AeroflotDataSet3";
            this.cashbox_AeroflotDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableofFlightsBindingSource
            // 
            this.tableofFlightsBindingSource.DataMember = "Table_of_Flights";
            this.tableofFlightsBindingSource.DataSource = this.cashbox_AeroflotDataSet;
            // 
            // cashbox_AeroflotDataSet
            // 
            this.cashbox_AeroflotDataSet.DataSetName = "cashbox_AeroflotDataSet";
            this.cashbox_AeroflotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.YellowGreen;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.INSERT_button);
            this.tabPage1.Controls.Add(this.Days_box);
            this.tabPage1.Controls.Add(this.Time_box);
            this.tabPage1.Controls.Add(this.Stops_box);
            this.tabPage1.Controls.Add(this.Direction_box);
            this.tabPage1.Controls.Add(this.Number_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1083, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INSERT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Day of departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time of departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stops (not necessary)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Direction of flight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of flight";
            // 
            // INSERT_button
            // 
            this.INSERT_button.BackColor = System.Drawing.Color.LawnGreen;
            this.INSERT_button.Location = new System.Drawing.Point(316, 125);
            this.INSERT_button.Name = "INSERT_button";
            this.INSERT_button.Size = new System.Drawing.Size(205, 106);
            this.INSERT_button.TabIndex = 5;
            this.INSERT_button.Text = "INSERT";
            this.INSERT_button.UseVisualStyleBackColor = false;
            this.INSERT_button.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // Days_box
            // 
            this.Days_box.Location = new System.Drawing.Point(32, 327);
            this.Days_box.Name = "Days_box";
            this.Days_box.Size = new System.Drawing.Size(209, 22);
            this.Days_box.TabIndex = 4;
            this.Days_box.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // Time_box
            // 
            this.Time_box.Location = new System.Drawing.Point(32, 247);
            this.Time_box.Name = "Time_box";
            this.Time_box.Size = new System.Drawing.Size(209, 22);
            this.Time_box.TabIndex = 3;
            this.Time_box.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // Stops_box
            // 
            this.Stops_box.Location = new System.Drawing.Point(32, 172);
            this.Stops_box.Name = "Stops_box";
            this.Stops_box.Size = new System.Drawing.Size(209, 22);
            this.Stops_box.TabIndex = 2;
            // 
            // Direction_box
            // 
            this.Direction_box.Location = new System.Drawing.Point(32, 101);
            this.Direction_box.Name = "Direction_box";
            this.Direction_box.Size = new System.Drawing.Size(209, 22);
            this.Direction_box.TabIndex = 1;
            this.Direction_box.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // Number_box
            // 
            this.Number_box.Location = new System.Drawing.Point(32, 34);
            this.Number_box.Name = "Number_box";
            this.Number_box.Size = new System.Drawing.Size(209, 22);
            this.Number_box.TabIndex = 0;
            this.Number_box.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Places);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1091, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // table_of_FlightsTableAdapter
            // 
            this.table_of_FlightsTableAdapter.ClearBeforeFill = true;
            // 
            // cashbox_AeroflotDataSet1
            // 
            this.cashbox_AeroflotDataSet1.DataSetName = "cashbox_AeroflotDataSet1";
            this.cashbox_AeroflotDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableofFlightsBindingSource1
            // 
            this.tableofFlightsBindingSource1.DataMember = "Table_of_Flights";
            this.tableofFlightsBindingSource1.DataSource = this.cashbox_AeroflotDataSet1;
            // 
            // table_of_FlightsTableAdapter1
            // 
            this.table_of_FlightsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableofFlightsBindingSource2
            // 
            this.tableofFlightsBindingSource2.DataMember = "Table_of_Flights";
            this.tableofFlightsBindingSource2.DataSource = this.cashbox_AeroflotDataSet1;
            // 
            // tableofFlightsBindingSource3
            // 
            this.tableofFlightsBindingSource3.DataMember = "Table_of_Flights";
            this.tableofFlightsBindingSource3.DataSource = this.cashbox_AeroflotDataSet1;
            // 
            // tableofFlightsBindingSource4
            // 
            this.tableofFlightsBindingSource4.DataMember = "Table_of_Flights";
            this.tableofFlightsBindingSource4.DataSource = this.cashbox_AeroflotDataSet1;
            // 
            // table_of_FlightsTableAdapter2
            // 
            this.table_of_FlightsTableAdapter2.ClearBeforeFill = true;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableofFlightsBindingSource6
            // 
            this.tableofFlightsBindingSource6.DataMember = "Table_of_Flights";
            this.tableofFlightsBindingSource6.DataSource = this.cashbox_AeroflotDataSet1;
            // 
            // cashbox_AeroflotDataSet4
            // 
            this.cashbox_AeroflotDataSet4.DataSetName = "cashbox_AeroflotDataSet4";
            this.cashbox_AeroflotDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableofFlightsBindingSource7
            // 
            this.tableofFlightsBindingSource7.DataMember = "Table_of_Flights";
            this.tableofFlightsBindingSource7.DataSource = this.cashbox_AeroflotDataSet4;
            // 
            // table_of_FlightsTableAdapter3
            // 
            this.table_of_FlightsTableAdapter3.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "FREE FLIGHTS COMPANY";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Places.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashbox_AeroflotDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashbox_AeroflotDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashbox_AeroflotDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashbox_AeroflotDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashbox_AeroflotDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableofFlightsBindingSource7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Places;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SELECT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button INSERT_button;
        private System.Windows.Forms.TextBox Days_box;
        private System.Windows.Forms.TextBox Time_box;
        private System.Windows.Forms.TextBox Stops_box;
        private System.Windows.Forms.TextBox Direction_box;
        private System.Windows.Forms.TextBox Number_box;
        private System.Windows.Forms.TabControl tabControl1;
        private cashbox_AeroflotDataSet cashbox_AeroflotDataSet;
        private System.Windows.Forms.BindingSource tableofFlightsBindingSource;
        private cashbox_AeroflotDataSetTableAdapters.Table_of_FlightsTableAdapter table_of_FlightsTableAdapter;
        private cashbox_AeroflotDataSet1 cashbox_AeroflotDataSet1;
        private System.Windows.Forms.BindingSource tableofFlightsBindingSource1;
        private cashbox_AeroflotDataSet1TableAdapters.Table_of_FlightsTableAdapter table_of_FlightsTableAdapter1;
        private System.Windows.Forms.BindingSource tableofFlightsBindingSource2;
        private System.Windows.Forms.BindingSource tableofFlightsBindingSource3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource tableofFlightsBindingSource4;
        private cashbox_AeroflotDataSet2 cashbox_AeroflotDataSet2;
        private System.Windows.Forms.BindingSource tableofFlightsBindingSource5;
        private cashbox_AeroflotDataSet2TableAdapters.Table_of_FlightsTableAdapter table_of_FlightsTableAdapter2;
        private cashbox_AeroflotDataSet3 cashbox_AeroflotDataSet3;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private cashbox_AeroflotDataSet3TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tableofFlightsBindingSource6;
        private cashbox_AeroflotDataSet4 cashbox_AeroflotDataSet4;
        private System.Windows.Forms.BindingSource tableofFlightsBindingSource7;
        private cashbox_AeroflotDataSet4TableAdapters.Table_of_FlightsTableAdapter table_of_FlightsTableAdapter3;
    }
}

