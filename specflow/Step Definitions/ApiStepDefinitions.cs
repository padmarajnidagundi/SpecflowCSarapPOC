using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Configuration;
using System.Net.Http;
using System.Text;
using TechTalk.SpecFlow;

namespace specflow
{
    [Binding]
    public class ApiStepDefinitions
    {
        private static readonly string _baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private static readonly HttpClient _httpClient = new HttpClient();
        private HttpResponseMessage _response;
        private string _responseBody;

        [Given(@"I send a GET request to ""(.*)""")]
        public void GivenISendAGETRequestTo(string path)
        {
            _response = _httpClient.GetAsync(_baseUrl + path).Result;
            _responseBody = _response.Content.ReadAsStringAsync().Result;
        }

        [Given(@"I send a POST request to ""(.*)"" with body:")]
        public void GivenISendAPOSTRequestToWithBody(string path, string body)
        {
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            _response = _httpClient.PostAsync(_baseUrl + path, content).Result;
            _responseBody = _response.Content.ReadAsStringAsync().Result;
        }

        [Then(@"the response status code should be (\d+)")]
        public void ThenTheResponseStatusCodeShouldBe(int expectedStatusCode)
        {
            Assert.AreEqual(expectedStatusCode, (int)_response.StatusCode,
                $"Expected status code {expectedStatusCode} but got {(int)_response.StatusCode}");
        }

        [Then(@"the response body should contain ""(.*)""")]
        public void ThenTheResponseBodyShouldContain(string expectedText)
        {
            Assert.IsTrue(_responseBody.Contains(expectedText),
                $"Response body did not contain '{expectedText}'. Actual body: {_responseBody}");
        }

        [Then(@"the response should contain more than (\d+) items")]
        public void ThenTheResponseShouldContainMoreThanItems(int minimumCount)
        {
            var array = JArray.Parse(_responseBody);
            Assert.Greater(array.Count, minimumCount,
                $"Expected more than {minimumCount} items but got {array.Count}");
        }
    }
}
