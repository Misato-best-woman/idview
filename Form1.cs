using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IdView
{
    public partial class Form1 : Form
    {
        static readonly string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ideas;";
        static readonly string query = "SELECT * FROM ideas";
        static LinkedList<Entry> items = new LinkedList<Entry>();
        public static Entry runner;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Prepare();
            Update(runner);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            runner = items.Find(runner).Previous.Value;
            Update(runner);
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            runner = items.Find(runner).Next.Value;
            Update(runner);
        }

        public void Prepare()
        {
            // dbConnection: object that is making the current connection
            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            MySqlCommand dbCommand = new MySqlCommand(query, dbConnection);
            // Timeout is to end proccess if ti does not connect to db
            dbCommand.CommandTimeout = 60;
            try
            {
                dbConnection.Open();
                // This one obviously is to read the db data
                MySqlDataReader dbReader = dbCommand.ExecuteReader();
                if (dbReader.HasRows)
                {
                    while (dbReader.Read())
                    {
                        Entry entry = new Entry(
                            dbReader.GetString(0),
                            dbReader.GetString(1),
                            dbReader.GetString(2),
                            dbReader.GetString(3),
                            dbReader.GetString(4)
                            );
                        items.AddLast(entry);
                    }
                }
                dbConnection.Close();
                runner = items.First.Value;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Update(Entry node)
        {
            ideaImage.ImageLocation = node.path;
            descriptBox.Text = node.sideNote;
            categoryName.Text = node.category;
            if (node.isDone == "0")
            {
                isDone.Checked = false;
            }
            else
            {
                isDone.Checked = true;
            }

        }
    }
}
