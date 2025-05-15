public interface IExerciseRepository: IRepository<Exercise>
{

}

public class ExerciseRepository: Repository<Exercise>, IExerciseRepository
{
    public ExerciseRepository(DbContext<Exercise> context): base(context)
    {
    }

}