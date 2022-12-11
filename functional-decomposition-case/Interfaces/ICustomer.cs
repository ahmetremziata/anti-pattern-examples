using functional_decomposition_case.Dto;

namespace functional_decomposition_case.Interfaces
{
    public interface ICustomer
    {
        Customer AddCustomer(string identityNo, string name, string surname);
    }
}