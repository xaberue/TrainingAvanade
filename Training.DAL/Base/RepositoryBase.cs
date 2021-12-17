using Training.DAL.Context;

namespace Training.DAL.Base
{
    public class RepositoryBase
    {

        protected readonly TrainingDbContext _trainingDbContext;


        protected RepositoryBase(TrainingDbContext trainingDbContext)
        {
            _trainingDbContext = trainingDbContext;
        }

    }
}
