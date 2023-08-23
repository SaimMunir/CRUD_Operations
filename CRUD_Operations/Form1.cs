using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.AccessControl;

namespace CRUD_Operations
{
	public partial class Form1 : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=SAIM-LEGION\SQLEXPRESS;Initial Catalog=crud_project;Integrated Security=True");

		public int StudentId;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GetStudentsRecrod();
		}

		private void GetStudentsRecrod()
		{
			SqlCommand cmd = new SqlCommand("Select * from StudentsTb", con);
			DataTable dt = new DataTable();
			con.Open();
			SqlDataReader sdr = cmd.ExecuteReader();
			dt.Load(sdr);
			con.Close();

			StudentRecordView.DataSource = dt;

		}

		private void button1_Click(object sender, EventArgs e) // Update Button
		{
			if (StudentId > 0)
			{
				SqlCommand cmd = new SqlCommand("Update StudentsTb SET Name = @Name,FatherName = @FatherName,RollNumber = @RollNumber,Address = @Address,Mobile = @Mobile Where StudentID = @ID", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@Name", txt_student_name.Text);
				cmd.Parameters.AddWithValue("@FatherName", txt_father_name.Text);
				cmd.Parameters.AddWithValue("@RollNumber", txt_rollno.Text);
				cmd.Parameters.AddWithValue("@Address", txt_address.Text);
				cmd.Parameters.AddWithValue("@Mobile", txt_mobile.Text);
				cmd.Parameters.AddWithValue("@ID", StudentId);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();


				GetStudentsRecrod();
				ResetValues();
				MessageBox.Show("Student Information Is Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			MessageBox.Show("Please Select a Student to Update The Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private void button3_Click(object sender, EventArgs e) //Delete Button
		{
			if(StudentId >0)
			{
				SqlCommand cmd = new SqlCommand("Delete FROM StudentsTb Where StudentID = @ID",  con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@ID", StudentId);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();


				GetStudentsRecrod();
				ResetValues();
				MessageBox.Show("Student Is Deleted From The System", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			MessageBox.Show("Please Select a Student to Delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private void button2_Click(object sender, EventArgs e) //Insert Button
		{
			if(IsValid())
			{
				SqlCommand cmd = new SqlCommand("Insert Into StudentsTb Values(@Name,@FatherName,@RollNumber,@Address,@Mobile)", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@Name", txt_student_name.Text);
				cmd.Parameters.AddWithValue("@FatherName", txt_father_name.Text);
				cmd.Parameters.AddWithValue("@RollNumber", txt_rollno.Text);
				cmd.Parameters.AddWithValue("@Address", txt_address.Text);
				cmd.Parameters.AddWithValue("@Mobile", txt_mobile.Text);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();


				GetStudentsRecrod();
				ResetValues();
				MessageBox.Show("New Student is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private bool IsValid() //Insert Button method
		{
			if(txt_student_name.Text ==  string.Empty)
			{
				MessageBox.Show("Student Name Is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void button4_Click(object sender, EventArgs e) //reset button
		{
			ResetValues();
		}

		private void label5_Click(object sender, EventArgs e)
		{
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
		}

		private void ResetValues() //reset code
		{
			StudentId = 0;
			txt_student_name.Clear();
			txt_father_name.Clear();
			txt_rollno.Clear();
			txt_address.Clear();
			txt_mobile.Clear();

			txt_student_name.Focus();
		}

		private void StudentRecordView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			StudentId = Convert.ToInt32(StudentRecordView.SelectedRows[0].Cells[0].Value);
			txt_student_name.Text = StudentRecordView.SelectedRows[0].Cells[1].Value.ToString();
			txt_father_name.Text = StudentRecordView.SelectedRows[0].Cells[2].Value.ToString();
			txt_rollno .Text = StudentRecordView.SelectedRows[0].Cells[3].Value.ToString();
			txt_address.Text = StudentRecordView.SelectedRows[0].Cells[4].Value.ToString();
			txt_mobile.Text = StudentRecordView.SelectedRows[0].Cells[5].Value.ToString();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}