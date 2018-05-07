using System;

namespace CorePCL.Generation.Data
{
    public class ProjectModelPathAttribute : Attribute
    {

    }

    public class ProjectModel : GenericTemplateModel
    {
        public string ProjectFileLocation => "../" + ProjectName + "/" + ProjectName + "/" + ProjectName + "/";
		//Root Folder
        [ProjectModelPath]
        public string BaseFolderPath => "../" + ProjectName + "/" + ProjectName + "/Root/";
        [ProjectModelPath]
        public string RepositoryInterfacePath => "../" + ProjectName + "/" + ProjectName + "/Trunk/Repository/";
        [ProjectModelPath]
        public string RepositoryPath => "../" + ProjectName + "/" + ProjectName + "/Trunk/Repository/Implementation/";
        [ProjectModelPath]
        public string ServiceInterfacePath => "../" + ProjectName + "/" + ProjectName + "/Trunk/Service/";
        [ProjectModelPath]
        public string ServicePath => "../" + ProjectName + "/" + ProjectName + "/Trunk/Service/Implementation/";
        [ProjectModelPath]
        public string ViewCodeBehindPath => "../" + ProjectName + "/" + ProjectName + "/Trunk/View/";
        [ProjectModelPath]
        public string ViewControllerInterfacePath => "../" + ProjectName + "/" + ProjectName + "/Trunk/ViewController/";
        [ProjectModelPath]
        public string ViewControllerPath => "../" + ProjectName + "/" + ProjectName + "/Trunk/ViewController/Implementation/";
        [ProjectModelPath]
        public string ViewModelPath => "../" + ProjectName + "/" + ProjectName + "/Trunk/ViewModel/";
        [ProjectModelPath]
        public string ViewPath => "../" + ProjectName + "/" + ProjectName + "/Trunk/View/";

        public ProjectModel(string projectName)
        {
            ProjectName = projectName;
        }
    }
}
