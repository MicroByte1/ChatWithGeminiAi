

using System.Net.Http.Json;
using Newtonsoft.Json;

public class Model {

    public static string apiUrl = "Your_Api_Key_Here";

    private Request request;

    private HttpClient client;

    private string ResponseMessage;

    public Model()
    {
        request = new Request(){
            Contents = new List<Content>(){
                new Content(){
                    Parts = new List<Part>(){
                        new Part()
                    }
                }
            }
        };

        ResponseMessage = "No Val";

        client = new HttpClient();
    }

    public async Task<bool> SendRequest(string chatMessage){
        request.Contents.First().Parts.First().Text = chatMessage;
        HttpResponseMessage res = await client.PostAsJsonAsync(apiUrl, request);
        if (res.IsSuccessStatusCode){
            string data = await res.Content.ReadAsStringAsync();
            Response? response = JsonConvert.DeserializeObject<Response>(data);
            if (response != null){
                ResponseMessage = response.Candidates.First().Content.Parts.First().Text;
                return true;
            }
        }
        
        return false;
    }

    public override string ToString()
    {
        return $"AI Message : {ResponseMessage}";
    }
}