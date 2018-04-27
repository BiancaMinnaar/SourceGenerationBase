namespace CorePCL.Generation.Repository
{
    public interface IProjectReaderRepository
    {
        string GetProjectName();
        string GetProjectFileLocation();
        string GetTemplatePath(string templateName);

        bool InsertFileReferenceInProjectFile(string classPath);
        bool InsertXamlFileReferenceInProjectFile(string classPath, string codeBehindFileName);
        bool InsertXamlEmbededResourceInProjectFile(string classPath);
    }
}
