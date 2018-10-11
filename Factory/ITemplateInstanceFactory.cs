using System.Collections.Generic;
using BaseBonsai.Generation.DataModel;
using BaseBonsai.Generation.Templates;

namespace MobileBonsai.Generation.Factory
{
    public interface ITemplateInstanceFactory<M>
        where M : TemplateDataModel, new()
    {
        List<ITemplate<M>> ToList();
        void Add<T>() where T:ITemplate<M>, new();
        void Add<T>(M model) where T : ITemplate<M>, new();
    }
}
