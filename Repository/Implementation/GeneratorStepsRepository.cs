using CorePCL.Generation.DataModel;
using CorePCL.Generation.Factory;
using CorePCL.Generation.Repository;
using CorePCL.Generation.Repository.Implementation;
using CorePCL.Generation.Service;
using CorePCL.Generation.Templates;

namespace MobileBonsai.Generation.Repository.Implementation
{
    public abstract class GeneratorStepsRepository<M>
        where M : TemplateDataModel, new()
    {
        protected IFileService _FileService;

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
        protected abstract void SetupSteps();
        public abstract void RunSteps();
    }
}
