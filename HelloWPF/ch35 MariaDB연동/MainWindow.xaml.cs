using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ch35_MariaDB연동
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Uid=root;Database=study;port=3306;pwd=1234");
          public MainWindow()
         {
            InitializeComponent();
            LoadData();
     
       
         }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM person",conn);
            conn.Open();
            MySqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            grd.ItemsSource = dt.DefaultView;
        }

        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtAddress.Clear();
        }      
        
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {            
                if(txtName.Text.Length == 0)
            {
                MessageBox.Show("이름을 입력하여주세요");
                return;
            }
            if (txtAge.Text.Length == 0)
            {
                MessageBox.Show("나이를 입력하여주세요");
                return;
            }
            if (txtAddress.Text.Length == 0)
            {
                MessageBox.Show("주소를 입력하여주세요");
                return;
            }
            try { 
            MySqlCommand cmd = new MySqlCommand("INSERT INTO person(Name,Age,Address)Values(@Name,@Age,@Address)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("입력되었습니다.");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                LoadData();
            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE person set Name='{0}',Age='{1}',Address='{2}' Where id ='{3}'",
                    txtName.Text, txtAge.Text, txtAddress.Text, txtId.Text
                    ), conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("수정하였습니다.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
                LoadData();
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM person  Where id ='{0}'",
                    txtId.Text
                    ), conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("삭제하였습니다.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }
    }
}

