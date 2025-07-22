using eShiftApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Printing;
using System.Xml.Linq;


namespace eShiftApp.Views.Admin
{
    public partial class SystemMonitoringControl : UserControl
    {
        private readonly CustomerController _customerController;
        private readonly ProductController _productController;
        private readonly TransportJobController _jobController;
        private readonly TransportUnitController _transportUnitController;
        public SystemMonitoringControl()
        {
            InitializeComponent();

            _customerController = new CustomerController();
            _productController = new ProductController();
            _jobController = new TransportJobController();
            _transportUnitController = new TransportUnitController();

            cmbFilterType.Items.AddRange(new string[] { "Customer", "Product", "Job", "Transport Unit" });
            cmbFilterType.SelectedIndexChanged += cmbFilterType_SelectedIndexChanged;

            cmbFilterType.SelectedIndex = 1;

        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbFilterType.SelectedItem?.ToString();

            switch (selected)
            {
                case "Customer":
                    dgvMonitor.DataSource = null;
                    dgvMonitor.DataSource = _customerController.GetAllCustomers();
                    break;

                case "Product":
                    dgvMonitor.DataSource = null;
                    dgvMonitor.DataSource = _productController.GetAllProducts();
                    break;

                case "Job":
                    dgvMonitor.DataSource = null;
                    dgvMonitor.DataSource = _jobController.GetAllJobs();
                    break;

                case "Transport Unit":
                    dgvMonitor.DataSource = null;
                    dgvMonitor.DataSource = _transportUnitController.GetAllUnits();
                    break;

                default:
                    dgvMonitor.DataSource = null;
                    dgvMonitor.DataSource = _customerController.GetAllCustomers();
                    break;
            }
        }

        private void SystemMonitoringControl_Load(object sender, EventArgs e)
        {
            cmbFilterType.SelectedIndex = 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvMonitor.DataSource == null || dgvMonitor.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.FileName = "Report.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        //  title
                        Paragraph title = new Paragraph("System Monitoring Report", FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD));
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 20f;
                        pdfDoc.Add(title);

                        // sub title
                        string reportType = cmbFilterType.SelectedItem?.ToString() ?? "Unknown";
                        Paragraph subTitle = new Paragraph(reportType + " Report", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY));
                        subTitle.Alignment = Element.ALIGN_CENTER;
                        subTitle.SpacingAfter = 20f;
                        pdfDoc.Add(subTitle);

                        // Create PDF table with same number of columns as DataGridView
                        PdfPTable pdfTable = new PdfPTable(dgvMonitor.Columns.Count);
                        pdfTable.WidthPercentage = 100;

                        // Add column headers
                        foreach (DataGridViewColumn column in dgvMonitor.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                            cell.BackgroundColor = new BaseColor(240, 240, 240);
                            pdfTable.AddCell(cell);
                        }

                        // Add row data
                        foreach (DataGridViewRow row in dgvMonitor.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value?.ToString() ?? "");
                                }
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("PDF Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
