using System.Collections.Generic;
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

        bool UpdateMasterRepoInterfaceWithMethod(string interfaceMethod);
        bool UpdateMasterRepoWithMethod(string methodSpecification);

        void SaveProjectItemData(string fileItem);
        ProjectModel GetProjectManifest();
        bool TestFileEntryExist(string fileItem);
    }
}
