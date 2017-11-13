﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Engineering_2017
{
    class Constants
    {

        //times
        public static TimeSpan openTime = new TimeSpan(09, 00, 00);
        public static TimeSpan CloseTime = new TimeSpan(18, 00, 00);
        public static TimeSpan appointmentLength = new TimeSpan(00, 15, 00);
        /*********************************** Selects ****************************************/
        public static string selectAllStaff = "SELECT * FROM Staff";
        public static string selectAllPatients = "SELECT * FROM Patients";
        public static string selectingLogin = "SELECT Staff_ID, Password FROM Staff";
        public static string selectAllGPAppointment = "SELECT Staff_ID,Firstname,Surname FROM Staff WHERE staff_Type ='GP'";
        public static string selectAllNurseAppointment = "SELECT Staff_ID,Firstname,Surname FROM Staff WHERE staff_Type ='Nurse'";
        public static string selectStaffMember = "SELECT Date,Time From Appointments WHERE Staff_ID = @StaffID";
        public static string selectTime = "SELECT Time From Appointments WHERE Staff_ID = @StaffID AND Date = @Date";


        public static string selectPatientByID = "SELECT * From Patients WHERE Patient_ID =@patientID";
        public static string selectPatientByDOB = "SELECT * From Patients WHERE Firstname=@firstname AND Surname=@surname and DOB=@dob";
        public static string selectPatientByAddress = "SELECT * From Patients WHERE Firstname=@firstname AND Surname=@surname and AddressLine=@address";

        public static string updatePatient = "UPDATE Patients SET Firstname=@firstname, Surname =@Surname , DOB =@DOB, AddressLine=@AddressLine, TownCity=@TownCity, County=@County, Postcode=@Postcode WHERE Patient_ID =@patientID";

        /*************************************** Inserts *******************************************/
        public static string insertNewPatient = "INSERT INTO[dbo].[Patients]([Firstname], [Surname], [DOB], [AddressLine], [TownCity], [County], [Postcode]) VALUES(@Firstname,@Surname,@DOB,@AddressLine,@TownCity,@County,@Postcode)";

    }
}
