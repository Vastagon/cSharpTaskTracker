using System.Data;
using System.Data.SqlClient;

namespace TaskTracker
{

    public partial class Form1 : Form
    {
        SqlDataAdapter adpt;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
            refreshDataTable();
        }


        ///string query = @$"insert into public.Tasks(name,description,completeBy,startedAt)values('{TextName.Text}','{TextDescription.Text}','{dateCompleteBy}','{dateStartedAt}')";



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

            string connetionString;
            SqlConnection con;
            connetionString = "Data Source=cnt-hou-lt-1283;Initial Catalog=Tasks;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();


            string query = @$"insert into Tasks(name,description,completeBy,startedAt)values('{TextName.Text}','{TextDescription.Text}','{dateCompleteBy}','{dateStartedAt}')";
            SqlCommand cmd = new SqlCommand(query, con);
            int n = cmd.ExecuteNonQuery();

            refreshDataTable();

            con.Close();


        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            InsertTask();
            ButtonSubmit.Text = "Task Added";

            ///Clear fields after submitting a task
            TextName.Text = "";
            TextDescription.Text = "";

        }



        private async void ButtonQuery_Click(object sender, EventArgs e)
        {

        }

      

        private async void ButtonConnect_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=cnt-hou-lt-1283;Initial Catalog=Tasks;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            await using SqlCommand command = new SqlCommand("SELECT * FROM Tasks", cnn);
            await using var reader = await command.ExecuteReaderAsync();


            cnn.Close();

            refreshDataTable();

        }

        private void refreshDataTable()
        {
            SqlConnection cnn;
            string connetionString = "Data Source=cnt-hou-lt-1283;Initial Catalog=Tasks;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            ///Fills dataTable with sql data
            adpt = new SqlDataAdapter("select * from Tasks", cnn);
            dt = new DataTable();
            Console.WriteLine(dt);
            adpt.Fill(dt);
            DataGridTasks.DataSource = dt;
        }

        ///Opens a modal when clicked on that displays the information in the cell that was clicked
        private void DataGridTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(DataGridTasks.SelectedColumns[0].HeaderText);
            using(Form2 form2 = new Form2())
           {
                //form2.Text = DataGridTasks.SelectedColumns[0].HeaderText;
                form2.Text = "Text Expanded";
                form2.TextExpanded.Text = DataGridTasks.SelectedCells[0].Value + string.Empty;
                form2.ShowDialog();
            }

        }
    }
}