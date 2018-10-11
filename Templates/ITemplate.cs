using BaseBonsai.Generation.Templates;
using BaseBonsai.Generation.DataModel;
using BaseBonsai.Generation.Repository.Implementation;
using BaseBonsai.Generation.Templates.PartialClasses;

namespace BaseBonsai.Generation.Templates
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
