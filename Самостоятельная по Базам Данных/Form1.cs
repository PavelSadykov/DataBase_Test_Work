using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

namespace Самостоятельная_по_Базам_Данных
{
    public partial class DgStore : Form
    {
        SQLiteConnection conn;
        string newFilename;
        string filename;
        bool chooseDB = false;
        DataTable dtTypeGoods;
        DataTable dtNameGoods;
        DataTable dtSuppliers;
        DataTable dtStores;
        SQLiteDataAdapter adTypeGoods;
        SQLiteDataAdapter adNameGoods;
        SQLiteDataAdapter adSuppliers;
        SQLiteDataAdapter adStores;

        public DgStore()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if ( chooseDB && openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    conn = new SQLiteConnection("Data Source=" + filename);
                    conn.Open();

                    richTextBox1.ForeColor = Color.Green;
                    
                    richTextBox1.Text = "  *ON*";
                   

                }
                catch (SQLiteException ex)

                {
                    MessageBox.Show($"Ошибка подключения: {ex.Message}");
                }
        }
            else
            {
                MessageBox.Show("Сначала выберете файл с БД");
            }
        }
        private void disconnectButton_Click(object sender, EventArgs e)
            {
                try
                {
                    if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.Text = "  *OFF*";
                   
                }
                    else
                    {
                        MessageBox.Show("Соединение не установлено");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка отключения: {ex.Message}");
                }
            }

      
    private void создатьБДToolStripMenuItem1_Click(object sender, EventArgs e)
    {
          
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "SQLite Database Files|*.db;*.sqlite;*.db3|All Files|*.*";
        saveFileDialog.Title = "Create a New SQLite Database File";

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            newFilename = saveFileDialog.FileName;

                try
                {
                    SQLiteConnection.CreateFile(newFilename);
                    

                conn = new SQLiteConnection("Data Source=" + newFilename);

                   conn.Open();


                    string sqltext = @"CREATE TABLE NameGoods (
                            id INTEGER PRIMARY KEY,
                            id_TypeGoods INTEGER,
                            name TEXT
                        );
                        CREATE TABLE TypeGoods (
                            id INTEGER PRIMARY KEY,
                            name TEXT
                        );
                        CREATE TABLE Suppliers (
                            id INTEGER PRIMARY KEY,
                            name TEXT
                        );
                        CREATE TABLE Stores (
                            id INTEGER PRIMARY KEY,
                            id_TypeGoods INTEGER,
                            id_Suppliers INTEGER,
                            quantity INTEGER,
                            cost INTEGER,
                            data TEXT
                        );";
                    using (SQLiteCommand cmd = new SQLiteCommand(sqltext, conn))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    создатьБДToolStripMenuItem1.Enabled = false;
                    
                }
                catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка создания базы данных: " + ex.Message);
            }
            finally
            {
                conn.Close();
                   
                    MessageBox.Show(" База данных из 4-х таблиц  успешно создана");
                }
        }
    }
    
        
    private void выбратьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                chooseDB = true;
            }

        }


        private void сохранитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    if (adTypeGoods != null && dtTypeGoods != null)
                        adTypeGoods.Update(dtTypeGoods);
                    if (adNameGoods != null && dtNameGoods != null)
                        adNameGoods.Update(dtNameGoods);
                    if (adSuppliers != null && dtSuppliers != null)
                        adSuppliers.Update(dtSuppliers);
                    if (adStores != null && dtStores != null)
                        adStores.Update(dtStores);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранеия изменений {ex.Message}");
                }
               
            }
            else
            {
                MessageBox.Show("Нажмите кнопку *Подключить*");
            }
           
        }
       
        private void выбратьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nameGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            string tableName = clickedItem.Text;

            try
            {
                string sqltext = $"SELECT * FROM {tableName}";
               
                        dtNameGoods = new DataTable();
                        adNameGoods = new SQLiteDataAdapter(sqltext, conn);
                        adNameGoods.SelectCommand = new SQLiteCommand(sqltext, conn);
                        SQLiteCommandBuilder cb = new SQLiteCommandBuilder(adNameGoods);
                        adNameGoods.Fill(dtNameGoods);
                        DgGrid.DataSource = dtNameGoods;
                        dtNameGoods.Columns[0].AutoIncrement = true;
                        dtNameGoods.Columns[0].AutoIncrementStep = 1;//шаг
                                                                     //dtAutors.Columns[0].AutoIncrementSeed = IncrementSeed("Books");//начальная точка отсчета
                        dtNameGoods.Columns[0].AutoIncrementSeed = 1;
                  
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error working with {tableName}: {ex.Message}");
            }
           
        }
        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            string tableName = clickedItem.Text;

            try
            {
              

                string sqltext = $"SELECT * FROM {tableName}";

                dtSuppliers = new DataTable();
                adSuppliers = new SQLiteDataAdapter(sqltext, conn);
                adSuppliers.SelectCommand = new SQLiteCommand(sqltext, conn);
                SQLiteCommandBuilder cb = new SQLiteCommandBuilder(adSuppliers);
                adSuppliers.Fill(dtSuppliers);
                DgGrid.DataSource = dtSuppliers;
                dtSuppliers.Columns[0].AutoIncrement = true;
                dtSuppliers.Columns[0].AutoIncrementStep = 1;//шаг
                                                             //dtAutors.Columns[0].AutoIncrementSeed = IncrementSeed("Books");//начальная точка отсчета
                dtSuppliers.Columns[0].AutoIncrementSeed = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error working with {tableName}: {ex.Message}");
            }
            
        }
        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            string tableName = clickedItem.Text;

            try
            {
           

                string sqltext = $"SELECT * FROM {tableName}";

                dtStores = new DataTable();
                adStores = new SQLiteDataAdapter(sqltext, conn);
                adStores.SelectCommand = new SQLiteCommand(sqltext, conn);
                SQLiteCommandBuilder cb = new SQLiteCommandBuilder(adStores);
                adStores.Fill(dtStores);
                DgGrid.DataSource = dtStores;
                dtStores.Columns[0].AutoIncrement = true;
                dtStores.Columns[0].AutoIncrementStep = 1;//шаг
                                                          //dtAutors.Columns[0].AutoIncrementSeed = IncrementSeed("Books");//начальная точка отсчета
                dtStores.Columns[0].AutoIncrementSeed = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error working with {tableName}: {ex.Message}");
            }
            
        }
        private void typeGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            string tableName = clickedItem.Text;

            try
            {
                string sqltext = $"SELECT * FROM {tableName}";

                dtTypeGoods = new DataTable();
                adTypeGoods = new SQLiteDataAdapter(sqltext, conn);
                adTypeGoods.SelectCommand = new SQLiteCommand(sqltext, conn);
                SQLiteCommandBuilder cb = new SQLiteCommandBuilder(adTypeGoods);
                adTypeGoods.Fill(dtTypeGoods);
                DgGrid.DataSource = dtTypeGoods;
                dtTypeGoods.Columns[0].AutoIncrement = true;
                dtTypeGoods.Columns[0].AutoIncrementStep = 1;//шаг
                                                             //dtAutors.Columns[0].AutoIncrementSeed = IncrementSeed("Books");//начальная точка отсчета
                dtTypeGoods.Columns[0].AutoIncrementSeed = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error working with {tableName}: {ex.Message}");
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private  void buttonSelect1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)//выбран ли запрос 
            {
                string selectedOption = comboBox1.SelectedItem.ToString();
                try
                {
                    if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    {
                        string query = string.Empty;
                        switch (selectedOption)
                        {
                            case "Информаиця о товаре":
                                query = @"SELECT ng.name AS ProductName, s.*
                                  FROM NameGoods ng
                                  JOIN Stores s ON ng.id_TypeGoods = s.id_TypeGoods";
                                break;

                            case "Типы товаров":
                                query = @"SELECT * FROM NameGoods"; 
                                break;

                            case "Поставщики":
                                query = @"SELECT * FROM Suppliers";
                                break;

                            case "Товар с максимальным количеством":
                                query = @"SELECT ng.name AS ProductName, s.*
                                  FROM NameGoods ng
                                  JOIN Stores s ON ng.id_TypeGoods = s.id_TypeGoods
                                WHERE quantity = (SELECT MAX(quantity) FROM Stores);"; 
                                break;
                            case "Товар с минимальным количеством":
                                query = @"SELECT ng.name AS ProductName, s.*
                                  FROM NameGoods ng
                                  JOIN Stores s ON ng.id_TypeGoods = s.id_TypeGoods
                                WHERE quantity = (SELECT MIN(quantity) FROM Stores);";
                                break;
                            case "Товар с минимальной себестоимостью":
                                query = @"SELECT ng.name AS ProductName, s.*
                                  FROM NameGoods ng
                                  JOIN Stores s ON ng.id_TypeGoods = s.id_TypeGoods
                                        WHERE cost = (SELECT MIN(cost) FROM Stores);";
                                break;
                            case "Товар с максимальной себестоимостью":
                                query = @"SELECT ng.name AS ProductName, s.*
                                  FROM NameGoods ng
                                  JOIN Stores s ON ng.id_TypeGoods = s.id_TypeGoods
                                        WHERE cost = (SELECT MAX(cost) FROM Stores);";
                                break;
                            case "Гвозди":
                                query = @"SELECT Stores.*, NameGoods.name AS product_name
                                        FROM Stores
                                        JOIN NameGoods ON Stores.id_TypeGoods = NameGoods.id_TypeGoods
                                        WHERE NameGoods.name = 'Гвозди';";
                                break;
                            case "ООО Метпром":
                                query = @"SELECT Stores.*, NameGoods.name AS product_name
                                    FROM Stores
                                        JOIN NameGoods ON Stores.id_TypeGoods = NameGoods.id
                                    JOIN Suppliers ON Stores.id_Suppliers = Suppliers.id
                                    WHERE Suppliers.name = 'ООО Метпром';";
                                break;
                            case "Товар с максимальной длительностью хранения":
                                query = @"SELECT * FROM Stores
                                        WHERE data = (SELECT MIN(data) FROM Stores);";
                                break;
                            case "Среднее количество товаров":
                                query = @"SELECT id_TypeGoods, AVG(quantity) AS ave_quantity FROM Stores
                                        GROUP BY id_TypeGoods";
                                       
                                break;
                        }
                    if(!string.IsNullOrEmpty(query))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        DgGrid.DataSource = dataTable;
                    }
                    }
                    else
                    {
                        MessageBox.Show("Нажмите кнопку *Подключить*");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Выберите запрос перед отправкой команды.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgStore_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Информаиця о товаре") ;
            comboBox1.Items.Add("Типы товаров");
            comboBox1.Items.Add("Поставщики");
            comboBox1.Items.Add("Товар с максимальным количеством");
            comboBox1.Items.Add("Товар с минимальным количеством");
            comboBox1.Items.Add("Товар с минимальной себестоимостью");
            comboBox1.Items.Add("Товар с максимальной себестоимостью");
            comboBox1.Items.Add("Гвозди");
            comboBox1.Items.Add("ООО Метпром");
            comboBox1.Items.Add("Товар с максимальной длительностью хранения");
            comboBox1.Items.Add("Среднее количество товаров");
        }
    }
}