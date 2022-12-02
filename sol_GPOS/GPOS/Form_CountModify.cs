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

namespace GPOS
{
    public partial class Form_CountModify : Form
    {
        public Form_CountModify()
        {
            InitializeComponent();
        }

        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.12.0;
                   Data Source=result.accdb;Mode=ReadWrite";

        public string MenuCount // 수량
        {
            get;
            set;
        }

        public int OrderTable // 주문한 테이블 번호
        {
            get;
            set;
        }

        public string MenuName // 선택한 메뉴의 이름
        {
            get;
            set;
        }

        public string MenuPrice
        {
            get;
            set;
        }

        string sql;


        private void Form_CountModify_Load(object sender, EventArgs e)
        {
            txt_Count.Text = MenuCount;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            sql = "UPDATE t_table" + OrderTable + "Order SET MenuCount = " + txt_Count.Text + ", MenuPrice = (" + MenuPrice + " / MenuCount) * " + txt_Count.Text + " WHERE MenuName = '" + MenuName + "';";

            var Conn = new OleDbConnection(StrSQL);
            int i;

            Conn.Open();

            var Comm = new OleDbCommand(sql, Conn);
            i = Comm.ExecuteNonQuery();

            Conn.Close();

            if (i == 0)
            {
                MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            int minus_Count = Convert.ToInt32(txt_Count.Text) - 1;

            if (minus_Count == 0)
            {
                MessageBox.Show("수량은 1 이상으로만 입력 가능합니다", "에러",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            txt_Count.Text = minus_Count.ToString();
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            int plus_Count = Convert.ToInt32(txt_Count.Text) + 1;
            txt_Count.Text = plus_Count.ToString();
        }
    }
}
