using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CsaAsistenciaRest
{
    [DataContract]
    public class Actividades
    {
        List<Actividad> listado;

        public Actividades()
        {
            this.listado = new List<Actividad>();
        }

        public void addActividad(Actividad actividad)
        {
            if(actividad != null)
            {
                this.listado.Add(actividad);
            }
        }

        [DataMember]
        public List<Actividad> ListadoValue
        {
            get { return listado; }
            set { listado = value; }
        }
    }
}
