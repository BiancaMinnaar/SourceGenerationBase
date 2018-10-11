using System;
using BaseBonsai.Generation.DataModel;
using BaseBonsai.Generation.Templates;

namespace BaseBonsai.Generation.Repository
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
