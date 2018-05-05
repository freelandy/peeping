using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
using peeping.DataAccess;
using peeping.Entity;

namespace peeping
{
    public partial class MainForm : Form
    {
        private List<TiKu> dataSource;
        private List<string> filterString = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.filterString.Add("单项选择题");
            this.filterString.Add("多项选择题");
            this.filterString.Add("判断题");
            this.filterString.Add("填空题");
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.InitialDirectory = Application.StartupPath;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                this.txtDbFile.Text = dlg.FileName;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                this.QueryData("");
            }
            catch
            {
                MessageBox.Show("应该是没安装Access驱动程序。或者可能是题库文件有问题，要不就是密码错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QueryData(string condition)
        {
            TiKuDA tikuDA = new TiKuDA(this.txtDbFile.Text,this.txtDbPassword.Text.Replace("'","''"));

            this.dataSource = tikuDA.GetList(condition);

            this.dataGridView1.DataSource = this.dataSource;

            this.lblTiKuCount.Text = ((List<TiKu>)this.dataGridView1.DataSource).Count.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count>0)
            {
                if (this.dataGridView1.SelectedRows[0].DataBoundItem != null)
                {
                    this.lblDAAN.Text = this.dataGridView1.SelectedRows[0].Cells["DaAn"].Value.ToString();
                    this.lblJIEMINGCHENG.Text = this.dataGridView1.SelectedRows[0].Cells["JieMingCheng"].Value.ToString();
                    this.lblTIXINGMINGCHENG.Text = this.dataGridView1.SelectedRows[0].Cells["TiXingMingCheng"].Value.ToString();
                    this.lblTMDAIMA.Text = this.dataGridView1.SelectedRows[0].Cells["TMDaiMa"].Value.ToString();
                    this.lblZHANGMINGCHENG.Text = this.dataGridView1.SelectedRows[0].Cells["ZhangMingCheng"].Value.ToString();
                    this.lblZHISHIDIANMINGCHENG.Text = this.dataGridView1.SelectedRows[0].Cells["ZhiShiDianMingCheng"].Value.ToString();

                    this.txtTGWENBEN.Text = this.dataGridView1.SelectedRows[0].Cells["TGWenBen"].Value.ToString();
                    if(this.dataGridView1.SelectedRows[0].Cells["TiXingMingCheng"].Value.ToString() == "单项选择题" ||
                        this.dataGridView1.SelectedRows[0].Cells["TiXingMingCheng"].Value.ToString() == "多项选择题")
                    {
                        this.txtTGWENBEN.Text = this.txtTGWENBEN.Text + "\r\n" + "A." + this.dataGridView1.SelectedRows[0].Cells["A"].Value.ToString();
                        this.txtTGWENBEN.Text = this.txtTGWENBEN.Text + "\r\n" + "B." + this.dataGridView1.SelectedRows[0].Cells["B"].Value.ToString() + "\n";
                        this.txtTGWENBEN.Text = this.txtTGWENBEN.Text + "\r\n" + "C." + this.dataGridView1.SelectedRows[0].Cells["C"].Value.ToString() + "\n";
                        this.txtTGWENBEN.Text = this.txtTGWENBEN.Text + "\r\n" + "D." + this.dataGridView1.SelectedRows[0].Cells["D"].Value.ToString() + "\n";
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File";
            
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream myStream;
                myStream = saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("GB2312"));

                string str = "";
                try
                {
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        if (i > 0)
                        {
                            str += "\t";
                        }
                        str += dataGridView1.Columns[i].HeaderText;
                    }
                    sw.WriteLine(str);
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[j].DataBoundItem != null)
                        {
                            string tempStr = "";
                            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                            {
                                if (k > 0)
                                {
                                    tempStr += "\t";
                                }

                                string temp = dataGridView1.Rows[j].Cells[k].Value == null ? "" : dataGridView1.Rows[j].Cells[k].Value.ToString();
                                temp = temp.Replace("\t", " ").Replace("\n", " ").Replace("\r", " ");
                                tempStr += temp;
                            }
                            sw.WriteLine(tempStr);
                        }
                    }

                    MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("导出的时候出了点错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                }
            }
        }

        private void chkAnswer_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["DaAn"].Visible = this.chkAnswer.Checked;
            this.lblDAAN.Visible = this.chkAnswer.Checked;
        }

        private void chkSingleChoise_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkSingleChoise.Checked)
            {
                this.filterString.Add("单项选择题");
            }
            else
            {
                this.filterString.Remove("单项选择题");
            }

            this.FilterData(this.filterString);
        }


        private void FilterData(List<string> tixing)
        {
            
            List<TiKu> newDataSource = this.dataSource.FindAll(delegate (TiKu t)
                                                               {
                                                                   bool ret = false;
                                                                   foreach(string s in tixing)
                                                                   {
                                                                       if(t.TiXingMingCheng == s)
                                                                       {
                                                                           ret = true;
                                                                       }
                                                                   }
                                                                   return ret;
                                                               } );

            this.dataGridView1.DataSource = newDataSource;
            this.lblTiKuCount.Text = ((List<TiKu>)this.dataGridView1.DataSource).Count.ToString();
        }

        private void chkMultiChoise_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkMultiChoise.Checked)
            {
                this.filterString.Add("多项选择题");
            }
            else
            {
                this.filterString.Remove("多项选择题");
            }

            this.FilterData(this.filterString);
        }

        private void chkTrueFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkTrueFalse.Checked)
            {
                this.filterString.Add("判断题");
            }
            else
            {
                this.filterString.Remove("判断题");
            }

            this.FilterData(this.filterString);
        }

        private void chkFill_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkFill.Checked)
            {
                this.filterString.Add("填空题");
            }
            else
            {
                this.filterString.Remove("填空题");
            }

            this.FilterData(this.filterString);
        }
    }
}
