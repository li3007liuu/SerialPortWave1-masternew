namespace SerialPortWave
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receDis = new System.Windows.Forms.TextBox();
            this.receNumText = new System.Windows.Forms.Label();
            this.timeSendFlag = new System.Windows.Forms.CheckBox();
            this.sendCmdButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sendText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendTime = new System.Windows.Forms.TextBox();
            this.textBaud = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.findport = new System.Windows.Forms.Button();
            this.openCom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.串口号 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textDatanum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.Label();
            this.selectPath = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearChart = new System.Windows.Forms.Button();
            this.setChartButton = new System.Windows.Forms.Button();
            this.yLabel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.30556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.63492F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tChart1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1344, 911);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.receDis);
            this.groupBox1.Controls.Add(this.receNumText);
            this.groupBox1.Controls.Add(this.timeSendFlag);
            this.groupBox1.Controls.Add(this.sendCmdButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.sendText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sendTime);
            this.groupBox1.Controls.Add(this.textBaud);
            this.groupBox1.Controls.Add(this.sendbutton);
            this.groupBox1.Controls.Add(this.findport);
            this.groupBox1.Controls.Add(this.openCom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.串口号);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(4, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(655, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // receDis
            // 
            this.receDis.Font = new System.Drawing.Font("微软雅黑 Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.receDis.Location = new System.Drawing.Point(363, 25);
            this.receDis.Margin = new System.Windows.Forms.Padding(4);
            this.receDis.Multiline = true;
            this.receDis.Name = "receDis";
            this.receDis.Size = new System.Drawing.Size(208, 50);
            this.receDis.TabIndex = 14;
            // 
            // receNumText
            // 
            this.receNumText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.receNumText.Location = new System.Drawing.Point(580, 39);
            this.receNumText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.receNumText.Name = "receNumText";
            this.receNumText.Size = new System.Drawing.Size(69, 30);
            this.receNumText.TabIndex = 13;
            // 
            // timeSendFlag
            // 
            this.timeSendFlag.AutoSize = true;
            this.timeSendFlag.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeSendFlag.Location = new System.Drawing.Point(349, 140);
            this.timeSendFlag.Margin = new System.Windows.Forms.Padding(4);
            this.timeSendFlag.Name = "timeSendFlag";
            this.timeSendFlag.Size = new System.Drawing.Size(18, 17);
            this.timeSendFlag.TabIndex = 12;
            this.timeSendFlag.UseVisualStyleBackColor = true;
            // 
            // sendCmdButton
            // 
            this.sendCmdButton.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendCmdButton.Location = new System.Drawing.Point(555, 82);
            this.sendCmdButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendCmdButton.Name = "sendCmdButton";
            this.sendCmdButton.Size = new System.Drawing.Size(91, 38);
            this.sendCmdButton.TabIndex = 11;
            this.sendCmdButton.Text = "发送";
            this.sendCmdButton.UseVisualStyleBackColor = true;
            this.sendCmdButton.Click += new System.EventHandler(this.sendCmdButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(277, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "命令:";
            // 
            // sendText
            // 
            this.sendText.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendText.Location = new System.Drawing.Point(363, 84);
            this.sendText.Margin = new System.Windows.Forms.Padding(4);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(184, 34);
            this.sendText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(277, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "接收区:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(495, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ms";
            // 
            // sendTime
            // 
            this.sendTime.Location = new System.Drawing.Point(377, 130);
            this.sendTime.Margin = new System.Windows.Forms.Padding(4);
            this.sendTime.Name = "sendTime";
            this.sendTime.Size = new System.Drawing.Size(111, 34);
            this.sendTime.TabIndex = 1;
            this.sendTime.TextChanged += new System.EventHandler(this.sendTime_TextChanged);
            // 
            // textBaud
            // 
            this.textBaud.Location = new System.Drawing.Point(92, 81);
            this.textBaud.Margin = new System.Windows.Forms.Padding(4);
            this.textBaud.Name = "textBaud";
            this.textBaud.Size = new System.Drawing.Size(173, 34);
            this.textBaud.TabIndex = 6;
            this.textBaud.TextChanged += new System.EventHandler(this.textBaud_TextChanged);
            // 
            // sendbutton
            // 
            this.sendbutton.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendbutton.Location = new System.Drawing.Point(539, 129);
            this.sendbutton.Margin = new System.Windows.Forms.Padding(4);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(107, 38);
            this.sendbutton.TabIndex = 0;
            this.sendbutton.Text = "开始采集";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // findport
            // 
            this.findport.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findport.Location = new System.Drawing.Point(7, 128);
            this.findport.Margin = new System.Windows.Forms.Padding(4);
            this.findport.Name = "findport";
            this.findport.Size = new System.Drawing.Size(104, 39);
            this.findport.TabIndex = 5;
            this.findport.Text = "搜索";
            this.findport.UseVisualStyleBackColor = true;
            this.findport.Click += new System.EventHandler(this.findport_Click);
            // 
            // openCom
            // 
            this.openCom.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openCom.Location = new System.Drawing.Point(119, 128);
            this.openCom.Margin = new System.Windows.Forms.Padding(4);
            this.openCom.Name = "openCom";
            this.openCom.Size = new System.Drawing.Size(148, 39);
            this.openCom.TabIndex = 4;
            this.openCom.Text = "打开串口";
            this.openCom.UseVisualStyleBackColor = true;
            this.openCom.Click += new System.EventHandler(this.openCom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率:";
            // 
            // 串口号
            // 
            this.串口号.AutoSize = true;
            this.串口号.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.串口号.Location = new System.Drawing.Point(1, 40);
            this.串口号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.串口号.Name = "串口号";
            this.串口号.Size = new System.Drawing.Size(77, 27);
            this.串口号.TabIndex = 2;
            this.串口号.Text = "串口号:";
            // 
            // port
            // 
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(92, 35);
            this.port.Margin = new System.Windows.Forms.Padding(4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(173, 35);
            this.port.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textDatanum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.filePath);
            this.groupBox2.Controls.Add(this.selectPath);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(667, 113);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(269, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件保存配置";
            // 
            // textDatanum
            // 
            this.textDatanum.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textDatanum.Location = new System.Drawing.Point(13, 128);
            this.textDatanum.Margin = new System.Windows.Forms.Padding(4);
            this.textDatanum.Name = "textDatanum";
            this.textDatanum.Size = new System.Drawing.Size(132, 31);
            this.textDatanum.TabIndex = 3;
            this.textDatanum.TextChanged += new System.EventHandler(this.textDatanum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "单个文件数据总数";
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filePath.Location = new System.Drawing.Point(119, 42);
            this.filePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(59, 24);
            this.filePath.TabIndex = 1;
            this.filePath.Text = "label4";
            // 
            // selectPath
            // 
            this.selectPath.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectPath.Location = new System.Drawing.Point(9, 36);
            this.selectPath.Margin = new System.Windows.Forms.Padding(4);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(100, 36);
            this.selectPath.TabIndex = 0;
            this.selectPath.Text = "选择";
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clearChart);
            this.groupBox3.Controls.Add(this.setChartButton);
            this.groupBox3.Controls.Add(this.yLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.xLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(944, 113);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(396, 174);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "波形图操作";
            // 
            // clearChart
            // 
            this.clearChart.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearChart.Location = new System.Drawing.Point(25, 128);
            this.clearChart.Margin = new System.Windows.Forms.Padding(4);
            this.clearChart.Name = "clearChart";
            this.clearChart.Size = new System.Drawing.Size(221, 39);
            this.clearChart.TabIndex = 7;
            this.clearChart.Text = "清除波形";
            this.clearChart.UseVisualStyleBackColor = true;
            this.clearChart.Click += new System.EventHandler(this.clearChart_Click);
            // 
            // setChartButton
            // 
            this.setChartButton.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setChartButton.Location = new System.Drawing.Point(272, 31);
            this.setChartButton.Margin = new System.Windows.Forms.Padding(4);
            this.setChartButton.Name = "setChartButton";
            this.setChartButton.Size = new System.Drawing.Size(100, 86);
            this.setChartButton.TabIndex = 6;
            this.setChartButton.Text = "设置";
            this.setChartButton.UseVisualStyleBackColor = true;
            this.setChartButton.Click += new System.EventHandler(this.setChartButton_Click);
            // 
            // yLabel
            // 
            this.yLabel.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yLabel.Location = new System.Drawing.Point(113, 81);
            this.yLabel.Margin = new System.Windows.Forms.Padding(4);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(132, 34);
            this.yLabel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(20, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 27);
            this.label8.TabIndex = 2;
            this.label8.Text = "y轴标签";
            // 
            // xLabel
            // 
            this.xLabel.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xLabel.Location = new System.Drawing.Point(113, 35);
            this.xLabel.Margin = new System.Windows.Forms.Padding(4);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(132, 31);
            this.xLabel.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(20, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "x轴标签";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(461, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "串口信号采集示波器";
            // 
            // tChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = -6;
            this.tableLayoutPanel1.SetColumnSpan(this.tChart1, 3);
            this.tChart1.Location = new System.Drawing.Point(3, 294);
            this.tChart1.Name = "tChart1";
            this.tChart1.Series.Add(this.fastLine1);
            this.tChart1.Size = new System.Drawing.Size(1337, 443);
            this.tChart1.TabIndex = 4;
            this.tChart1.Click += new System.EventHandler(this.tChart1_Click);
            // 
            // fastLine1
            // 
            this.fastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.fastLine1.ColorEach = false;
            // 
            // 
            // 
            this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.fastLine1.Title = "fastLine1";
            this.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            this.fastLine1.XValues.DataMember = "X";
            this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine1.YValues.DataMember = "Y";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1341, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1359, 788);
            this.MinimumSize = new System.Drawing.Size(1359, 788);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口信号采集示波器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 串口号;
        private System.Windows.Forms.ComboBox port;
        private System.Windows.Forms.Button findport;
        private System.Windows.Forms.TextBox textBaud;
        private System.Windows.Forms.TextBox sendTime;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.TextBox textDatanum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendCmdButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button setChartButton;
        private System.Windows.Forms.TextBox yLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox xLabel;
        private System.Windows.Forms.CheckBox timeSendFlag;
        private System.Windows.Forms.Button clearChart;
        private System.Windows.Forms.Label receNumText;
        private System.Windows.Forms.TextBox receDis;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.FastLine fastLine1;
    }
}

