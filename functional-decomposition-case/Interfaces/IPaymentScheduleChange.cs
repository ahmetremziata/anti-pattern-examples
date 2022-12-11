using functional_decomposition_case.Dto;

namespace functional_decomposition_case.Interfaces
{
    public interface IPaymentScheduleChange
    {
        void AlterPaymentSchedule(Customer customer);
    }
}