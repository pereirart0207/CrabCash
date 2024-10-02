namespace CrabCash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        static void WriteToFile(string amount, string group)
        {
            // Get the path of the executable's directory and create a "data" folder within it
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");

            // Ensure that the "data" directory exists
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            // Create the full file path within the "data" folder
            string filePath = Path.Combine(directoryPath, "gst.yt");

            // Use StreamWriter with "true" to append to the file if it exists, or create it if it doesn't
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Get the current date and time
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                // Write the date, values separated by "|", and then go to the next line
                writer.WriteLine($"{currentDate}|{amount}|{group}");
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

                    if (parts.Length == 3)
                    {
                        // Convert and add the data to the groups list
                        Group group = new Group
                        {
                            ID = int.Parse(parts[0]), // ID
                            Name = parts[1],           // Name
                            AllocatedMoney = decimal.Parse(parts[2]) // Allocated money
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
            public override string ToString()
            {
                return Name; // Solo mostrar el nombre en el ComboBox
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            CreateFileIfNotExists("data/groups.yt");
            CreateFileIfNotExists("data/gst.yt");
            List<Group> groups = GetGroups("data/groups.yt");
            comboBoxGroups.DataSource = groups;
        }
    }
}
