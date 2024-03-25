namespace DevFreela.Application.Exceptions;

public class ProjectAlreadyStartedException : Exception
{
    public ProjectAlreadyStartedException() : base("Project is already started status")
    {
        
    }
}