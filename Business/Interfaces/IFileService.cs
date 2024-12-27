using Business.Models;

namespace Business.Interfaces;

public interface IFileService
{
    bool SaveContactsToFile(List<ContactEntity> contact);
    string GetContactsFromFile();
}
