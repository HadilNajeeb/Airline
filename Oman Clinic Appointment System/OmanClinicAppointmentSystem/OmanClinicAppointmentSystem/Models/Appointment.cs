﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System.Models
{
    internal class Appointment
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public Doctor Doctor { get; set; }
        
        public Patient Patient { get; set; }
      

        public Appointment(string date, Doctor doctor, Patient patient)
        {
           
            this.Date = date;
            this.Doctor = doctor;
            this.Patient = patient;

        }


    }
}
