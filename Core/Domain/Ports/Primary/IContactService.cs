using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;

namespace Domain.Primary.Ports;

public interface IContactService
{
    Task<Contact> CreateContact(CreateContactDTO contact);
    Task<Contact> DeleteContact(int id);
    Task<Contact> UpdateContact(UpdateContactDTO contact);    
    Task<Contact> GetContactById(int id);
}
