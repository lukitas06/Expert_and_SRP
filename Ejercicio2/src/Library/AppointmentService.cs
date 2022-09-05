using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {

        public static string CreateAppointment(string id, DateTime date, string appoinmentPlace, Doctor doctor, Patient patient)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            stringBuilder.Append(doctor.validDoctor());
            stringBuilder.Append(patient.validPatient());

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }

            if (isValid== true & doctor.getDoctor()!="None" &  patient.getPatient()!="None") 
            {
                stringBuilder.Append("Appoinment scheduled");
            }
            if(doctor.getDoctor()=="None" |  patient.getPatient()=="None"){
                stringBuilder.Append( "Appointment can not be scheduled");
            }
            return stringBuilder.ToString();
        }
    }
}
