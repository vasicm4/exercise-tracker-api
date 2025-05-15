public interface IExerciseService 
{
    Exercise? GetExerciseById(int id);
    List<Exercise> GetAllExercises();
    Exercise AddExercise(Exercise exercise);
    void UpdateExercise(Exercise exercise);
    string? DeleteExercise(int id);
}

public class ExerciseService: IExerciseService
{
    public readonly IExerciseRepository Repository;
    public ExerciseService(IExerciseRepository repository)
    {
        Repository = repository;
    }

    public Exercise? GetExerciseById(int id)
    {
        return Repository.GetById(id);
    }

    public List<Exercise> GetAllExercises()
    {
        return Repository.GetAll();
    }

    public Exercise AddExercise(Exercise exercise)
    {
        return Repository.Add(exercise);
    }

    public void UpdateExercise(Exercise exercise)
    {
        Repository.Update(exercise);
    }

    public string? DeleteExercise(int id)
    {
        return Repository.Delete(id);
    }
}