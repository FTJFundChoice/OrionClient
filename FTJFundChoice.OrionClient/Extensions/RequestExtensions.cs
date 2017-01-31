namespace FTJFundChoice.OrionClient.Extensions {

    internal static class RequestExtensions {

        internal static void AddExpandQueryParameters(this Request request, bool includePorfolio, bool includeUserDefinedFields) {
            if (includePorfolio) {
                request.AddQueryParameter("expand", "1");
            }

            if (includeUserDefinedFields) {
                request.AddQueryParameter("expand", "32");
            }
        }

        internal static void AddTopSkipQueryParameters(this Request request, int top, int skip) {
            request.AddQueryParameter("$top", top.ToString());
            request.AddQueryParameter("$skip", skip.ToString());
        }

        internal static void AddActiveQueryParameters(this Request request, bool? isActive) {
            if (isActive.HasValue) {
                request.AddQueryParameter("isActive", isActive.Value ? "1" : "0");
            }
        }
    }
}