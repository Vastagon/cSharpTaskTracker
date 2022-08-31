using Npgsql;
using System.Data;

namespace TaskTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertRecord()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                string query = @"insert into public.Tasks(Name,Fees)values('Gautum',200.0)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    TextName.Text = "Juan";
                }
            }
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            ButtonSubmit.Text = "Sent";

            //TestConnection();
            InsertRecord();

            ///Clear fields after submitting a task
            TextName.Text = "";
            //TextDescription.Text = "";

        }

        private void TextDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestConnection()
        {
            using(NpgsqlConnection con = GetConnection())
            {
                con.Open();
                if(con.State == ConnectionState.Open)
                {
                    TextDescription.Text = "Connected";
                }
            }
        }

        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=Vastagon1;Database=TaskTrackerDatabase");
        }
    }
}