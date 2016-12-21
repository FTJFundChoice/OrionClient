using RestSharp;

namespace OrionClient.Helpers {

    internal static class QueryHelpers {

        internal static void AddExpandQueryParameters(RestRequest request, bool includePorfolio, bool includeUserDefinedFields) {
            int expandCounter = 0;
            if (includePorfolio) {
                request.AddQueryParameter(string.Format("expand[{0}]", expandCounter), "1");
                expandCounter++;
            }

            if (includeUserDefinedFields) {
                request.AddQueryParameter(string.Format("expand[{0}]", expandCounter), "32");
                expandCounter++;
            }
        }

        internal static void AddTopSkipQueryParameters(RestRequest request, int top, int skip) {
            request.AddQueryParameter("$top", top.ToString());
            request.AddQueryParameter("$skip", skip.ToString());
        }
    }
}