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
            this.btn_CountEdit = new System.Windows.Forms.Button();
            this.btn_allCancel = new System.Windows.Forms.Button();
            this.btn_selectCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_totPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cate2 = new System.Windows.Forms.Button();
            this.btn_cate1 = new System.Windows.Forms.Button();
            this.btn_cate3 = new System.Windows.Forms.Button();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
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
            this.lbl_OrderTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_OrderTable.Location = new System.Drawing.Point(13, 14);
            this.lbl_OrderTable.Name = "lbl_OrderTable";
            this.lbl_OrderTable.Size = new System.Drawing.Size(110, 29);
            this.lbl_OrderTable.TabIndex = 1;
            this.lbl_OrderTable.Text = "n번 테이블";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_CountEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_allCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_selectCancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 511);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 62);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btn_CountEdit
            // 
            this.btn_CountEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.btn_CountEdit.FlatAppearance.BorderSize = 0;
            this.btn_CountEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CountEdit.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CountEdit.ForeColor = System.Drawing.Color.White;
            this.btn_CountEdit.Location = new System.Drawing.Point(3, 3);
            this.btn_CountEdit.Name = "btn_CountEdit";
            this.btn_CountEdit.Size = new System.Drawing.Size(137, 56);
            this.btn_CountEdit.TabIndex = 6;
            this.btn_CountEdit.Text = "수량";
            this.btn_CountEdit.UseVisualStyleBackColor = false;
            this.btn_CountEdit.Click += new System.EventHandler(this.btn_CountEdit_Click);
            // 
            // btn_allCancel
            // 
            this.btn_allCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_allCancel.FlatAppearance.BorderSize = 0;
            this.btn_allCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allCancel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_allCancel.ForeColor = System.Drawing.Color.White;
            this.btn_allCancel.Location = new System.Drawing.Point(289, 3);
            this.btn_allCancel.Name = "btn_allCancel";
            this.btn_allCancel.Size = new System.Drawing.Size(137, 56);
            this.btn_allCancel.TabIndex = 8;
            this.btn_allCancel.Text = "전체 취소";
            this.btn_allCancel.UseVisualStyleBackColor = false;
            this.btn_allCancel.Click += new System.EventHandler(this.btn_allCancel_Click);
            // 
            // btn_selectCancel
            // 
            this.btn_selectCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btn_selectCancel.FlatAppearance.BorderSize = 0;
            this.btn_selectCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectCancel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_selectCancel.ForeColor = System.Drawing.Color.White;
            this.btn_selectCancel.Location = new System.Drawing.Point(146, 3);
            this.btn_selectCancel.Name = "btn_selectCancel";
            this.btn_selectCancel.Size = new System.Drawing.Size(137, 56);
            this.btn_selectCancel.TabIndex = 7;
            this.btn_selectCancel.Text = "선택 취소";
            this.btn_selectCancel.UseVisualStyleBackColor = false;
            this.btn_selectCancel.Click += new System.EventHandler(this.btn_selectCancel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_totPrice, 1, 0);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "총액";
            // 
            // lbl_totPrice
            // 
            this.lbl_totPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_totPrice.AutoSize = true;
            this.lbl_totPrice.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_totPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_totPrice.Location = new System.Drawing.Point(340, 50);
            this.lbl_totPrice.Name = "lbl_totPrice";
            this.lbl_totPrice.Size = new System.Drawing.Size(87, 47);
            this.lbl_totPrice.TabIndex = 1;
            this.lbl_totPrice.Text = "0 원";
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
            this.btn_cate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.btn_cate2.FlatAppearance.BorderSize = 0;
            this.btn_cate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cate2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cate2.ForeColor = System.Drawing.Color.White;
            this.btn_cate2.Location = new System.Drawing.Point(347, 14);
            this.btn_cate2.Name = "btn_cate2";
            this.btn_cate2.Size = new System.Drawing.Size(166, 64);
            this.btn_cate2.TabIndex = 1;
            this.btn_cate2.Text = "식사 메뉴";
            this.btn_cate2.UseVisualStyleBackColor = false;
            this.btn_cate2.Click += new System.EventHandler(this.btn_cate2_Click);
            // 
            // btn_cate1
            // 
            this.btn_cate1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.btn_cate1.FlatAppearance.BorderSize = 0;
            this.btn_cate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cate1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cate1.ForeColor = System.Drawing.Color.White;
            this.btn_cate1.Location = new System.Drawing.Point(60, 14);
            this.btn_cate1.Name = "btn_cate1";
            this.btn_cate1.Size = new System.Drawing.Size(166, 64);
            this.btn_cate1.TabIndex = 0;
            this.btn_cate1.Text = "고기 메뉴";
            this.btn_cate1.UseVisualStyleBackColor = false;
            this.btn_cate1.Click += new System.EventHandler(this.btn_cate1_Click);
            // 
            // btn_cate3
            // 
            this.btn_cate3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cate3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.btn_cate3.FlatAppearance.BorderSize = 0;
            this.btn_cate3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cate3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cate3.ForeColor = System.Drawing.Color.White;
            this.btn_cate3.Location = new System.Drawing.Point(635, 14);
            this.btn_cate3.Name = "btn_cate3";
            this.btn_cate3.Size = new System.Drawing.Size(166, 64);
            this.btn_cate3.TabIndex = 2;
            this.btn_cate3.Text = "음료 / 주류";
            this.btn_cate3.UseVisualStyleBackColor = false;
            this.btn_cate3.Click += new System.EventHandler(this.btn_cate3_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.btn_Pay.FlatAppearance.BorderSize = 0;
            this.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pay.ForeColor = System.Drawing.Color.White;
            this.btn_Pay.Location = new System.Drawing.Point(261, 3);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(252, 90);
            this.btn_Pay.TabIndex = 8;
            this.btn_Pay.Text = "결제하기";
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Pay, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(805, 634);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(517, 96);
            this.tableLayoutPanel4.TabIndex = 9;
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
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Order_FormClosed);
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
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label lbl_totPrice;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn_Pay;
        private TableLayoutPanel tableLayoutPanel4;
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