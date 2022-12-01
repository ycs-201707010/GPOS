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
                Application.StartupPath + "\\Resources\\drinks\\beer.png",
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
            selected_button = (Button)sender;
            int btnNum = Convert.ToInt32(selected_button.Tag) - 1;
            int i = -1;

            if (isMeat)
            {
                var Conn = new OleDbConnection(StrSQL);

                Conn.Open();
                string Sql = "INSERT INTO t_table" + orderTable + "Order(MenuName, MenuCount, MenuPrice) VALUES('";

                Sql += MeatMenus[btnNum].N + "', " + 1 + ", " +
                    MeatMenus[btnNum].P + ")";

                var Comm = new OleDbCommand(Sql, Conn);
                i = Comm.ExecuteNonQuery();
                Conn.Close();
            }
            else if (isMeal)
            {
                var Conn = new OleDbConnection(StrSQL);

                Conn.Open();
                string Sql = "INSERT INTO t_table" + orderTable + "Order(MenuName, MenuCount, MenuPrice) VALUES('";

                Sql += MealMenus[btnNum].N + "', " + 1 + ", " +
                    MealMenus[btnNum].P + ")";

                var Comm = new OleDbCommand(Sql, Conn);
                i = Comm.ExecuteNonQuery();
                Conn.Close();
            }
            else if (isDrink)
            {
                var Conn = new OleDbConnection(StrSQL);

                Conn.Open();
                string Sql = "INSERT INTO t_table" + orderTable + "Order(MenuName, MenuCount, MenuPrice) VALUES('";

                Sql += DrinkMenus[btnNum].N + "', " + 1 + ", " +
                    DrinkMenus[btnNum].P + ")";

                var Comm = new OleDbCommand(Sql, Conn);
                i = Comm.ExecuteNonQuery();
                Conn.Close();
            }

            if (i == 0)
            {
                MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lv_Orders_View();
        }

        private void lv_Orders_View()
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

        private void btn_CountEdit_Click(object sender, EventArgs e)
        {
            // string selected_menuCount = lv_Orders.;
            Form_CountModify form_cm = new Form_CountModify();

            form_cm.ShowDialog();
        }
    }
}
