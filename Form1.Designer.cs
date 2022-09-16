namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btcong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsothunhat = new System.Windows.Forms.TextBox();
            this.txtsothuhai = new System.Windows.Forms.TextBox();
            this.bttru = new System.Windows.Forms.Button();
            this.btnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            this.rdblabel = new System.Windows.Forms.RadioButton();
            this.rdbmessageboxtext = new System.Windows.Forms.RadioButton();
            this.lnkchonmau = new System.Windows.Forms.LinkLabel();
            this.llkchonhinh = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ứng dụng tính cơ bản";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btcong
            // 
            this.btcong.Location = new System.Drawing.Point(52, 225);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(122, 42);
            this.btcong.TabIndex = 2;
            this.btcong.Text = "Cộng";
            this.btcong.UseVisualStyleBackColor = true;
            this.btcong.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập số thứ 1 :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(104, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập số thứ 2:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtsothunhat
            // 
            this.txtsothunhat.Location = new System.Drawing.Point(222, 85);
            this.txtsothunhat.Multiline = true;
            this.txtsothunhat.Name = "txtsothunhat";
            this.txtsothunhat.Size = new System.Drawing.Size(313, 20);
            this.txtsothunhat.TabIndex = 0;
            this.txtsothunhat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsothuhai
            // 
            this.txtsothuhai.Location = new System.Drawing.Point(222, 159);
            this.txtsothuhai.Name = "txtsothuhai";
            this.txtsothuhai.Size = new System.Drawing.Size(313, 23);
            this.txtsothuhai.TabIndex = 6;
            this.txtsothuhai.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bttru
            // 
            this.bttru.Location = new System.Drawing.Point(207, 225);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(122, 42);
            this.bttru.TabIndex = 8;
            this.bttru.Text = "Trừ";
            this.bttru.UseVisualStyleBackColor = true;
            // 
            // btnhan
            // 
            this.btnhan.Location = new System.Drawing.Point(368, 225);
            this.btnhan.Name = "btnhan";
            this.btnhan.Size = new System.Drawing.Size(122, 42);
            this.btnhan.TabIndex = 9;
            this.btnhan.Text = "Nhân";
            this.btnhan.UseVisualStyleBackColor = true;
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(521, 225);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(122, 42);
            this.btnchia.TabIndex = 10;
            this.btnchia.Text = "Chia";
            this.btnchia.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(85, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kết quả";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblketqua.Location = new System.Drawing.Point(207, 296);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(32, 37);
            this.lblketqua.TabIndex = 13;
            this.lblketqua.Text = "0";
            this.lblketqua.Click += new System.EventHandler(this.label6_Click);
            // 
            // rdblabel
            // 
            this.rdblabel.AutoSize = true;
            this.rdblabel.Checked = true;
            this.rdblabel.Location = new System.Drawing.Point(183, 380);
            this.rdblabel.Name = "rdblabel";
            this.rdblabel.Size = new System.Drawing.Size(76, 19);
            this.rdblabel.TabIndex = 14;
            this.rdblabel.TabStop = true;
            this.rdblabel.Text = "Trên label";
            this.rdblabel.UseVisualStyleBackColor = true;
            this.rdblabel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbmessageboxtext
            // 
            this.rdbmessageboxtext.AutoSize = true;
            this.rdbmessageboxtext.Location = new System.Drawing.Point(351, 380);
            this.rdbmessageboxtext.Name = "rdbmessageboxtext";
            this.rdbmessageboxtext.Size = new System.Drawing.Size(115, 19);
            this.rdbmessageboxtext.TabIndex = 15;
            this.rdbmessageboxtext.Text = "Message box text";
            this.rdbmessageboxtext.UseVisualStyleBackColor = true;
            // 
            // lnkchonmau
            // 
            this.lnkchonmau.AutoSize = true;
            this.lnkchonmau.Location = new System.Drawing.Point(113, 426);
            this.lnkchonmau.Name = "lnkchonmau";
            this.lnkchonmau.Size = new System.Drawing.Size(61, 15);
            this.lnkchonmau.TabIndex = 16;
            this.lnkchonmau.TabStop = true;
            this.lnkchonmau.Text = "chọn màu";
            this.lnkchonmau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkchonmau_LinkClicked);
            // 
            // llkchonhinh
            // 
            this.llkchonhinh.AutoSize = true;
            this.llkchonhinh.Location = new System.Drawing.Point(238, 426);
            this.llkchonhinh.Name = "llkchonhinh";
            this.llkchonhinh.Size = new System.Drawing.Size(61, 15);
            this.llkchonhinh.TabIndex = 17;
            this.llkchonhinh.TabStop = true;
            this.llkchonhinh.Text = "chon hinh";
            this.llkchonhinh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llkchonhinh_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llkchonhinh);
            this.Controls.Add(this.lnkchonmau);
            this.Controls.Add(this.rdbmessageboxtext);
            this.Controls.Add(this.rdblabel);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnhan);
            this.Controls.Add(this.bttru);
            this.Controls.Add(this.txtsothuhai);
            this.Controls.Add(this.txtsothunhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btcong);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btcong;
        private Label label2;
        private Label label3;
        private TextBox txtsothunhat;
        private TextBox txtsothuhai;
        private Button bttru;
        private Button btnhan;
        private Button btnchia;
        private Label label5;
        private Label lblketqua;
        private RadioButton rdblabel;
        private RadioButton rdbmessageboxtext;
        private LinkLabel lnkchonmau;
        private LinkLabel llkchonhinh;
    }
}