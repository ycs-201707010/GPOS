using System.Data.OleDb;
using System.Data;

namespace GPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source=result.accdb;Mode=Read"; // �����ͺ��̽� ���� ���ڿ�.
        Form_Order form_order;
        string selected_table = "";
        Button selected_button;
        private Point MousePoint; // ��ư�� ������ ���� ��ư�� ��ǥ�� ������ ��������

        /* ����� ���� �޼���� ��ܿ� ���� */
        private void btnTable_Click(object sender, EventArgs e)
        {
            selected_button = (Button)sender;
            selected_table = selected_button.Text;

            lbl_SelectedTable.Text = selected_table + "��";
            lbl_nonSelect.Visible = false;

            lv_Orders_View();
        }

        private void btnTable_MouseDown(object sender, MouseEventArgs e)
        {
            MousePoint = new Point(e.X, e.Y);
        }

        private void btnTable_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selected_button = (Button)sender;

                selected_button.Location = new Point(selected_button.Left - (MousePoint.X - e.X), selected_button.Top - (MousePoint.Y - e.Y));
            }
        }

        private void lv_Orders_View()
        {
            int i = 0; // No �ۼ��� ���
            this.lv_Orders.Items.Clear();

            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            string Sql = "SELECT * FROM t_table" + selected_table + "Order";

            var OleAdapter = new OleDbDataAdapter(Sql, Conn);

            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("dsTable");
            OleAdapter.Fill(ds, "dsTable");

            var query = dt.AsEnumerable().
                Select(Orderlist => new
                {
                    Name = Orderlist.Field<string>("MenuName"),
                    Count = Orderlist.Field<int>("MenuCount").ToString(),
                    Price = Orderlist.Field<int>("MenuPrice").ToString()
                });

            foreach (var ListData in query)
            {
                i++;

                var strArray = new String[] {
                    i.ToString(),
                    ListData.Name,
                    ListData.Count,
                    ListData.Price
                };

                this.lv_Orders.Items.Add(new ListViewItem(strArray));
            }
            Conn.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;
            lbl_Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lbl_Time.Text = DateTime.Now.ToString("HH�� mm�� ss��");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH�� mm�� ss��");
        }

        private void btn_Manage_Click(object sender, EventArgs e)
        {
            /*this.IsMdiContainer = true;

            Form_Order form_order = new Form_Order();
            form_order.MdiParent = this; // �ֹ����� â�� �θ� �����̳ʴ� �ٷ� ���! ��°� ������.
            form_order.Show();*/

            if (selected_table == "") // ���̺��� ���õ��� �ʾҴٸ�
            {
                MessageBox.Show("���̺��� ������ �ֽʽÿ�", "GPOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (DialogResult == DialogResult.OK)
                {
                    return;
                }
            }
            else
            {
                pan_Order.Visible = true;
                lbl_Pos_System.Visible = false;
                btn_back.Visible = true;

                form_order = new Form_Order(selected_table);
                form_order.TopLevel = false; // true�� �ϸ� ����.
                form_order.Dock = System.Windows.Forms.DockStyle.Fill;
                pan_Order.Controls.Add(form_order);
                form_order.Show();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            pan_Order.Visible = false;
            lbl_Pos_System.Visible = true;
            btn_back.Visible = false;

            form_order.Close();

            lv_Orders_View();
        }

        private void btn_Pay_Click(object sender, EventArgs e) // �����ϱ� ��ư ������ ��.
        {
            Form_Pay f_pay = new Form_Pay();
            f_pay.ShowDialog();
        }
    }
}