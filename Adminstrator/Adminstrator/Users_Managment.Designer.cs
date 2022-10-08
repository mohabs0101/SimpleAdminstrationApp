namespace Adminstrator
{
    partial class Users_Managment
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
            this.refreshBTn = new System.Windows.Forms.Button();
            this.edite_pnl = new System.Windows.Forms.Panel();
            this.changeBTN = new System.Windows.Forms.Button();
            this.delete_BTN = new System.Windows.Forms.Button();
            this.add_BTN = new System.Windows.Forms.Button();
            this.edite_BTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBTn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.privilegecombo_id = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.previligecombo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.signin_BTN = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edite_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshBTn
            // 
            this.refreshBTn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBTn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.refreshBTn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshBTn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBTn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBTn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBTn.ForeColor = System.Drawing.Color.Black;
            this.refreshBTn.Location = new System.Drawing.Point(1176, 316);
            this.refreshBTn.Name = "refreshBTn";
            this.refreshBTn.Size = new System.Drawing.Size(75, 34);
            this.refreshBTn.TabIndex = 59;
            this.refreshBTn.Text = "Refresh";
            this.refreshBTn.UseVisualStyleBackColor = false;
            this.refreshBTn.Click += new System.EventHandler(this.refreshBTn_Click_1);
            // 
            // edite_pnl
            // 
            this.edite_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edite_pnl.Controls.Add(this.changeBTN);
            this.edite_pnl.Controls.Add(this.delete_BTN);
            this.edite_pnl.Location = new System.Drawing.Point(32, 406);
            this.edite_pnl.Name = "edite_pnl";
            this.edite_pnl.Size = new System.Drawing.Size(130, 150);
            this.edite_pnl.TabIndex = 58;
            this.edite_pnl.Visible = false;
            // 
            // changeBTN
            // 
            this.changeBTN.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.changeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBTN.ForeColor = System.Drawing.Color.Black;
            this.changeBTN.Location = new System.Drawing.Point(15, 23);
            this.changeBTN.Name = "changeBTN";
            this.changeBTN.Size = new System.Drawing.Size(94, 42);
            this.changeBTN.TabIndex = 12;
            this.changeBTN.Text = "Update";
            this.changeBTN.UseVisualStyleBackColor = false;
            this.changeBTN.Click += new System.EventHandler(this.changeBTN_Click);
            // 
            // delete_BTN
            // 
            this.delete_BTN.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.delete_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_BTN.ForeColor = System.Drawing.Color.Black;
            this.delete_BTN.Location = new System.Drawing.Point(15, 80);
            this.delete_BTN.Name = "delete_BTN";
            this.delete_BTN.Size = new System.Drawing.Size(94, 42);
            this.delete_BTN.TabIndex = 11;
            this.delete_BTN.Text = "Delete";
            this.delete_BTN.UseVisualStyleBackColor = false;
            this.delete_BTN.Click += new System.EventHandler(this.button4_Click);
            // 
            // add_BTN
            // 
            this.add_BTN.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.add_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_BTN.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_BTN.ForeColor = System.Drawing.Color.Black;
            this.add_BTN.Location = new System.Drawing.Point(43, 320);
            this.add_BTN.Name = "add_BTN";
            this.add_BTN.Size = new System.Drawing.Size(110, 50);
            this.add_BTN.TabIndex = 57;
            this.add_BTN.Text = "add";
            this.add_BTN.UseVisualStyleBackColor = false;
            this.add_BTN.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // edite_BTN
            // 
            this.edite_BTN.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.edite_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edite_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edite_BTN.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edite_BTN.ForeColor = System.Drawing.Color.Black;
            this.edite_BTN.Location = new System.Drawing.Point(159, 321);
            this.edite_BTN.Name = "edite_BTN";
            this.edite_BTN.Size = new System.Drawing.Size(102, 49);
            this.edite_BTN.TabIndex = 56;
            this.edite_BTN.Text = "Edite";
            this.edite_BTN.UseVisualStyleBackColor = false;
            this.edite_BTN.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.user_id,
            this.username,
            this.firstname,
            this.lastname,
            this.password,
            this.email,
            this.privilege});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(43, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 254);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // select
            // 
            this.select.FillWeight = 40F;
            this.select.HeaderText = "select";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.Visible = false;
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.Name = "username";
            // 
            // firstname
            // 
            this.firstname.HeaderText = "firstname";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "lastname";
            this.lastname.Name = "lastname";
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // privilege
            // 
            this.privilege.HeaderText = "privilege";
            this.privilege.Name = "privilege";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.backBTn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 51);
            this.panel1.TabIndex = 61;
            // 
            // backBTn
            // 
            this.backBTn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBTn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.backBTn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBTn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTn.ForeColor = System.Drawing.Color.Black;
            this.backBTn.Location = new System.Drawing.Point(1184, 12);
            this.backBTn.Name = "backBTn";
            this.backBTn.Size = new System.Drawing.Size(92, 28);
            this.backBTn.TabIndex = 7;
            this.backBTn.Text = "Back";
            this.backBTn.UseVisualStyleBackColor = false;
            this.backBTn.Click += new System.EventHandler(this.backBTn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Users Managements";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.privilegecombo_id);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.previligecombo);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.signin_BTN);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(541, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 414);
            this.panel2.TabIndex = 91;
            // 
            // privilegecombo_id
            // 
            this.privilegecombo_id.FormattingEnabled = true;
            this.privilegecombo_id.Location = new System.Drawing.Point(477, 328);
            this.privilegecombo_id.Name = "privilegecombo_id";
            this.privilegecombo_id.Size = new System.Drawing.Size(14, 21);
            this.privilegecombo_id.TabIndex = 105;
            this.privilegecombo_id.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(74, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 104;
            this.label7.Text = "privilege";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(265, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 43);
            this.label6.TabIndex = 102;
            this.label6.Text = "signup";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // previligecombo
            // 
            this.previligecombo.FormattingEnabled = true;
            this.previligecombo.Location = new System.Drawing.Point(208, 326);
            this.previligecombo.MinimumSize = new System.Drawing.Size(250, 0);
            this.previligecombo.Name = "previligecombo";
            this.previligecombo.Size = new System.Drawing.Size(250, 21);
            this.previligecombo.TabIndex = 103;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(207, 133);
            this.textBox1.MinimumSize = new System.Drawing.Size(250, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 91;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(207, 181);
            this.textBox2.MinimumSize = new System.Drawing.Size(250, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 92;
            // 
            // signin_BTN
            // 
            this.signin_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signin_BTN.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.signin_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_BTN.FlatAppearance.BorderSize = 2;
            this.signin_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.signin_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signin_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_BTN.ForeColor = System.Drawing.Color.Black;
            this.signin_BTN.Location = new System.Drawing.Point(207, 354);
            this.signin_BTN.Name = "signin_BTN";
            this.signin_BTN.Size = new System.Drawing.Size(89, 37);
            this.signin_BTN.TabIndex = 101;
            this.signin_BTN.Text = "Save";
            this.signin_BTN.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(207, 85);
            this.textBox3.MinimumSize = new System.Drawing.Size(250, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 30);
            this.textBox3.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 100;
            this.label5.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(207, 229);
            this.textBox4.MinimumSize = new System.Drawing.Size(250, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 20);
            this.textBox4.TabIndex = 94;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 99;
            this.label4.Text = "Password";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(207, 275);
            this.textBox5.MinimumSize = new System.Drawing.Size(250, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 20);
            this.textBox5.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 98;
            this.label3.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 96;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 97;
            this.label2.Text = "Firstname";
            // 
            // Users_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1288, 747);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshBTn);
            this.Controls.Add(this.edite_pnl);
            this.Controls.Add(this.add_BTN);
            this.Controls.Add(this.edite_BTN);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "Users_Managment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users_Managment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Users_Managment_Load);
            this.edite_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel edite_pnl;
        private System.Windows.Forms.Button changeBTN;
        private System.Windows.Forms.Button delete_BTN;
        private System.Windows.Forms.Button add_BTN;
        private System.Windows.Forms.Button edite_BTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button refreshBTn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBTn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox privilegecombo_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox previligecombo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button signin_BTN;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilege;
    }
}