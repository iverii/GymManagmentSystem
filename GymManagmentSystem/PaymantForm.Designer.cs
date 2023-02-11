namespace GymManagmentSystem
{
    partial class PaymantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymantForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.PayBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            this.PaymentDGV = new System.Windows.Forms.DataGridView();
            this.MemberNamesCB = new System.Windows.Forms.ComboBox();
            this.MebmberNameTB = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(905, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 48);
            this.label3.TabIndex = 43;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(391, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 42;
            this.label2.Text = "PAYMENTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 47;
            this.label5.Text = "AMOUNT";
            // 
            // AmountTB
            // 
            this.AmountTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountTB.Location = new System.Drawing.Point(12, 295);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(208, 43);
            this.AmountTB.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "MEMBER NAME";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 43);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "PAYMENT";
            // 
            // ResetBTN
            // 
            this.ResetBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBTN.FlatAppearance.BorderSize = 0;
            this.ResetBTN.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetBTN.Location = new System.Drawing.Point(105, 344);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(115, 49);
            this.ResetBTN.TabIndex = 49;
            this.ResetBTN.Text = "RESET";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // PayBTN
            // 
            this.PayBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayBTN.FlatAppearance.BorderSize = 0;
            this.PayBTN.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PayBTN.Location = new System.Drawing.Point(8, 344);
            this.PayBTN.Name = "PayBTN";
            this.PayBTN.Size = new System.Drawing.Size(82, 49);
            this.PayBTN.TabIndex = 50;
            this.PayBTN.Text = "PAY";
            this.PayBTN.UseVisualStyleBackColor = true;
            this.PayBTN.Click += new System.EventHandler(this.PayBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBTN.FlatAppearance.BorderSize = 0;
            this.BackBTN.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackBTN.Location = new System.Drawing.Point(53, 399);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(115, 49);
            this.BackBTN.TabIndex = 51;
            this.BackBTN.Text = "BACK";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // PaymentDGV
            // 
            this.PaymentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentDGV.Location = new System.Drawing.Point(241, 174);
            this.PaymentDGV.Name = "PaymentDGV";
            this.PaymentDGV.RowHeadersWidth = 51;
            this.PaymentDGV.RowTemplate.Height = 29;
            this.PaymentDGV.Size = new System.Drawing.Size(677, 336);
            this.PaymentDGV.TabIndex = 52;
            // 
            // MemberNamesCB
            // 
            this.MemberNamesCB.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemberNamesCB.FormattingEnabled = true;
            this.MemberNamesCB.Location = new System.Drawing.Point(12, 216);
            this.MemberNamesCB.Name = "MemberNamesCB";
            this.MemberNamesCB.Size = new System.Drawing.Size(208, 35);
            this.MemberNamesCB.TabIndex = 53;
            // 
            // MebmberNameTB
            // 
            this.MebmberNameTB.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MebmberNameTB.Location = new System.Drawing.Point(310, 126);
            this.MebmberNameTB.Name = "MebmberNameTB";
            this.MebmberNameTB.Size = new System.Drawing.Size(173, 38);
            this.MebmberNameTB.TabIndex = 54;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBTN.Location = new System.Drawing.Point(500, 126);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(125, 38);
            this.SearchBTN.TabIndex = 55;
            this.SearchBTN.Text = "SEARCH";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshBTN.Location = new System.Drawing.Point(631, 126);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(140, 39);
            this.RefreshBTN.TabIndex = 56;
            this.RefreshBTN.Text = "REFRESH";
            this.RefreshBTN.UseVisualStyleBackColor = true;
            this.RefreshBTN.Click += new System.EventHandler(this.RefreshBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // PaymantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 551);
            this.Controls.Add(this.RefreshBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.MebmberNameTB);
            this.Controls.Add(this.MemberNamesCB);
            this.Controls.Add(this.PaymentDGV);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.PayBTN);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymantForm";
            this.Load += new System.EventHandler(this.PaymantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox AmountTB;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button ResetBTN;
        private Button PayBTN;
        private Button BackBTN;
        private DataGridView PaymentDGV;
        private ComboBox MemberNamesCB;
        private TextBox MebmberNameTB;
        private Button SearchBTN;
        private Button RefreshBTN;
        private PictureBox pictureBox1;
    }
}