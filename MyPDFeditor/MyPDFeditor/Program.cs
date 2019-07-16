using MyPDFeditor.Modelo;
using System;

namespace MyPDFeditor
{
    class Program
    {
        static void Main(string[] args)
       {
            W9 w9 = new W9()
            {
                Nombre = "JUAN PEREZ PEREZ",
                Ciudad = "LEON",
                Domicilio = "CALLE ALFARO 313C",
                Estado = "GUANAJUATO",
                Tel = "477171234",
                TipoNegocio = 1,
                CodigoPostal = "37000",
                NombreNegocio = "CASTORES SA DE CV",
                Domicilio2 = String.Empty
            };
            PdfCreador creador = new PdfCreador();
            creador.CrearPDF(w9);
        }
    }
}
