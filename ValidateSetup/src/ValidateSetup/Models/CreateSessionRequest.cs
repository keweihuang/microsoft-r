// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ValidateSetup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CreateSessionRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreateSessionRequest class.
        /// </summary>
        public CreateSessionRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateSessionRequest class.
        /// </summary>
        /// <param name="name">Name of the session. **Optional**</param>
        /// <param name="snapshotId">Id of the snapshot to be loaded into the
        /// new created session. **Optional**</param>
        /// <param name="runtimeType">Type of the runtime. **Optional [Default
        /// R]**. Possible values include: 'R', 'Python'</param>
        public CreateSessionRequest(string name = default(string), string snapshotId = default(string), RuntimeType? runtimeType = default(RuntimeType?))
        {
            Name = name;
            SnapshotId = snapshotId;
            RuntimeType = runtimeType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the session. **Optional**
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets id of the snapshot to be loaded into the new created
        /// session. **Optional**
        /// </summary>
        [JsonProperty(PropertyName = "snapshotId")]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Gets or sets type of the runtime. **Optional [Default R]**.
        /// Possible values include: 'R', 'Python'
        /// </summary>
        [JsonProperty(PropertyName = "runtimeType")]
        public RuntimeType? RuntimeType { get; set; }

    }
}
