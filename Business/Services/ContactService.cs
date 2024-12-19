using Business.Interfaces;
using Business.Models;
using System.ComponentModel;

namespace Business.Services;
public class ContactService : IContactService
{
    private readonly FileService _fileService;

    public ContactService(FileService fileService) 
    {
        _fileService = fileService;
    }

    public bool CreateContact(ContactForm contactForm)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Contact> GetAllContacts() 
    {
        throw new NotImplementedException();
    }
}
