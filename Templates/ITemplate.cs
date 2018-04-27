using CorePCL.Generation.Templates;
using CorePCL.Generation.DataModel;
using CorePCL.Generation.Repository.Implementation;
using CorePCL.Generation.Templates.PartialClasses;

namespace CorePCL.Generation.Templates
{
    /// <summary>
    /// Template. Depricated Use ITemplate<M>
    /// </summary>
    public interface ITemplate : ITemplate<TemplateDataModel>
    {
    }

    public interface ITemplate<M> where M : TemplateDataModel
    {
        string TemplateResourceKey { get; }
        M DataModel { get; set; }
        TemplateEnum TemplateType { get; }
        string FullProjectFileName { get; }
        string TransformText();
        SourceEnum TemplateEnum { get; }
        string GetFileName();
    }
}
