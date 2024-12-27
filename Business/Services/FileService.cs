using Business.Interfaces;
using Business.Models;
using Business.Services;
using System.Diagnostics;
using System.Text.Json;

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


    public bool SaveContactsToFile(List<ContactEntity> contact)
    {
        try
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
            var json = JsonSerializer.Serialize(contact, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json); 
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public string GetContactsFromFile()
    {
        if (File.Exists(_filePath))
        {
            return File.ReadAllText(_filePath);
        }
        return null!;
    }
}
