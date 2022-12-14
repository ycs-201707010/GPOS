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
    public partial class Form_Order : Form
    {
        // 지금 어떤 메뉴 카테고리에 들어왔는지 구분하는 변수
        Boolean isMeat = true;
        Boolean isMeal = false;
        Boolean isDrink = false;

        // 누른 메뉴 버튼
        private Button selected_button;

        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.12.0;
                   Data Source=result.accdb;Mode=ReadWrite"; // 데이터베이스 연결 문자열.

        // 버튼 이미지 경로를 설정하는 배열
        static string[] MeatAssets = new string[] 
        {
                Application.StartupPath + "\\Resources\\Meat\\fork_belly.png",
                Application.StartupPath + "\\Resources\\Meat\\galmegi.png",
                Application.StartupPath + "\\Resources\\Meat\\mok.png",
                Application.StartupPath + "\\Resources\\Meat\\hangjung.png",
                Application.StartupPath + "\\Resources\\Meat\\gupdegi.png",
                Application.StartupPath + "\\Resources\\Meat\\gallby.png"
        };

        static string[] MealAssets = new string[]
        {
                Application.StartupPath + "\\Resources\\Meals\\nangmeon.png",
                Application.StartupPath + "\\Resources\\Meals\\Miso.png",
                Application.StartupPath + "\\Resources\\Meals\\kimchistew.png",
                Application.StartupPath + "\\Resources\\Meals\\chiesefriedrice.png",
                Application.StartupPath + "\\Resources\\Meals\\eggzim.png",
                Application.StartupPath + "\\Resources\\Meals\\plainRice.png"
        };

        static string[] DrinkAssets = new string[]
        {
                Application.StartupPath + "\\Resources\\drinks\\soju.png",
                Application.StartupPath + "\\Resources\\drinks\\beer_sub.png",
                Application.StartupPath + "\\Resources\\drinks\\makgulri.png",
                Application.StartupPath + "\\Resources\\drinks\\eagleflower.png",
                Application.StartupPath + "\\Resources\\drinks\\tictok.png",
                Application.StartupPath + "\\Resources\\drinks\\drink.png"
        };

        // 메뉴 구조체가 담길 배열
        // 고기 메뉴는 고기 배열에, 식사 메뉴는 식사 배열에.
        Menu[] MeatMenus = new Menu[]
        {
            new Menu("삼겹살 (150g)", 6500, MeatAssets[0]),
            new Menu("갈매기 (150g)", 6500, MeatAssets[1]),
            new Menu("목살 (150g)", 7000, MeatAssets[2]),
            new Menu("항정살 (150g)", 7000, MeatAssets[3]),
            new Menu("껍데기 (150g)", 5500, MeatAssets[4]),
            new Menu("수제 돼지갈비 (150g)", 8000, MeatAssets[5])
        };

        Menu[] MealMenus = new Menu[]
        {
            new Menu("냉면 (물/비빔)", 4500, MealAssets[0]),
            new Menu("된장찌개", 2000, MealAssets[1]),
            new Menu("김치찌개", 2000, MealAssets[2]),
            new Menu("치즈 볶음밥", 3000, MealAssets[3]),
            new Menu("계란찜", 2000, MealAssets[4]),
            new Menu("공기밥", 1000, MealAssets[5])
        };

        Menu[] DrinkMenus = new Menu[]
        {
            new Menu("소주", 4000, MealAssets[0]),
            new Menu("맥주", 4000, MealAssets[1]),
            new Menu("막걸리", 3000, MealAssets[2]),
            new Menu("매화수", 5000, MealAssets[3]),
            new Menu("이슬톡톡", 3000, MealAssets[4]),
            new Menu("음료", 2000, MealAssets[5])
        };

        // 기타
        String savelbl = "번 테이블";
        int orderTable; // 선택된 테이블 번호
        int totPrice = 0; // 선택된 테이블의 주문한 총 금액.

        public struct Menu
        {
            public Menu(string name, int price, string link)
            {
                N = name;
                P = price;
                L = link;
            }

            public string N { get; }
            public int P { get; }
            public string L { get; }
        }


        public Form_Order()
        {
            InitializeComponent();
        }

        public Form_Order(string selectedTable)
        {
            orderTable = Convert.ToInt32(selectedTable);
            
            InitializeComponent();
        }

        private void Form_Order_Load(object sender, EventArgs e)
        {
            lbl_OrderTable.Text = orderTable + savelbl;

            if (isMeat)
            {
                button1.Image = Image.FromFile(MeatAssets[0]);
                button2.Image = Image.FromFile(MeatAssets[1]);
                button3.Image = Image.FromFile(MeatAssets[2]);
                button4.Image = Image.FromFile(MeatAssets[3]);
                button5.Image = Image.FromFile(MeatAssets[4]);
                button6.Image = Image.FromFile(MeatAssets[5]);
            }

            lv_Orders_View();
            lbl_totPriceModify();
        }

        private void btn_cate1_Click(object sender, EventArgs e)
        {
            isMeat = true;

            isMeal = false;
            isDrink = false;

            button1.Image = Image.FromFile(MeatAssets[0]);
            button2.Image = Image.FromFile(MeatAssets[1]);
            button3.Image = Image.FromFile(MeatAssets[2]);
            button4.Image = Image.FromFile(MeatAssets[3]);
            button5.Image = Image.FromFile(MeatAssets[4]);
            button6.Image = Image.FromFile(MeatAssets[5]);
        }

        private void btn_cate2_Click(object sender, EventArgs e)
        {
            isMeal = true;

            isMeat = false;
            isDrink = false;

            button1.Image = Image.FromFile(MealAssets[0]);
            button2.Image = Image.FromFile(MealAssets[1]);
            button3.Image = Image.FromFile(MealAssets[2]);
            button4.Image = Image.FromFile(MealAssets[3]);
            button5.Image = Image.FromFile(MealAssets[4]);
            button6.Image = Image.FromFile(MealAssets[5]);
        }

        private void btn_cate3_Click(object sender, EventArgs e)
        {
            isDrink = true;

            isMeal = false;
            isMeat = false;

            button1.Image = Image.FromFile(DrinkAssets[0]);
            button2.Image = Image.FromFile(DrinkAssets[1]);
            button3.Image = Image.FromFile(DrinkAssets[2]);
            button4.Image = Image.FromFile(DrinkAssets[3]);
            button5.Image = Image.FromFile(DrinkAssets[4]);
            button6.Image = Image.FromFile(DrinkAssets[5]);
        }

        private void button_Click(object sender, EventArgs e)
        {
            selected_button = (Button)sender; // 어떤 버튼을 눌렀는지 버튼 객체를 받아옴
            int btnNum = Convert.ToInt32(selected_button.Tag) - 1; // 몇번 버튼을 눌렀는지 번호를 받아오고 1을 차감 (배열의 인덱스로 사용)
            int i = -1; // SQL 구문에 의해 영향을 받은 행의 개수.

            string add_menu = "";
            int menu_price = 0;
            bool is_existed = false;

            string sql; // 실행할 sql 구문

            // 선택한 버튼의 종류, 버튼의 번호에 따라 메뉴 명과 가격을 불러온다.
            if (isMeat)
            {
                add_menu = MeatMenus[btnNum].N;
                menu_price = MeatMenus[btnNum].P;
            }
            else if (isMeal)
            {
                add_menu = MealMenus[btnNum].N;
                menu_price = MealMenus[btnNum].P;
            }
            else if (isDrink)
            {
                add_menu = DrinkMenus[btnNum].N;
                menu_price = DrinkMenus[btnNum].P;
            }

            // 1. ListViewItem에서 아이템 목록을 살펴본다.
            // 2. 메뉴 명이 똑같은 아이템이 있으면 SQL 구문은 UPDATE
            // 2-1. 존재하지 않으면, SQL 구문은 INSERT 구문.
            // 3. SQL 구문을 실행.

            // 1. ListViewItem에서 아이템 목록을 살펴본다.
            for (var k = 0; k < lv_Orders.Items.Count; k++)
            {
                if (add_menu == lv_Orders.Items[k].SubItems[1].Text)
                {
                    is_existed = true;

                    break;
                }
            }

            if (is_existed) // 새로 들어온 메뉴일 경우
            {
                sql = "UPDATE t_table" + orderTable + "Order SET MenuCount = MenuCount + 1, MenuPrice = " + menu_price + " * (MenuCount + 1) WHERE MenuName = '" + add_menu + "';";
            }
            else
            {
                sql = "INSERT INTO t_table" + orderTable + "Order(MenuName, MenuCount, MenuPrice) VALUES('";

                sql += add_menu + "', " + 1 + ", " + menu_price + ")";
            }

            sql_Comm_Execute(sql); // sql 구문 실행
            lv_Orders_View(); // 바뀐 주문내역 DB를 리스트뷰에 옮겨담기
            lbl_totPriceModify(); // 변동된 총 가격을 lbl_totPrice에 반영
        }

        private void lv_Orders_View() // 데이터베이스에 반영된 주문 목록을 리스트뷰에 출력하는 메서드.
        {
            int i = 0; // No 작성시 사용
            this.lv_Orders.Items.Clear();

            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            string Sql = "SELECT * FROM t_table" + orderTable + "Order";

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

        private void lbl_totPriceModify()
        {
            totPrice = 0;
            int curPrice = 0;

            for (var k = 0; k < lv_Orders.Items.Count; k++)
            {
                curPrice = Convert.ToInt32(lv_Orders.Items[k].SubItems[3].Text);
                totPrice += curPrice;
            }

            lbl_totPrice.Text = totPrice + " 원";
        }

        private void sql_Comm_Execute(string SQL)
        {
            var Conn = new OleDbConnection(StrSQL);
            int i;

            Conn.Open();

            var Comm = new OleDbCommand(SQL, Conn);
            i = Comm.ExecuteNonQuery();

            Conn.Close();

            if (i == 0)
            {
                MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CountEdit_Click(object sender, EventArgs e)
        {
            if (lv_Orders.SelectedItems.Count == 0) // 선택한 아이템이 없다면?
            {
                MessageBox.Show("먼저 아이템을 선택해주세요", "알림",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Form_CountModify form_cm = new Form_CountModify();
            form_cm.MenuCount = lv_Orders.SelectedItems[0].SubItems[2].Text.ToString();
            form_cm.OrderTable = orderTable;
            form_cm.MenuName = lv_Orders.SelectedItems[0].SubItems[1].Text.ToString();
            form_cm.MenuPrice = lv_Orders.SelectedItems[0].SubItems[3].Text.ToString();
            form_cm.ShowDialog();


            if (form_cm.DialogResult == DialogResult.OK)
            {
                lv_Orders_View(); // 바뀐 주문내역 DB를 리스트뷰에 옮겨담기
                lbl_totPriceModify(); // 변동된 총 가격을 lbl_totPrice에 반영
            }
        }

        private void btn_allCancel_Click(object sender, EventArgs e) // 전체 취소 버튼
        {
            DialogResult mb_alert = MessageBox.Show("정말 모든 주문 내역을 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (mb_alert == DialogResult.Yes)
            {
                var Conn = new OleDbConnection(StrSQL);
                int i;

                Conn.Open();

                string sql = "DELETE FROM t_table" + orderTable + "Order";

                var Comm = new OleDbCommand(sql, Conn);
                i = Comm.ExecuteNonQuery();

                Conn.Close();

                this.lv_Orders.Items.Clear();
                lbl_totPriceModify();
            }
            else
            {
                return;
            }
        }

        private void btn_selectCancel_Click(object sender, EventArgs e)
        {
            if (lv_Orders.SelectedItems.Count == 0) // 선택한 아이템이 없다면?
            {
                MessageBox.Show("먼저 아이템을 선택해주세요", "알림",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DialogResult mb_alert = MessageBox.Show("정말 주문 내역을 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (mb_alert == DialogResult.Yes)
            {
                string MenuName = lv_Orders.SelectedItems[0].SubItems[1].Text.ToString();

                var Conn = new OleDbConnection(StrSQL);
                int i;

                Conn.Open();

                string sql = "DELETE FROM t_table" + orderTable + "Order WHERE MenuName = '" + MenuName + "'";

                var Comm = new OleDbCommand(sql, Conn);
                i = Comm.ExecuteNonQuery();

                Conn.Close();

                lv_Orders_View();
                lbl_totPriceModify();
            }
            else
            {
                return;
            }
            
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (lbl_totPrice.Text.Length == 0)
            {
                MessageBox.Show("주문 내역이 없어 결제할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form_Pay f_pay = new Form_Pay(orderTable);
            f_pay.PassValue = totPrice;
            f_pay.ShowDialog();

            if (f_pay.DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form_Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)ParentForm).pan_Order.Visible = false;
            ((Form1)ParentForm).lbl_Pos_System.Visible = true;
            ((Form1)ParentForm).btn_back.Visible = false;

            ((Form1)ParentForm).lv_Orders_View();
        }
    }
}
