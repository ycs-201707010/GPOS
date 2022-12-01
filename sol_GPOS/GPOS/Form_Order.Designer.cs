namespace GPOS
{
    partial class Form_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_Orders = new System.Windows.Forms.ListView();
            this.col_No = new System.Windows.Forms.ColumnHeader();
            this.col_Name = new System.Windows.Forms.ColumnHeader();
            this.col_Count = new System.Windows.Forms.ColumnHeader();
            this.col_Cost = new System.Windows.Forms.ColumnHeader();
            this.lbl_OrderTable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_disCount = new System.Windows.Forms.Button();
            this.btn_CountEdit = new System.Windows.Forms.Button();
            this.btn_allCancel = new System.Windows.Forms.Button();
            this.btn_selectCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cate2 = new System.Windows.Forms.Button();
            this.btn_cate1 = new System.Windows.Forms.Button();
            this.btn_cate3 = new System.Windows.Forms.Button();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_doOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lv_Orders);
            this.panel1.Controls.Add(this.lbl_OrderTable);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 488);
            this.panel1.TabIndex = 0;
            // 
            // lv_Orders
            // 
            this.lv_Orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_No,
            this.col_Name,
            this.col_Count,
            this.col_Cost});
            this.lv_Orders.FullRowSelect = true;
            this.lv_Orders.GridLines = true;
            this.lv_Orders.Location = new System.Drawing.Point(13, 44);
            this.lv_Orders.MultiSelect = false;
            this.lv_Orders.Name = "lv_Orders";
            this.lv_Orders.Size = new System.Drawing.Size(404, 429);
            this.lv_Orders.TabIndex = 2;
            this.lv_Orders.UseCompatibleStateImageBehavior = false;
            this.lv_Orders.View = System.Windows.Forms.View.Details;
            // 
            // col_No
            // 
            this.col_No.Text = "No.";
            this.col_No.Width = 50;
            // 
            // col_Name
            // 
            this.col_Name.Text = "상품명";
            this.col_Name.Width = 210;
            // 
            // col_Count
            // 
            this.col_Count.Text = "수량";
            // 
            // col_Cost
            // 
            this.col_Cost.Text = "금액";
            this.col_Cost.Width = 80;
            // 
            // lbl_OrderTable
            // 
            this.lbl_OrderTable.AutoSize = true;
            this.lbl_OrderTable.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_OrderTable.Location = new System.Drawing.Point(13, 14);
            this.lbl_OrderTable.Name = "lbl_OrderTable";
            this.lbl_OrderTable.Size = new System.Drawing.Size(115, 27);
            this.lbl_OrderTable.TabIndex = 1;
            this.lbl_OrderTable.Text = "n번 테이블";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_disCount, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_CountEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_allCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_selectCancel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 511);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 62);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btn_disCount
            // 
            this.btn_disCount.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_disCount.Location = new System.Drawing.Point(324, 3);
            this.btn_disCount.Name = "btn_disCount";
            this.btn_disCount.Size = new System.Drawing.Size(101, 56);
            this.btn_disCount.TabIndex = 9;
            this.btn_disCount.Text = "할인";
            this.btn_disCount.UseVisualStyleBackColor = true;
            // 
            // btn_CountEdit
            // 
            this.btn_CountEdit.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CountEdit.Location = new System.Drawing.Point(3, 3);
            this.btn_CountEdit.Name = "btn_CountEdit";
            this.btn_CountEdit.Size = new System.Drawing.Size(101, 56);
            this.btn_CountEdit.TabIndex = 6;
            this.btn_CountEdit.Text = "수량";
            this.btn_CountEdit.UseVisualStyleBackColor = true;
            this.btn_CountEdit.Click += new System.EventHandler(this.btn_CountEdit_Click);
            // 
            // btn_allCancel
            // 
            this.btn_allCancel.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_allCancel.Location = new System.Drawing.Point(110, 3);
            this.btn_allCancel.Name = "btn_allCancel";
            this.btn_allCancel.Size = new System.Drawing.Size(101, 56);
            this.btn_allCancel.TabIndex = 8;
            this.btn_allCancel.Text = "전체 취소";
            this.btn_allCancel.UseVisualStyleBackColor = true;
            // 
            // btn_selectCancel
            // 
            this.btn_selectCancel.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_selectCancel.Location = new System.Drawing.Point(217, 3);
            this.btn_selectCancel.Name = "btn_selectCancel";
            this.btn_selectCancel.Size = new System.Drawing.Size(101, 56);
            this.btn_selectCancel.TabIndex = 7;
            this.btn_selectCancel.Text = "선택 취소";
            this.btn_selectCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightCyan;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 583);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(430, 147);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "총액";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(312, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "nn,nnn 원";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btn_cate2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_cate1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_cate3, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(459, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(863, 92);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // btn_cate2
            // 
            this.btn_cate2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cate2.Location = new System.Drawing.Point(347, 14);
            this.btn_cate2.Name = "btn_cate2";
            this.btn_cate2.Size = new System.Drawing.Size(166, 64);
            this.btn_cate2.TabIndex = 1;
            this.btn_cate2.Text = "식사 메뉴";
            this.btn_cate2.UseVisualStyleBackColor = true;
            this.btn_cate2.Click += new System.EventHandler(this.btn_cate2_Click);
            // 
            // btn_cate1
            // 
            this.btn_cate1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cate1.Location = new System.Drawing.Point(60, 14);
            this.btn_cate1.Name = "btn_cate1";
            this.btn_cate1.Size = new System.Drawing.Size(166, 64);
            this.btn_cate1.TabIndex = 0;
            this.btn_cate1.Text = "고기 메뉴";
            this.btn_cate1.UseVisualStyleBackColor = true;
            this.btn_cate1.Click += new System.EventHandler(this.btn_cate1_Click);
            // 
            // btn_cate3
            // 
            this.btn_cate3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cate3.Location = new System.Drawing.Point(635, 14);
            this.btn_cate3.Name = "btn_cate3";
            this.btn_cate3.Size = new System.Drawing.Size(166, 64);
            this.btn_cate3.TabIndex = 2;
            this.btn_cate3.Text = "음료 / 주류";
            this.btn_cate3.UseVisualStyleBackColor = true;
            this.btn_cate3.Click += new System.EventHandler(this.btn_cate3_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pay.Location = new System.Drawing.Point(3, 3);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(252, 90);
            this.btn_Pay.TabIndex = 8;
            this.btn_Pay.Text = "결제하기";
            this.btn_Pay.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_doOrder, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Pay, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(805, 634);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(517, 96);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // btn_doOrder
            // 
            this.btn_doOrder.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_doOrder.Location = new System.Drawing.Point(261, 3);
            this.btn_doOrder.Name = "btn_doOrder";
            this.btn_doOrder.Size = new System.Drawing.Size(252, 90);
            this.btn_doOrder.TabIndex = 9;
            this.btn_doOrder.Text = "주문하기";
            this.btn_doOrder.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(459, 110);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(863, 518);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 166);
            this.button2.TabIndex = 1;
            this.button2.Tag = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 166);
            this.button3.TabIndex = 2;
            this.button3.Tag = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(648, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 166);
            this.button4.TabIndex = 3;
            this.button4.Tag = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 166);
            this.button5.TabIndex = 4;
            this.button5.Tag = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(218, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(209, 166);
            this.button6.TabIndex = 5;
            this.button6.Tag = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 166);
            this.button1.TabIndex = 0;
            this.button1.Tag = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1334, 742);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Order";
            this.Load += new System.EventHandler(this.Form_Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_OrderTable;
        private ListView lv_Orders;
        private ColumnHeader col_No;
        private ColumnHeader col_Name;
        private ColumnHeader col_Count;
        private ColumnHeader col_Cost;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_allCancel;
        private Button btn_selectCancel;
        private Button btn_CountEdit;
        private Button btn_disCount;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn_Pay;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btn_doOrder;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btn_cate3;
        private Button btn_cate2;
        private Button btn_cate1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}