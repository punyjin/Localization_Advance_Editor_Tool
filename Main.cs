using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Localization_Editor
{
    public partial class Main : Form
    {
		// ค่า Hex สำหรับการเข้ารหัสและการถอดรหัส
        private static readonly string UeHex = "3001DA2676B9F3AB06AE32FD34DF4EACC789659950B720B5153E4B99A7F3978F";
        private static readonly string ivHex = "53F735D97B8A2943D5EDC1F7B50AB130";
        public static readonly byte[] Unity = ConvertHexStringToByteArray(UeHex);
        public static readonly byte[] IV = ConvertHexStringToByteArray(ivHex);

        public Main()
        {
            InitializeComponent();
            InitializeContextMenu();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void Main_Resize(object sender, EventArgs e)
        {
			// ปรับขนาดของ button1 ตามขนาดของ Form
            button1.Width = this.Width / 2;
            button1.Height = this.Height / 2;
        }

        private static byte[] ConvertHexStringToByteArray(string hexString)
        {
            int length = hexString.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
				// แปลง hex string เป็น byte array
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return bytes;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            Export_Raw_Data(); //เรียกใช้ฟังชั่น Export
        }

        public void Export_Raw_Data()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("ท่านยังไม่ได้นำเข้าไฟล์เข้าสู่ระบบ กรุณาลองใหม่อีกครั้ง");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string csvString = GetCSVString();
                File.WriteAllText(filePath, csvString);
                MessageBox.Show("Decrypted File exported successfully!");
            }
        }

        public void Export_Encrypted_Data()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("ท่านยังไม่ได้นำเข้าไฟล์เข้าสู่ระบบ กรุณาลองใหม่อีกครั้ง");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Encrypted Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                byte[] encryptedBytes = ResourceData.GetDataInGame.EncryptStringToBytes_SEQ(GetCSVString(), Unity, IV);
                File.WriteAllBytes(filePath, encryptedBytes);
                MessageBox.Show("File exported successfully!");
            }
        }

        public void CallImpprtFileDialog()
        {
            string filePath = ResourceData.ImportFile();
            if (!string.IsNullOrEmpty(filePath))
            {
                byte[] encryptedBytes = File.ReadAllBytes(filePath);
                string decryptedText = ResourceData.GetDataInGame.DecryptStringFromBytes_SEQ(encryptedBytes, Unity, IV);
                if (!string.IsNullOrEmpty(decryptedText) && IsEncryptedFile(decryptedText)) // ตรวจสอบว่าไฟล์ถูกเข้ารหัสหรือไม่
                {
					// แสดงข้อมูลที่ถอดรหัสในตาราง
					ClearColumns();
                    DisplayCSV(decryptedText);
                    richTextBox1.Text = filePath;
                }
                else //ถ้าไฟล์ไม่ถูกเข้ารหัสจะไม่ทำการถอดรหัสและจะส่งเข้าโปรแกรมทันที
                {
					// แสดงข้อมูลในไฟล์ที่ไม่ได้เข้ารหัส
					ClearColumns();
                    DisplayTextFile(filePath);
                    richTextBox1.Text = filePath;
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Export_Encrypted_Data();
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Loader C++ Dll Found !");
        }

        private bool IsEncryptedFile(string decryptedText)
        {
            // ในกรณีที่ข้อมูลถูกเข้ารหัส ข้อมูลที่ถูกถอดรหัสจะไม่ = null
            return !string.IsNullOrWhiteSpace(decryptedText);
        }

        private void DisplayTextFile(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            DisplayCSV(fileContent);
        }

        private string GetCSVString()
        {
            string csv = "";
            int columnsCount = dataGridView1.Columns.Count;
            // นำเข้า ส่วน headers ใน String CSV
            for (int i = 0; i < columnsCount; i++)
            {
                csv += dataGridView1.Columns[i].HeaderText;
                if (i < columnsCount - 1)
                {
                    csv += ",";
                }
            }
            csv += "\n";
            // นำเข้าข้อมูลของแถวใน String CSV
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < columnsCount; i++)
                    {
                        csv += row.Cells[i].Value;
                        if (i < columnsCount - 1)
                        {
                            csv += ",";
                        }
                    }
                    csv += "\n";
                }
            }
            return csv;
        }

        private void ClearColumns()
        {
            // ล้างคอลัมน์ในตาราง
            dataGridView1.Columns.Clear();
        }

        private void DisplayCSV(string csvData)
        {
            string[] rows = csvData.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            if (rows.Length > 0)
            {
                string[] headers = rows[0].Split(',');
                foreach (string header in headers)
                {
                    // เพิ่มคอลัมน์ตาม headers
                    dataGridView1.Columns.Add(header, header);
                }

                for (int i = 1; i < rows.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(rows[i]))
                    {
                        // เพิ่มแถวในตารางตามข้อมูล
                        dataGridView1.Rows.Add(rows[i].Split(','));
                    }
                }
            }
            // ตั้งค่า AutoSizeColumnsMode เป็น Fill
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CallImpprtFileDialog();
        }

        private void TSMI_Save_Decrypted_Click(object sender, EventArgs e)
        {
            Export_Raw_Data();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // About Me
            DateTime DateT = DateTime.Now;
            var StbDateT = DateT.ToString("MM/dd/yyyy");
            MessageBox.Show("EN: This program was created by xorbit256 for the purpose of Study programming in c# language and experiment with real users.\r\n" +
                "\r\nTH: โปรแกรมนี้ถูกสร้างขึ้นโดย xorbit256 โดยเพื่อจุดประสงค์คือการ ศึกษาโปรแกรมใน ภาษา c# และ ทดลองกับผู้ใช้งานจริง \r\n" +
                "\r\nJP: このプログラムは、xorbit256 によって次の目的で作成されました。 C# 言語でプログラミングを学習し、実際のユーザーを使って実験してみましょう。"
                , "About Me | " + StbDateT, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // ปิดโปรแกรม
        }

        private void TSMI_Save_Encrypted_Click(object sender, EventArgs e)
        {
            Export_Encrypted_Data();
        }

        private void TSMI_Open_Click(object sender, EventArgs e)
        {
            CallImpprtFileDialog();
        }

        private void TSMI_HEX_COLOR_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Hex_Color_Menu>().Count() == 1)
                Application.OpenForms.OfType<Hex_Color_Menu>().First().Close();
            var fGESEditor_User_client_interface_entry = new Hex_Color_Menu();
            fGESEditor_User_client_interface_entry.Show();
        }

        private void TSMI_XML_FILE_LOADER_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Ingame_Input_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Helper_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Helper>().Count() == 1)
                Application.OpenForms.OfType<Helper>().First().Close();
            var fGESEditor_User_client_interface_entry = new Helper();
            fGESEditor_User_client_interface_entry.Show();
        }

        private void InitializeContextMenu() // เพิ่ม ContextMenu ที่สามารถคลิ๊กขวาแล้วเลือกสี HEX ได้
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem insertHexColorMenuItem = new ToolStripMenuItem("Insert HEX Color");
            insertHexColorMenuItem.Click += new EventHandler(InsertHexColorMenuItem_Click);
            contextMenu.Items.Add(insertHexColorMenuItem);
            dataGridView1.ContextMenuStrip = contextMenu;
            dataGridView1.MouseDown += DataGridView1_MouseDown;
        }

        private void DataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                {
                    // เลือกเซลล์เมื่อคลิ๊กขวา
                    dataGridView1.ClearSelection();
                    dataGridView1[hitTestInfo.ColumnIndex, hitTestInfo.RowIndex].Selected = true;
                }
            }
        }

        private void InsertHexColorMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        Color color = colorDialog.Color;
                        string hexColor = ColorTranslator.ToHtml(color);
                        // แทรก hex color ลงในค่าปัจจุบันของเซลล์
                        string currentValue = selectedCell.Value?.ToString() ?? string.Empty;
                        string newValue = $"{currentValue}[{hexColor}] [-]";
                        selectedCell.Value = newValue;
                    }
                }
            }
        }
    }
}
