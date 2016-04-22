using System.Runtime.Serialization;

namespace CsaAsistenciaRest
{
    [DataContract]
    public class Profesor
    {
        int id;
        string nombre;
        string apellido;

        public Profesor()
        {
        }

        [DataMember]
        public int IdValue
        {
            get { return id; }
            set { id = value; }
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
