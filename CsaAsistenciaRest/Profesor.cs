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

        public Profesor(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
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
