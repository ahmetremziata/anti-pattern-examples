using System;
using functional_decomposition_case.Interfaces;

namespace functional_decomposition_case.Dto
{
    public class PaymentScheduleChange : IPaymentScheduleChange
    {
        public void AlterPaymentSchedule(Customer customer)
        {
            Console.WriteLine("Changing payment schedule to specific customer " + customer);
        }
    }
}