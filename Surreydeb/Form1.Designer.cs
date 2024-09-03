namespace Surreydeb
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
            components = new System.ComponentModel.Container();
            ServerAdress = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            List_Items = new ListView();
            pswdinform = new Label();
            setstatus = new Label();
            userinfo = new Label();
            Deviceinfo = new Label();
            pswdinf2 = new Label();
            Currentstart = new Label();
            Opentime = new Label();
            round_buton1 = new ePOSOne.btnProduct.round_buton();
            SuspendLayout();
            // 
            // ServerAdress
            // 
            ServerAdress.AcceptsTab = true;
            ServerAdress.AccessibleDescription = "Serveradress";
            ServerAdress.AccessibleName = "Please Enter Server Adress";
            ServerAdress.AllowDrop = true;
            ServerAdress.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ServerAdress.BorderStyle = BorderStyle.FixedSingle;
            ServerAdress.Cursor = Cursors.IBeam;
            ServerAdress.Font = new Font("Segoe UI", 7F);
            ServerAdress.Location = new Point(12, 14);
            ServerAdress.Multiline = true;
            ServerAdress.Name = "ServerAdress";
            ServerAdress.Size = new Size(200, 20);
            ServerAdress.TabIndex = 0;
            ServerAdress.Tag = "Please Enter Server Adress";
            ServerAdress.Text = "Please Enter server Address";
            ServerAdress.TextAlignChanged += Form1_Load;
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.AccessibleDescription = "AdminAccaddr";
            textBox1.AccessibleName = "AdminAccaddr";
            textBox1.AllowDrop = true;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 7F);
            textBox1.Location = new Point(218, 14);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 20);
            textBox1.TabIndex = 1;
            textBox1.Tag = "Please Enter Server Adress";
            textBox1.Text = "Please Enter Administrator Account";
            // 
            // textBox2
            // 
            textBox2.AcceptsTab = true;
            textBox2.AccessibleDescription = "AdminPswd";
            textBox2.AccessibleName = "AdminPswd";
            textBox2.AllowDrop = true;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 7F);
            textBox2.Location = new Point(436, 14);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 20);
            textBox2.TabIndex = 2;
            textBox2.Tag = "Please Enter Server Adress";
            textBox2.Text = "Please Enter Password";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // List_Items
            // 
            List_Items.BackColor = SystemColors.InactiveBorder;
            List_Items.Location = new Point(12, 90);
            List_Items.Name = "List_Items";
            List_Items.Size = new Size(1254, 51);
            List_Items.TabIndex = 6;
            List_Items.UseCompatibleStateImageBehavior = false;
            // 
            // pswdinform
            // 
            pswdinform.AutoSize = true;
            pswdinform.BackColor = SystemColors.InactiveBorder;
            pswdinform.Font = new Font("Arial Black", 7F);
            pswdinform.Location = new Point(23, 107);
            pswdinform.Name = "pswdinform";
            pswdinform.Size = new Size(152, 17);
            pswdinform.TabIndex = 7;
            pswdinform.Text = "Password Information";
            // 
            // setstatus
            // 
            setstatus.AutoSize = true;
            setstatus.BackColor = SystemColors.InactiveBorder;
            setstatus.Font = new Font("Arial Black", 7F);
            setstatus.Location = new Point(797, 107);
            setstatus.Name = "setstatus";
            setstatus.Size = new Size(76, 17);
            setstatus.TabIndex = 8;
            setstatus.Text = "Set Status";
            // 
            // userinfo
            // 
            userinfo.AutoSize = true;
            userinfo.BackColor = SystemColors.InactiveBorder;
            userinfo.Font = new Font("Arial Black", 7F);
            userinfo.Location = new Point(601, 107);
            userinfo.Name = "userinfo";
            userinfo.Size = new Size(119, 17);
            userinfo.TabIndex = 9;
            userinfo.Text = "User Information";
            // 
            // Deviceinfo
            // 
            Deviceinfo.AutoSize = true;
            Deviceinfo.BackColor = SystemColors.InactiveBorder;
            Deviceinfo.Font = new Font("Arial Black", 7F);
            Deviceinfo.Location = new Point(422, 107);
            Deviceinfo.Name = "Deviceinfo";
            Deviceinfo.Size = new Size(133, 17);
            Deviceinfo.TabIndex = 10;
            Deviceinfo.Text = "Device Information";
            // 
            // pswdinf2
            // 
            pswdinf2.AutoSize = true;
            pswdinf2.BackColor = SystemColors.InactiveBorder;
            pswdinf2.Font = new Font("Arial Black", 7F);
            pswdinf2.Location = new Point(227, 107);
            pswdinf2.Name = "pswdinf2";
            pswdinf2.Size = new Size(152, 17);
            pswdinf2.TabIndex = 11;
            pswdinf2.Text = "Password Information";
            // 
            // Currentstart
            // 
            Currentstart.AutoSize = true;
            Currentstart.BackColor = SystemColors.InactiveBorder;
            Currentstart.Font = new Font("Arial Black", 7F);
            Currentstart.Location = new Point(923, 107);
            Currentstart.Name = "Currentstart";
            Currentstart.Size = new Size(121, 17);
            Currentstart.TabIndex = 12;
            Currentstart.Text = "Currently Started";
            // 
            // Opentime
            // 
            Opentime.AutoSize = true;
            Opentime.BackColor = SystemColors.InactiveBorder;
            Opentime.Font = new Font("Arial Black", 7F);
            Opentime.Location = new Point(1099, 107);
            Opentime.Name = "Opentime";
            Opentime.Size = new Size(86, 17);
            Opentime.TabIndex = 13;
            Opentime.Text = "Open Times";
            // 
            // round_buton1
            // 
            round_buton1.BorderColor = Color.Silver;
            round_buton1.ButtonColor = Color.Blue;
            round_buton1.Location = new Point(653, 8);
            round_buton1.Name = "round_buton1";
            round_buton1.OnHoverBorderColor = Color.Gray;
            round_buton1.OnHoverButtonColor = Color.Yellow;
            round_buton1.OnHoverTextColor = Color.Gray;
            round_buton1.Size = new Size(94, 29);
            round_buton1.TabIndex = 16;
            round_buton1.Text = "Login";
            round_buton1.TextColor = Color.White;
            round_buton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1278, 450);
            Controls.Add(round_buton1);
            Controls.Add(Opentime);
            Controls.Add(Currentstart);
            Controls.Add(pswdinf2);
            Controls.Add(Deviceinfo);
            Controls.Add(userinfo);
            Controls.Add(setstatus);
            Controls.Add(pswdinform);
            Controls.Add(List_Items);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ServerAdress);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ServerAdress;
        private TextBox textBox1;
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ListView List_Items;
        private Label pswdinform;
        private Label setstatus;
        private Label userinfo;
        private Label Deviceinfo;
        private Label pswdinf2;
        private Label Currentstart;
        private Label Opentime;
        private ePOSOne.btnProduct.round_buton round_buton1;
    }
}
