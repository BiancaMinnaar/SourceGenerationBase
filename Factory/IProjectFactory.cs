using CorePCL.Generation.DataModel;
using CorePCL.Generation.Templates;

namespace CorePCL.Generation.Factory
{
    public interface IProjectFactory
    {
        void UpdateProjectFileWithFileReference<M>(ITemplate<M> template) where M : TemplateDataModel;
    }
}
