using System.Net.Http.Headers;
namespace BusinessLogic;

public class StudentDataBAL
{
    public async Task<int[]> GetStudentDataAsync()
    {
        await Task.CompletedTask;
        return [2, 7, 9, 3];
    }

    public async Task<dynamic> getRapido()
    {
        var body = "";
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://dummy.restapiexample.com/api/v1/employees"),
            Headers =
    {
        { "accept", "application/json" }
    },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
        return body;
    }
}