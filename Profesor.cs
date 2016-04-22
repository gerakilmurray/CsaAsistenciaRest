using System;

public class Profesor
{
    int id;
    string Nombre;
    string Apellido;

    public Profesor()
	{
	}
    
    [DataMember]
    public int IdValue
    {
        get { return /*id*/ 1; }
        set { id = value; }
    }

    [DataMember]
    public string NombreValue
    {
        get { return /*Nombre*/ "Rubén"; }
        set { Nombre = value; }
    }

    [DataMember]
    public string ApellidoValue
    {
        get { return /*Apellido*/ "Jirafales"; }
        set { Apellido = value; }
    }
}
