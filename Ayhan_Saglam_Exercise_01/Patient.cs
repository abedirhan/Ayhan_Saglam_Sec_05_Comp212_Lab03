using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayhan_Saglam_Exercise_01
{
   public class Patient
    {// Fields
        private string _patientName;
        private string _patientAddress;
        private double _value;
        private string _province;
        // Getters and Setters
        public string PatientName
        {
            get => _patientName;
            set => _patientName = value;
        }

        public string PatientAddress
        {
            get => _patientAddress;
            set => _patientAddress = value;
        }

        public double Value
        {
            get => _value;
            set => _value = value;
        }

        public string Province
        {
            get => _province;
            set => _province = value;
        }
        //No argument constructor
        public Patient()
        {
            
        }
        //Patient object constructor
        public Patient(string patientName, string patientAddress, double value, string province)
        {
            _patientName = patientName;
            _patientAddress = patientAddress;
            _value = value;
            _province = province;
        }

        public override string ToString()
        {
            return $"{PatientName}  {Value} ";
        }
    }
}
