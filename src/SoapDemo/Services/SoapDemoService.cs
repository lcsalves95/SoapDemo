using System.Xml;

namespace SoapDemo.Services
{
    public class SoapDemoService : SOAPDemoSoap
    {
        private readonly SOAPDemoSoapClient _client;

        public SoapDemoService()
        {
            _client = new SOAPDemoSoapClient();
        }

        public async Task<long> AddIntegerAsync(long Arg1, long Arg2)
        {
            return await _client.AddIntegerAsync(Arg1, Arg2);
        }

        public async Task<long> DivideIntegerAsync(long Arg1, long Arg2)
        {
            if (Arg2 == 0) throw new ArgumentException("Divisor não pode ser igual a zero.");
            return await _client.DivideIntegerAsync(Arg1, Arg2);
        }

        public async Task<Person> FindPersonAsync(string id)
        {
            return await _client.FindPersonAsync(id);
        }

        public async Task<ArrayOfXElement> GetByNameAsync(string name)
        {
            return await _client.GetByNameAsync(name);
        }

        public async Task<XmlElement> GetDataSetByNameAsync(string name)
        {
            return await _client.GetDataSetByNameAsync(name);
        }

        public async Task<PersonIdentification[]> GetListByNameAsync(string name)
        {
            return await _client.GetListByNameAsync(name);
        }

        public async Task<Address> LookupCityAsync(string zip)
        {
            return await _client.LookupCityAsync(zip);
        }

        public async Task<string> MissionAsync()
        {
            return await _client.MissionAsync();
        }

        public async Task<XmlElement> QueryByNameAsync(string name)
        {
            return await _client.QueryByNameAsync(name);
        }
    }
}
