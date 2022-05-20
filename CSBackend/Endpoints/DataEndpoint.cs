using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Server.Models;
using Server.HTTP;
using System.Net;
using CSBackend;

namespace Server.Endpoints
{
    [EndpointPath("/data")]
    class DataEndpoint
    {
        public DataEndpoint(){}


        [EndpointMethod("GET")]
        public Response GetUsers(Request request, Response response)
        {
            try
            {                
                response.Content = DummyData.getData();
                response.Status = HttpStatusCode.OK;                
            }            
            catch
            {
                response.Status = HttpStatusCode.BadRequest;        
            }
            return response;
        }
    }
}
