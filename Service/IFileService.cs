namespace CorePCL.Generation.Service
{
    public interface IFileService
    {
        bool WriteFileToDisk(string fullFilePath, string content);
        bool UpdateCShrpFileWithMethod(string fullFilePath, string methodContent);
        string ReadFromFile(string FullFilePath);
        bool CreateDirectory(string path);
    }
}
