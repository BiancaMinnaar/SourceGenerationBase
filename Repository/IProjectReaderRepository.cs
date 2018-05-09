using CorePCL.Generation.Data;

namespace CorePCL.Generation.Repository
{
    public interface IProjectReaderRepository
    {
        ProjectModel Model { get; }
        string GetProjectName();
        string GetProjectFileLocation();
        string GetTemplatePath(string templateName);

        bool InsertFileReferenceInProjectFile(string classPath);
        bool InsertXamlFileReferenceInProjectFile(string classPath, string codeBehindFileName);
        bool InsertXamlEmbededResourceInProjectFile(string classPath);
        bool InsertDirecotryReferenceInProjectFile(string classPath);
        bool InsertEmbededResourceInProjectFile(string resourceName);
    }
}
