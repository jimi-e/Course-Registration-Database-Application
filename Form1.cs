using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)//form加载
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
           
            this.oleDbDataAdapter1.Fill(dataSet11);
        }

        string SID=null;//学号
        int course_count=0;//课程数
        int course_credit_count=0;//学分
        bool state = false;//提交状态

        private void button1_Click(object sender, EventArgs e)
        {
            SID = textBox1.Text;//获取输入的学号，初始化按钮
            state = false;
            if (SID.Length > 0)//获取姓名
            {
                dataSet11.Clear();
                string SelectStudentName = " WHERE Student_ID='" + SID + "'";
                string oldselectStmt = oleDbDataAdapter1.SelectCommand.CommandText;
                SelectStudentName = oldselectStmt + SelectStudentName;
                oleDbDataAdapter1.SelectCommand.CommandText = SelectStudentName;
                dataSet11.Clear();
                this.oleDbDataAdapter1.Fill(dataSet11);

                if(dataSet11.Tables[0].Rows.Count>0)
                label1.Text = dataSet11.Tables[0].Rows[0][0].ToString();
                else 
                { MessageBox.Show("学号输入错误!", "登陆失败"); return;}

                dataSet11.Clear();
                oleDbDataAdapter1.SelectCommand.CommandText = oldselectStmt;


            }



            if (SID.Length > 0)//获取学分
            {
                //select该学生的已选课程和学分（从sc表和c表内连接表）
                string SelectSC_count = " WHERE Student_ID='" + SID + "'";
                string oldselectStmt5 = oleDbDataAdapter5.SelectCommand.CommandText;
                SelectSC_count = oldselectStmt5 + SelectSC_count;
                oleDbDataAdapter5.SelectCommand.CommandText = SelectSC_count;
                dataSet51.Clear();
                this.oleDbDataAdapter5.Fill(dataSet51);
                oleDbDataAdapter5.SelectCommand.CommandText = oldselectStmt5;


                   course_count = dataSet51.Tables[0].Rows.Count;
                   course_credit_count = 0;
                   for (int i=0;i< course_count;i++)
                   {

                       string toString = dataSet51.Tables[0].Rows[i][2].ToString();
                       int tmp4 =0;
                       int.TryParse(toString, out tmp4);

                       course_credit_count += tmp4;
               
                   }
                   //根据已选课程显示课程数
                int   tmp = 0;
                int.TryParse(course_count.ToString(), out tmp);
                if(tmp==5)
                { label3.Text = "您已选" + course_count.ToString() + "节课程，已达选课数上限。" ; }
                else if(tmp<3)
                {   int tmp2 = 3 - tmp;
                    tmp2.ToString();
                    label3.Text = "您已选" + course_count.ToString() + "节课程，还需要选择" + tmp2 + "节课程。";
                 }
                else if (tmp >= 3&&tmp<=4)
                {   int tmp2 = 5 - tmp;
                    tmp2.ToString();
                    label3.Text = "您已选" + course_count.ToString() + "节课程，已满足要求，还最多选择" + tmp2 + "节课程。";
                }

                //根据已选课程显示学分数
                tmp = 0;
                int.TryParse(course_credit_count.ToString(), out tmp);
                if (tmp == 12)
                { label4.Text = "您已选" + course_credit_count.ToString() + "学分，已达学分上限。"; }
                else if (tmp < 8)
                {
                    int tmp2 = 8 - tmp;
                    tmp2.ToString();
                    label4.Text = "您已选" + course_credit_count.ToString() + "学分，还需要选择" + tmp2 + "学分。";
                }
                else if (tmp >= 8 && tmp <= 11)
                {
                    int tmp2 = 12 - tmp;
                    tmp2.ToString();
                    label4.Text = "您已选" + course_credit_count.ToString() + "学分，已满足要求，还最多选择" + tmp2 + "学分。";
                }



            }

            
            if (SID.Length > 0)//可选课程表
            {


                //select该学生的已选课程（sc表）
                string SelectSC_CID = " WHERE Student_ID='" + SID + "'";
                string oldselectStmt3 = oleDbDataAdapter3.SelectCommand.CommandText;
                SelectSC_CID = oldselectStmt3 + SelectSC_CID;
                oleDbDataAdapter3.SelectCommand.CommandText = SelectSC_CID;
                dataSet31.Clear();
                this.oleDbDataAdapter3.Fill(dataSet31);
                oleDbDataAdapter3.SelectCommand.CommandText = oldselectStmt3;
                //从c表中用select剔除所有已选课程，从而生成可选表
                string oldselectStmt2 = oleDbDataAdapter2.SelectCommand.CommandText;
                string NOTSelectSC = oldselectStmt2;
                for (int i=0; i<dataSet31.Tables[0].Rows.Count; i++)
                {

                    string temp = " AND Course_ID!='" + dataSet31.Tables[0].Rows[i][1].ToString() + "'";
                    NOTSelectSC = NOTSelectSC + temp;

                }

                dataSet21.Clear();
                oleDbDataAdapter2.SelectCommand.CommandText = NOTSelectSC;
                this.oleDbDataAdapter2.Fill(dataSet21);
                oleDbDataAdapter2.SelectCommand.CommandText = oldselectStmt2;
                //根据该学生的sc表记录中的state列判断其是否已经提交
                if (dataSet31.Tables[0].Rows.Count > 0)
                {
                    
                    string state_check=dataSet31.Tables[0].Rows[0][2].ToString();
                    int tmp = string.Compare(state_check, "True");
                    if (tmp == 0) state = true;

                }

                 }


            if (SID.Length > 0)//已选
            {   //select该学生已选课程（sc表和c表与t表的内连接表中，t表加入是为了显示教师姓名）
                string oldselectStmt4 = oleDbDataAdapter4.SelectCommand.CommandText;
                string SelectSC = " AND Student_Course.Student_ID='" + SID + "'";
                string oldselectStmt = oleDbDataAdapter4.SelectCommand.CommandText;
                SelectSC = oldselectStmt + SelectSC;
                oleDbDataAdapter4.SelectCommand.CommandText = SelectSC; 
                dataSet41.Clear();
                this.oleDbDataAdapter4.Fill(dataSet41);
                oleDbDataAdapter4.SelectCommand.CommandText = oldselectStmt4;

            }

            if (SID.Length > 0)//根据当前学生state是否true，判断其是否已提交，若已提交则不能选课删课，且提交按钮变为撤销按钮
            { if (state == true)//若已提交，将提交按钮和删课按钮变为不可选，
                {

                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Text = "撤销提交";
                    label8.Text = "您已提交选课内容！" + Environment.NewLine + "请撤销提交再做修改！";
                }
                else if (state == false)
                    {
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Text = "提交";
                    label8.Text = null;
                }
            }

        }

     

        private void button2_Click(object sender, EventArgs e)//选课按钮
        {   if(this.dataGridView1.SelectedRows.Count!=0)
            {
              

                //根据已选课程数和学分数计算是否可选这节课，不可就报对应错误
                if (SID.Length > 0)
                {
                    if (course_count < 5)
                    {
                        if (course_credit_count <= 12 - (int)this.dataGridView1.SelectedRows[0].Cells[3].Value)
                        {   //使用数据集完成插入操作
                            this.oleDbDataAdapter3.Fill(dataSet31);
                            DataRow row = dataSet31.Student_Course.NewRow();

                            row["Student_ID"] = this.SID;
                            row["Course_ID"] = (int)this.dataGridView1.SelectedRows[0].Cells[0].Value;
                            row["State"] = 0;

                            dataSet31.Student_Course.Rows.InsertAt(row, 0);
                            oleDbDataAdapter3.Update(dataSet31, "Student_Course");
                            button1_Click(sender, e);
                        }
                    else MessageBox.Show("您最多只能选修12学分!", "选课错误");
                    }
                    else MessageBox.Show("您最多只能选择5门课程!", "选课错误");
                }
            }
            else MessageBox.Show("您未选择课程!", "选课错误");



        }

        private void button3_Click(object sender, EventArgs e)//删课按钮
        {
            if (this.dataGridView3.SelectedRows.Count != 0)
            {
      
                int deleteCourse_ID = (int)this.dataGridView3.SelectedRows[0].Cells[0].Value;

                //使用命令对象删除此课程
                String deleteSC = "DELETE Student_Course WHERE Student_ID=	" + this.SID + "AND Course_ID=" + deleteCourse_ID;
                OleDbCommand cmdDeleteSC = new OleDbCommand(deleteSC, this.oleDbConnection1);

                this.oleDbConnection1.Open();          
                cmdDeleteSC.ExecuteNonQuery();
                this.oleDbConnection1.Close();

                this.dataSet41.Clear();
                button1_Click(sender, e);

            }
            else MessageBox.Show("您未选择需要删除的课程!", "删课错误");
        }

        private void button4_Click(object sender, EventArgs e)//state为false，则此学生未提交，此键为提交键；state为true，则此学生已提交，此键为撤销提交键
        {
            if (state==false)//提交
            {
                
                //根据现有学分和课程数核实是否满足规则，不满足报错，满足修改计较状态项state为1
           
                if (course_count >= 3 && course_count <= 5)
                {
                    if (course_credit_count >= 8 && course_credit_count <= 12)
                    {   //select该学生的已选课程（sc表）
                        string SelectSC_CID = " WHERE Student_ID='" + SID + "'";
                        string oldselectStmt3 = oleDbDataAdapter3.SelectCommand.CommandText;
                        SelectSC_CID = oldselectStmt3 + SelectSC_CID;
                        oleDbDataAdapter3.SelectCommand.CommandText = SelectSC_CID;
                        dataSet31.Clear();
                        this.oleDbDataAdapter3.Fill(dataSet31);
                        oleDbDataAdapter3.SelectCommand.CommandText = oldselectStmt3;
                        //直接修改状态项state为1
                        for (int i = 0; i < dataSet31.Tables[0].Rows.Count; i++)
                        {
                            dataSet31.Tables[0].Rows[i][2] = 1;
                        }


                        oleDbDataAdapter3.Update(dataSet31, "Student_Course");
                        MessageBox.Show("提交成功!", "提示");
                        button1_Click(sender, e);

                    }
                    else MessageBox.Show("您需要选择至少修8学分!", "提交错误");

                }
                else MessageBox.Show("您需要选择至少3门课程!", "提交错误");
            }
            else if (state == true) //撤销提交
            {   //select该学生的已选课程（sc表）
                string SelectSC_CID = " WHERE Student_ID='" + SID + "'";
                string oldselectStmt3 = oleDbDataAdapter3.SelectCommand.CommandText;
                SelectSC_CID = oldselectStmt3 + SelectSC_CID;
                oleDbDataAdapter3.SelectCommand.CommandText = SelectSC_CID;
                dataSet31.Clear();
                this.oleDbDataAdapter3.Fill(dataSet31);
                oleDbDataAdapter3.SelectCommand.CommandText = oldselectStmt3;
                
                //直接修改状态项state为1
                for (int i = 0; i < dataSet31.Tables[0].Rows.Count; i++) 
                {
                    dataSet31.Tables[0].Rows[i][2] = 0;
                }


                oleDbDataAdapter3.Update(dataSet31, "Student_Course");
                MessageBox.Show("提交撤销成功!", "提示");
                button1_Click(sender, e);
            }


        }

       //按键变色
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor =Color.LightCoral;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(51, 153, 255);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightSalmon;
 
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }
    }
}
