using System.Data.SqlClient;
namespace WinFormsAppSqlConnection
{
    public partial class Form1 : Form
    {
        string connstr = @"Server=22005781peggyli;Database=test;Trusted_Connection=true;";
        DialogResult ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            SqlConnection connection=new SqlConnection(connstr);
            connection.Open();
            connection.Close();
           DialogResult ans= MessageBox.Show("連線成功");
           
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection(connstr); 
            SqlCommand cmd=conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO dbo.Product(prdt_id,prdt_name,price)VALUES(@id,@name,@price)";
            cmd.Parameters.AddWithValue("@id", txtCode.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
             ans= MessageBox.Show("新增成功","提示",MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                txtCode.Clear();
                txtName.Clear();
                txtPrice.Clear();
            }
              


        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE dbo.Product
                                SET prdt_name=@name,price=@price
                                WHERE prdt_id=@id";
            cmd.Parameters.AddWithValue("@id", txtCode.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
           ans= MessageBox.Show("修改成功");
            if (ans == DialogResult.Yes)
            {
                txtCode.Clear();
                txtName.Clear();
                txtPrice.Clear();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE FROM dbo.Product WHERE prdt_id=@id;";
            cmd.Parameters.AddWithValue("@id", txtCode.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            ans=MessageBox.Show("刪除成功");
            if (ans == DialogResult.Yes)
            {
                txtCode.Clear();
                txtName.Clear();
                txtPrice.Clear();
            }
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM dbo.Product WHERE prdt_id=@id;";
            cmd.Parameters.AddWithValue("@id", txtCode.Text);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader["prdt_name"].ToString();
                txtPrice.Text = reader["price"].ToString();
            }
            else
            {
                txtName.Clear();
                txtPrice.Clear();
            }
           
            conn.Close();
            ans=MessageBox.Show("搜尋成功");
            if (ans == DialogResult.Yes)
            {
                txtName.Clear();
                txtPrice.Clear();
            }
        }
    }
}