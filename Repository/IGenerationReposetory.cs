using System;
using CorePCL.Generation.DataModel;
using CorePCL.Generation.Templates;

namespace CorePCL.Generation.Repository
{
    public interface IGenerationReposetory<M>
        where M : TemplateDataModel, new()
    {
        M GetBaseDataModel(string templateName);
        bool WriteTemplateToFile(string fullFilePath, string templateOutput);
        bool WriteTemplateToFile<T>(T template, ISourceFileMapRepository<T, M> mapRepository)
            where T : ITemplate<M>;
    }
}
