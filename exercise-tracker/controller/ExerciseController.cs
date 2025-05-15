using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ExerciseController: ControllerBase
{
    private readonly IExerciseService Service;
    public ExerciseController(IExerciseService service)
    {
        Service = service;
    }

    [HttpGet("{id}")]
    public ActionResult<Exercise?> GetExerciseById(int id)
    {
        Exercise? exercise = Service.GetExerciseById(id);
        if (exercise == null)
        {
            return NotFound();
        }
        return Ok(exercise);
    }
    
    [HttpGet]
    public ActionResult<List<Exercise>> GetAll()
    {
        return Ok(Service.GetAllExercises());
    }

    [HttpPost]
    public ActionResult Add(Exercise exercise)
    {
        return Ok(Service.AddExercise(exercise));
    }

    [HttpPut]
    public ActionResult ActionResultUpdate(Exercise exercise)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult<string?> Delete(int id)
    {
        string? ret = Service.DeleteExercise(id);
        if (ret == null)
        {
            return NotFound();
        }
        return Ok(ret);
    }
}