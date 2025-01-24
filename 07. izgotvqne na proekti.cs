string architect_name = Console.ReadLine();
int needed_hours_to_complete = int.Parse(Console.ReadLine());

int one_project = 3;

int count_projects = needed_hours_to_complete * one_project;

Console.WriteLine($"The architect {architect_name} will need {count_projects} hours to complete {needed_hours_to_complete} project/s.");