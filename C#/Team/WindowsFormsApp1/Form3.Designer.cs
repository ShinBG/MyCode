namespace WindowsFormsApp1
{
    partial class Form3
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_TS = new System.Windows.Forms.Button();
            this.btn_TSB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(277, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(243, 206);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(243, 206);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_TS
            // 
            this.btn_TS.Location = new System.Drawing.Point(12, 12);
            this.btn_TS.Name = "btn_TS";
            this.btn_TS.Size = new System.Drawing.Size(75, 23);
            this.btn_TS.TabIndex = 10;
            this.btn_TS.Text = "자가용";
            this.btn_TS.UseVisualStyleBackColor = true;
            this.btn_TS.Click += new System.EventHandler(this.btn_TS_Click);
            // 
            // btn_TSB
            // 
            this.btn_TSB.Location = new System.Drawing.Point(277, 12);
            this.btn_TSB.Name = "btn_TSB";
            this.btn_TSB.Size = new System.Drawing.Size(75, 23);
            this.btn_TSB.TabIndex = 11;
            this.btn_TSB.Text = "버스";
            this.btn_TSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TSB.UseVisualStyleBackColor = true;
            this.btn_TSB.Click += new System.EventHandler(this.btn_TSB_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.btn_TSB);
            this.Controls.Add(this.btn_TS);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_TS;
        private System.Windows.Forms.Button btn_TSB;
    }
}