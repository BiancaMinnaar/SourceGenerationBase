using BaseBonsai.DataContracts;

namespace BaseBonsai.Generation.DataModel
{
    public class TemplateDataModel : BaseViewModel
    {
        public FileModel _Template { get; set; }
        public string Template
        {
            get => _Template.CodeName;
            set => _Template = new FileModel() { CodeName = value };
        }

        public virtual void SetData(){}
    }
}
