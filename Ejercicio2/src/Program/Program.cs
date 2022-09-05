using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            Doctor doctor1= new Doctor("Lucas Alegre", "Cardiologo");
            Patient patient1= new Patient("Ricardo Rodriguez", 099436845,18);
            Doctor doctor2= new Doctor("Lucas Alegre", "hola");
            Patient patient2= new Patient("", 099436845,18);



            string appointmentResult = AppointmentService.CreateAppointment("A1972", DateTime.Now,"Sala de Resonancia Medica Uruguaya",doctor2,patient2);
            Console.WriteLine(appointmentResult);

            //string appointmentResult2 = AppointmentService.CreateAppointment("", DateTime.Now,"Sala de Resonancia Medica Uruguaya",doctor1,patient1);
            //Console.WriteLine(appointmentResult2);
        }
    }
}