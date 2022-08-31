using Npgsql;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace TaskTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///Function to add new task into 
        private void InsertTask()
        {
            ///Properly formats Date strings that will be added to database
            string dateCompleteBy = DateCompleteBy.Value.ToString();
            int dateCompleteBySpaceIndex = dateCompleteBy.IndexOf(" ");
            dateCompleteBy = dateCompleteBy.Substring(0, dateCompleteBySpaceIndex+1);

            string dateStartedAt = DateTime.Today.ToString();
            int dateStartedAtSpaceIndex = dateStartedAt.IndexOf(" ");
            dateStartedAt = dateStartedAt.Substring(0, dateStartedAtSpaceIndex+1);

            using (NpgsqlConnection con = GetConnection())
            {
                string query = @$"insert into public.Tasks(name,description,completeBy,startedAt)values('{TextName.Text}','{TextDescription.Text}','{dateCompleteBy}','{dateStartedAt}')";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
            }
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
            InsertTask();
            ButtonSubmit.Text = "Task Added";

            ///Clear fields after submitting a task
            TextName.Text = "";
            TextDescription.Text = "";

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

        private void DataGridTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataDridTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
                e.Value = "ASD";
        }
        private async void PopulateDataGridView()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                await using var cmd = new NpgsqlCommand("SELECT description FROM Tasks", con);
                await using var reader = await cmd.ExecuteReaderAsync();

                ///gets name/first column of SQL database
                while (await reader.ReadAsync())
                {
                    Console.WriteLine(reader.GetString(0));
                }

            }
        }


    }
}