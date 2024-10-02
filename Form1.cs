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



        private void labelSaving_Click(object sender, EventArgs e)
        {

        }
    }
}
