using functional_decomposition_case.Dto;

namespace functional_decomposition_case.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(string identityNo);
        void AddCustomer(Customer customer);
    }
}