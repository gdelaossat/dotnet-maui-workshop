namespace MonkeyFinder.Services;
using System.Net.Http.Json;

public class MonkeyService
{

    List<Monkey> monkeyList = new();
    public async Task<List<Monkey>> GetMonkeys()
    {
        if (monkeyList?.Count > 0)
            return monkeyList;

        var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");

        if (response.IsSuccessStatusCode)
        {
            monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
        }

        return monkeyList;

    }

    HttpClient httpClient;
    public MonkeyService()
    {
        this.httpClient = new HttpClient();
    }





}
