using Business.Models;
using Business.Helpers
using System.Diagnostics;


namespace Business.Factories;
public static class ContactFactory
{
    public static ContactForm Create()
    {
        return new ContactForm();
    }

    public static ContactEntity? Create(ContactForm form)
    {
        try
        {
            return new ContactEntity
            {
                FirstName = form.FirstName,
                LastName = form.LastName,
                Adress = form.Adress,
                PostalCode = form.PostalCode,
                City = form.City,
                Email = form.Email,
                Phone = form.Phone,
            };
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error creating ContactEntity: {ex.Message}");
            return null;
        }
    }

    public static Contact? Create(ContactEntity entity)
    {
        try
        {
            return new Contact
            {
                FullName = $"{entity.FirstName} {entity.LastName}",
                Email = entity.Email,
                FullAdress = $"{entity.Adress} {entity.PostalCode}",
                City = entity.City,
                Phone = entity.Phone,
            };
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error creating Contact: {ex.Message}");
            return null;
        }
    }
}

