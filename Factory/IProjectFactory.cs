using BaseBonsai.Generation.DataModel;
using BaseBonsai.Generation.Templates;

namespace BaseBonsai.Generation.Factory
{
    public interface IProjectFactory
    {
        void UpdateProjectFileWithFileReference<M>(ITemplate<M> template) where M : TemplateDataModel;
    }
}
