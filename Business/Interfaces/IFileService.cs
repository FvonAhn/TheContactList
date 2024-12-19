namespace Business.Interfaces;

public interface IFileService
{
    bool SaveContactToFile(string content);
    string GetContactFromFile();
}
