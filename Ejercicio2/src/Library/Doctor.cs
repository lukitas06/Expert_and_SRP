using System;
using System.Text;

namespace Library
{
    public class Doctor{
        public string Name{get;}
        public string SpecialField{get;}

        public Doctor(string name, string specialField){
            this.Name=name;
            this.SpecialField= specialField;

        }
        public string validDoctor(){
            StringBuilder stringBuilder = new StringBuilder("");
            Boolean doctorIsValid = true;

            if (string.IsNullOrEmpty(this.Name))
            {
                stringBuilder.Append("Invalid doctor name\n");
                doctorIsValid = false;
            }
            if (string.IsNullOrEmpty(this.SpecialField))
            {
                stringBuilder.Append("Invalid doctor special field\n");
                doctorIsValid = false;
            }
            if(doctorIsValid){
                stringBuilder.Append("The doctor data is valid\n");
            }
            return stringBuilder.ToString();
        }
        public  string getDoctor()
        {
            if(validDoctor()=="The doctor data is valid"){
                return $"Name: {this.Name}, Special field: {this.SpecialField} ";
            }
            return "None";
        }
    }
}