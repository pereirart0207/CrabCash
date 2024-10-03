using System.Globalization;

namespace CrabCash
{
    public partial class Form1 : Form
    {

        List<Group> groups = new List<Group>();
        bool imEdittingGroup = false;
        public Form1()
        {
            InitializeComponent();
        }

        static void NewPurchase(Purchase purchase, string fileName)
        {

            string[] purchaseData = {purchase.CreatedAt.ToString(), purchase.Amount.ToString(), purchase.Group.ToString(), purchase.Data.ToString() };
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {

                writer.WriteLine(string.Join("|", purchaseData));
            }
        }


        List<Purchase> GetPurchases()
        {
            List<Purchase> purchases = new List<Purchase>();
            
            string[] lines = File.ReadAllLines("data/gst.yt");

            foreach (string line in lines)
            {
                string[] items = line.Split("|");

                Purchase purchase = new Purchase
                {
                    CreatedAt = ConvertStringToDateTime(items[0]),


                };
                
            }


            return purchases;
        }


        public static string ConvertDateTimeToString(DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public static DateTime ConvertStringToDateTime(string dateString)
        {
            return DateTime.ParseExact(dateString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        } 

        public static List<Group> GetGroups(string filePath)
        {
            List<Group> groupsT = new List<Group>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');

                    if (parts.Length == 4)
                    {
                        Group group = new Group
                        (
                            name: parts[1],
                            allocatedMoney: decimal.Parse(parts[2]),
                            prioritary: (parts[3] == "True")
                        );

                        groupsT.Add(group);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }

            return groupsT;
        }

        public static void CreateFileIfNotExists(string relativeFilePath)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), relativeFilePath);

            string directoryPath = Path.GetDirectoryName(filePath);
            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                    Console.WriteLine($"Directory created: {directoryPath}");
                }

                if (!File.Exists(filePath))
                {
                    using (FileStream fs = File.Create(filePath))
                    {
                        Console.WriteLine($"File created: {filePath}");
                    }
                }
                else
                {
                    Console.WriteLine("File already exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating the file: {ex.Message}");
            }
        }

        void WriteAllGroups()
        {
            if (groups == null)
            {
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter("data/groups.yt", false))
                {
                    foreach (Group group in groups)
                    {
                        sw.WriteLine($"{group.ID}|{group.Name}|{group.AllocatedMoney}|{group.Prioritary}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir el archivo: {ex.Message}");
            }
        }

        private void labelSaving_Click(object sender, EventArgs e)
        {

        }

        public class Group
        {
            public Guid ID { get; private set; }  // Cambié el ID a Guid y lo generé automáticamente
            public string Name { get; set; }
            public decimal AllocatedMoney { get; set; }
            public bool Prioritary { get; set; }

            // Constructor que asigna el Guid por defecto
            public Group(string name, decimal allocatedMoney, bool prioritary)
            {
                ID = Guid.NewGuid();  // Genera un Guid único automáticamente
                Name = name;
                AllocatedMoney = allocatedMoney;
                Prioritary = prioritary;
            }

            public override string ToString()
            {
                return Name;
            }
        }



        
        public class Purchase {

            public DateTime CreatedAt { get; set; }
            public decimal Amount {  get; set; }
            public string Group {  get; set; }
            public string Data { get; set; }

            public Purchase() { 
            CreatedAt = DateTime.Now;
            }
        
        
        
        }



        void updateGroups()
        {
            groups = GetGroups("data/groups.yt");

            comboBoxGroups.DataSource = null;
            comboBoxGroups.DataSource = groups;

            listBoxGroups.DataSource = null;
            listBoxGroups.DataSource = groups;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            CreateFileIfNotExists("data/groups.yt");
            CreateFileIfNotExists("data/gst.yt");
            updateGroups();
            listBoxGroups.SelectedIndex = -1;
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (textBoxGroupName.Text == "" || textBoxDestinatedAmount.Text == "" || comboBoxpriority.SelectedIndex < 0)
            {
                MessageBox.Show("Campos vacíos o incorretos\n asegurese de llenar todos los campos");
                return;
            }

            if (imEdittingGroup)
            {
                btnAddGroup.Text = "Agregar";

                if (listBoxGroups.SelectedItem is Group selectedGroup)
                {
                    selectedGroup.Name = textBoxGroupName.Text;
                    selectedGroup.AllocatedMoney = decimal.Parse(textBoxDestinatedAmount.Text);
                    selectedGroup.Prioritary = (comboBoxpriority.SelectedIndex == 0);
                    listBoxGroups.Refresh();
                }

                imEdittingGroup = false;
            }
            else
            {
                bool prio = comboBoxpriority.SelectedIndex == 0;

                decimal allocatedMoney;
                if (decimal.TryParse(textBoxDestinatedAmount.Text, out allocatedMoney))
                {
                    Group group = new Group(textBoxGroupName.Text, allocatedMoney, prio);
                    groups.Add(group);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido.");
                }
            }

            WriteAllGroups();
            updateGroups();
            listBoxGroups.SelectedIndex = -1;
            textBoxDestinatedAmount.Text = "";
            textBoxGroupName.Text = "";
            EditableGroupForm(true);
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            Group selectedGroup = listBoxGroups.SelectedItem as Group;

            listBoxGroups.SelectedIndex = -1;

            if (selectedGroup != null)
            {
                groups.RemoveAll(g => g.ID == selectedGroup.ID);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un grupo antes de eliminar.");
            }

            WriteAllGroups();
            updateGroups();
            EditableGroupForm(true);
            textBoxDestinatedAmount.Clear();
            textBoxGroupName.Clear();
            comboBoxpriority.SelectedIndex = -1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditableGroupForm(false);
            if (listBoxGroups.SelectedItem != null)
            {
                Group currentGroup = listBoxGroups.SelectedItem as Group;

                if (currentGroup != null)
                {
                    textBoxDestinatedAmount.Text = currentGroup.AllocatedMoney.ToString("F2");
                    textBoxGroupName.Text = currentGroup.Name;
                    comboBoxpriority.SelectedIndex = (currentGroup.Prioritary) ? 0 : 1;
                }
            }
            else
            {
                textBoxDestinatedAmount.Clear();
                textBoxGroupName.Clear();
                comboBoxpriority.SelectedIndex = -1;
            }
        }

        void EditableGroupForm(bool editable, bool newItem = false)
        {
            buttonNew.Visible = !editable;
            btnAddGroup.Visible = editable;
            textBoxDestinatedAmount.Enabled = editable;
            textBoxGroupName.Enabled = editable;
            comboBoxpriority.Enabled = editable;

            if (newItem)
            {
                textBoxGroupName.Clear();
                textBoxDestinatedAmount.Clear();
                comboBoxpriority.SelectedIndex = -1;
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            EditableGroupForm(true, true);
        }

        private void btnGroupEdit_Click(object sender, EventArgs e)
        {
            EditableGroupForm(true);
            imEdittingGroup = true;
            btnAddGroup.Text = "Guardar cambio";
        }

        private void textBoxDestinatedAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permitir solo dígitos, un punto decimal, y teclas de control como Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Bloquear entrada no permitida
            }

            // Solo permitir un único punto decimal
            if (e.KeyChar == '.' && textBoxDestinatedAmount.Text.Contains('.'))
            {
                e.Handled = true; // Bloquear si ya hay un punto decimal
            }

        }

        private void btnAddBuy_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();

            purchase.Data = textBoxBuyInfo.Text;
            purchase.Amount = decimal.Parse(textBoxAmount.Text);

            if (comboBoxGroups.SelectedItem != null)
            {
                Group selectedGroup = comboBoxGroups.SelectedItem as Group;
                purchase.Group = selectedGroup.ID.ToString(); 

                NewPurchase(purchase, "gst.yt");
            }
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, un punto decimal, y teclas de control como Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Bloquear entrada no permitida
            }

            // Solo permitir un único punto decimal
            if (e.KeyChar == '.' && textBoxAmount.Text.Contains('.'))
            {
                e.Handled = true; // Bloquear si ya hay un punto decimal
            }
        }
    }
}
