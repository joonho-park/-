namespace 엑셀_기업
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Grade = new System.Windows.Forms.Button();
            this.textBox_KOR = new System.Windows.Forms.TextBox();
            this.textBox_NIPA = new System.Windows.Forms.TextBox();
            this.textBox_KEDI = new System.Windows.Forms.TextBox();
            this.textBox_IBK = new System.Windows.Forms.TextBox();
            this.textBox_KDB = new System.Windows.Forms.TextBox();
            this.label_KOR = new System.Windows.Forms.Label();
            this.label_NIPA = new System.Windows.Forms.Label();
            this.label_KEDI = new System.Windows.Forms.Label();
            this.label_IBK = new System.Windows.Forms.Label();
            this.label_KDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E});
            this.dataGridView1.Location = new System.Drawing.Point(28, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(679, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.Name = "D";
            // 
            // E
            // 
            this.E.HeaderText = "E";
            this.E.Name = "E";
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(40, 8);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(93, 23);
            this.button_Load.TabIndex = 1;
            this.button_Load.Text = "엑셀가져오기";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(150, 8);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "엑셀저장";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Grade
            // 
            this.button_Grade.Location = new System.Drawing.Point(635, 389);
            this.button_Grade.Name = "button_Grade";
            this.button_Grade.Size = new System.Drawing.Size(93, 23);
            this.button_Grade.TabIndex = 3;
            this.button_Grade.Text = "총점확인";
            this.button_Grade.UseVisualStyleBackColor = true;
            this.button_Grade.Click += new System.EventHandler(this.button_Grade_Click);
            // 
            // textBox_KOR
            // 
            this.textBox_KOR.Location = new System.Drawing.Point(98, 390);
            this.textBox_KOR.Name = "textBox_KOR";
            this.textBox_KOR.Size = new System.Drawing.Size(53, 23);
            this.textBox_KOR.TabIndex = 4;
            // 
            // textBox_NIPA
            // 
            this.textBox_NIPA.Location = new System.Drawing.Point(197, 391);
            this.textBox_NIPA.Name = "textBox_NIPA";
            this.textBox_NIPA.Size = new System.Drawing.Size(46, 23);
            this.textBox_NIPA.TabIndex = 5;
            // 
            // textBox_KEDI
            // 
            this.textBox_KEDI.Location = new System.Drawing.Point(287, 390);
            this.textBox_KEDI.Name = "textBox_KEDI";
            this.textBox_KEDI.Size = new System.Drawing.Size(55, 23);
            this.textBox_KEDI.TabIndex = 6;
            // 
            // textBox_IBK
            // 
            this.textBox_IBK.Location = new System.Drawing.Point(426, 390);
            this.textBox_IBK.Name = "textBox_IBK";
            this.textBox_IBK.Size = new System.Drawing.Size(46, 23);
            this.textBox_IBK.TabIndex = 7;
            // 
            // textBox_KDB
            // 
            this.textBox_KDB.Location = new System.Drawing.Point(562, 390);
            this.textBox_KDB.Name = "textBox_KDB";
            this.textBox_KDB.Size = new System.Drawing.Size(52, 23);
            this.textBox_KDB.TabIndex = 8;
            // 
            // label_KOR
            // 
            this.label_KOR.AutoSize = true;
            this.label_KOR.Location = new System.Drawing.Point(13, 394);
            this.label_KOR.Name = "label_KOR";
            this.label_KOR.Size = new System.Drawing.Size(79, 15);
            this.label_KOR.TabIndex = 9;
            this.label_KOR.Text = "한국조폐공사";
            // 
            // label_NIPA
            // 
            this.label_NIPA.AutoSize = true;
            this.label_NIPA.Location = new System.Drawing.Point(157, 395);
            this.label_NIPA.Name = "label_NIPA";
            this.label_NIPA.Size = new System.Drawing.Size(34, 15);
            this.label_NIPA.TabIndex = 10;
            this.label_NIPA.Text = "NIPA";
            // 
            // label_KEDI
            // 
            this.label_KEDI.AutoSize = true;
            this.label_KEDI.Location = new System.Drawing.Point(249, 394);
            this.label_KEDI.Name = "label_KEDI";
            this.label_KEDI.Size = new System.Drawing.Size(32, 15);
            this.label_KEDI.TabIndex = 11;
            this.label_KEDI.Text = "KEDI";
            // 
            // label_IBK
            // 
            this.label_IBK.AutoSize = true;
            this.label_IBK.Location = new System.Drawing.Point(348, 390);
            this.label_IBK.Name = "label_IBK";
            this.label_IBK.Size = new System.Drawing.Size(72, 15);
            this.label_IBK.TabIndex = 12;
            this.label_IBK.Text = "IBK기업은행";
            // 
            // label_KDB
            // 
            this.label_KDB.AutoSize = true;
            this.label_KDB.Location = new System.Drawing.Point(478, 390);
            this.label_KDB.Name = "label_KDB";
            this.label_KDB.Size = new System.Drawing.Size(78, 15);
            this.label_KDB.TabIndex = 13;
            this.label_KDB.Text = "KDB산업은행";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_KDB);
            this.Controls.Add(this.label_IBK);
            this.Controls.Add(this.label_KEDI);
            this.Controls.Add(this.label_NIPA);
            this.Controls.Add(this.label_KOR);
            this.Controls.Add(this.textBox_KDB);
            this.Controls.Add(this.textBox_IBK);
            this.Controls.Add(this.textBox_KEDI);
            this.Controls.Add(this.textBox_NIPA);
            this.Controls.Add(this.textBox_KOR);
            this.Controls.Add(this.button_Grade);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn A;
        private DataGridViewTextBoxColumn B;
        private DataGridViewTextBoxColumn C;
        private DataGridViewTextBoxColumn D;
        private DataGridViewTextBoxColumn E;
        private Button button_Load;
        private Button button_Save;
        private OpenFileDialog openFileDialog1;
        private Button button_Grade;
        private TextBox textBox_KOR;
        private TextBox textBox_NIPA;
        private TextBox textBox_KEDI;
        private TextBox textBox_IBK;
        private TextBox textBox_KDB;
        private Label label_KOR;
        private Label label_NIPA;
        private Label label_KEDI;
        private Label label_IBK;
        private Label label_KDB;
    }
}