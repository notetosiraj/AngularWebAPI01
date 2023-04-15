namespace CRM01.Core
{
    public interface IUnitOfWork
    {
        IEmployeeRespository employeeRespository { get; set; }        

      //  void Commit();
            
        int Complete();
    
    }
}
