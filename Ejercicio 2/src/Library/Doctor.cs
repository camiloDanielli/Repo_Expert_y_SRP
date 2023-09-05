namespace Library
{
  public class Doctor
  {
    public string doctorName{ get; }
    public string appointmentPlace { get; }

    public List<string> Propierties()
    {
      List<string> propiedades = new List<string>();
      propiedades.Add(doctorName);
      propiedades.Add(appointmentPlace);
      return propiedades;
    }    
  }
}
