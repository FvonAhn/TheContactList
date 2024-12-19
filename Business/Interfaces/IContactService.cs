using Business.Models;

namespace Business.Interfaces;
public interface IContactService
{
    bool CreateContact(ContactForm contactForm);
    IEnumerable<Contact> GetAllContacts();
}
