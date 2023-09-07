var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var company = new Company("Nestle", 25000, "Foodstuffs");

app.MapGet("/First exercise", () => $"{company.Name} - {company.QuantityOfWorkers} - {company.Occupation}");
app.MapGet("/Second exercise", () => new Random().Next(0, 101).ToString());

app.Run();

class Company
{
    public string Name { get; set; }
    public int QuantityOfWorkers { get; set; }
    public string Occupation { get; set; }

    public Company(string name, int quantityOfWorkers, string occupation)
    {
        Name = name;
        QuantityOfWorkers = quantityOfWorkers;
        Occupation = occupation;
    }
}







