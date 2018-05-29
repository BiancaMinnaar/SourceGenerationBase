using System;

namespace CorePCL.Generation.Data
{
    public class ProjectModelPathAttribute : Attribute {}

    public class ProjectModel : GenericTemplateModel
    {
        public string SolutionFileLocation => "../" + ProjectName + "/";
        public string ProjectFileLocation => "../" + ProjectName + "/" + ProjectName +"/";
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
        //iOS
        [ProjectModelPath]
        public string IOSProjectPath => "../" + ProjectName + "/iOS/";
        [ProjectModelPath]
        public string IOSAssetsPath => "../" + ProjectName + "/iOS/Assets.xcassets/";
        [ProjectModelPath]
        public string IOSAssetsAppIconPath => "../" + ProjectName + "/iOS/Assets.xcassets/AppIcon.appiconset/";
        [ProjectModelPath]
        public string IOSResourcesPath => "../" + ProjectName + "/iOS/Resources/";
        [ProjectModelPath]
        public string IOSInjectionPath => "../" + ProjectName + "/iOS/Injection/";
        //Droid
        [ProjectModelPath]
        public string DroidProjectPath => "../" + ProjectName + "/Droid/";
        [ProjectModelPath]
        public string DroidAssetsPath => "../" + ProjectName + "/Droid/Assets/";
        [ProjectModelPath]
        public string DroidPropertiesPath => "../" + ProjectName + "/Droid/Properties/";
        [ProjectModelPath]
        public string DroidResourcesPath => "../" + ProjectName + "/Droid/Resources/";
        [ProjectModelPath]
        public string DroidResourcesDrawablePath => "../" + ProjectName + "/Droid/Resources/drawable/";
        [ProjectModelPath]
        public string DroidResourcesDrawableHdpiPath => "../" + ProjectName + "/Droid/Resources/drawable-hdpi/";
        [ProjectModelPath]
        public string DroidResourcesDrawableXhdpiPath => "../" + ProjectName + "/Droid/Resources/drawable-xhdpi/";
        [ProjectModelPath]
        public string DroidResourcesDrawableXxhdpiPath => "../" + ProjectName + "/Droid/Resources/drawable-xxhdpi/";
        [ProjectModelPath]
        public string DroidResourcesLayoutPath => "../" + ProjectName + "/Droid/Resources/layout/";
        [ProjectModelPath]
        public string DroidResourcesValuesPath => "../" + ProjectName + "/Droid/Resources/values/";
        [ProjectModelPath]
        public string DroidInjectionPath => "../" + ProjectName + "/Droid/Injection/";

        public ProjectModel(string projectName)
        {
            ProjectName = projectName;
        }
    }
}
