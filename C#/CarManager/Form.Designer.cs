namespace CarManager
{
    partial class Form
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_AllLookUp = new System.Windows.Forms.Button();
            this.button_SelectedLookUp = new System.Windows.Forms.Button();
            this.textBox_parkingSpot_lookUp = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_parkingManager = new System.Windows.Forms.DataGridView();
            this.textBox_parkingSpot = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_parkingRemove = new System.Windows.Forms.Button();
            this.button_parkingAdd = new System.Windows.Forms.Button();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.listBox_logPrint = new System.Windows.Forms.ListBox();
            this.timer_DisplayNow = new System.Windows.Forms.Timer(this.components);
            this.statusStrip_Now = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Now = new System.Windows.Forms.ToolStripStatusLabel();
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parkingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip_Now.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.button_AllLookUp);
            this.groupBox2.Controls.Add(this.button_SelectedLookUp);
            this.groupBox2.Controls.Add(this.textBox_parkingSpot_lookUp);
            this.groupBox2.Location = new System.Drawing.Point(486, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(384, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 공간 현황 관리";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "공간번호";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(214, 98);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(141, 29);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "공간추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_AllLookUp
            // 
            this.button_AllLookUp.Location = new System.Drawing.Point(214, 61);
            this.button_AllLookUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_AllLookUp.Name = "button_AllLookUp";
            this.button_AllLookUp.Size = new System.Drawing.Size(141, 29);
            this.button_AllLookUp.TabIndex = 7;
            this.button_AllLookUp.Text = "전체조회";
            this.button_AllLookUp.UseVisualStyleBackColor = true;
            this.button_AllLookUp.Click += new System.EventHandler(this.button_AllLookUp_Click);
            // 
            // button_SelectedLookUp
            // 
            this.button_SelectedLookUp.Location = new System.Drawing.Point(214, 25);
            this.button_SelectedLookUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_SelectedLookUp.Name = "button_SelectedLookUp";
            this.button_SelectedLookUp.Size = new System.Drawing.Size(141, 29);
            this.button_SelectedLookUp.TabIndex = 6;
            this.button_SelectedLookUp.Text = "해당 공간 조회";
            this.button_SelectedLookUp.UseVisualStyleBackColor = true;
            this.button_SelectedLookUp.Click += new System.EventHandler(this.button_SelectedLookUp_Click);
            // 
            // textBox_parkingSpot_lookUp
            // 
            this.textBox_parkingSpot_lookUp.Location = new System.Drawing.Point(93, 25);
            this.textBox_parkingSpot_lookUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_parkingSpot_lookUp.Name = "textBox_parkingSpot_lookUp";
            this.textBox_parkingSpot_lookUp.Size = new System.Drawing.Size(114, 25);
            this.textBox_parkingSpot_lookUp.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_parkingManager);
            this.groupBox3.Location = new System.Drawing.Point(14, 211);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(855, 246);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주차 현황";
            // 
            // dataGridView_parkingManager
            // 
            this.dataGridView_parkingManager.AllowUserToAddRows = false;
            this.dataGridView_parkingManager.AllowUserToDeleteRows = false;
            this.dataGridView_parkingManager.AutoGenerateColumns = false;
            this.dataGridView_parkingManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parkingManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingSpotDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.parkingTimeDataGridViewTextBoxColumn});
            this.dataGridView_parkingManager.DataSource = this.bindingSource1;
            this.dataGridView_parkingManager.Location = new System.Drawing.Point(22, 25);
            this.dataGridView_parkingManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_parkingManager.Name = "dataGridView_parkingManager";
            this.dataGridView_parkingManager.ReadOnly = true;
            this.dataGridView_parkingManager.RowHeadersWidth = 51;
            this.dataGridView_parkingManager.RowTemplate.Height = 23;
            this.dataGridView_parkingManager.Size = new System.Drawing.Size(805, 214);
            this.dataGridView_parkingManager.TabIndex = 0;
            this.dataGridView_parkingManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_parkingManager_CellClick);
            // 
            // textBox_parkingSpot
            // 
            this.textBox_parkingSpot.Location = new System.Drawing.Point(90, 25);
            this.textBox_parkingSpot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_parkingSpot.Name = "textBox_parkingSpot";
            this.textBox_parkingSpot.Size = new System.Drawing.Size(114, 25);
            this.textBox_parkingSpot.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_parkingRemove);
            this.groupBox1.Controls.Add(this.button_parkingAdd);
            this.groupBox1.Controls.Add(this.textBox_phoneNumber);
            this.groupBox1.Controls.Add(this.textBox_driverName);
            this.groupBox1.Controls.Add(this.textBox_carNumber);
            this.groupBox1.Controls.Add(this.textBox_parkingSpot);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(384, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차/출차";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "차주이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "차량번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "공간번호";
            // 
            // button_parkingRemove
            // 
            this.button_parkingRemove.Location = new System.Drawing.Point(247, 59);
            this.button_parkingRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_parkingRemove.Name = "button_parkingRemove";
            this.button_parkingRemove.Size = new System.Drawing.Size(86, 29);
            this.button_parkingRemove.TabIndex = 5;
            this.button_parkingRemove.Text = "출차";
            this.button_parkingRemove.UseVisualStyleBackColor = true;
            this.button_parkingRemove.Click += new System.EventHandler(this.button_parkingRemove_Click);
            // 
            // button_parkingAdd
            // 
            this.button_parkingAdd.Location = new System.Drawing.Point(247, 21);
            this.button_parkingAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_parkingAdd.Name = "button_parkingAdd";
            this.button_parkingAdd.Size = new System.Drawing.Size(86, 29);
            this.button_parkingAdd.TabIndex = 4;
            this.button_parkingAdd.Text = "주차";
            this.button_parkingAdd.UseVisualStyleBackColor = true;
            this.button_parkingAdd.Click += new System.EventHandler(this.button_parkingAdd_Click);
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(90, 126);
            this.textBox_phoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(114, 25);
            this.textBox_phoneNumber.TabIndex = 3;
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(90, 92);
            this.textBox_driverName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(114, 25);
            this.textBox_driverName.TabIndex = 2;
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(90, 59);
            this.textBox_carNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(114, 25);
            this.textBox_carNumber.TabIndex = 1;
            // 
            // listBox_logPrint
            // 
            this.listBox_logPrint.FormattingEnabled = true;
            this.listBox_logPrint.ItemHeight = 15;
            this.listBox_logPrint.Location = new System.Drawing.Point(15, 466);
            this.listBox_logPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_logPrint.Name = "listBox_logPrint";
            this.listBox_logPrint.Size = new System.Drawing.Size(853, 154);
            this.listBox_logPrint.TabIndex = 2;
            // 
            // timer_DisplayNow
            // 
            this.timer_DisplayNow.Enabled = true;
            this.timer_DisplayNow.Interval = 1000;
            this.timer_DisplayNow.Tick += new System.EventHandler(this.timer_DisplayNow_Tick);
            // 
            // statusStrip_Now
            // 
            this.statusStrip_Now.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Now.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Now});
            this.statusStrip_Now.Location = new System.Drawing.Point(0, 644);
            this.statusStrip_Now.Name = "statusStrip_Now";
            this.statusStrip_Now.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip_Now.Size = new System.Drawing.Size(914, 26);
            this.statusStrip_Now.TabIndex = 3;
            this.statusStrip_Now.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Now
            // 
            this.toolStripStatusLabel_Now.Name = "toolStripStatusLabel_Now";
            this.toolStripStatusLabel_Now.Size = new System.Drawing.Size(12, 20);
            this.toolStripStatusLabel_Now.Text = ".";
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingSpotDataGridViewTextBoxColumn.Width = 125;
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            this.carNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.carNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkingTimeDataGridViewTextBoxColumn
            // 
            this.parkingTimeDataGridViewTextBoxColumn.DataPropertyName = "ParkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.HeaderText = "ParkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingTimeDataGridViewTextBoxColumn.Name = "parkingTimeDataGridViewTextBoxColumn";
            this.parkingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(CarManager.ParkingCar);
            // 
            // parkingCarBindingSource
            // 
            this.parkingCarBindingSource.DataSource = typeof(CarManager.ParkingCar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 670);
            this.Controls.Add(this.statusStrip_Now);
            this.Controls.Add(this.listBox_logPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip_Now.ResumeLayout(false);
            this.statusStrip_Now.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_parkingSpot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private System.Windows.Forms.TextBox textBox_parkingSpot_lookUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_AllLookUp;
        private System.Windows.Forms.Button button_SelectedLookUp;
        private System.Windows.Forms.DataGridView dataGridView_parkingManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_parkingRemove;
        private System.Windows.Forms.Button button_parkingAdd;
        private System.Windows.Forms.ListBox listBox_logPrint;
        private System.Windows.Forms.Timer timer_DisplayNow;
        private System.Windows.Forms.StatusStrip statusStrip_Now;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Now;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parkingCarBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

