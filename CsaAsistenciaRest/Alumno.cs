using System.Runtime.Serialization;

namespace CsaAsistenciaRest
{
    [DataContract]
    public class Alumno
    {
        int dni;
        string nroSocio;
        string nombre;
        string apellido;

        public Alumno()
        {
        }

        public Alumno(int dni, string nroSocio, string nombre, string apellido)
        {
            this.dni = dni;
            this.nroSocio = nroSocio;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        [DataMember]
        public int DniValue
        {
            get { return dni; }
            set { dni = value; }
        }

        [DataMember]
        public string NroSocioValue
        {
            get { return nroSocio; }
            set { nroSocio = value; }
        }

        [DataMember]
        public string NombreValue
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public string ApellidoValue
        {
            get { return apellido; }
            set { apellido = value; }
        }
    }
}
