using BossBabeProjectLibrary;

const string server = "localhost\\sqlexpress";
const string database = "BossBabeProject";

var projectctrlr = new ProjectController(server, database);
projectctrlr.OpenConnection();

Console.WriteLine($"{ProjectController.UpdateHoursWorked(2)}"); ;

projectctrlr.CloseConnection();
//var workctrlr = new WorkController(server, database);
//workctrlr.OpenConnection();
