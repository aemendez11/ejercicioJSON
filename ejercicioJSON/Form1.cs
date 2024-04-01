using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioJSON
{
    public partial class Form1 : Form
    {
        List<int> notasTemporales = new List<int>();
        List<Notas> listaNotas = new List<Notas>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            int nota = Convert.ToInt16(txtNota.Text);

            notasTemporales.Add(nota);
        }

        private void grabar()
        {
            string json=JsonConvert.SerializeObject(listaNotas);
            string archivo = "Datos.json";
            System.IO.File.WriteAllText(archivo, json);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guarda a un alumno con sus notas
            Notas notas = new Notas();
            notas.Nombre = txtNombre.Text;
            notas.NotasAlum = notasTemporales;

            //Guarda a ese alumno en el listado de notas de alumnos
            listaNotas.Add(notas);

            //Borrar las notas temporales para el proximo alumno
            //notasTemporales.Clear();
            grabar();
        }
    }
}
