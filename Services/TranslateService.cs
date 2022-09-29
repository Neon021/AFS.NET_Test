using AFS.NET_Test.DataAccess;
using AFS.NET_Test.ViewModels;
using System.Text.Json;

namespace AFS.NET_Test.Services
{
    public class TranslateService : ITranslateService
    {
        private HttpClient _httpclient;
        private CRUD_Record _cRUD;

        public TranslateService(HttpClient httpClient, CRUD_Record cRUD)
        {
            _httpclient = httpClient;
            _cRUD = cRUD;

        }
        public async Task<TranslateViewModel> Translate(TranslateViewModel vm)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"https://api.funtranslations.com/translate/shakespeare.json?text={vm.contents.text}");
            
            using (var request = await _httpclient.SendAsync(requestMessage))
            {
                request.EnsureSuccessStatusCode();

                var response = await request.Content.ReadAsStreamAsync();
                var responseObject = await JsonSerializer.DeserializeAsync<TranslateViewModel>(response);

                await _cRUD.CreateRecord(new Models.Record { Input = vm.contents.text, Output = vm.contents.translated, Date = DateTime.Now });
                return responseObject;
            }
        }
    }
}
