using System;
using System.ComponentModel;
using System.IO;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace 엑셀_기업
{
    public partial class Form1 : Form
    {

        public List<string> list = new List<string>();
        public int Kor = 0;
        public int NIPA = 0;
        public int KEDI = 0;
        public int IBK = 0;
        public int KDB = 0;
        #region constructor

        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        public string 한국조폐공사
        {
            get;set;
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = null;
            Excel.Workbook xlworkbook = null;
            Excel.Worksheet Xlworksheet = null;
            list.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel File (*.xlsx)|*xlsx|Excel File 97~2003 (*.xls)|*.xls|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dataGridView1.Columns.Clear();

                    DataTable dt = new DataTable();

                    xlApp = new Excel.Application();
                    xlworkbook = xlApp.Workbooks.Open(ofd.FileName);
                    Xlworksheet = (Excel.Worksheet)xlworkbook.Worksheets.get_Item(1);

                    Excel.Range range = Xlworksheet.UsedRange;

                    object[,] data = range.Value;

                    for (int i = 5; i > 0; i--)
                    {
                        dt.Columns.Add(i.ToString(), typeof(string));
                    }

                    for (int r = 1; r < range.Rows.Count+1; r++)
                    {
                        DataRow dr = dt.Rows.Add();
                        for (int c = 1; c < range.Columns.Count+1; c++)
                        {
                            dr[c - 1] = data[r, c];
                            list.Add(data[r, c].ToString());
                        }
                    }

                    xlworkbook.Close(true);
                    xlApp.Quit();

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    ReleaseExcelObject(Xlworksheet);
                    ReleaseExcelObject(xlworkbook);
                    ReleaseExcelObject(xlApp);
                }
            }
        }
        private void ReleaseExcelObject(object obj)
        {
            try
            {
                if(obj !=null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch(Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }
        private void button_Save_Click(object sender, EventArgs e)
        {

        }

        private void button_Grade_Click(object sender, EventArgs e)
        {
            int k = 5;
            Kor = 0;
            NIPA = 0;
            KEDI = 0;
            IBK = 0;
            KDB = 0;
            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i].ToString())
                {
                    case "한국조폐공사":
                        Kor+= +k;
                        break;
                    case "NIPA":
                        NIPA+=k;
                        break;
                    case "KEDI":
                        KEDI+=k;
                        break;
                    case "IBK기업은행":
                        IBK+=k;
                        break;
                    case "KDB산업은행":
                        KDB+=k;
                        break;
                    default:
                        break;
                }
                k--;
                if(k==0)
                {
                    k = 5;
                }
            }
            this.textBox_IBK.Text = IBK.ToString();
            this.textBox_KDB.Text = KDB.ToString();
            this.textBox_KEDI.Text = KEDI.ToString();
            this.textBox_NIPA.Text = NIPA.ToString();
            this.textBox_KOR.Text = Kor.ToString();
           
        }
    }
}