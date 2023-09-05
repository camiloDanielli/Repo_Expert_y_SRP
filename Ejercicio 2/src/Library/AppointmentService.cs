using System;
using System.Text;



namespace Library
{
    public class AppointmentService
    {
        //string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName
        public static string CreateAppointment(Person persona, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (Validator.ValidatePerson(persona) != "Person validated" )
            {
                isValid = false;
                stringBuilder.Append(Validator.ValidatePerson(persona));
            }
            else if (Validator.ValidateDoctor(doctor) != "Doctor validated")
            {
                isValid = false;
                stringBuilder.Append(Validator.ValidateDoctor(doctor));
            }
            else
            {
                stringBuilder.Append(Validator.ValidatePerson(persona) + "\n");
                stringBuilder.Append(Validator.ValidateDoctor(doctor) + "\n") ;
                stringBuilder.Append("Appoinment scheduled")
            }

            return stringBuilder.ToString();
        }

    }
}
