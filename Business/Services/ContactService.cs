using Business.Factories;
using Business.Helpers;
using Business.Interfaces;
using Business.Models;
using System.ComponentModel;
using System.Diagnostics;

namespace Business.Services;
public class ContactService : IContactService
{
    private readonly FileService _fileService;

    public ContactService(FileService fileService) 
    {
        _fileService = fileService;
    }

    public bool CreateContact(ContactForm form)
    {
        try
        {
            ContactEntity contactEntity = ContactFactory.Create(form)!;
            contactEntity.Id = IdGenerator.GenerateID();
            return true;
        }
        catch (Exception ex) 
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
}
