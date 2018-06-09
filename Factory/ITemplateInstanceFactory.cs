using System;
using System.Collections.Generic;
using CorePCL.Generation.DataModel;
using CorePCL.Generation.Templates;

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
