namespace dot
{
    using System;
    public class AustraliaTax// : Tax
    {

        public AustraliaTax(float sal)
        {
            BaseSalary = sal;
        }

        private float _baseSalary;

        public float BaseSalary
        {
            get
            {
                return _baseSalary;
            }
            set
            {
                if(value<=0)
                {
                    throw new Exception("Salary must be greater than 0");
                }
                _baseSalary = value;
            }
        }

        //Calculate the Offet based on the BaseSalary (Remember to use the public one)
        public float CalculateOffsets()
        {
            //first test -OK
            float tmp = _baseSalary;
            
            return tmp;
        }

        //Calculate the Deductions based on the BaseSalary (Remember to use the public one)
        public float CalculateDeductions()
        {return 0;}

        public string OffsetDescription()
        {return "";}

        public string DeductionsDescription()
        {return "";}
    
        //private func

        private float CompulsoryMedicare()
        {
            float temp = _baseSalary;
            if(temp <= 211335) //Do a rg test - Ok
            {
                return temp;
            }
            if(temp <= 21.336)//DO a 
            {
                return temp * 0.8; //reduce 20%
            }
            
            return 0;
        }

    }
}