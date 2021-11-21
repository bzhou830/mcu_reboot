namespace ComDev
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_portNameReceive = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_open = new System.Windows.Forms.Button();
            this.cb_stopBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_dataBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_baudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelVal = new System.Windows.Forms.Label();
            this.btn_press = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_portNameReceive
            // 
            this.cb_portNameReceive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_portNameReceive.FormattingEnabled = true;
            this.cb_portNameReceive.Location = new System.Drawing.Point(60, 23);
            this.cb_portNameReceive.Name = "cb_portNameReceive";
            this.cb_portNameReceive.Size = new System.Drawing.Size(91, 20);
            this.cb_portNameReceive.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(10, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "端口号";
            // 
            // Btn_open
            // 
            this.Btn_open.Location = new System.Drawing.Point(13, 157);
            this.Btn_open.Name = "Btn_open";
            this.Btn_open.Size = new System.Drawing.Size(138, 23);
            this.Btn_open.TabIndex = 26;
            this.Btn_open.Text = "打开串口";
            this.Btn_open.UseVisualStyleBackColor = true;
            this.Btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // cb_stopBit
            // 
            this.cb_stopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_stopBit.FormattingEnabled = true;
            this.cb_stopBit.Location = new System.Drawing.Point(60, 119);
            this.cb_stopBit.Name = "cb_stopBit";
            this.cb_stopBit.Size = new System.Drawing.Size(91, 20);
            this.cb_stopBit.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "停止位";
            // 
            // cb_dataBit
            // 
            this.cb_dataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dataBit.FormattingEnabled = true;
            this.cb_dataBit.Location = new System.Drawing.Point(60, 89);
            this.cb_dataBit.Name = "cb_dataBit";
            this.cb_dataBit.Size = new System.Drawing.Size(91, 20);
            this.cb_dataBit.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(10, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "数据位";
            // 
            // cb_baudRate
            // 
            this.cb_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_baudRate.FormattingEnabled = true;
            this.cb_baudRate.Location = new System.Drawing.Point(60, 58);
            this.cb_baudRate.Name = "cb_baudRate";
            this.cb_baudRate.Size = new System.Drawing.Size(91, 20);
            this.cb_baudRate.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "波特率";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_portNameReceive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cb_baudRate);
            this.groupBox1.Controls.Add(this.Btn_open);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_dataBit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_stopBit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 193);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelVal);
            this.groupBox2.Location = new System.Drawing.Point(185, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 124);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "开机键状态";
            // 
            // labelVal
            // 
            this.labelVal.AutoSize = true;
            this.labelVal.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVal.ForeColor = System.Drawing.Color.Red;
            this.labelVal.Location = new System.Drawing.Point(46, 49);
            this.labelVal.Name = "labelVal";
            this.labelVal.Size = new System.Drawing.Size(73, 29);
            this.labelVal.TabIndex = 0;
            this.labelVal.Text = "正常";
            // 
            // btn_press
            // 
            this.btn_press.Location = new System.Drawing.Point(185, 142);
            this.btn_press.Name = "btn_press";
            this.btn_press.Size = new System.Drawing.Size(48, 60);
            this.btn_press.TabIndex = 26;
            this.btn_press.Text = "按下开机";
            this.btn_press.UseVisualStyleBackColor = true;
            this.btn_press.Click += new System.EventHandler(this.Btn_press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 60);
            this.button3.TabIndex = 26;
            this.button3.Text = "读取状态";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_get);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(247, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 60);
            this.button4.TabIndex = 26;
            this.button4.Text = "回到正常";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_return);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 214);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_press);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ComDev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_portNameReceive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_open;
        private System.Windows.Forms.ComboBox cb_stopBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_dataBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_baudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelVal;
        private System.Windows.Forms.Button btn_press;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

