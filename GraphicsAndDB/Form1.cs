using Microsoft.VisualBasic.FileIO;
using System.Security.Cryptography;

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
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string filePath = openFileDialog.FileName;

            using (TextFieldParser textFieldParser= new TextFieldParser(filePath))
            {
                textFieldParser.TextFieldType = FieldType.Delimited;
                textFieldParser.Delimiters = new[] { "," };
                textFieldParser.HasFieldsEnclosedInQuotes = true;

                dgvAppData.Columns.Clear();
                dgvAppData.Rows.Clear();

                // Leer encabezados
                //Si todavia quedan lineas por leer
                if (!textFieldParser.EndOfData)
                {
                    foreach (var header in textFieldParser.ReadFields())
                        dgvAppData.Columns.Add(header, header);
                }

                // Leer filas
                //Mientas que queden lineas por leer seran agregadas
                while (!textFieldParser.EndOfData)
                    dgvAppData.Rows.Add(textFieldParser.ReadFields());
            }

        }
    }
}
