using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WappaMobile.ChallengeDev.Models;

namespace WappaMobile.ChallengeDev.GoogleMaps
{
    public class GeoCodeServices
    {
        public async Task<Coordinate> SearchAsync(Address address)
        {
            if (address == null || !address.IsValid)
                throw new ArgumentNullException(nameof(address));

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Settings.URL_BASE);
                var result = await client.GetAsync($@"json?address={address}&key={Settings.API_KEY}");

                if (result.IsSuccessStatusCode)
                {
                    var e = JsonConvert.DeserializeObject<GeoCode>(await result.Content.ReadAsStringAsync());

                    if (e.status.Equals("REQUEST_DENIED"))
                        throw new GoogleMapsRequestDeniedExcepion("Check the API_KEY.");
                    else
                    {
                        var c = new Coordinate(e.lat, e.lng);

                        if (!c.IsEmpty) 
                            return c;
                    }
                }
            }

            throw new AddressNotFoundException(address);
        }
    }
}
