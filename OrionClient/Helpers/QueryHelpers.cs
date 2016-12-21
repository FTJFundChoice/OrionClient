using RestSharp;

namespace OrionClient.Helpers {

    internal static class QueryHelpers {

        internal static void AddExpandQueryParameters(RestRequest request, bool includePorfolio, bool includeUserDefinedFields) {
            if (includePorfolio) {
                request.AddQueryParameter("expand", "1");
            }

            if (includeUserDefinedFields) {
                request.AddQueryParameter("expand", "32");
            }
        }

        internal static void AddTopSkipQueryParameters(RestRequest request, int top, int skip) {
            request.AddQueryParameter("$top", top.ToString());
            request.AddQueryParameter("$skip", skip.ToString());
        }
    }
}