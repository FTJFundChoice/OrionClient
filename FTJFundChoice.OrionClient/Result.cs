using RestSharp;
using System;
using System.Net;

namespace FTJFundChoice.OrionClient {

    public interface IResult {
        string Content { get; set; }
        Exception ErrorException { get; set; }
        string ErrorMessage { get; set; }
        ResponseStatus ResponseStatus { get; set; }
        HttpStatusCode StatusCode { get; set; }
        string StatusDescription { get; set; }

        OrionException OrionException { get; }
    }

    public class Result : IResult {
        public string Content { get; set; }

        // Summary:
        //     Exceptions thrown during the request, if any.
        //
        // Remarks:
        //     Will contain only network transport or framework exceptions thrown during the
        //     request. HTTP protocol errors are handled by RestSharp and will not appear here.
        public Exception ErrorException { get; set; }

        // Summary:
        //     Transport or other non-HTTP error generated while attempting request
        public string ErrorMessage { get; set; }

        // Summary:
        //     Status of the request. Will return Error for transport errors. HTTP errors will
        //     still return ResponseStatus.Completed, check StatusCode instead
        public ResponseStatus ResponseStatus { get; set; }

        // Summary:
        //     HTTP response status code
        public HttpStatusCode StatusCode { get; set; }

        // Summary:
        //     Description of HTTP status returned
        public string StatusDescription { get; set; }

        public OrionException OrionException {
            get {
                if (StatusCode == HttpStatusCode.OK || string.IsNullOrEmpty(Content)) {
                    return null;
                }
                return SimpleJson.DeserializeObject<OrionException>(Content, SimpleJson.DataContractJsonSerializerStrategy);
            }
        }

        public Result(IRestResponse response) {
            ErrorException = response.ErrorException;
            ErrorMessage = response.ErrorMessage;
            ResponseStatus = response.ResponseStatus;
            StatusCode = response.StatusCode;
            StatusDescription = response.StatusDescription;
            Content = response.Content;
        }
    }

    public class Result<T> : Result {

        public Result(IRestResponse<T> response) : base(response) {
            Data = response.Data;
        }

        public T Data { get; set; }
    }
}