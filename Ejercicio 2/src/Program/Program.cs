using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            persona1 = new Person("Steven Jhonson", "5555-555-555", "986782342");
            doctor1 = new Doctor("Wall Street", "Armand");
            persona2 = new Person("Ralf Manson", "5555-555-555", "");
            doctor2 = new Doctor("", "Queen Street");

            string appointment1 = AppointmentService.CreateAppointment(persona1, doctor1);
            string appointment2 = AppointmentService.CreateAppointment(persona2, doctor2);

            Console.WriteLine(appointmentResult);
            Console.WriteLine(appointmentResult2);
        }
    }
}
