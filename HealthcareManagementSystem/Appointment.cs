//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthcareManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public Appointment()
        {
            
        }

        public Appointment(string cost, DateTime dateTime, string natureOfAct, Patient patient)
        {
            DateAndTime = dateTime;
            Cost = cost;
            NatureOfAct = natureOfAct;
            Patient = patient;
        }


        public int IdAppointment { get; set; }
        public System.DateTime DateAndTime { get; set; }
        public string Cost { get; set; }
        public string NatureOfAct { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
