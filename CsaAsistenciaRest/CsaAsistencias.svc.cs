using System;
using System.Linq;

namespace CsaAsistenciaRest
{
    public class CsaAsistencias : IServiceRest
    {
        public Profesor GetLogin(string user, string password)
        {
            if (user == null || user.Count() == 0)
            {
                throw new ArgumentNullException("user");
            }
            if (password == null || password.Count() == 0)
            {
                throw new ArgumentNullException("password");
            }
            Profesor jirafales = new Profesor();
            jirafales.IdValue = 1;
            jirafales.NombreValue = "Rubén";
            jirafales.ApellidoValue = "Jirafales";
            return jirafales;
        }

        public Actividades GetActividades(int idProfesor)
        {
            if (idProfesor <= 0)
            {
                throw new ArgumentNullException("idProfesor");
            }
            Actividades lista = new Actividades();
            Actividad hockeyM21 = new Actividad(1, "Jirafales Hockey mañana Fem-21");
            lista.addActividad(hockeyM21);
            Actividad hockeyM17 = new Actividad(2, "Jirafales Hocket mañana Fem-17");
            lista.addActividad(hockeyM17);
            Actividad hockeyT21 = new Actividad(3, "Jirafales Hocket tarde Fem-21");
            lista.addActividad(hockeyT21);
            Actividad hockeyT17 = new Actividad(4, "Jirafales Hocket tarde Fem-17");
            lista.addActividad(hockeyT17);

            return lista;
        }


        public Planilla GetPlanillaActividad(int idActividad)
        {
            if (idActividad <= 0)
            {
                throw new ArgumentNullException("idActividad");
            }
            Planilla planilla = new Planilla();

            Alumno a1 = new Alumno(44333222, "11223344/5", "María Laura", "Fernández");
            Alumno a2 = new Alumno(45333222, "11223344/6", "María Emilia", "Fernández");
            Alumno a3 = new Alumno(46333222, "11223344/7", "María Eugenia", "Fernández");

            planilla.IdActividadValue = idActividad;
            planilla.addAlumno(a1);
            planilla.addAlumno(a2);
            planilla.addAlumno(a3);

            return planilla;
        }

        bool IServiceRest.SaveAsistencia(int idProfesor, int idActividad, int dniAlumno)
        {
            return true;            
        }

        bool IServiceRest.RemoveAsistencia(int idProfesor, int idActividad, int dniAlumno)
        {
            return true;
        }
    }
}
