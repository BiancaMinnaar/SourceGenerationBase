using System;
using System.Collections.Generic;
using CorePCL.Generation.DataModel;
using CorePCL.Generation.Templates;

namespace MobileBonsai.Generation.Factory
{
    public interface ITemplateInstanceFactoy<M>
        where M : TemplateDataModel, new()
    {
        List<ITemplate<M>> ToList();
    }
}
