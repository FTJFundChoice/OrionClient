using FTJFundChoice.OrionClient.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Net;
using System.Net.Http;

namespace FTJFundChoice.OrionClient {

    public interface IResult {
        string Content { get; }
        OrionException OrionException { get; }
        string ReasonPhrase { get; }
        StatusCode StatusCode { get; }
        string StatusDescription { get; }
        bool Success { get; }
    }

    public interface IResult<T> : IResult {
        T Data { get; }
    }

    public class Result : IResult {

        public Result(HttpResponseMessage response) {
            Success = response.IsSuccessStatusCode;
            ReasonPhrase = response.ReasonPhrase;
            StatusCode = ConvertStatusCode(response.StatusCode);
            StatusDescription = GetStatusCodeValue(StatusCode);
            Content = response.Content.ReadAsStringAsync().Result;

            if (StatusCode != StatusCode.OK)
                OrionException = ConvertContentToException();
        }

        public string Content { get; private set; }
        public OrionException OrionException { get; private set; }
        public string ReasonPhrase { get; private set; }
        public StatusCode StatusCode { get; private set; }
        public string StatusDescription { get; private set; }
        public bool Success { get; private set; }

        internal OrionException ConvertContentToException() {
            var exception = JsonConvert.DeserializeObject<OrionException>(Content);
            return exception;
        }

        internal StatusCode ConvertStatusCode(HttpStatusCode status) {
            switch (status) {
                case HttpStatusCode.Accepted:
                    return StatusCode.Accepted;

                case HttpStatusCode.BadRequest:
                    return StatusCode.BadRequest;

                case HttpStatusCode.Forbidden:
                    return StatusCode.Forbidden;

                case HttpStatusCode.NotFound:
                    return StatusCode.NotFound;

                case HttpStatusCode.OK:
                    return StatusCode.OK;

                case HttpStatusCode.Unauthorized:
                    return StatusCode.Unauthorized;

                case HttpStatusCode.Found:
                    return StatusCode.Found;

                case HttpStatusCode.MethodNotAllowed:
                    return StatusCode.MethodNotAllowed;

                default:
                    throw new NotSupportedException(string.Format("Unsuppored method type {0}", status.ToString()));
            }
        }

        internal string GetStatusCodeValue(StatusCode code) {
            return Enum.GetName(typeof(StatusCode), code);
        }
    }

    public class Result<T> : Result, IResult<T> {

        public Result(HttpResponseMessage message) : base(message) {
            if (message.IsSuccessStatusCode)
                Data = JsonConvert.DeserializeObject<T>(Content, new StringEnumConverter());
        }

        public T Data { get; set; }
    }
}