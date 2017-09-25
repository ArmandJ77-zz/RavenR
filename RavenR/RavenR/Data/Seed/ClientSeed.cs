using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RavenR.Models;

namespace RavenR.Data.Seed
{
  public static class ClientSeed
  {
    public static List<Client> Clients =>
      JsonConvert.DeserializeObject<List<Client>>(@"[{
                        ""Name"": ""Frederick"",
                        ""LastName"": ""Archer"",
                        ""Email"": ""farcher0@wsj.com""
                      }, {
                        ""Name"": ""Meara"",
                        ""LastName"": ""Horley"",
                        ""Email"": ""mhorley1@ebay.co.uk""
                      }, {
                        ""Name"": ""Addia"",
                        ""LastName"": ""Gambles"",
                        ""Email"": ""agambles2@wikispaces.com""
                      }, {
                        ""Name"": ""Hart"",
                        ""LastName"": ""MacDermot"",
                        ""Email"": ""hmacdermot3@pen.io""
                      }, {
                        ""Name"": ""Ki"",
                        ""LastName"": ""Lavallin"",
                        ""Email"": ""klavallin4@guardian.co.uk""
                      }, {
                        ""Name"": ""Jacklin"",
                        ""LastName"": ""Danford"",
                        ""Email"": ""jdanford5@amazon.co.uk""
                      }, {
                        ""Name"": ""Rod"",
                        ""LastName"": ""Cuxon"",
                        ""Email"": ""rcuxon6@google.pl""
                      }, {
                        ""Name"": ""Care"",
                        ""LastName"": ""Rogge"",
                        ""Email"": ""crogge7@utexas.edu""
                      }, {
                        ""Name"": ""Shaina"",
                        ""LastName"": ""Weitzel"",
                        ""Email"": ""sweitzel8@a8.net""
                      }, {
                        ""Name"": ""Noel"",
                        ""LastName"": ""Cowerd"",
                        ""Email"": ""ncowerd9@chicagotribune.com""
                      }]");
  }
}
