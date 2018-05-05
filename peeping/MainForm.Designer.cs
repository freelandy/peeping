namespace peeping
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTGWENBEN = new System.Windows.Forms.TextBox();
            this.lblDAAN = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblZHISHIDIANMINGCHENG = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblJIEMINGCHENG = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblZHANGMINGCHENG = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTIXINGMINGCHENG = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTMDAIMA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkAnswer = new System.Windows.Forms.CheckBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.chkSingleChoise = new System.Windows.Forms.CheckBox();
            this.txtDbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTrueFalse = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMultiChoise = new System.Windows.Forms.CheckBox();
            this.txtDbFile = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TMDaima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZhangMingCheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JieMingCheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZhiShiDianMingCheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiXingMingCheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGWenBen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDDaAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTiKuCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 70);
            this.panel1.TabIndex = 0;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.lblTiKuCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(881, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 525);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTGWENBEN);
            this.groupBox2.Controls.Add(this.lblDAAN);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblZHISHIDIANMINGCHENG);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblJIEMINGCHENG);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblZHANGMINGCHENG);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblTIXINGMINGCHENG);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTMDAIMA);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 153);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // txtTGWENBEN
            // 
            this.txtTGWENBEN.Location = new System.Drawing.Point(81, 39);
            this.txtTGWENBEN.Multiline = true;
            this.txtTGWENBEN.Name = "txtTGWENBEN";
            this.txtTGWENBEN.ReadOnly = true;
            this.txtTGWENBEN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTGWENBEN.Size = new System.Drawing.Size(795, 88);
            this.txtTGWENBEN.TabIndex = 14;
            // 
            // lblDAAN
            // 
            this.lblDAAN.AutoSize = true;
            this.lblDAAN.Location = new System.Drawing.Point(81, 130);
            this.lblDAAN.Name = "lblDAAN";
            this.lblDAAN.Size = new System.Drawing.Size(0, 12);
            this.lblDAAN.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 12;
            this.label15.Text = "答    案:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "题    干:";
            // 
            // lblZHISHIDIANMINGCHENG
            // 
            this.lblZHISHIDIANMINGCHENG.AutoSize = true;
            this.lblZHISHIDIANMINGCHENG.Location = new System.Drawing.Point(743, 18);
            this.lblZHISHIDIANMINGCHENG.Name = "lblZHISHIDIANMINGCHENG";
            this.lblZHISHIDIANMINGCHENG.Size = new System.Drawing.Size(0, 12);
            this.lblZHISHIDIANMINGCHENG.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(678, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "知 识 点:";
            // 
            // lblJIEMINGCHENG
            // 
            this.lblJIEMINGCHENG.AutoSize = true;
            this.lblJIEMINGCHENG.Location = new System.Drawing.Point(558, 18);
            this.lblJIEMINGCHENG.Name = "lblJIEMINGCHENG";
            this.lblJIEMINGCHENG.Size = new System.Drawing.Size(0, 12);
            this.lblJIEMINGCHENG.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "节 名 称:";
            // 
            // lblZHANGMINGCHENG
            // 
            this.lblZHANGMINGCHENG.AutoSize = true;
            this.lblZHANGMINGCHENG.Location = new System.Drawing.Point(363, 18);
            this.lblZHANGMINGCHENG.Name = "lblZHANGMINGCHENG";
            this.lblZHANGMINGCHENG.Size = new System.Drawing.Size(0, 12);
            this.lblZHANGMINGCHENG.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "章 名 称:";
            // 
            // lblTIXINGMINGCHENG
            // 
            this.lblTIXINGMINGCHENG.AutoSize = true;
            this.lblTIXINGMINGCHENG.Location = new System.Drawing.Point(204, 18);
            this.lblTIXINGMINGCHENG.Name = "lblTIXINGMINGCHENG";
            this.lblTIXINGMINGCHENG.Size = new System.Drawing.Size(0, 12);
            this.lblTIXINGMINGCHENG.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "试题类型:";
            // 
            // lblTMDAIMA
            // 
            this.lblTMDAIMA.AutoSize = true;
            this.lblTMDAIMA.Location = new System.Drawing.Point(76, 18);
            this.lblTMDAIMA.Name = "lblTMDAIMA";
            this.lblTMDAIMA.Size = new System.Drawing.Size(0, 12);
            this.lblTMDAIMA.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "试题编号:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseFile);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.chkAnswer);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.chkFill);
            this.groupBox1.Controls.Add(this.chkSingleChoise);
            this.groupBox1.Controls.Add(this.txtDbPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkTrueFalse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkMultiChoise);
            this.groupBox1.Controls.Add(this.txtDbFile);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 94);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(411, 19);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(57, 23);
            this.btnBrowseFile.TabIndex = 23;
            this.btnBrowseFile.Text = "浏览";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(758, 56);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(111, 23);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkAnswer
            // 
            this.chkAnswer.AutoSize = true;
            this.chkAnswer.Checked = true;
            this.chkAnswer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnswer.Location = new System.Drawing.Point(536, 60);
            this.chkAnswer.Name = "chkAnswer";
            this.chkAnswer.Size = new System.Drawing.Size(72, 16);
            this.chkAnswer.TabIndex = 14;
            this.chkAnswer.Text = "显示答案";
            this.chkAnswer.UseVisualStyleBackColor = true;
            this.chkAnswer.CheckedChanged += new System.EventHandler(this.chkAnswer_CheckedChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(623, 56);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(111, 23);
            this.btnQuery.TabIndex = 21;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // chkFill
            // 
            this.chkFill.AutoSize = true;
            this.chkFill.Checked = true;
            this.chkFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFill.Location = new System.Drawing.Point(797, 22);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(72, 16);
            this.chkFill.TabIndex = 11;
            this.chkFill.Text = "填    空";
            this.chkFill.UseVisualStyleBackColor = true;
            this.chkFill.CheckedChanged += new System.EventHandler(this.chkFill_CheckedChanged);
            // 
            // chkSingleChoise
            // 
            this.chkSingleChoise.AutoSize = true;
            this.chkSingleChoise.Checked = true;
            this.chkSingleChoise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSingleChoise.Location = new System.Drawing.Point(536, 22);
            this.chkSingleChoise.Name = "chkSingleChoise";
            this.chkSingleChoise.Size = new System.Drawing.Size(72, 16);
            this.chkSingleChoise.TabIndex = 12;
            this.chkSingleChoise.Text = "单项选择";
            this.chkSingleChoise.UseVisualStyleBackColor = true;
            this.chkSingleChoise.CheckedChanged += new System.EventHandler(this.chkSingleChoise_CheckedChanged);
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Location = new System.Drawing.Point(76, 58);
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.Size = new System.Drawing.Size(100, 21);
            this.txtDbPassword.TabIndex = 18;
            this.txtDbPassword.Text = "wwjt_wy_sg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "题库文件:";
            // 
            // chkTrueFalse
            // 
            this.chkTrueFalse.AutoSize = true;
            this.chkTrueFalse.Checked = true;
            this.chkTrueFalse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrueFalse.Location = new System.Drawing.Point(710, 22);
            this.chkTrueFalse.Name = "chkTrueFalse";
            this.chkTrueFalse.Size = new System.Drawing.Size(72, 16);
            this.chkTrueFalse.TabIndex = 13;
            this.chkTrueFalse.Text = "判    断";
            this.chkTrueFalse.UseVisualStyleBackColor = true;
            this.chkTrueFalse.CheckedChanged += new System.EventHandler(this.chkTrueFalse_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "密    码:";
            // 
            // chkMultiChoise
            // 
            this.chkMultiChoise.AutoSize = true;
            this.chkMultiChoise.Checked = true;
            this.chkMultiChoise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMultiChoise.Location = new System.Drawing.Point(623, 22);
            this.chkMultiChoise.Name = "chkMultiChoise";
            this.chkMultiChoise.Size = new System.Drawing.Size(72, 16);
            this.chkMultiChoise.TabIndex = 20;
            this.chkMultiChoise.Text = "多项选择";
            this.chkMultiChoise.UseVisualStyleBackColor = true;
            this.chkMultiChoise.CheckedChanged += new System.EventHandler(this.chkMultiChoise_CheckedChanged);
            // 
            // txtDbFile
            // 
            this.txtDbFile.Location = new System.Drawing.Point(76, 20);
            this.txtDbFile.Name = "txtDbFile";
            this.txtDbFile.ReadOnly = true;
            this.txtDbFile.Size = new System.Drawing.Size(329, 21);
            this.txtDbFile.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qid,
            this.TMDaima,
            this.ZhangMingCheng,
            this.JieMingCheng,
            this.ZhiShiDianMingCheng,
            this.TiXingMingCheng,
            this.TGWenBen,
            this.PDDaAn,
            this.A,
            this.B,
            this.C,
            this.D,
            this.DaAn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(875, 261);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // qid
            // 
            this.qid.DataPropertyName = "QID";
            this.qid.HeaderText = "编号";
            this.qid.Name = "qid";
            this.qid.ReadOnly = true;
            this.qid.Visible = false;
            // 
            // TMDaima
            // 
            this.TMDaima.DataPropertyName = "TMDaima";
            this.TMDaima.HeaderText = "题目代码";
            this.TMDaima.Name = "TMDaima";
            this.TMDaima.ReadOnly = true;
            this.TMDaima.Visible = false;
            // 
            // ZhangMingCheng
            // 
            this.ZhangMingCheng.DataPropertyName = "ZhangMingCheng";
            this.ZhangMingCheng.HeaderText = "章名称";
            this.ZhangMingCheng.Name = "ZhangMingCheng";
            this.ZhangMingCheng.ReadOnly = true;
            // 
            // JieMingCheng
            // 
            this.JieMingCheng.DataPropertyName = "JieMingCheng";
            this.JieMingCheng.HeaderText = "节名称";
            this.JieMingCheng.Name = "JieMingCheng";
            this.JieMingCheng.ReadOnly = true;
            // 
            // ZhiShiDianMingCheng
            // 
            this.ZhiShiDianMingCheng.DataPropertyName = "ZhiShiDianMingCheng";
            this.ZhiShiDianMingCheng.HeaderText = "知识点";
            this.ZhiShiDianMingCheng.Name = "ZhiShiDianMingCheng";
            this.ZhiShiDianMingCheng.ReadOnly = true;
            // 
            // TiXingMingCheng
            // 
            this.TiXingMingCheng.DataPropertyName = "TiXingMingCheng";
            this.TiXingMingCheng.HeaderText = "题型";
            this.TiXingMingCheng.Name = "TiXingMingCheng";
            this.TiXingMingCheng.ReadOnly = true;
            // 
            // TGWenBen
            // 
            this.TGWenBen.DataPropertyName = "TGWenBen";
            this.TGWenBen.HeaderText = "题干";
            this.TGWenBen.Name = "TGWenBen";
            this.TGWenBen.ReadOnly = true;
            // 
            // PDDaAn
            // 
            this.PDDaAn.DataPropertyName = "PDDaAn";
            this.PDDaAn.HeaderText = "判断答案";
            this.PDDaAn.Name = "PDDaAn";
            this.PDDaAn.ReadOnly = true;
            this.PDDaAn.Visible = false;
            // 
            // A
            // 
            this.A.DataPropertyName = "A";
            this.A.HeaderText = "选项A";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            // 
            // B
            // 
            this.B.DataPropertyName = "B";
            this.B.HeaderText = "选项B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            // 
            // C
            // 
            this.C.DataPropertyName = "C";
            this.C.HeaderText = "选项C";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // D
            // 
            this.D.DataPropertyName = "D";
            this.D.HeaderText = "选项D";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            // 
            // DaAn
            // 
            this.DaAn.DataPropertyName = "DaAn";
            this.DaAn.HeaderText = "答案";
            this.DaAn.Name = "DaAn";
            this.DaAn.ReadOnly = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "总数:";
            // 
            // lblTiKuCount
            // 
            this.lblTiKuCount.Name = "lblTiKuCount";
            this.lblTiKuCount.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新偷窥无罪";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTGWENBEN;
        private System.Windows.Forms.Label lblDAAN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblZHISHIDIANMINGCHENG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblJIEMINGCHENG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblZHANGMINGCHENG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTIXINGMINGCHENG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTMDAIMA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkAnswer;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.CheckBox chkFill;
        private System.Windows.Forms.CheckBox chkSingleChoise;
        private System.Windows.Forms.TextBox txtDbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTrueFalse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkMultiChoise;
        private System.Windows.Forms.TextBox txtDbFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TMDaima;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZhangMingCheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn JieMingCheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZhiShiDianMingCheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiXingMingCheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGWenBen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDDaAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaAn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblTiKuCount;
    }
}

