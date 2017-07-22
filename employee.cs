

namespace dot
{
    using System;
    public class employee
    {
        enum nations {Australia};
        #region base_fields 
        private nations _nationality; //Could be a enum but we can forget some nations 
        private float _baseSalary; //Could be a struct (must be discussed)
        //private Tax _tax;
        private AustraliaTax _tax;
        #endregion

        #region Properties
        //For sanity implemnt business logic here

        //Property that respond the nationality, one may try to use others the ones contained in nations
        public string Nationality
        {
            get
            {
                return ((nations)_nationality).ToString();
            }
            set
            {
                string buf = value.ToLower();
                if(!Enum.TryParse<nations>(value,out _nationality))
                {
                    //Other actions may be needed, must dicuss
                    throw new Exception("Country is invalid");
                }
                switch (_nationality)
                {
                    case 0: //Australia
                        _tax = new AustraliaTax(_baseSalary);
                        break;
                    default:
                        throw new Exception("Developer did not implemented it");
                }
            }
        }


        //this is the salary, it must be greater than 0
        public float BaseSalary
        {
            get
            {
                return _baseSalary;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Salary must be greater than zero");
                }
                _baseSalary = value;
                _tax.BaseSalary = BaseSalary;
            }
        }

        //this is the rounded salary for standard sake - Read Only
        //One may test if 
        public int UpRoundedBaseSalary
        {
            get
            {
                return (int)Math.Ceiling(_baseSalary);
            }
        }
        #endregion


        #region Constructors

        public employee(string nationality, float baseSalary)
        {
            Nationality = nationality; //This will set country and the tax count, but not the tax base salary
            BaseSalary = baseSalary; //This will set the base salary and the tax base salary 
        }

        #endregion

        #region Methods

        #endregion
    }
}