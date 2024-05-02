using System;
using System.Windows.Forms;
using ClosedXML.Excel;


namespace ExcelData
{
    public partial class Form1 : Form
    {
        ListView listView;
        Button button;

        public Form1()
        {
            InitializeComponent();

            listView2 = new ListView();
            button2 = new Button();

            // Añade elementos a ListView
            listView2.Items.Add("Elemento 1");
            listView2.Items.Add("Elemento 2");
            listView2.Items.Add("Elemento 3");

            // Añade el evento Click al botón
            button2.Click += Button2_Click;

            // Añade los controles al formulario
            Controls.Add(listView2);
            Controls.Add(button2);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Crea un nuevo libro de trabajo
            var workbook = new XLWorkbook();

            // Añade una hoja de trabajo
            var worksheet = workbook.Worksheets.Add("Hoja1");

            // Escribe los datos de ListView en la hoja de trabajo
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                worksheet.Cell(i + 1, 1).Value = listView2.Items[i].Text;
            }

            // Guarda el libro de trabajo
            workbook.SaveAs("C:\\temp\\ListViewData.xlsx");

            MessageBox.Show("Datos guardados en Excel exitosamente!");
        }
    }
}

    

