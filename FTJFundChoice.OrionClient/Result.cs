using Newtonsoft.Json;
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

    public interface IResult<T> : IResult {
        T Data { get; }
    }

    public class Result : IResult {
        public string Content { get; set; }
        public Exception ErrorException { get; set; }
        public string ErrorMessage { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }

        public bool Success {
            get {
                return StatusCode == HttpStatusCode.OK;
            }
        }

        public OrionException OrionException {
            get {
                if (StatusCode == HttpStatusCode.OK || string.IsNullOrEmpty(Content)) {
                    return null;
                }
                return JsonConvert.DeserializeObject<OrionException>(Content);
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

    public class Result<T> : Result, IResult<T> {

        public Result(IRestResponse<T> response) : base(response) {
            Data = response.Data;
        }

        public T Data { get; set; }
    }
}