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
  }
}
