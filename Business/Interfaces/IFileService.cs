using Business.Models;

namespace Business.Interfaces;

public interface IFileService
{
    bool SaveContactToFile(List<ContactEntity> contact);
    List<ContactEntity> GetContactFromFile();
}
