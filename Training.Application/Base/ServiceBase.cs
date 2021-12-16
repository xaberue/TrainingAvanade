using Training.Core.Repositories;

namespace Training.Application.Base
{
    public class ServiceBase
    {

        protected readonly IUnitOfWork _unitOfWork;


        protected ServiceBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
