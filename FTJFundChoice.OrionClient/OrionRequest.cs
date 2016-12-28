using RestSharp;
using System;

namespace FTJFundChoice.OrionClient {

    public class OrionRequest : RestRequest {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RestRequest"/> class.
        /// </summary>
        public OrionRequest() {
            IntializeJsonSerializer();
        }

        /// <summary>
        /// Sets Method property to value of method
        ///
        /// </summary>
        /// <param name="method">Method to use for this request</param>
        public OrionRequest(Method method) : base(method) {
            IntializeJsonSerializer();
        }

        /// <summary>
        /// Sets Resource property
        ///
        /// </summary>
        /// <param name="resource">Resource to use for this request</param>
        public OrionRequest(string resource) : base(resource) {
            IntializeJsonSerializer();
        }

        /// <summary>
        /// Sets Resource and Method properties
        ///
        /// </summary>
        /// <param name="resource">Resource to use for this request</param><param name="method">Method to use for this request</param>
        public OrionRequest(string resource, Method method) : base(resource, method) {
            IntializeJsonSerializer();
        }

        /// <summary>
        /// Sets Resource property
        ///
        /// </summary>
        /// <param name="resource">Resource to use for this request</param>
        public OrionRequest(Uri resource) : base(resource) {
            IntializeJsonSerializer();
        }

        /// <summary>
        /// Sets Resource and Method properties
        ///
        /// </summary>
        /// <param name="resource">Resource to use for this request</param><param name="method">Method to use for this request</param>
        public OrionRequest(Uri resource, Method method) : base(resource, method) {
            IntializeJsonSerializer();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Intializes the serializer.
        /// </summary>
        protected void IntializeJsonSerializer() {
            JsonSerializer = OrionJsonSerializer.Default;
        }

        #endregion Methods
    }
}