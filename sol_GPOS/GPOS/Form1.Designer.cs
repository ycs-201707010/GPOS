namespace GPOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Pos_System = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_SelectedTable = new System.Windows.Forms.Label();
            this.lbl_nonSelect = new System.Windows.Forms.Label();
            this.btn_Manage = new System.Windows.Forms.Button();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.lv_Orders = new System.Windows.Forms.ListView();
            this.col_No = new System.Windows.Forms.ColumnHeader();
            this.col_Name = new System.Windows.Forms.ColumnHeader();
            this.col_Count = new System.Windows.Forms.ColumnHeader();
            this.col_Cost = new System.Windows.Forms.ColumnHeader();
            this.pan_Order = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gold;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(154, 243);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 85);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnTable_Click);
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gold;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(274, 243);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 85);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnTable_Click);
            this.btn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.lbl_Time);
            this.panel1.Controls.Add(this.lbl_Date);
            this.panel1.Controls.Add(this.lbl_Pos_System);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 74);
            this.panel1.TabIndex = 15;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(17, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 50);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("한컴 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Time.Location = new System.Drawing.Point(1157, 43);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(65, 19);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "현재시간";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("한컴 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date.Location = new System.Drawing.Point(1123, 12);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(136, 35);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "현 재 날 짜";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Pos_System
            // 
            this.lbl_Pos_System.AutoSize = true;
            this.lbl_Pos_System.Font = new System.Drawing.Font("한컴 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pos_System.Location = new System.Drawing.Point(17, 23);
            this.lbl_Pos_System.Name = "lbl_Pos_System";
            this.lbl_Pos_System.Size = new System.Drawing.Size(206, 35);
            this.lbl_Pos_System.TabIndex = 0;
            this.lbl_Pos_System.Text = "G POS SYSTEM";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.lbl_SelectedTable);
            this.panel2.Controls.Add(this.lbl_nonSelect);
            this.panel2.Location = new System.Drawing.Point(931, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 67);
            this.panel2.TabIndex = 3;
            // 
            // lbl_SelectedTable
            // 
            this.lbl_SelectedTable.AutoSize = true;
            this.lbl_SelectedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SelectedTable.Location = new System.Drawing.Point(183, 13);
            this.lbl_SelectedTable.Name = "lbl_SelectedTable";
            this.lbl_SelectedTable.Size = new System.Drawing.Size(0, 39);
            this.lbl_SelectedTable.TabIndex = 16;
            this.lbl_SelectedTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nonSelect
            // 
            this.lbl_nonSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nonSelect.AutoSize = true;
            this.lbl_nonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nonSelect.Location = new System.Drawing.Point(125, 21);
            this.lbl_nonSelect.Name = "lbl_nonSelect";
            this.lbl_nonSelect.Size = new System.Drawing.Size(147, 25);
            this.lbl_nonSelect.TabIndex = 17;
            this.lbl_nonSelect.Text = "좌석을 선택하세요";
            this.lbl_nonSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Manage
            // 
            this.btn_Manage.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Manage.Location = new System.Drawing.Point(931, 690);
            this.btn_Manage.Name = "btn_Manage";
            this.btn_Manage.Size = new System.Drawing.Size(203, 126);
            this.btn_Manage.TabIndex = 18;
            this.btn_Manage.Text = "주문관리";
            this.btn_Manage.UseVisualStyleBackColor = false;
            this.btn_Manage.Click += new System.EventHandler(this.btn_Manage_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pay.Location = new System.Drawing.Point(1134, 690);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(203, 126);
            this.btn_Pay.TabIndex = 19;
            this.btn_Pay.Text = "결제하기";
            this.btn_Pay.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gold;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(154, 360);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 85);
            this.btn6.TabIndex = 20;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnTable_Click);
            this.btn6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Gold;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(274, 360);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 85);
            this.btn7.TabIndex = 21;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnTable_Click);
            this.btn7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.Gold;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn11.Location = new System.Drawing.Point(154, 474);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(85, 85);
            this.btn11.TabIndex = 22;
            this.btn11.Text = "11";
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.btnTable_Click);
            this.btn11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.Gold;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn12.Location = new System.Drawing.Point(274, 474);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(85, 85);
            this.btn12.TabIndex = 23;
            this.btn12.Text = "12";
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.btnTable_Click);
            this.btn12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gold;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(397, 243);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 85);
            this.btn3.TabIndex = 24;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnTable_Click);
            this.btn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Gold;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(397, 360);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(85, 85);
            this.btn8.TabIndex = 25;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnTable_Click);
            this.btn8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.Gold;
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn13.Location = new System.Drawing.Point(397, 474);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(85, 85);
            this.btn13.TabIndex = 26;
            this.btn13.Text = "13";
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.btnTable_Click);
            this.btn13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gold;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(518, 243);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 85);
            this.btn4.TabIndex = 27;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnTable_Click);
            this.btn4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Gold;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(518, 360);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(85, 85);
            this.btn9.TabIndex = 28;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnTable_Click);
            this.btn9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.Gold;
            this.btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn14.Location = new System.Drawing.Point(518, 474);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(85, 85);
            this.btn14.TabIndex = 29;
            this.btn14.Text = "14";
            this.btn14.UseVisualStyleBackColor = false;
            this.btn14.Click += new System.EventHandler(this.btnTable_Click);
            this.btn14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gold;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(639, 242);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 85);
            this.btn5.TabIndex = 30;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnTable_Click);
            this.btn5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Gold;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn10.Location = new System.Drawing.Point(639, 360);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(85, 85);
            this.btn10.TabIndex = 31;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btnTable_Click);
            this.btn10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.Gold;
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn15.Location = new System.Drawing.Point(639, 474);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(85, 85);
            this.btn15.TabIndex = 32;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = false;
            this.btn15.Click += new System.EventHandler(this.btnTable_Click);
            this.btn15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseDown);
            this.btn15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTable_MouseMove);
            // 
            // lv_Orders
            // 
            this.lv_Orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_No,
            this.col_Name,
            this.col_Count,
            this.col_Cost});
            this.lv_Orders.GridLines = true;
            this.lv_Orders.Location = new System.Drawing.Point(931, 141);
            this.lv_Orders.Name = "lv_Orders";
            this.lv_Orders.Size = new System.Drawing.Size(406, 551);
            this.lv_Orders.TabIndex = 33;
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
            // pan_Order
            // 
            this.pan_Order.Location = new System.Drawing.Point(0, 74);
            this.pan_Order.Name = "pan_Order";
            this.pan_Order.Size = new System.Drawing.Size(1334, 742);
            this.pan_Order.TabIndex = 34;
            this.pan_Order.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1336, 815);
            this.Controls.Add(this.pan_Order);
            this.Controls.Add(this.lv_Orders);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn_Manage);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn14);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Panel panel1;
        private Label lbl_Pos_System;
        private Label lbl_Date;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_Time;
        private Panel panel2;
        private Label lbl_SelectedTable;
        private Button btn_Manage;
        private Button btn_Pay;
        private Button btn6;
        private Button btn7;
        private Button btn11;
        private Button btn12;
        private Button btn3;
        private Button btn8;
        private Button btn13;
        private Button btn4;
        private Button btn9;
        private Button btn14;
        private Button btn5;
        private Button btn10;
        private Button btn15;
        private Label lbl_nonSelect;
        private Button btn_back;
        private ListView lv_Orders;
        private ColumnHeader col_No;
        private ColumnHeader col_Name;
        private ColumnHeader col_Count;
        private ColumnHeader col_Cost;
        private Panel pan_Order;
    }
}