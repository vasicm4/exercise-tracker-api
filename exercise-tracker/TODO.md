This is an application where you should record exercise data. DONE

You should choose one type of exercise only. We want to keep the app simple so you focus on the subject you're learning and not on the business complexities. DONE

You can choose raw SQL or Entity Framework for your data-persistence. DONE

The model for your exercise class should have at least the following properties: 
    {Id INT, 
    DateStart DateTime, 
    DateEnd DateTime, 
    Duration TimeSpan, 
    Comments string} 
    DONE

Your application should have the following classes: 
UserInput, 
ExerciseController,
ExerciseService (where business logic will be handled) and 
ExerciseRepository. 
These classes might feel empty at first but they'll be needed in most applications as they grow.

You can choose between SQLite or SQLServer. DONE

You need to use dependency injection to access the repository from the controller. DONE

Don't forget to add validation to your app. 

Don't forget to create a Github repository for your project from the beginning.  DONE

You might come across the concept of Unit of Work in some tutorials. I suggest you don't use it, so you focus on learning how a single repository works. DONE

Keep your application simple (only one table). Complexity is your enemy at the moment, since you want to focus solely on learning the pattern. DONE

To illustrate the Separation of Concerns by the repository pattern, create a different branch of your project where you'll replace Entity Framework by Dapper or ADO.NET in your repository. You'll notice that you won't need to touch your controller.

Create an application with two types of exercises (ex. weights and cardio), using EF for one and Raw SQL for the other