using BaseBonsai.Generation.DataModel;
using BaseBonsai.Generation.Factory;
using BaseBonsai.Generation.Repository;
using BaseBonsai.Generation.Repository.Implementation;
using BaseBonsai.Generation.Service;
using BaseBonsai.Generation.Templates;

namespace MobileBonsai.Generation.Repository.Implementation
{
    public abstract class GeneratorStepsRepository<M>
        where M : TemplateDataModel, new()
    {
        protected IFileService _FileService;
        IProjectFactory _ProjectFactory;
        GenerationReposetory<M> _Repository;

        protected GeneratorStepsRepository(IFileService fileService, IProjectFactory projectFactory){
            _FileService = fileService;
            _ProjectFactory = projectFactory;
            _Repository = new GenerationReposetory<M>(fileService, projectFactory);
        }

        public M GetDataModel(string templateName)
        {
            return _Repository.GetBaseDataModel(templateName);
        }

        public void WriteTemplateWithModelInjection<I>(I template, ISourceFileMapRepository<I, M> sourceFileRepo)
            where I : ITemplate<M>
        {
            _Repository.WriteTemplateToFile(template, sourceFileRepo);
        }

        public abstract M SetupModel(string templateName);
        public abstract void SetupSteps();
        public abstract void RunSteps();
    }
}
