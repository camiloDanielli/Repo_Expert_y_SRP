namespace Library
{
  public class Person
  {
    public string name{ get; }
    public string id { get; }
    public string phoneNumber { get; }

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
