using System.Collections.Generic;

namespace Library
{
  public class Person
  {
    public string name{ get; }
    public string id { get; }
    public string phoneNumber { get; }

    public Person(string Name, string Id, string PhoneNumber)
    {
      this.name = Name;
      this.id = Id;
      this.phoneNumber = PhoneNumber;
    }

    public List<string> Propierties()
    {
      List<string> propiedades = new List<string>();
      propiedades.Add(name);
      propiedades.Add(id);
      propiedades.Add(phoneNumber);
      return propiedades;
    }    

    public List<string> PropiertiesNames()
    {
      List<string> listaPropiedades = new List<string>();
      listaPropiedades.Add("name");
      listaPropiedades.Add("id");
      listaPropiedades.Add("phone number");
      return listaPropiedades;
    }
  }
}
