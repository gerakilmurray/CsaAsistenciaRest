using System.ServiceModel;
namespace CsaAsistenciaRest
{
    [ServiceContract]
    public interface IServiceRest
    {
        [OperationContract]
        Profesor GetLogin(string user, string password);

        [OperationContract]
        Actividades GetActividades(int idProfesor);

        [OperationContract]
        Planilla GetPlanillaActividad(int idActividad);

        [OperationContract]
        bool SaveAsistencia(int idProfesor, int idActividad, int dniAlumno);

        [OperationContract]
        bool RemoveAsistencia(int idProfesor, int idActividad, int dniAlumno);
    } 
}
