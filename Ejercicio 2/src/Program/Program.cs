using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
          ValidatePacientData validdatpa= new ValidatePacientData("Joaco",12,"43433423-5","099482993");//Valida datos de paciente.
          ValidateDocData validdatdoc=new ValidateDocData("Jose Perez","Oftalmologo"); //Valida datos de Doctor.
          ValidatePlaceDateData validdpladat=new ValidatePlaceDateData("Av.Batlle Berres",DateTime.Now); //Valida lugar y fecha.
           if (validdatpa.getvalid()==4&&validdatdoc.getvalid()==2&&validdpladat.getvalid()==2)
           {//Mira que todos los datos sean validos
            Pacient newPacient = new Pacient(validdatpa.name,validdatpa.age,validdatpa.id,validdatpa.phonenumber);// Crea paciente
            Doctor newDoctor = new Doctor(validdatdoc.name,validdatdoc.speciality); //Crea Doctor
            PlaceData newPlacedate = new PlaceData(validdpladat.place,validdpladat.date); //Crea Lugar y fecha
            Appointment newAppointment = new Appointment(newDoctor,newPacient,newPlacedate);//Crea citación.
           }
           else{
                Console.WriteLine("Los datos ingresados son incorrectos, reviselos");
               }
         
           
         
          
          }


          }
        

         

        }

