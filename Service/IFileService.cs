namespace CorePCL.Generation.Service
{
    public interface IFileService
    {
        bool WriteFileToDisk(string fullFilePath, string content);
        string ReadFromFile(string FullFilePath);
        bool CreateDirectory(string path);
    }
}
