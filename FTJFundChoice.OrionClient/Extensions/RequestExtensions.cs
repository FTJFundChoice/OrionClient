namespace FTJFundChoice.OrionClient.Extensions {

    internal static class RequestExtensions {

        internal static void AddExpandQueryParameters(this Request request, params int[] expands) {
			if (expands != null && expands.Length > 0)
			{
				foreach (var expand in expands)
					request.AddQueryParameter("expand", expand.ToString());
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