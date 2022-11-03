using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;

namespace WagTool
{
    
    public partial class MainScreen : Form
    {

        string savePath = "Raport-LuksiWaga.csv";
       
        string sqlConnectionConfig = $"{IOController.connectionString}";
        DateTime startTime;
        DateTime endTime;
        TimeSpan diffTime;
        bool hasStarted = false;
        bool sqlWorking = false; 
        bool ioException = false;
        double totalWeight = 0;
        double tonsPerHourValue = 1;

        public MainScreen()
        {
            InitializeComponent();
            currentDateTimeValue.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            updateSqlConnectionStatus();
           
        }


        public void updateDb()
        {
            SqlConnection con = new SqlConnection(sqlConnectionConfig);
            
            try
            {
                con.Open(); 
                string material = selectMaterial.GetItemText(selectMaterial.SelectedItem).ToString();
                SqlCommand cmd = new SqlCommand($"insert into dane (czas_rozpoczecia,czas_zakonczenia,czas_trwania,material,waga) values ('{startTime}','{endTime}','{diffTime}','{material}','{totalWeight}')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                saveToCsvBtn.Enabled = true;
            }
            catch(Exception sqlUpdateException)
            {
                MessageBox.Show($"Brak połączenia z bazą danych! DANE NIE ZOSTANĄ ZAPISANE. Spisz je ręcznie. Zresetuj program. \n \n {sqlUpdateException}", "UWAGA!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                saveToCsvBtn.Enabled = false;
                sqlWorking = false;
            }
          }   

        public string GetConnectionString()
        {
            return sqlConnectionConfig;
        }
        public string GetCSV()
        {
            using(SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();
                return CreateCSV(new SqlCommand("select id,czas_rozpoczecia,czas_zakonczenia,czas_trwania,material,waga from dane", conn).ExecuteReader());
            }
        }
        public string CreateCSV(IDataReader reader)
        {
            string file = savePath;
            
            List<string> lines = new List<string>();

            string headerLine = "";

            string[] columns = new string[reader.FieldCount];
            for(int i=0; i<reader.FieldCount;i++)
            {
                columns[i] = reader.GetName(i);
            }
            headerLine = string.Join(",", columns);
            lines.Add(headerLine);

            while(reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                lines.Add(string.Join(",", values));
            }

            try
            {
                System.IO.File.WriteAllLines(file, lines);
                ioException = false;
            }
            catch (System.IO.IOException e)
            {
                MessageBox.Show("Zamknij program LibreOffice Calc aby zapisać plik i spróbuj ponownie!","Błąd zapisu!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                ioException = true;
            }

            if(!ioException) 
                MessageBox.Show("Zapisano raport na pulpicie pod nazwą \"Raport-LuksiWaga.csv\". Kliknij dwukrotnie ten plik, aby uruchomić go w arkuszu kalkulacyjnym.", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return file;
        }

        private void currentDateTime_Tick(object sender, EventArgs e)
        {
            currentDateTimeValue.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
        private void saveToCsvBtn_Click(object sender, EventArgs e)
        {    
            GetCSV(); 
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (selectMaterial.SelectedItem != null)
            {
                totalWeight = 0;
                startTime = DateTime.Now;
                startTimeValue.Text = startTime.ToString();
                countDiffTime.Text = "-";
                stopTimeValue.Text = "-";
                hasStarted = true;
                toolStripProgressBar1.Visible = true;
                toolStripStatusLabel1.Visible = true;
                startBtn.Enabled = false;
                startBtn.BackColor = Color.Empty;
                saveToCsvBtn.Enabled = false;
                selectMaterial.Enabled = false;
                tonsPerHour.Text = tonsPerHourValue.ToString();

                countWeightTimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Wybierz materiał!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if(hasStarted)
            {
                
                endTime = DateTime.Now;
                stopTimeValue.Text = DateTime.Now.ToString();
                diffTime = endTime.Subtract(startTime);
                countDiffTime.Text = diffTime.ToString();
                countWeightTimer.Enabled = false;
                
                updateDb();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Visible = false;
                if(sqlWorking)
                    MessageBox.Show("Pomyślnie zapisano pomiar w bazie danych","OK",MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    saveToCsvBtn.Enabled = false;
                }
                startBtn.Enabled = true;
                startBtn.BackColor = Color.LightGreen;
                selectMaterial.Enabled = true;
            }
          
            hasStarted = false;
            
        }

        public bool checkSqlConnection()
        {
            SqlConnection con = new SqlConnection(sqlConnectionConfig);
            try
            {
                con.Open();
                sqlWorking = true;
                return true;
            }
            catch (SqlException)
            {
                sqlWorking = false;
                saveToCsvBtn.Enabled = false;
                return false;
            }

        }

        public void updateSqlConnectionStatus()
        {
            if(checkSqlConnection())
            {
                sqlStatus.Text = "Połączono z bazą danych \u2713";
                sqlStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show("BŁĄD POŁĄCZENIA Z BAZĄ DANYCH! Dane nie będą zapisywane!", "Błąd połączenia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                sqlStatus.Text = "\u26A0 BŁĄD POŁĄCZENIA Z BAZĄ DANYCH!";
                sqlStatus.ForeColor = System.Drawing.Color.Red;
                sqlStatus.Font = new Font(sqlStatus.Font, FontStyle.Bold);
                
            }
        }

        private void addWeight()
        {

            totalWeight = totalWeight + tonsPerHourValue;
            tonsCalculatedValue.Invoke(new Action(delegate ()
            {
                tonsCalculatedValue.Text = totalWeight.ToString();
            }));
            

        }

        private void countWeightTimer_Tick(object sender, EventArgs e)
        {
            addWeight();
        }


    }
    public class IOController
    {
        public static readonly string DATA_SOURCE = "SQL server addr";
        public static readonly string INITIAL_CATALOG = "Db name";
        public static readonly string connectionString = $"Data Source={DATA_SOURCE}; Initial Catalog ={INITIAL_CATALOG}; Integrated Security = True; Trusted_Connection = True; TrustServerCertificate = True";
    }
}
