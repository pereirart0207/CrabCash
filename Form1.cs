namespace CrabCash
{
    public partial class Form1 : Form
    {

        List<Group> groups;
        public Form1()
        {
            InitializeComponent();
        }



        static void WriteToFile(string[] data, bool writeDate, string fileName)
        {
            // Obtener la ruta del directorio donde está el ejecutable y crear la carpeta "data" dentro de él
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");

            // Asegurarse de que el directorio "data" exista
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Crear la ruta completa del archivo dentro de la carpeta "data"
            string filePath = Path.Combine(directoryPath, fileName);

            // Usar StreamWriter con "true" para añadir al archivo si ya existe, o crearlo si no existe
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Escribir la fecha y hora actuales si writeDate es true
                if (writeDate)
                {
                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.Write(currentDate + "|");
                }

                // Escribir todos los elementos del arreglo en una sola línea, separados por "|"
                writer.WriteLine(string.Join("|", data));
            }
        }


        public static List<Group> GetGroups(string filePath)
        {
            List<Group> groups = new List<Group>();

            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Process each line
                foreach (string line in lines)
                {
                    // Split the line using '|' as separator
                    string[] parts = line.Split('|');

                    if (parts.Length == 4)
                    {
                        // Convert and add the data to the groups list
                        Group group = new Group
                        {
                            ID = int.Parse(parts[0]), // ID
                            Name = parts[1],           // Name
                            AllocatedMoney = decimal.Parse(parts[2]), // Allocated money
                            Prioritary = (parts[3] == "1")
                        };

                        groups.Add(group);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }

            return groups;
        }

        public static void CreateFileIfNotExists(string relativeFilePath)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), relativeFilePath);

            // Obtiene la ruta del directorio
            string directoryPath = Path.GetDirectoryName(filePath);
            try
            {
                // Verifica si el directorio existe, si no lo crea
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                    Console.WriteLine($"Directory created: {directoryPath}");
                }

                // Verifica si el archivo ya existe
                if (!File.Exists(filePath))
                {
                    // Crea el archivo si no existe
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






        private void labelSaving_Click(object sender, EventArgs e)
        {

        }


        public class Group
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal AllocatedMoney { get; set; }
            public bool Prioritary { get; set; }
            public override string ToString()
            {
                return Name; // Solo mostrar el nombre en el ComboBox
            }
        }

        void updateGroups() {
            groups = GetGroups("data/groups.yt");
            comboBoxGroups.DataSource = groups;
            listBoxGroups.DataSource = groups;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            CreateFileIfNotExists("data/groups.yt");
            CreateFileIfNotExists("data/gst.yt");
            updateGroups();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(groups.Count.ToString());
            WriteToFile(new string[] { groups.Count + 1.ToString(), textBoxGroupName.Text, textBoxDestinatedAmount.Text, (comboBoxpriority.SelectedItem.ToString() == "Prioritario").ToString() }, false, "groups.yt");
            updateGroups();
        }
    }
}
