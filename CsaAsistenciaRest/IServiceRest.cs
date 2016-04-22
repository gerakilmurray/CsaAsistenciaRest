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
    } 
}
