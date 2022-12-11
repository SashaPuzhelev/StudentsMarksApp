using ConsoleApp1;

var driver = new Driver();
driver.Name = "Sasha";
driver.Age = 18;
driver.Sex = "м";
Human human = driver;
if (human is Driver driver1)
{
    human = driver1;
}
human.GetInfo();
Console.ReadKey();

Animal[] animals = new Animal[5];

