using System.Runtime.Serialization;

namespace CsaAsistenciaRest
{
    [DataContract]
    public class Actividad
    {
        int id;
        string descripcion;

        public Actividad()
        {
        }

        public Actividad(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        [DataMember]
        public int IdValue
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string DescripcionValue
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
