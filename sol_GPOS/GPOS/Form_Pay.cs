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
    public partial class Form_Pay : Form
    {
        public Form_Pay()
        {
            InitializeComponent();
        }

        public Form_Pay(int table)
        {
            payTable = table;
            InitializeComponent();
        }

        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.12.0;
                   Data Source=result.accdb;Mode=ReadWrite"; // 데이터베이스 연결 문자열.

        int payTable; // 결제할 테이블 번호
     
        private int current_pay_price = 0; // 현재까지 결제한 금액

        TextBox recent_txt;

        private void btn_exit_Click(object sender, EventArgs e) // X 버튼
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public int PassValue
        {
            get; set;
        }

        private void Form_Pay_Load(object sender, EventArgs e) // 로드 될때.
        {
            txt_tot_Price.Text = PassValue.ToString();
            this.ActiveControl = txt_Discount; // 폼이 로드가 완료되면, 가장 처음에 액티브 시킬 컨트롤은 무엇인지 설정
            recent_txt = txt_Discount;
            txt_tot_Price.Enabled = false;
            txt_Amount_Of_Payment.Enabled = false;
        }

        private void txtBox_Click(object sender, EventArgs e)
        {
            recent_txt = (TextBox)sender;
        }

        private void btn_Card_Payment_Click(object sender, EventArgs e)
        {
            txt_Cash_Payment.Text = "0";
            txt_Card_Payment.Text = txt_Amount_Of_Payment.Text;

        }

        private void btn_Cash_Payment_Click(object sender, EventArgs e)
        {
            txt_Card_Payment.Text = "0";
            txt_Cash_Payment.Text = txt_Amount_Of_Payment.Text;
        }

        private void txt_Discount_Leave(object sender, EventArgs e) // 할인액 입력 후 텍스트박스 포커스를 벗어날 때
        {
            if (txt_Discount.Text == "")
            {
                txt_Discount.Text = "0";
                txt_Amount_Of_Payment.Text = txt_tot_Price.Text;
            }
            else if (Convert.ToInt32(txt_tot_Price.Text) < Convert.ToInt32(txt_Discount.Text))
            {
                MessageBox.Show("할인액은 총 결제액을 초과할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Discount.Text = "0";
                txt_Discount.Focus();
            }
            else
            {
                int amon = Convert.ToInt32(txt_tot_Price.Text) - Convert.ToInt32(txt_Discount.Text);

                txt_Amount_Of_Payment.Text = amon.ToString();
            }
        }

        private void txt_Card_Payment_Leave(object sender, EventArgs e)
        {
            if (txt_Card_Payment.Text == "")
            {
                txt_Card_Payment.Text = "0";
                txt_Card_Payment.Focus();

                return;
            }

            if (Convert.ToInt32(txt_Amount_Of_Payment.Text) < Convert.ToInt32(txt_Card_Payment.Text))
            {
                MessageBox.Show("총 결제액을 초과할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Card_Payment.Text = "0";
                
            }
        }

        private void txt_Cash_Payment_Leave(object sender, EventArgs e)
        {
            if (txt_Cash_Payment.Text == "")
            {
                txt_Cash_Payment.Text = "0";
                txt_Cash_Payment.Focus();

                return;
            }

            if (Convert.ToInt32(txt_Amount_Of_Payment.Text) < Convert.ToInt32(txt_Cash_Payment.Text))
            {
                MessageBox.Show("총 결제액을 초과할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Cash_Payment.Text = "0";
                txt_Cash_Payment.Focus();
            }
        }

        private void txt_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txt_Discount_Leave(sender, e);
                txt_Card_Payment.Focus();
            }
        }



        private void btn_doPay_Click(object sender, EventArgs e)
        {
            int amount_don = Convert.ToInt32(txt_Amount_Of_Payment.Text);
            int card_don = Convert.ToInt32(txt_Card_Payment.Text);
            int cash_don = Convert.ToInt32(txt_Cash_Payment.Text);

            if (card_don == 0 && cash_don == 0)
            {
                MessageBox.Show("결제할 금액을 입력해 주십시오.");
            }
            else if (amount_don <= card_don + cash_don)
            {
                /*
                 * 1. 데이터베이스를 사용해서, 날짜의 결제 금액과 테이블 갯수를 증가시키고, 그 테이블의 주문 내역을 싹 지운다.
                 * 2. 결제 창을 닫는다.
                 * 3. 결제 완료 창을 띄운다.
                 */

                var Conn = new OleDbConnection(StrSQL);
                int i;

                Conn.Open();

                string sql = "DELETE FROM t_table" + payTable + "Order";

                var Comm = new OleDbCommand(sql, Conn);
                i = Comm.ExecuteNonQuery();

                Conn.Close();

                Form_Process form_Process = new Form_Process();
                form_Process.ShowDialog();

                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                current_pay_price += card_don + cash_don;
                txt_paidPrice.Text = current_pay_price.ToString();
                txt_Amount_Of_Payment.Text = (amount_don - card_don - cash_don).ToString();

                txt_Card_Payment.Text = "0";
                txt_Cash_Payment.Text = "0";

                txt_Discount.Enabled = false;
                btn_exit.Visible = false;
                Form_Process form_Process = new Form_Process();
                form_Process.ShowDialog();
            }
        }

        private void keyPadClick(object sender, EventArgs e)
        {
            recent_txt.Focus();

            if (recent_txt.Text == "0")
            {
                recent_txt.Text = ((Button)sender).Text;
            }
            else
            {
                recent_txt.Text += ((Button)sender).Text;
            }

            txt_Discount_Leave(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            recent_txt.Text = "";

            txt_Discount_Leave(sender, e);
        }
    }
}
