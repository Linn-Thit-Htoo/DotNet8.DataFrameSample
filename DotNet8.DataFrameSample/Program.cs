using DotNet8.DataFrameSample;
using DotNet8.DataFrameSample.Models;
using Newtonsoft.Json;

AppDbContext _appDbContext = new();

var jsonStr = await File.ReadAllTextAsync("Data/Tbl_State,json.json");
List<StateModel> stateLst = JsonConvert.DeserializeObject<List<StateModel>>(jsonStr)!;

var dataLst = stateLst.Select(item => new StateDataModel()
{
    StateCode = item.StateCode,
    StateName = item.StateName
});

await _appDbContext.State.AddRangeAsync(dataLst);
int result = await _appDbContext.SaveChangesAsync();

Console.WriteLine($"Result: {result}");

Console.WriteLine("json str: " + jsonStr);