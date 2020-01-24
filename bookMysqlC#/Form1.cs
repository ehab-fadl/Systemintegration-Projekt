using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


/* ****
 * Author 
 * Ehab Fadl
 * 
 * 
 * 
 * */
namespace bookMysql
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=ls-68880f3e0d856d4fbf541b2e6ef9356b9fb630dc.c779hma5onlz.us-east-1.rds.amazonaws.com;
                                       Database=dbmaster;Uid=admin;Pwd=121345eafeD$;";
        int bookID = 0;
        public Form1()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("BookViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dgvBook.DataSource = dtblBook;
                dgvBook.Columns[0].Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ///////
        }

      public  void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("BookViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dgvBook.DataSource = dtblBook;
                dgvBook.Columns[0].Visible = false;
            }
        }

       public void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

       public void Clear()
        {
            txtBookName.Text = txtAuthor.Text = txtDescripiton.Text = txtSearch.Text = "";
            bookID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        public void dgvBook_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow.Index != -1)
            {
                txtBookName.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
                txtAuthor.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
                txtDescripiton.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
                bookID = Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";
                btnDelete.Enabled = Enabled;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /////
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           //////
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           //////
        }

       public void btnSave_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("BookAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_BookID", bookID);
                mySqlCmd.Parameters.AddWithValue("_BookName", txtBookName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Author", txtAuthor.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Description", txtDescripiton.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                Clear();
                GridFill();
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //////////
        }

       public void btnSearch_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("BookSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dgvBook.DataSource = dtblBook;
                dgvBook.Columns[0].Visible = false;
            }
        }

        public void btnCancel_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

       public void btnDelete_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("BookDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_BookID", bookID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();
            }
        }

        public void dgvBook_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow.Index != -1)
            {
                txtBookName.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
                txtAuthor.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
                txtDescripiton.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
                bookID = Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";
                btnDelete.Enabled = Enabled;
            }
        }

        public void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("BookSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dgvBook.DataSource = dtblBook;
                dgvBook.Columns[0].Visible = false;
            }
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
           /////
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
           //////
        }

        private void txtDescripiton_TextChanged(object sender, EventArgs e)
        {
           ////
        }

        private void txtBookName_DoubleClick(object sender, EventArgs e)
        {
            txtBookName.Text = "Book  ,Pages:    , Cost:  $";
        }

        private void txtAuthor_DoubleClick(object sender, EventArgs e)
        {
            txtAuthor.Text = "Author";
        }

        private void txtDescripiton_DoubleClick(object sender, EventArgs e)
        {
            txtDescripiton.Text = "Description: 100 Pages.\n Cost: 25$";
        }
    }
}
