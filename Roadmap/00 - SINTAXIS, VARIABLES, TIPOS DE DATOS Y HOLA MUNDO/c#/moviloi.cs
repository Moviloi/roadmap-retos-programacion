using System;

// URL del sitio oficial de C#: https://dotnet.microsoft.com/es-es/languages/csharp

// sitnaxis de comentario en una linea

/* sintaxis de
 * comentario en
 * varias lineas
 */


namespace Ejercicio_Logica_MoureDev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var numero = 5; //declaracion de variable
            const double pi = 3.1416; //declaracion de constante

            int suma = 0;
            float division = 3.14f;
            string nombre = "MoureDev";
            char letra = 'M';
            bool esVerdadero = true;
            DateTime fechaActual = DateTime.Now;
            double numeroDecimal = 9.99;
            decimal numeroDecimalAlto = 19.99m;
            long numeroGrande = 1234567890L;

            Console.WriteLine("Hola, C#!");

        }
    }
}
