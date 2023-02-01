using System.Threading.Tasks;
using RestSharp;

namespace CretaceousClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhnost:5000/");
      RestRequest request = new RestRequest($"api/animals", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
  }
}
