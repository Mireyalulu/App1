using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;


namespace App1
{
    public class _13090390
    {
        string id;
        string nombre;
        string apellido;
        string direccion;
        string telefono;
        string carrera;
        string semestre;
        string correo;
        string github;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "nombre")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [JsonProperty(PropertyName = "apellido")]
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        [JsonProperty(PropertyName = "direccion")]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        [JsonProperty(PropertyName = "telefono")]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        [JsonProperty(PropertyName = "carrera")]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        [JsonProperty(PropertyName = "semestre")]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        [JsonProperty(PropertyName = "correo")]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        [JsonProperty(PropertyName = "github")]
        public string Github
        {
            get { return github; }
            set { github = value; }
        }
        [Version]
        public string Version { get; set; }
    }
}
