using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;

namespace Domain.Secondary.Ports;

public interface IContactRepository
{
    Task<Contact> CreateContact(Contact contact);
    Task<Contact> DeleteContact(int id);
    Task<Contact> UpdateContact(Contact contact);    
    Task<Contact?> GetContactById(int id);
}
