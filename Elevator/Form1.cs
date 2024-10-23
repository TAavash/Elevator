using System.Data;
using System.Data.SqlClient;

namespace Elevator
{
    public partial class Form1 : Form
    {
        int liftSpeed = 5;
        bool isMovingUp = false;
        bool isMovingDown = false;

        bool isClosing = false;
        bool isOpening = false;
        int doorSpeed = 5;
        int doorMaxOpenWidth;

        bool isDoorOpen = false;

        string connectString = @"Server = AAVASHT; Database = Lift; Trusted_Connection = True";

        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            doorMaxOpenWidth = pictureBox1.Width / 2 ;
            dataGridViewLogs.ColumnCount = 2;

            dataGridViewLogs.Columns[0].Name = "Time";
            dataGridViewLogs.Columns[1].Name = "Events";

            dt.Columns.Add("Time");
            dt.Columns.Add("Events");

        }
        private void logEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");
            dt.Rows.Add(currentTime, message);
            dataGridViewLogs.Rows.Add(currentTime, message);

            InsertLogsIntoDB(dt);
        }


        private void InsertLogsIntoDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    string query = @"Insert into liftRecord(LogTIme, EventDescription) values(@Time, @Logs)";
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = new SqlCommand(query, conn);
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "Time");
                        adapter.InsertCommand.Parameters.Add("@Logs", SqlDbType.NVarChar, 255, "Events");

                        conn.Open();

                        adapter.Update(dt);
                    }
                }
            }

            catch (Exception ex) {
                MessageBox.Show("Error while saving", ex.Message);
            }
        }

        private void loadLogsFromDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    string query = @"Select LogTIme, EventDescription from liftRecord order by LogTIme desc";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Rows.Clear();

                        adapter.Fill(dt);

                        dataGridViewLogs.Rows.Clear();

                        foreach(DataRow row in dt.Rows)
                        {
                            string currentTime = Convert.ToDateTime(row["LogTIme"]).ToString("hh:mm:ss");
                            string events = row["EventDescription"].ToString();

                            dataGridViewLogs.Rows.Add(currentTime, events);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading record from DB: ", ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadLogsFromDB();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isDoorOpen) {
                logEvents("Cannot move up, the damn door is still open!");
                return;
            }

            isMovingUp = true;
            isMovingDown = false;
            button1.BackColor = Color.LightGreen;
            button2.BackColor = Color.White; // Reset the color of the down button
            button1.Enabled = false;         // Disable the up button
            button2.Enabled = false;         // Disable the down button during the movement
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMovingUp)
            {
                if (pictureBox1.Top > 0)  // Ensure the elevator doesn’t go above the top
                {
                    pictureBox1.Top -= liftSpeed;
                }
                else
                {
                    pictureBox1.Top = 0;
                    StopElevator();
                    logEvents("Mathi pugyo");

                    //button1.Enabled = true; // Enable the up button
                    //button2.Enabled = true; // Enable the down button
                }
            }

            if (isMovingDown)
            {
                if (pictureBox1.Bottom < this.ClientSize.Height) // Move down until the bottom is reached
                {
                    pictureBox1.Top += liftSpeed;
                }
                else
                {
                    pictureBox1.Top = this.ClientSize.Height - pictureBox1.Height; // Stop at the bottom
                    StopElevator();
                    logEvents("Rock Bottom");

                    //button1.Enabled = true; // Enable the up button
                    //button2.Enabled = true; // Enable the down button
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isDoorOpen)
            {
                logEvents("Cannot move down; the damn door is still open!");
                return;
            }

            isMovingDown = true;
            isMovingUp = false;
            button2.BackColor = Color.LightGreen;
            button1.BackColor = Color.White; // Reset the color of the up button
            button1.Enabled = false;         // Disable the up button during movement
            button2.Enabled = false;         // Disable the down button during movement
            timer1.Start();
        }

        private void StopElevator()
        {
            isMovingUp = false;
            isMovingDown = false;
            button1.BackColor = Color.White; // Reset the up button color
            button2.BackColor = Color.White; // Reset the down button color
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isDoorOpen)
            {
                logEvents("Lift is already opened!");
            }
            else
            {
                isOpening = true;
                isClosing = false;
                timer2.Start();
                closeBtn.Enabled = false;
                logEvents("Lift khulyo get in or get lost !!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isDoorOpen)
            {
                isOpening = false;
                isClosing = true;
                timer2.Start();
                openBtn.Enabled = false;
                logEvents("Lift banda hudaixa, don't move !!");
            }
            else
            {
                logEvents("Lift is already closed!");
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top != 0) {

                if (isOpening)
                {
                    if (leftDoor_G.Left > 0)
                    {
                        leftDoor_G.Left -= doorSpeed;
                        rightDoor_G.Left += doorSpeed;
                    }
                    else
                    {
                        timer2.Stop();
                        closeBtn.Enabled = true;
                        isDoorOpen = true;

                    }
                }

                if (isClosing)
                {
                    if (leftDoor_G.Left < doorMaxOpenWidth - 20)
                    {
                        leftDoor_G.Left += doorSpeed;
                        rightDoor_G.Left -= doorSpeed;
                    }
                    else
                    {

                        timer2.Stop();
                        openBtn.Enabled = true;
                        isDoorOpen = false;
                    }

                }
            }


            else
            {
                if (isOpening)
                {
                    if (leftDoor_T.Left > 0)
                    {
                        leftDoor_T.Left -= doorSpeed;
                        rightDoor_T.Left += doorSpeed;
                    }
                    else
                    {
                        timer2.Stop();
                        closeBtn.Enabled = true;
                        isDoorOpen = true;

                    }
                }

                if (isClosing)
                {
                    if (leftDoor_T.Left < doorMaxOpenWidth - 20)
                    {
                        leftDoor_T.Left += doorSpeed;
                        rightDoor_T.Left -= doorSpeed;
                    }
                    else
                    {

                        timer2.Stop();
                        openBtn.Enabled = true;
                        isDoorOpen = false;
                    }

                }
            }

        }

        private void dataGridViewLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
