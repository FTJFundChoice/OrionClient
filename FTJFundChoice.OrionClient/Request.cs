using FTJFundChoice.OrionClient.Enums;
using System;
using System.Net.Http;

namespace FTJFundChoice.OrionClient {

    internal class Request : HttpRequestMessage {

        #region Constructors

        public Request() : base() {
        }

        public Request(Method method, Uri requestUri) : base(ConvertMethod(method), requestUri) {
        }

        public Request(Method method, string requestUri) : base(ConvertMethod(method), requestUri) {
        }

        public Request(string requestUri, Method method) : base(ConvertMethod(method), requestUri) {
        }

        #endregion Constructors

        internal static HttpMethod ConvertMethod(Method method) {
            switch (method) {
                case Enums.Method.GET:
                    return HttpMethod.Get;

                case Enums.Method.POST:
                    return HttpMethod.Post;

                case Enums.Method.PUT:
                    return HttpMethod.Put;

                case Enums.Method.DELETE:
                    return HttpMethod.Delete;

                default:
                    throw new NotSupportedException(string.Format("Unsupported method type {0}", method.ToString()));
            }
        }

        internal void AddQueryParameter(string key, string value) {
            var currentUri = RequestUri.ToString();
            if (!currentUri.Contains("?"))
                currentUri += "?";
            else
                currentUri += "&";

            RequestUri = new Uri(string.Format("{0}{1}={2}", currentUri, key, value), UriKind.Relative);
        }

        internal void AddHeader(string key, string value) {
            Headers.Add(key, value);
        }

        internal void AddParameter(string mediaType, string value) {
            Content = new StringContent(value, System.Text.Encoding.Unicode, mediaType);
        }

        internal void AddUrlSegment(string key, string value) {
            string trueKey = "{" + key + "}";
            var url = RequestUri.ToString();
            url = url.Replace(trueKey, value);
            var uri = new Uri(url, UriKind.Relative);
            RequestUri = uri;
        }
    }
}