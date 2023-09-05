namespace Library
{
  public class Validator
  {
    public static string ValidatePerson(Person persona)
    {
      int counter = 0;
      foreach (string propiedad in persona.Propierties())
      {
        if (string.IsNullOrEmpty(propiedad))
        {
          return $"Unable to create, the person´s {persona.PropiertiesNames()[counter]} is missing";
        }
        counter++;
      }
      return "Person validated";
    }

    public static string ValidateDoctor(Doctor doctor)
    {
      int counter = 0;
      foreach (string propiedad in doctor.Propierties())
      {
        if (string.IsNullOrEmpty(propiedad))
        {
          return $"Unable to create, the doctor´s {doctor.PropiertiesNames()[counter]} is missing";
        }
        counter++;
      }
      return "Doctor validated";
    }
  }
}
