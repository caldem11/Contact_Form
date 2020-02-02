namespace Contact_Form
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.custID = new System.Windows.Forms.TextBox();
            this.custFn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custLn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.custAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.custSt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.custZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.custPh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.custPh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.custZip);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.custSt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.custAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.custLn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.custFn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.custID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 243);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(174, 243);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 3;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(255, 243);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(75, 23);
            this.bntUpdate.TabIndex = 4;
            this.bntUpdate.Text = "Update";
            this.bntUpdate.UseVisualStyleBackColor = true;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 453);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 454);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            // 
            // custID
            // 
            this.custID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerID", true));
            this.custID.Location = new System.Drawing.Point(101, 15);
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(191, 22);
            this.custID.TabIndex = 0;
            // 
            // custFn
            // 
            this.custFn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "First_name", true));
            this.custFn.Location = new System.Drawing.Point(101, 43);
            this.custFn.Name = "custFn";
            this.custFn.Size = new System.Drawing.Size(191, 22);
            this.custFn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // custLn
            // 
            this.custLn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Last_Name", true));
            this.custLn.Location = new System.Drawing.Point(101, 71);
            this.custLn.Name = "custLn";
            this.custLn.Size = new System.Drawing.Size(191, 22);
            this.custLn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // custAdd
            // 
            this.custAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.custAdd.Location = new System.Drawing.Point(99, 99);
            this.custAdd.Multiline = true;
            this.custAdd.Name = "custAdd";
            this.custAdd.Size = new System.Drawing.Size(191, 79);
            this.custAdd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // custSt
            // 
            this.custSt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "State", true));
            this.custSt.Location = new System.Drawing.Point(391, 100);
            this.custSt.Name = "custSt";
            this.custSt.Size = new System.Drawing.Size(140, 22);
            this.custSt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "State:";
            // 
            // custZip
            // 
            this.custZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Zipcode", true));
            this.custZip.Location = new System.Drawing.Point(391, 128);
            this.custZip.Name = "custZip";
            this.custZip.Size = new System.Drawing.Size(140, 22);
            this.custZip.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zipcode:";
            // 
            // custPh
            // 
            this.custPh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
            this.custPh.Location = new System.Drawing.Point(391, 156);
            this.custPh.Name = "custPh";
            this.custPh.Size = new System.Drawing.Size(140, 22);
            this.custPh.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone:";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Contact_Form.Customer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 484);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bntUpdate);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Input";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox custPh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox custZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox custSt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custLn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custFn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}

