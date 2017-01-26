namespace Monitor_Suhu__Record_
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblrata = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTgl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRataRata = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateData = new System.Windows.Forms.DateTimePicker();
            this.dataGridSuhu = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suhuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblsuhuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SUHUDataSet = new Monitor_Suhu__Record_.DB_SUHUDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.graphSuhuNow = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbl_suhuTableAdapter = new Monitor_Suhu__Record_.DB_SUHUDataSetTableAdapters.tbl_suhuTableAdapter();
            this.tableAdapterManager1 = new Monitor_Suhu__Record_.DB_SUHUDataSetTableAdapters.TableAdapterManager();
            this.waktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suhuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.graphSuhuRecord = new ZedGraph.ZedGraphControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.dateGraph = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsuhuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SUHUDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 315);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Monitor_Suhu__Record_.Properties.Resources.blue;
            this.tabPage1.Controls.Add(this.lblrata);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblJam);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblTgl);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblTemp);
            this.tabPage1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Widget";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblrata
            // 
            this.lblrata.AutoSize = true;
            this.lblrata.BackColor = System.Drawing.Color.Transparent;
            this.lblrata.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrata.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblrata.Location = new System.Drawing.Point(416, 180);
            this.lblrata.Name = "lblrata";
            this.lblrata.Size = new System.Drawing.Size(169, 43);
            this.lblrata.TabIndex = 10;
            this.lblrata.Text = "00.00 °C";
            this.lblrata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(462, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tampilan Suhu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(478, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Suhu";
            // 
            // lblJam
            // 
            this.lblJam.AutoSize = true;
            this.lblJam.BackColor = System.Drawing.Color.Transparent;
            this.lblJam.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJam.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblJam.Location = new System.Drawing.Point(40, 180);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(83, 24);
            this.lblJam.TabIndex = 3;
            this.lblJam.Text = "HH : MM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(40, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "JAM";
            // 
            // lblTgl
            // 
            this.lblTgl.AutoSize = true;
            this.lblTgl.BackColor = System.Drawing.Color.Transparent;
            this.lblTgl.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTgl.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTgl.Location = new System.Drawing.Point(40, 96);
            this.lblTgl.Name = "lblTgl";
            this.lblTgl.Size = new System.Drawing.Size(171, 24);
            this.lblTgl.TabIndex = 1;
            this.lblTgl.Text = "Hari , DD-MM-YYY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal :";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTemp.Location = new System.Drawing.Point(384, 89);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(228, 61);
            this.lblTemp.TabIndex = 5;
            this.lblTemp.Text = "00.00 °C";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTemp.Click += new System.EventHandler(this.lblTemp_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lblRataRata);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dateData);
            this.tabPage2.Controls.Add(this.dataGridSuhu);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Suhu Rata-rata";
            // 
            // lblRataRata
            // 
            this.lblRataRata.AutoSize = true;
            this.lblRataRata.Location = new System.Drawing.Point(123, 47);
            this.lblRataRata.Name = "lblRataRata";
            this.lblRataRata.Size = new System.Drawing.Size(46, 16);
            this.lblRataRata.TabIndex = 6;
            this.lblRataRata.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tanggal";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(355, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // dateData
            // 
            this.dateData.Location = new System.Drawing.Point(126, 15);
            this.dateData.Name = "dateData";
            this.dateData.Size = new System.Drawing.Size(200, 20);
            this.dateData.TabIndex = 1;
            this.dateData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridSuhu
            // 
            this.dataGridSuhu.AllowUserToAddRows = false;
            this.dataGridSuhu.AllowUserToDeleteRows = false;
            this.dataGridSuhu.AutoGenerateColumns = false;
            this.dataGridSuhu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSuhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuhu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.suhuDataGridViewTextBoxColumn1,
            this.waktuDataGridViewTextBoxColumn1});
            this.dataGridSuhu.DataSource = this.tblsuhuBindingSource;
            this.dataGridSuhu.Location = new System.Drawing.Point(3, 78);
            this.dataGridSuhu.Name = "dataGridSuhu";
            this.dataGridSuhu.ReadOnly = true;
            this.dataGridSuhu.Size = new System.Drawing.Size(656, 211);
            this.dataGridSuhu.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // suhuDataGridViewTextBoxColumn1
            // 
            this.suhuDataGridViewTextBoxColumn1.DataPropertyName = "suhu";
            this.suhuDataGridViewTextBoxColumn1.HeaderText = "suhu";
            this.suhuDataGridViewTextBoxColumn1.Name = "suhuDataGridViewTextBoxColumn1";
            this.suhuDataGridViewTextBoxColumn1.ReadOnly = true;
            this.suhuDataGridViewTextBoxColumn1.Width = 250;
            // 
            // waktuDataGridViewTextBoxColumn1
            // 
            this.waktuDataGridViewTextBoxColumn1.DataPropertyName = "waktu";
            this.waktuDataGridViewTextBoxColumn1.HeaderText = "waktu";
            this.waktuDataGridViewTextBoxColumn1.Name = "waktuDataGridViewTextBoxColumn1";
            this.waktuDataGridViewTextBoxColumn1.ReadOnly = true;
            this.waktuDataGridViewTextBoxColumn1.Width = 245;
            // 
            // tblsuhuBindingSource
            // 
            this.tblsuhuBindingSource.DataMember = "tbl_suhu";
            this.tblsuhuBindingSource.DataSource = this.dB_SUHUDataSet;
            // 
            // dB_SUHUDataSet
            // 
            this.dB_SUHUDataSet.DataSetName = "DB_SUHUDataSet";
            this.dB_SUHUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.graphSuhuNow);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(662, 286);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Graph (Real Time)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // graphSuhuNow
            // 
            this.graphSuhuNow.Location = new System.Drawing.Point(3, 4);
            this.graphSuhuNow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.graphSuhuNow.Name = "graphSuhuNow";
            this.graphSuhuNow.ScrollGrace = 0D;
            this.graphSuhuNow.ScrollMaxX = 0D;
            this.graphSuhuNow.ScrollMaxY = 0D;
            this.graphSuhuNow.ScrollMaxY2 = 0D;
            this.graphSuhuNow.ScrollMinX = 0D;
            this.graphSuhuNow.ScrollMinY = 0D;
            this.graphSuhuNow.ScrollMinY2 = 0D;
            this.graphSuhuNow.Size = new System.Drawing.Size(653, 278);
            this.graphSuhuNow.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbl_suhuTableAdapter
            // 
            this.tbl_suhuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbl_suhuTableAdapter = this.tbl_suhuTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Monitor_Suhu__Record_.DB_SUHUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // waktuDataGridViewTextBoxColumn
            // 
            this.waktuDataGridViewTextBoxColumn.DataPropertyName = "waktu";
            this.waktuDataGridViewTextBoxColumn.HeaderText = "Waktu";
            this.waktuDataGridViewTextBoxColumn.Name = "waktuDataGridViewTextBoxColumn";
            this.waktuDataGridViewTextBoxColumn.ReadOnly = true;
            this.waktuDataGridViewTextBoxColumn.Width = 225;
            // 
            // suhuDataGridViewTextBoxColumn
            // 
            this.suhuDataGridViewTextBoxColumn.DataPropertyName = "suhu";
            this.suhuDataGridViewTextBoxColumn.HeaderText = "Suhu";
            this.suhuDataGridViewTextBoxColumn.Name = "suhuDataGridViewTextBoxColumn";
            this.suhuDataGridViewTextBoxColumn.ReadOnly = true;
            this.suhuDataGridViewTextBoxColumn.Width = 225;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Nomor";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.refreshBtn);
            this.tabPage4.Controls.Add(this.dateGraph);
            this.tabPage4.Controls.Add(this.graphSuhuRecord);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(662, 286);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Graph";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // graphSuhuRecord
            // 
            this.graphSuhuRecord.Location = new System.Drawing.Point(3, 44);
            this.graphSuhuRecord.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.graphSuhuRecord.Name = "graphSuhuRecord";
            this.graphSuhuRecord.ScrollGrace = 0D;
            this.graphSuhuRecord.ScrollMaxX = 0D;
            this.graphSuhuRecord.ScrollMaxY = 0D;
            this.graphSuhuRecord.ScrollMaxY2 = 0D;
            this.graphSuhuRecord.ScrollMinX = 0D;
            this.graphSuhuRecord.ScrollMinY = 0D;
            this.graphSuhuRecord.ScrollMinY2 = 0D;
            this.graphSuhuRecord.Size = new System.Drawing.Size(656, 237);
            this.graphSuhuRecord.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tanggal";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(360, 8);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // dateGraph
            // 
            this.dateGraph.Location = new System.Drawing.Point(143, 11);
            this.dateGraph.Name = "dateGraph";
            this.dateGraph.Size = new System.Drawing.Size(200, 20);
            this.dateGraph.TabIndex = 6;
            this.dateGraph.ValueChanged += new System.EventHandler(this.dateGraph_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 315);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "APLIKASI SUHU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsuhuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SUHUDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTgl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private DB_SUHUDataSet dB_SUHUDataSet;
        private System.Windows.Forms.BindingSource tblsuhuBindingSource;
        private DB_SUHUDataSetTableAdapters.tbl_suhuTableAdapter tbl_suhuTableAdapter;
        private DB_SUHUDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateData;
        private System.Windows.Forms.DataGridView dataGridSuhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suhuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRataRata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblrata;
        private System.Windows.Forms.TabPage tabPage3;
        private ZedGraph.ZedGraphControl graphSuhuNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suhuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DateTimePicker dateGraph;
        private ZedGraph.ZedGraphControl graphSuhuRecord;
    }
}

