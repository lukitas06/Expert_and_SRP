using System;
using System.Text;

namespace Library
{
    public class Patient{
        
        string Name{get;}
        int PhoneNumber{get;}
        int Age{get;}
    
        public   Patient(string name, int phone,int age){
            this.Name=name;
            this.PhoneNumber=phone;
            this.Age=age;
        }

        public string validPatient(){
            StringBuilder stringBuilder = new StringBuilder("");
            Boolean patientIsValid = true;

            if (this.Name=="")
            {
                stringBuilder.Append("Invalid patient name\n");
                patientIsValid = false;
            }
            if (this.PhoneNumber.ToString()=="")
            {
                stringBuilder.Append("Invalid patient phone number\n");
                patientIsValid = false;
            }
            if (this.Age.ToString()=="")
            {
                stringBuilder.Append("Invalid patient age\n");
                patientIsValid = false;
            }
            if(patientIsValid){
                stringBuilder.Append("The patient data is valid\n");
            }
            return stringBuilder.ToString();
        }
        public string getPatient(){
            if(validPatient()=="The patient data is valid"){
                return $"Name: {this.Name}, Phone number: {this.PhoneNumber}, Age: {this.Age} ";
            }
            return "None";
        }
    }

}