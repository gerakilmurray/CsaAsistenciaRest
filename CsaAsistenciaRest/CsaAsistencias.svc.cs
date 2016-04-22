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
            Actividad hockeyM21 = new Actividad();
            hockeyM21.IdValue = 1;
            hockeyM21.DescripcionValue = "Jirafales Hockey mañana Fem-21";
            lista.addActividad(hockeyM21);
            Actividad hockeyM17 = new Actividad();
            hockeyM17.IdValue = 1;
            hockeyM17.DescripcionValue = "Jirafales Hocket mañana Fem-17";
            lista.addActividad(hockeyM17);
            Actividad hockeyT21 = new Actividad();
            hockeyT21.IdValue = 1;
            hockeyT21.DescripcionValue = "Jirafales Hocket tarde Fem-21";
            lista.addActividad(hockeyT21);
            Actividad hockeyT17 = new Actividad();
            hockeyT17.IdValue = 1;
            hockeyT17.DescripcionValue = "Jirafales Hocket tarde Fem-17";
            lista.addActividad(hockeyT17);

            return lista;
        }
    }
}
