// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Subject contains a reference to the object or user identities a role
    /// binding applies to.  This can either hold a direct API object
    /// reference, or a value for non-objects such as user and group names.
    /// </summary>
    public partial class V1alpha1Subject
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1Subject class.
        /// </summary>
        public V1alpha1Subject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1Subject class.
        /// </summary>
        /// <param name="kind">Kind of object being referenced. Values defined
        /// by this API group are "User", "Group", and "ServiceAccount". If the
        /// Authorizer does not recognized the kind value, the Authorizer
        /// should report an error.</param>
        /// <param name="name">Name of the object being referenced.</param>
        /// <param name="apiVersion">APIVersion holds the API group and version
        /// of the referenced subject. Defaults to "v1" for ServiceAccount
        /// subjects. Defaults to "rbac.authorization.k8s.io/v1alpha1" for User
        /// and Group subjects.</param>
        /// <param name="namespaceProperty">Namespace of the referenced object.
        /// If the object kind is non-namespace, such as "User" or "Group", and
        /// this value is not empty the Authorizer should report an
        /// error.</param>
        public V1alpha1Subject(string kind, string name, string apiVersion = default(string), string namespaceProperty = default(string))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Name = name;
            NamespaceProperty = namespaceProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion holds the API group and version of the
        /// referenced subject. Defaults to "v1" for ServiceAccount subjects.
        /// Defaults to "rbac.authorization.k8s.io/v1alpha1" for User and Group
        /// subjects.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind of object being referenced. Values defined by
        /// this API group are "User", "Group", and "ServiceAccount". If the
        /// Authorizer does not recognized the kind value, the Authorizer
        /// should report an error.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets name of the object being referenced.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets namespace of the referenced object.  If the object
        /// kind is non-namespace, such as "User" or "Group", and this value is
        /// not empty the Authorizer should report an error.
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Kind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kind");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
