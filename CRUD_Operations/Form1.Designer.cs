namespace CRUD_Operations
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.StudentRecordView = new System.Windows.Forms.DataGridView();
			this.txt_student_name = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_father_name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_mobile = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_rollno = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_address = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.StudentRecordView)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(238, 311);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 49);
			this.button1.TabIndex = 0;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "Student:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// StudentRecordView
			// 
			this.StudentRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentRecordView.Location = new System.Drawing.Point(12, 381);
			this.StudentRecordView.Name = "StudentRecordView";
			this.StudentRecordView.RowHeadersWidth = 51;
			this.StudentRecordView.RowTemplate.Height = 24;
			this.StudentRecordView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.StudentRecordView.Size = new System.Drawing.Size(819, 196);
			this.StudentRecordView.TabIndex = 2;
			this.StudentRecordView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordView_CellClick);
			// 
			// txt_student_name
			// 
			this.txt_student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_student_name.Location = new System.Drawing.Point(130, 36);
			this.txt_student_name.Name = "txt_student_name";
			this.txt_student_name.Size = new System.Drawing.Size(207, 26);
			this.txt_student_name.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(12, 311);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 49);
			this.button2.TabIndex = 0;
			this.button2.Text = "Insert";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(478, 311);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(137, 49);
			this.button3.TabIndex = 0;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(694, 311);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(137, 49);
			this.button4.TabIndex = 0;
			this.button4.Text = "Reset";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(423, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "Father:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txt_father_name
			// 
			this.txt_father_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_father_name.Location = new System.Drawing.Point(521, 36);
			this.txt_father_name.Name = "txt_father_name";
			this.txt_father_name.Size = new System.Drawing.Size(207, 26);
			this.txt_father_name.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(423, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 36);
			this.label3.TabIndex = 1;
			this.label3.Text = "Mobile:";
			// 
			// txt_mobile
			// 
			this.txt_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_mobile.Location = new System.Drawing.Point(521, 117);
			this.txt_mobile.Name = "txt_mobile";
			this.txt_mobile.Size = new System.Drawing.Size(207, 26);
			this.txt_mobile.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 36);
			this.label4.TabIndex = 1;
			this.label4.Text = "Roll No:";
			// 
			// txt_rollno
			// 
			this.txt_rollno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_rollno.Location = new System.Drawing.Point(130, 117);
			this.txt_rollno.Name = "txt_rollno";
			this.txt_rollno.Size = new System.Drawing.Size(207, 26);
			this.txt_rollno.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 196);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 36);
			this.label5.TabIndex = 1;
			this.label5.Text = "Address:";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// txt_address
			// 
			this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_address.Location = new System.Drawing.Point(130, 202);
			this.txt_address.Name = "txt_address";
			this.txt_address.Size = new System.Drawing.Size(207, 26);
			this.txt_address.TabIndex = 3;
			this.txt_address.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(843, 598);
			this.Controls.Add(this.txt_mobile);
			this.Controls.Add(this.txt_father_name);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_address);
			this.Controls.Add(this.txt_rollno);
			this.Controls.Add(this.txt_student_name);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.StudentRecordView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Patient Information";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.StudentRecordView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView StudentRecordView;
		private System.Windows.Forms.TextBox txt_student_name;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_father_name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_mobile;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_rollno;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_address;
	}
}

