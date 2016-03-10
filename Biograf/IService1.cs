using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Biograf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        //[WebGet(ResponseFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle =
        WebMessageBodyStyle.Wrapped, UriTemplate = "getMoviesDate/{date}")]
        string GetMoviesDate(string date);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle =
        WebMessageBodyStyle.Wrapped, UriTemplate = "addMovie/{date}/{title}/{description}/{urlPicture}")]
        String PutNewMovie(string date, string title, string description, string urlPicture);
        
    }
    
}
