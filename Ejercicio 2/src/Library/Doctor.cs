using System.Collections.Generic;

namespace Library
{
  public class Doctor
  {
    public string doctorName{ get; }
    public string appointmentPlace { get; }

    public Doctor(string DoctorName, string AppointmentPlace)
    {
      this.doctorName = DoctorName;
      this.appointmentPlace = AppointmentPlace;
    }

    public List<string> Propierties()
    {
      
      List<string> propiedades = new List<string>();
      propiedades.Add(doctorName);
      propiedades.Add(appointmentPlace);
      return propiedades;
    }    

    public List<string> PropiertiesNames()
    {
      List<string> listaPropiedades = new List<string>();
      listaPropiedades.Add("name");
      listaPropiedades.Add("appointment place");
      return listaPropiedades;
    }
      
  }
}
