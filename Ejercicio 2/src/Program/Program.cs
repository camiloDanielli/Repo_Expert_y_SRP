using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person("Steven Jhonson", "5555-555-555", "986782342");
            Doctor doctor1 = new Doctor("Wall Street", "Armand");
            Person persona2 = new Person("Ralf Manson", "5555-555-555", "");
            Doctor doctor2 = new Doctor("", "Queen Street");
            Person persona3 = new Person("Leandro Barral", "5555-673-192", "198192932");
            Doctor doctor3 = new Doctor("", "Park Avenue");
            Person persona4 = new Person("", "", "");
            Doctor doctor4 = new Doctor("", "Queen´s Garden");
            Person persona5 = new Person("Fransisco", "5555-555-553", "12345561");
            Doctor doctor5 = new Doctor("Howard", "");
            Person persona6 = new Person("Ralf Manson", "5555-234-567", "019239481");
            Doctor doctor6 = new Doctor("Marcos", "UCU");

            string appointment1 = AppointmentService.CreateAppointment(persona1, doctor1);
            string appointment2 = AppointmentService.CreateAppointment(persona2, doctor2);
            string appointment3 = AppointmentService.CreateAppointment(persona3, doctor3);
            string appointment4 = AppointmentService.CreateAppointment(persona4, doctor4);
            string appointment5 = AppointmentService.CreateAppointment(persona5, doctor5);
            string appointment6 = AppointmentService.CreateAppointment(persona6, doctor6);

            Console.WriteLine(appointment1);
            Console.WriteLine(appointment2);
            Console.WriteLine(appointment3);
            Console.WriteLine(appointment4);
            Console.WriteLine(appointment5);
            Console.WriteLine(appointment6);
        }
    }
}
