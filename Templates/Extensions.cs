using CorePCL.Generation.DataModel;
using CorePCL.Generation.Repository;

namespace CorePCL.Generation.Templates.Extensions
{
    public static class Extentions
    {
        public static string GetFileName<T,M>(this T template, ISourceFileMapRepository<T, M> sourceFileMap, string fileName) where T : ITemplate<M> where M:TemplateDataModel
        {
            template.DataModel._Template = new FileModel()
            {
                CodeName = fileName,
                Extension = sourceFileMap.GetSourceExtension(template),
                ProjectFilePath = sourceFileMap.GetSourcePath(template)
            };
            return template.DataModel._Template.FileName;
        }

        public static string GetFullProjectFileName<T, M>(this T template) where T : ITemplate<M> where M : TemplateDataModel
        {
            return template.DataModel._Template.FullProjectFileName;
        }
    }
}
