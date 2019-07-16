using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using MyPDFeditor.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MyPDFeditor
{
    public class PdfCreador
    {

        public void CrearPDF(W9 obj) { 
            string root = new FileInfo(Assembly.GetExecutingAssembly().Location).FullName;
            //Instacia para leer PDF
            //LLenar campos del form PDF
            PdfDocument pdf = new PdfDocument(new PdfReader("../../../assets/fw9.pdf"),new PdfWriter("outputw9.pdf"));
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdf, true);
            IDictionary<string, PdfFormField> fields = form.GetFormFields();
            fields["topmostSubform[0].Page1[0].f1_1[0]"].SetValue(obj.Nombre);
            fields["topmostSubform[0].Page1[0].f1_2[0]"].SetValue(obj.NombreNegocio);
            fields["topmostSubform[0].Page1[0].FederalClassification[0].c1_1[0]"].SetValue("0");
            fields["topmostSubform[0].Page1[0].Address[0].f1_7[0]"].SetValue(obj.Domicilio);
            fields["topmostSubform[0].Page1[0].Address[0].f1_8[0]"].SetValue($"{obj.Ciudad} {obj.Estado} {obj.CodigoPostal}");
            fields["topmostSubform[0].Page1[0].f1_10[0]"].SetValue(obj.Tel);
            pdf.Close();
            

            

            
            

        }
    }
}
