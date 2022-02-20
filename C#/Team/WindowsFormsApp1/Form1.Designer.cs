namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Tvolume = new System.Windows.Forms.Button();
            this.btn_ToForm2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjunkookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cjbangdir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cseouldir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trafficvolumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ToForm3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trafficvolumeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trafficvolumeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ellipseControl1 = new WindowsFormsApp1.EllipseControl();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficvolumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficvolumeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficvolumeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Tvolume
            // 
            this.btn_Tvolume.Location = new System.Drawing.Point(120, 103);
            this.btn_Tvolume.Name = "btn_Tvolume";
            this.btn_Tvolume.Size = new System.Drawing.Size(543, 42);
            this.btn_Tvolume.TabIndex = 0;
            this.btn_Tvolume.Text = "현교통량 확인";
            this.btn_Tvolume.UseVisualStyleBackColor = true;
            this.btn_Tvolume.Click += new System.EventHandler(this.btn_Tvolume_Click);
            // 
            // btn_ToForm2
            // 
            this.btn_ToForm2.Location = new System.Drawing.Point(120, 302);
            this.btn_ToForm2.Name = "btn_ToForm2";
            this.btn_ToForm2.Size = new System.Drawing.Size(543, 65);
            this.btn_ToForm2.TabIndex = 1;
            this.btn_ToForm2.Text = "서울방향 자가/버스 소요시간 보기";
            this.btn_ToForm2.UseVisualStyleBackColor = true;
            this.btn_ToForm2.Click += new System.EventHandler(this.btn_ToForm2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdateDataGridViewTextBoxColumn,
            this.stimeDataGridViewTextBoxColumn,
            this.cjunkookDataGridViewTextBoxColumn,
            this.Cjbangdir,
            this.Cseouldir});
            this.dataGridView1.DataSource = this.trafficvolumeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(543, 56);
            this.dataGridView1.TabIndex = 2;
            // 
            // sdateDataGridViewTextBoxColumn
            // 
            this.sdateDataGridViewTextBoxColumn.DataPropertyName = "Sdate";
            this.sdateDataGridViewTextBoxColumn.HeaderText = "날짜";
            this.sdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdateDataGridViewTextBoxColumn.Name = "sdateDataGridViewTextBoxColumn";
            this.sdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // stimeDataGridViewTextBoxColumn
            // 
            this.stimeDataGridViewTextBoxColumn.DataPropertyName = "Stime";
            this.stimeDataGridViewTextBoxColumn.HeaderText = "시간";
            this.stimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stimeDataGridViewTextBoxColumn.Name = "stimeDataGridViewTextBoxColumn";
            this.stimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cjunkookDataGridViewTextBoxColumn
            // 
            this.cjunkookDataGridViewTextBoxColumn.DataPropertyName = "Cjunkook";
            this.cjunkookDataGridViewTextBoxColumn.HeaderText = "전국교통량";
            this.cjunkookDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cjunkookDataGridViewTextBoxColumn.Name = "cjunkookDataGridViewTextBoxColumn";
            this.cjunkookDataGridViewTextBoxColumn.Width = 120;
            // 
            // Cjbangdir
            // 
            this.Cjbangdir.DataPropertyName = "Cjbangdir";
            this.Cjbangdir.HeaderText = "지방방향교통량";
            this.Cjbangdir.MinimumWidth = 6;
            this.Cjbangdir.Name = "Cjbangdir";
            this.Cjbangdir.Width = 125;
            // 
            // Cseouldir
            // 
            this.Cseouldir.DataPropertyName = "Cseouldir";
            this.Cseouldir.HeaderText = "서울방향교통량";
            this.Cseouldir.MinimumWidth = 6;
            this.Cseouldir.Name = "Cseouldir";
            this.Cseouldir.Width = 125;
            // 
            // trafficvolumeBindingSource
            // 
            this.trafficvolumeBindingSource.DataSource = typeof(WindowsFormsApp1.Traffic_volume);
            // 
            // btn_ToForm3
            // 
            this.btn_ToForm3.Location = new System.Drawing.Point(120, 373);
            this.btn_ToForm3.Name = "btn_ToForm3";
            this.btn_ToForm3.Size = new System.Drawing.Size(543, 65);
            this.btn_ToForm3.TabIndex = 3;
            this.btn_ToForm3.Text = "지방방향 자가/버스 소요시간 보기";
            this.btn_ToForm3.UseVisualStyleBackColor = true;
            this.btn_ToForm3.Click += new System.EventHandler(this.btn_ToForm3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "교통량 및 소요시간 살펴보는 프로그램";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(752, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 26);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trafficvolumeBindingSource2
            // 
            this.trafficvolumeBindingSource2.DataSource = typeof(WindowsFormsApp1.Traffic_volume);
            // 
            // trafficvolumeBindingSource1
            // 
            this.trafficvolumeBindingSource1.DataSource = typeof(WindowsFormsApp1.Traffic_volume);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApp1.Form1);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 30;
            this.ellipseControl1.TargetControl = this;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(120, 212);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(543, 85);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ToForm3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ToForm2);
            this.Controls.Add(this.btn_Tvolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficvolumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficvolumeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficvolumeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tvolume;
        private System.Windows.Forms.Button btn_ToForm2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource trafficvolumeBindingSource;
        private System.Windows.Forms.Button btn_ToForm3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource trafficvolumeBindingSource1;
        private System.Windows.Forms.BindingSource trafficvolumeBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjbangdirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cseouldirDataGridViewTextBoxColumn;
        private EllipseControl ellipseControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjunkookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cjbangdir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cseouldir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

