/* 
 * ztserver
 *
 * The ztserver REST API.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ZeroTierInformation
    /// </summary>
    [DataContract]
    public partial class ZeroTierInformation :  IEquatable<ZeroTierInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroTierInformation" /> class.
        /// </summary>
        /// <param name="Nwid">Nwid.</param>
        /// <param name="Path">Path.</param>
        /// <param name="Nodeid">Nodeid.</param>
        /// <param name="Addresses">Addresses.</param>
        public ZeroTierInformation(string Nwid = default(string), string Path = default(string), string Nodeid = default(string), List<string> Addresses = default(List<string>))
        {
            this.Nwid = Nwid;
            this.Path = Path;
            this.Nodeid = Nodeid;
            this.Addresses = Addresses;
        }
        
        /// <summary>
        /// Gets or Sets Nwid
        /// </summary>
        [DataMember(Name="nwid", EmitDefaultValue=false)]
        public string Nwid { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Nodeid
        /// </summary>
        [DataMember(Name="nodeid", EmitDefaultValue=false)]
        public string Nodeid { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZeroTierInformation {\n");
            sb.Append("  Nwid: ").Append(Nwid).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Nodeid: ").Append(Nodeid).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ZeroTierInformation);
        }

        /// <summary>
        /// Returns true if ZeroTierInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of ZeroTierInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZeroTierInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nwid == other.Nwid ||
                    this.Nwid != null &&
                    this.Nwid.Equals(other.Nwid)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Nodeid == other.Nodeid ||
                    this.Nodeid != null &&
                    this.Nodeid.Equals(other.Nodeid)
                ) && 
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Nwid != null)
                    hash = hash * 59 + this.Nwid.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Nodeid != null)
                    hash = hash * 59 + this.Nodeid.GetHashCode();
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
