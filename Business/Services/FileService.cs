using Business.Interfaces;
using Business.Services;q
using System.Diagnostics;

namespace Business.Services;
public class FileService : IFileService
{
    private readonly string _directoryPath;
    private readonly string _filePath;

    public FileService(string directoryPath = "Data", string filePath = "list.json")
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, filePath);
    }

    public string GetContactFromFile()
    {
        if (File.Exists(_filePath))
        {
            return File.ReadAllText(_filePath);
        }
        return null!;
    }

    public bool SaveContactToFile(string content)
    {
        try
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
            File.WriteAllText(_filePath, content); 
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
}
