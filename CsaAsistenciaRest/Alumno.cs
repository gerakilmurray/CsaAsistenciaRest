using System.Runtime.Serialization;

namespace CsaAsistenciaRest
{
    [DataContract]
    public class Alumno
    {
        int dni;
        string nombre;
        string apellido;

        public Alumno()
        {
        }

        [DataMember]
        public int DniValue
        {
            get { return dni; }
            set { dni = value; }
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
