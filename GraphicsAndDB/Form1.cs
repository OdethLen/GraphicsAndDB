namespace GraphicsAndDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open csv file";
            openFileDialog.Filter = "csv files |*.csv";
            if (openFileDialog.ShowDialog()!=DialogResult.OK )
            return;
            string filePath = openFileDialog.FileName;

            try
            {
                // Leer todas las líneas del archivo
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    MessageBox.Show("File is empty.");
                    return;
                }

                // Limpiar el DataGridView
                dgvAppData.Rows.Clear();
                dgvAppData.Columns.Clear();



                // Leer encabezados desde la primera línea
                string[] headers = lines[0].Split(',');

                foreach (string header in headers)
                {
                    dgvAppData.Columns.Add(header, header);
                }

                // Agregar el resto de las filas
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');
                    dgvAppData.Rows.Add(values);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }

        }
    }
}
