namespace dot
{
    //This the base class of all taxes 
    public abstract class Tax
    {
        
        //Holds the real value of the salary
        protected float _baseSalary;
    
        //Must act like a property and implement business logic
        public float BaseSalary;

        //Calculate the Offet based on the BaseSalary (Remember to use the public one)
        abstract public float CalculateOffsets();

        //Calculate the Deductions based on the BaseSalary (Remember to use the public one)
        abstract public float CalculateDeductions();

        abstract public string OffsetDescription();

        abstract public string DeductionsDescription();
    }
}