using Garage;
            

Zero fxs = new Zero()
        {
            MainColor = "Red",
            BatteryKWh = 50,
            MaximumOccupancy = 2
        };

        Tesla modelS = new Tesla()
        {
            MainColor = "Blue",
            BatteryKWh = 75,
            MaximumOccupancy = 5
        };

        Ram ramTruck = new Ram()
        {
            MainColor = "Green",
            FuelCapacity = 30,
            MaximumOccupancy = 3
        };

        Cessna mx410 = new Cessna()
        {
            MainColor = "White",
            FuelCapacity = 100,
            MaximumOccupancy = 2
        };

        
        fxs.Drive();
        fxs.Turn("left");
        fxs.Stop();

        modelS.Drive();
        modelS.Turn("right");
        modelS.Stop();

        ramTruck.Drive();
        ramTruck.Turn("left");
        ramTruck.Stop();

        mx410.Drive();
        mx410.Turn("right");
        mx410.Stop();






//////////DONT TOUCH THIS CODE//////////////////////////////////////////////////////////////////////////////////////


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




app.Run();

