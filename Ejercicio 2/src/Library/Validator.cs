namespace Library
{
  public class Validator
  {
    public static string ValidatePerson(Person persona)
    {
      foreach propiedad in persona.Propierties()
      {
        if (string.IsNullOrEmpty(propiedad))
        {
          return $"Unable to create, {propiedad} is missing";
        }
      }
      return "Person validated";
    }

    public static string ValidateDoctor(Doctor doctor)
    {
      foreach propiedad in doctor.Propierties()
      {
        if (string.IsNullOrEmpty(propiedad))
        {
          return $"Unable to create, {propiedad} is missing";
        }
      }
      return "Doctor validated";
    }
  }
}
