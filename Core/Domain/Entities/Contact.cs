using Domain.DTOs;
using Domain.Entities;
using Domain.Enums;

namespace Domain;

public sealed class Contact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BornDate { get; set; }
    public ContactType Type { get; set; }
    public string Register { get; set; }
    public List<MeanContact> MeanContacts { get; set; }

    public Contact(CreateContactDTO createContactDTO)
    {
        Name = createContactDTO.Name;
        BornDate = createContactDTO.BornDate;
        Type = createContactDTO.Type;
        Register = createContactDTO.Register;
        MeanContacts = createContactDTO.MeanContacts.Select(p => new MeanContact(p)).ToList();
    }


    public Contact(UpdateContactDTO updateContactDTO)
    {
        Name = updateContactDTO.Name;
        BornDate = updateContactDTO.BornDate;
        Register = updateContactDTO.Register;
    }
}
