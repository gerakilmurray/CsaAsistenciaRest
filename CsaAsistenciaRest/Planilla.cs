using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CsaAsistenciaRest
{
    [DataContract]
    public class Planilla
    {
        int idActividad;
        List<Alumno> alumnos;

        public Planilla()
        {
            this.alumnos = new List<Alumno>();
        }

        public void addAlumno(Alumno alumno)
        {
            if(alumno != null)
            {
                this.alumnos.Add(alumno);
            }
        }

        [DataMember]
        public int IdActividadValue
        {
            get { return idActividad; }
            set { idActividad = value; }
        }

        [DataMember]
        public List<Alumno> AlumnosValue
        {
            get { return alumnos; }
            set { alumnos = value; }
        }
    }
}
