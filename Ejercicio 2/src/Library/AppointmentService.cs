using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(Person persona, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            if (Validator.ValidatePerson(persona) != "Person validated" )
            {
                stringBuilder.Append(Validator.ValidatePerson(persona));
            }
            else if (Validator.ValidateDoctor(doctor) != "Doctor validated")
            {
                stringBuilder.Append(Validator.ValidatePerson(persona) + "\n");
                stringBuilder.Append(Validator.ValidateDoctor(doctor));
            }
            else
            {
                stringBuilder.Append(Validator.ValidatePerson(persona) + "\n");
                stringBuilder.Append(Validator.ValidateDoctor(doctor) + "\n") ;
                stringBuilder.Append("Appointment scheduled!");
            }

            return stringBuilder.ToString();
        }

    }
}
