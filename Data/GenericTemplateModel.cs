namespace CorePCL.Generation.Data
{
    public class GenericTemplateModel : BaseViewModel
    {
        public string ProjectName { get; set; }
        public string FileListXPath => "/Project/ItemGroup";
    }
}
