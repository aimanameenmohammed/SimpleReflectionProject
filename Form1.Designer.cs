namespace ReflectionProject
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClassList = new System.Windows.Forms.ListBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMethodList = new System.Windows.Forms.ListBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtDLLPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblIsSelectedStatic = new System.Windows.Forms.Label();
            this.lblSelectedReturnType = new System.Windows.Forms.Label();
            this.lblSelectedName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvShowParameters = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRequired = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.flyParameters = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowParameters)).BeginInit();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lbClassList);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(9, 97);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(303, 606);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classes";
            // 
            // lbClassList
            // 
            this.lbClassList.BackColor = System.Drawing.Color.White;
            this.lbClassList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbClassList.Font = new System.Drawing.Font("Segoe UI", 12.8F, System.Drawing.FontStyle.Bold);
            this.lbClassList.ItemHeight = 30;
            this.lbClassList.Location = new System.Drawing.Point(12, 46);
            this.lbClassList.Name = "lbClassList";
            this.lbClassList.Size = new System.Drawing.Size(277, 540);
            this.lbClassList.TabIndex = 0;
            this.lbClassList.SelectedIndexChanged += new System.EventHandler(this.lbClassList_SelectedIndexChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 10;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, -1);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(15, 10);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.lbMethodList);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(319, 97);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(330, 606);
            this.guna2Panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Methods";
            // 
            // lbMethodList
            // 
            this.lbMethodList.BackColor = System.Drawing.Color.White;
            this.lbMethodList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMethodList.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbMethodList.ItemHeight = 25;
            this.lbMethodList.Location = new System.Drawing.Point(10, 46);
            this.lbMethodList.Name = "lbMethodList";
            this.lbMethodList.Size = new System.Drawing.Size(315, 525);
            this.lbMethodList.TabIndex = 0;
            this.lbMethodList.SelectedIndexChanged += new System.EventHandler(this.lbMethodList_SelectedIndexChanged);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.guna2Button1);
            this.guna2Panel3.Controls.Add(this.txtDLLPath);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel3.FillColor = System.Drawing.Color.AliceBlue;
            this.guna2Panel3.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1197, 77);
            this.guna2Panel3.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(750, 16);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(173, 52);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Browse";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtDLLPath
            // 
            this.txtDLLPath.BorderRadius = 5;
            this.txtDLLPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDLLPath.DefaultText = "";
            this.txtDLLPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDLLPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDLLPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDLLPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDLLPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDLLPath.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.txtDLLPath.ForeColor = System.Drawing.Color.Black;
            this.txtDLLPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDLLPath.Location = new System.Drawing.Point(126, 20);
            this.txtDLLPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDLLPath.Name = "txtDLLPath";
            this.txtDLLPath.PlaceholderText = "";
            this.txtDLLPath.SelectedText = "";
            this.txtDLLPath.Size = new System.Drawing.Size(605, 52);
            this.txtDLLPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "DLL File:";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel4.FillColor = System.Drawing.Color.AliceBlue;
            this.guna2Panel4.Location = new System.Drawing.Point(652, 97);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(807, 169);
            this.guna2Panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Method Details";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.lblIsSelectedStatic);
            this.guna2Panel5.Controls.Add(this.lblSelectedReturnType);
            this.guna2Panel5.Controls.Add(this.lblSelectedName);
            this.guna2Panel5.Controls.Add(this.label8);
            this.guna2Panel5.Controls.Add(this.label7);
            this.guna2Panel5.Controls.Add(this.label6);
            this.guna2Panel5.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Location = new System.Drawing.Point(3, 40);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(801, 126);
            this.guna2Panel5.TabIndex = 5;
            // 
            // lblIsSelectedStatic
            // 
            this.lblIsSelectedStatic.AutoSize = true;
            this.lblIsSelectedStatic.BackColor = System.Drawing.Color.Transparent;
            this.lblIsSelectedStatic.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblIsSelectedStatic.Location = new System.Drawing.Point(103, 90);
            this.lblIsSelectedStatic.Name = "lblIsSelectedStatic";
            this.lblIsSelectedStatic.Size = new System.Drawing.Size(35, 24);
            this.lblIsSelectedStatic.TabIndex = 8;
            this.lblIsSelectedStatic.Text = "No";
            // 
            // lblSelectedReturnType
            // 
            this.lblSelectedReturnType.AutoSize = true;
            this.lblSelectedReturnType.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedReturnType.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSelectedReturnType.Location = new System.Drawing.Point(156, 52);
            this.lblSelectedReturnType.Name = "lblSelectedReturnType";
            this.lblSelectedReturnType.Size = new System.Drawing.Size(61, 24);
            this.lblSelectedReturnType.TabIndex = 7;
            this.lblSelectedReturnType.Text = "String";
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.AutoSize = true;
            this.lblSelectedName.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSelectedName.Location = new System.Drawing.Point(103, 10);
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(104, 24);
            this.lblSelectedName.TabIndex = 6;
            this.lblSelectedName.Text = "GetName()";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Static :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(20, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Return Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name :";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel6.BorderRadius = 10;
            this.guna2Panel6.BorderThickness = 1;
            this.guna2Panel6.Controls.Add(this.dgvShowParameters);
            this.guna2Panel6.Controls.Add(this.label5);
            this.guna2Panel6.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel6.FillColor = System.Drawing.Color.AliceBlue;
            this.guna2Panel6.Location = new System.Drawing.Point(652, 272);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(807, 163);
            this.guna2Panel6.TabIndex = 5;
            // 
            // dgvShowParameters
            // 
            this.dgvShowParameters.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvShowParameters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowParameters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowParameters.ColumnHeadersHeight = 24;
            this.dgvShowParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShowParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnName,
            this.Column1,
            this.clmnRequired});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowParameters.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowParameters.GridColor = System.Drawing.Color.Black;
            this.dgvShowParameters.Location = new System.Drawing.Point(6, 37);
            this.dgvShowParameters.Name = "dgvShowParameters";
            this.dgvShowParameters.RowHeadersVisible = false;
            this.dgvShowParameters.RowHeadersWidth = 51;
            this.dgvShowParameters.RowTemplate.Height = 24;
            this.dgvShowParameters.Size = new System.Drawing.Size(793, 120);
            this.dgvShowParameters.TabIndex = 7;
            this.dgvShowParameters.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowParameters.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvShowParameters.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowParameters.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dgvShowParameters.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvShowParameters.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvShowParameters.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvShowParameters.ThemeStyle.RowsStyle.Height = 24;
            // 
            // clmnName
            // 
            this.clmnName.HeaderText = "Name";
            this.clmnName.MinimumWidth = 6;
            this.clmnName.Name = "clmnName";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Type";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // clmnRequired
            // 
            this.clmnRequired.HeaderText = "Required";
            this.clmnRequired.MinimumWidth = 6;
            this.clmnRequired.Name = "clmnRequired";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Parameters";
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel7.BorderRadius = 10;
            this.guna2Panel7.BorderThickness = 1;
            this.guna2Panel7.Controls.Add(this.flyParameters);
            this.guna2Panel7.Controls.Add(this.label12);
            this.guna2Panel7.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel7.FillColor = System.Drawing.Color.AliceBlue;
            this.guna2Panel7.Location = new System.Drawing.Point(652, 441);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(807, 262);
            this.guna2Panel7.TabIndex = 6;
            // 
            // flyParameters
            // 
            this.flyParameters.AutoScroll = true;
            this.flyParameters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flyParameters.Location = new System.Drawing.Point(8, 35);
            this.flyParameters.Name = "flyParameters";
            this.flyParameters.Size = new System.Drawing.Size(796, 224);
            this.flyParameters.TabIndex = 7;
            this.flyParameters.WrapContents = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 27);
            this.label12.TabIndex = 6;
            this.label12.Text = "Input Parameters";
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.AutoScroll = true;
            this.guna2Panel8.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel8.BorderRadius = 10;
            this.guna2Panel8.BorderThickness = 1;
            this.guna2Panel8.Controls.Add(this.dataGridView1);
            this.guna2Panel8.Controls.Add(this.lblResult);
            this.guna2Panel8.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel8.FillColor = System.Drawing.Color.AliceBlue;
            this.guna2Panel8.Location = new System.Drawing.Point(9, 812);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(1378, 229);
            this.guna2Panel8.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1371, 203);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(19, 71);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 27);
            this.lblResult.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(8, 779);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 30);
            this.label13.TabIndex = 8;
            this.label13.Text = "Results";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(652, 709);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(804, 52);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Execute";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(9, 706);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(637, 52);
            this.guna2Button3.TabIndex = 9;
            this.guna2Button3.Text = "Clear All";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1463, 1055);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.guna2Panel8);
            this.Controls.Add(this.guna2Panel7);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowParameters)).EndInit();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ListBox lbClassList;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.ListBox lbMethodList;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtDLLPath;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShowParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnRequired;
        private System.Windows.Forms.Label lblIsSelectedStatic;
        private System.Windows.Forms.Label lblSelectedReturnType;
        private System.Windows.Forms.Label lblSelectedName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.FlowLayoutPanel flyParameters;
        private System.Windows.Forms.Label lblResult;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

