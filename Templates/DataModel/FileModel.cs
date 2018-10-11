namespace BaseBonsai.Generation.DataModel
{
    public class FileModel
    {
		public string CodeName { get; set; }
        public string Extension { get; set; }
        public string FileName { get { return CodeName + '.' + Extension; }}
        public string ProjectFilePath { get; set; }
        public string FullProjectFileName 
        { 
            get 
            { 
                var cleanPath = ProjectFilePath.Replace('/', '\\').Split(new string[] {"..\\"}, System.StringSplitOptions.None);
                var projectIncluded = cleanPath[cleanPath.Length - 1];
                var firstSlash = projectIncluded.IndexOf('\\');
                var solutionExcluded = cleanPath[cleanPath.Length-1].Substring(firstSlash +1);
                var secondSlash = solutionExcluded.IndexOf('\\');
                var projectExcluded = solutionExcluded.Substring(secondSlash +1);
                return projectExcluded + FileName; 
            }
        }
    }
}
