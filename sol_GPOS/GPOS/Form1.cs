namespace GPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form_Order form_order;
        string selected_table = "";
        Button selected_button;
        private Point MousePoint; // ��ư�� ������ ���� ��ư�� ��ǥ�� ������ ��������

        /* ����� ���� �޼���� ��ܿ� ���� */
        private void btnTable_Click(object sender, EventArgs e)
        {
            selected_button = (Button)sender;
            selected_table = selected_button.Text;

            lbl_SelectedTable.Text = selected_table;
            lbl_nonSelect.Visible = false;
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
        }
    }
}