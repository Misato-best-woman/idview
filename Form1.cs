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
        private readonly string description = "Lorem impsum dolor sit amet ";
        static readonly string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ideas;";
        static readonly string query = "SELECT * FROM ideas";
        private string reading;

        LinkedList<Entry> items = new LinkedList<Entry>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            descriptBox.Text = string.Concat(Enumerable.Repeat(description, 8));
            categoryName.Text = description;
            Prepare();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (descriptBox.Text.Length != 1)
            {
                descriptBox.Text = descriptBox.Text.Substring(0, descriptBox.Text.Length / 2);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            descriptBox.Text = string.Concat(Enumerable.Repeat(descriptBox.Text, 2));
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
                /* Must set row data into Entry struct, but how???
                ** Entry entry = new Entry(rowindex(0), ..., rowindex(4));
                ** items.AddLast(entry);
                 */
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
                    Console.WriteLine(entry.id);
                    Console.WriteLine(entry.sideNote);
                    Console.WriteLine(entry.category);
                    Console.WriteLine(entry.isDone + "\n\n");
                }
                Console.WriteLine(items.Count);
                dbConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
