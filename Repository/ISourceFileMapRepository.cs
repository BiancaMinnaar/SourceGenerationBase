using BaseBonsai.Generation.DataModel;
using BaseBonsai.Generation.Templates;

namespace BaseBonsai.Generation.Repository
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
