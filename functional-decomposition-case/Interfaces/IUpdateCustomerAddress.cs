using functional_decomposition_case.Dto;

namespace functional_decomposition_case.Interfaces
{
    public interface IUpdateCustomerAddress
    {
        void ChangeCustomerAddress(Customer customer, string address);
    }
}