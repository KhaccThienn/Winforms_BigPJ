using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigPJV2.Forms
{
    public partial class FrmGenerateQR : Form
    {
        public Employee emp;
        public bool IsOpened { get; set; } = false;
        public FrmGenerateQR()
        {
            InitializeComponent();
        }

        private void FrmGenerateQR_Load(object sender, EventArgs e)
        {
            PrintingData();
            GeneratingQR();
        }

        private void PrintingData()
        {
            txtId.Text = emp.Id.ToString();
            txtName.Text = emp.Name.ToString();
            txtEmail.Text = emp.Email.ToString();
            txtPhone.Text = emp.Phone.ToString();
            txtAddress.Text = emp.Address.ToString();
            txtGender.Text = (bool)emp.Gender ? "Male" : "Female";
            txtBirthday.Text = emp.BirthDay.ToString("dd / MM / yyyy");
            txtDepartment.Text = emp.Department.Name.ToString();
            txtLevel.Text = emp.Level.Name.ToString();
        }

        private void GeneratingQR()
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();

            var myData = QG.CreateQrCode(txtId.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(myData);
            pb_QrCode.Image = code.GetGraphic(50);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog s = new System.Windows.Forms.SaveFileDialog();
            s.FileName = "Image"; // Default file name
            s.DefaultExt = ".png"; // Default file extension
            s.Filter = "Image (*.jpg;*.png)|*.jpg;*.png"; // Filter files by extension
            s.FileName = txtName.Text;
            if (s.ShowDialog() == DialogResult.OK)
            {
                // Lưu ảnh
                pb_QrCode.Image.Save(s.FileName);
            }
        }
    }
}
