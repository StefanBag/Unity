//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Friends.Internal.Generated.Http;



namespace Unity.Services.Friends.Internal.Generated.Models
{
    /// <summary>
    /// Relationship model
    /// </summary>
    [Preserve]
    [DataContract(Name = "Relationship")]
    internal class Relationship
    {
        /// <summary>
        /// Creates an instance of Relationship.
        /// </summary>
        /// <param name="id">id param</param>
        /// <param name="created">created param</param>
        /// <param name="type">type param</param>
        /// <param name="members">A list of members involved in the relationship.</param>
        /// <param name="expires">expires param</param>
        [Preserve]
        public Relationship(string id, DateTime created, RelationshipType type, List<Member> members, DateTime? expires = default)
        {
            Id = id;
            Created = created;
            Expires = expires;
            Type = type;
            Members = members;
        }

        /// <summary>
        /// Parameter id of Relationship
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id{ get; }
        
        /// <summary>
        /// Parameter created of Relationship
        /// </summary>
        [Preserve]
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Created{ get; }
        
        /// <summary>
        /// Parameter expires of Relationship
        /// </summary>
        [Preserve]
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public DateTime? Expires{ get; }
        
        /// <summary>
        /// Parameter type of Relationship
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public RelationshipType Type{ get; }
        
        /// <summary>
        /// A list of members involved in the relationship.
        /// </summary>
        [Preserve]
        [DataMember(Name = "members", IsRequired = true, EmitDefaultValue = true)]
        public List<Member> Members{ get; }
    
        /// <summary>
        /// Formats a Relationship into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Id != null)
            {
                serializedModel += "id," + Id + ",";
            }
            if (Created != null)
            {
                serializedModel += "created," + Created.ToString() + ",";
            }
            if (Expires != null)
            {
                serializedModel += "expires," + Expires.ToString() + ",";
            }
            serializedModel += "type," + Type.ToString() + ",";
            if (Members != null)
            {
                serializedModel += "members," + Members.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a Relationship as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Id != null)
            {
                var idStringValue = Id.ToString();
                dictionary.Add("id", idStringValue);
            }
            
            if (Created != null)
            {
                var createdStringValue = Created.ToString();
                dictionary.Add("created", createdStringValue);
            }
            
            if (Expires != null)
            {
                var expiresStringValue = Expires.ToString();
                dictionary.Add("expires", expiresStringValue);
            }
            
            var typeStringValue = Type.ToString();
            dictionary.Add("type", typeStringValue);
            
            return dictionary;
        }
    }
}
