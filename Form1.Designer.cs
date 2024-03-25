namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet11 = new WindowsFormsApp1.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.课程编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.任课教师DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程学分DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet21 = new WindowsFormsApp1.DataSet2();
            this.button2 = new System.Windows.Forms.Button();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataSet31 = new WindowsFormsApp1.DataSet3();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter5 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataSet51 = new WindowsFormsApp1.DataSet5();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataSet41 = new WindowsFormsApp1.DataSet4();
            this.课程编号DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名称DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.任课教师DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程学分DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet41)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "请输入学号";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(159, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(328, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 3;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT  Student_Name\r\nFROM      Student";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=LAPTOP-1RPB26TE;Integrated Security=SSPI;Initial C" +
    "atalog=Course_Selection_System";
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Student", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Student_Name", "Student_Name")})});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(240, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "你好！";
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = resources.GetString("oleDbSelectCommand2.CommandText");
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Course", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("课程编号", "课程编号"),
                        new System.Data.Common.DataColumnMapping("课程名称", "课程名称"),
                        new System.Data.Common.DataColumnMapping("任课教师", "任课教师"),
                        new System.Data.Common.DataColumnMapping("课程学分", "课程学分")})});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程编号DataGridViewTextBoxColumn,
            this.课程名称DataGridViewTextBoxColumn,
            this.任课教师DataGridViewTextBoxColumn,
            this.课程学分DataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Course";
            this.dataGridView1.DataSource = this.dataSet21;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(737, 283);
            this.dataGridView1.TabIndex = 5;
            // 
            // 课程编号DataGridViewTextBoxColumn
            // 
            this.课程编号DataGridViewTextBoxColumn.DataPropertyName = "课程编号";
            this.课程编号DataGridViewTextBoxColumn.HeaderText = "课程编号";
            this.课程编号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.课程编号DataGridViewTextBoxColumn.Name = "课程编号DataGridViewTextBoxColumn";
            this.课程编号DataGridViewTextBoxColumn.Width = 125;
            // 
            // 课程名称DataGridViewTextBoxColumn
            // 
            this.课程名称DataGridViewTextBoxColumn.DataPropertyName = "课程名称";
            this.课程名称DataGridViewTextBoxColumn.HeaderText = "课程名称";
            this.课程名称DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.课程名称DataGridViewTextBoxColumn.Name = "课程名称DataGridViewTextBoxColumn";
            this.课程名称DataGridViewTextBoxColumn.Width = 125;
            // 
            // 任课教师DataGridViewTextBoxColumn
            // 
            this.任课教师DataGridViewTextBoxColumn.DataPropertyName = "任课教师";
            this.任课教师DataGridViewTextBoxColumn.HeaderText = "任课教师";
            this.任课教师DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.任课教师DataGridViewTextBoxColumn.Name = "任课教师DataGridViewTextBoxColumn";
            this.任课教师DataGridViewTextBoxColumn.Width = 125;
            // 
            // 课程学分DataGridViewTextBoxColumn
            // 
            this.课程学分DataGridViewTextBoxColumn.DataPropertyName = "课程学分";
            this.课程学分DataGridViewTextBoxColumn.HeaderText = "课程学分";
            this.课程学分DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.课程学分DataGridViewTextBoxColumn.Name = "课程学分DataGridViewTextBoxColumn";
            this.课程学分DataGridViewTextBoxColumn.Width = 125;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(846, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "选课";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT  Student_ID, Course_ID, State\r\nFROM      Student_Course";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO [Student_Course] ([Student_ID], [Course_ID], [State]) VALUES (?, ?, ?" +
    ")";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Student_ID", System.Data.OleDb.OleDbType.Integer, 0, "Student_ID"),
            new System.Data.OleDb.OleDbParameter("Course_ID", System.Data.OleDb.OleDbType.Integer, 0, "Course_ID"),
            new System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.Boolean, 0, "State")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE [Student_Course] SET [Student_ID] = ?, [Course_ID] = ?, [State] = ? WHERE " +
    "(([Student_ID] = ?) AND ([Course_ID] = ?) AND ((? = 1 AND [State] IS NULL) OR ([" +
    "State] = ?)))";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Student_ID", System.Data.OleDb.OleDbType.Integer, 0, "Student_ID"),
            new System.Data.OleDb.OleDbParameter("Course_ID", System.Data.OleDb.OleDbType.Integer, 0, "Course_ID"),
            new System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.Boolean, 0, "State"),
            new System.Data.OleDb.OleDbParameter("Original_Student_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Course_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Course_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_State", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "State", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_State", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "State", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM [Student_Course] WHERE (([Student_ID] = ?) AND ([Course_ID] = ?) AND " +
    "((? = 1 AND [State] IS NULL) OR ([State] = ?)))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Student_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Course_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Course_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_State", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "State", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_State", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "State", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter3
            // 
            this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Student_Course", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Student_ID", "Student_ID"),
                        new System.Data.Common.DataColumnMapping("Course_ID", "Course_ID"),
                        new System.Data.Common.DataColumnMapping("State", "State")})});
            this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // dataSet31
            // 
            this.dataSet31.DataSetName = "DataSet3";
            this.dataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = resources.GetString("oleDbSelectCommand4.CommandText");
            this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
            // 
            // oleDbDataAdapter4
            // 
            this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
            this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Course", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("课程编号", "课程编号"),
                        new System.Data.Common.DataColumnMapping("课程名称", "课程名称"),
                        new System.Data.Common.DataColumnMapping("任课教师", "任课教师"),
                        new System.Data.Common.DataColumnMapping("课程学分", "课程学分"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Student_ID", "Student_ID")})});
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(846, 532);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 60);
            this.button3.TabIndex = 9;
            this.button3.Text = "删课";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = resources.GetString("oleDbSelectCommand5.CommandText");
            this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
            // 
            // oleDbDataAdapter5
            // 
            this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
            this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Course", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Course_ID", "Course_ID"),
                        new System.Data.Common.DataColumnMapping("Student_ID", "Student_ID"),
                        new System.Data.Common.DataColumnMapping("Course_Credit", "Course_Credit"),
                        new System.Data.Common.DataColumnMapping("State", "State")})});
            // 
            // dataSet51
            // 
            this.dataSet51.DataSetName = "DataSet5";
            this.dataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(397, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "课程数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(436, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "学分";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "可选课程                ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "已选课程                ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(847, 762);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 60);
            this.button4.TabIndex = 15;
            this.button4.Text = "提交";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(779, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 83);
            this.label7.TabIndex = 16;
            this.label7.Text = "亲爱的同学，\r\n请确保您的选课节数为3-5门，\r\n选修学分为8-12学分。\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(773, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 31);
            this.label8.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSalmon;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(399, 760);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 62);
            this.label9.TabIndex = 18;
            this.label9.Text = "提交之后需撤销才能再做修改！\r\n请谨慎提交！！！";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程编号DataGridViewTextBoxColumn1,
            this.课程名称DataGridViewTextBoxColumn1,
            this.任课教师DataGridViewTextBoxColumn1,
            this.课程学分DataGridViewTextBoxColumn1});
            this.dataGridView3.DataMember = "Course";
            this.dataGridView3.DataSource = this.dataSet41;
            this.dataGridView3.Location = new System.Drawing.Point(12, 435);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(737, 289);
            this.dataGridView3.TabIndex = 8;
            // 
            // dataSet41
            // 
            this.dataSet41.DataSetName = "DataSet4";
            this.dataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 课程编号DataGridViewTextBoxColumn1
            // 
            this.课程编号DataGridViewTextBoxColumn1.DataPropertyName = "课程编号";
            this.课程编号DataGridViewTextBoxColumn1.HeaderText = "课程编号";
            this.课程编号DataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.课程编号DataGridViewTextBoxColumn1.Name = "课程编号DataGridViewTextBoxColumn1";
            this.课程编号DataGridViewTextBoxColumn1.Width = 125;
            // 
            // 课程名称DataGridViewTextBoxColumn1
            // 
            this.课程名称DataGridViewTextBoxColumn1.DataPropertyName = "课程名称";
            this.课程名称DataGridViewTextBoxColumn1.HeaderText = "课程名称";
            this.课程名称DataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.课程名称DataGridViewTextBoxColumn1.Name = "课程名称DataGridViewTextBoxColumn1";
            this.课程名称DataGridViewTextBoxColumn1.Width = 125;
            // 
            // 任课教师DataGridViewTextBoxColumn1
            // 
            this.任课教师DataGridViewTextBoxColumn1.DataPropertyName = "任课教师";
            this.任课教师DataGridViewTextBoxColumn1.HeaderText = "任课教师";
            this.任课教师DataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.任课教师DataGridViewTextBoxColumn1.Name = "任课教师DataGridViewTextBoxColumn1";
            this.任课教师DataGridViewTextBoxColumn1.Width = 125;
            // 
            // 课程学分DataGridViewTextBoxColumn1
            // 
            this.课程学分DataGridViewTextBoxColumn1.DataPropertyName = "课程学分";
            this.课程学分DataGridViewTextBoxColumn1.HeaderText = "课程学分";
            this.课程学分DataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.课程学分DataGridViewTextBoxColumn1.Name = "课程学分DataGridViewTextBoxColumn1";
            this.课程学分DataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 847);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选课系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet41)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 任课教师DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程学分DataGridViewTextBoxColumn;
        private DataSet2 dataSet21;
        private System.Windows.Forms.Button button2;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
        private DataSet3 dataSet31;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
        private DataSet4 dataSet41;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter5;
        private DataSet5 dataSet51;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程编号DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名称DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 任课教师DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程学分DataGridViewTextBoxColumn1;
    }
}

