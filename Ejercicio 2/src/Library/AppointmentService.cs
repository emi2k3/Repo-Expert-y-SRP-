using System;
using System.Text;

namespace Library
{
    public class ValidatePacientData
    {
        
        public string name { get ; }
        public int age {get ; }
        public string id {get ; }
        public string phonenumber {get ;}
        public int valid=0;
  // Datos esperados por el paciente y valid suma todos los int, y si da 4(La cantidad de atributos) es valido.
        void Validatename(ValidatePacientData Validate){
            if (string.IsNullOrEmpty(Validate.name)){
                Console.WriteLine("Name is null or empty, check again");
            }
            else{
                this.valid+=1;
            }
        }
        void Validateage(ValidatePacientData Validate){
             if (string.IsNullOrEmpty(Validate.age.ToString())){
                Console.WriteLine("Age is null or empty, check again");
            }
            else{
               this.valid+=1;;
            }
        }
        void Validateid(ValidatePacientData Validate){
             if (string.IsNullOrEmpty(Validate.id)){
                Console.WriteLine("ID is null or empty, check again");
            }
            else{
                this.valid+=1;;
            }
        }
        void Validatephonenumber(ValidatePacientData Validate){
             if (string.IsNullOrEmpty(Validate.phonenumber)){
                Console.WriteLine("Phone number is null or empty, check again");
            }
            else{
                this.valid+=1;;
            }
        }

        public int getvalid(){
            return this.valid;
        }
        
            
        
        public ValidatePacientData(string name, int age, string id, string phonenumber){
            this.name=name;
            this.age=age;
            this.id=id;
            this.phonenumber=phonenumber;
        }


        
    }
        public class Pacient
    {
        
        public string name { get ; }
        public int age {get ; }
        public string id {get ; }
        public string phonenumber {get ;}   

          public Pacient(string name, int age, string id, string phonenumber){
            this.name=name;
            this.age=age;
            this.id=id;
            this.phonenumber=phonenumber;

        }

    
    }
       public class ValidateDocData
    {
        
        public string name { get ; }
        public string speciality {get ; }
        public int valid=0;
  // Datos esperados por el Doctor y valid suma todos los int, y si da 2(La cantidad de atributos) es valido.
        void Validatename(ValidateDocData Validate){
            if (string.IsNullOrEmpty(Validate.name)){
                Console.WriteLine("Name is null or empty, check again");
            }
            else{
                this.valid+=1;
            }
        }
      void Validatspeciality(ValidateDocData Validate){
            if (string.IsNullOrEmpty(Validate.speciality)){
                Console.WriteLine("Speciality is null or empty, check again");
            }
            else{
                this.valid+=1;
            }
        }

        public int getvalid(){
            return this.valid;
        }
        
            
        
        public ValidateDocData(string name, string speciality){
            this.name=name;
            this.speciality=speciality;
        }



}
 public class Doctor
    {
        
        public string name { get ; }
        public string speciality {get ; }
        public Doctor(string name, string speciality){
            this.name=name;
            this.speciality=speciality;
        }


}
public class ValidatePlaceDateData
    {
        
        public string place { get ; }
        public DateTime date {get ; }
        public int valid=0;
  // Datos esperados por el (lugar y fecha) y valid suma todos los int, y si da 2(La cantidad de atributos) es valido.
        void Validateplace(ValidatePlaceDateData Validate){
            if (string.IsNullOrEmpty(Validate.place)){
                Console.WriteLine("Place is null or empty, check again");
            }
            else{
                this.valid+=1;
            }
        }
      void Validatedate(ValidatePlaceDateData Validate){
            if (string.IsNullOrEmpty(Validate.date.ToString())){
                Console.WriteLine("Date is null or empty, check again");
            }
            else{
                this.valid+=1;
            }
        
        
        }
          public int getvalid(){
            return this.valid;
        }
        public ValidatePlaceDateData(string place, DateTime date){
            this.place=place;
            this.date=date;
        }
}

    public class PlaceData
    {
        
        public string place { get ; }
        public DateTime date {get ; }
        public int valid=0;
  // Datos esperados por el (lugar y fecha) y valid suma todos los int, y si da 2(La cantidad de atributos) es valido.
        public PlaceData(string place, DateTime date){
            this.place=place;
            this.date=date;
        }
    }

    public class Appointment 
    {
        private static int idappo=0;
        public Doctor Doc{get;}
        public Pacient Pac{get;}
        public PlaceData Pldate{get;}

        public Appointment(Doctor Doctor,Pacient Pacient,PlaceData placeData){
            this.Doc=Doctor;
            this.Pac=Pacient;
            this.Pldate=placeData;
            idappo++;
            Console.WriteLine($"You have to come in {placeData.date} on {placeData.place} to be attended by {Doctor.name}. Doctor speciality is {Doctor.speciality}");
        }

    }

}