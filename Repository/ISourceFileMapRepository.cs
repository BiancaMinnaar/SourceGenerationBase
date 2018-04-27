using CorePCL.Generation.DataModel;
using CorePCL.Generation.Templates;

namespace CorePCL.Generation.Repository
{
    public interface ISourceFileMapRepository<T,M> 
        where T: ITemplate<M>
        where M: TemplateDataModel
    {
        IProjectReaderRepository _ReaderRepo { get; set; }
        string GetSourceExtension(T template);
        string GetSourcePath(T template);
    }
}
