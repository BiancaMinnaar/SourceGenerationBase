using BaseBonsai.Generation.DataModel;
using BaseBonsai.Generation.Factory;
using BaseBonsai.Generation.Service;
using BaseBonsai.Generation.Templates;

namespace BaseBonsai.Generation.Repository.Implementation
{
    public class GenerationReposetory<M> : IGenerationReposetory<M>
        where M : TemplateDataModel, new()
    {
        IFileService _FileService;
        IProjectFactory _ProjectFactory;

        public GenerationReposetory(IFileService fileService, IProjectFactory projectPactory)
        {
            _FileService = fileService;
            _ProjectFactory = projectPactory;
        }

        public M GetBaseDataModel(string templateName)
        {
            var model = new M()
            {
                Template = templateName
            };
            model.SetData();
            return model;
        }

        public bool WriteTemplateToFile(string fullFilePath, string templateOutput)
        {
            return _FileService.WriteFileToDisk(fullFilePath, templateOutput);
        }

        public bool WriteTemplateToFile<T>(T template, ISourceFileMapRepository<T,M> mapRepository)
            where T : ITemplate<M>
        {
            var templateOutput = template.TransformText();
            var fullName = mapRepository.GetSourcePath(template) + template.GetFileName();
            var hasWritten = _FileService.WriteFileToDisk(fullName, templateOutput);
            _ProjectFactory.UpdateProjectFileWithFileReference<M>(template);

            return hasWritten;
        }
    }
}
