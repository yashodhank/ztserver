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
    /// ZeroTierUnforwardRequest
    /// </summary>
    [DataContract]
    public partial class ZeroTierUnforwardRequest :  IEquatable<ZeroTierUnforwardRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroTierUnforwardRequest" /> class.
        /// </summary>
        /// <param name="Proxyport">Proxyport.</param>
        public ZeroTierUnforwardRequest(int? Proxyport = default(int?))
        {
            this.Proxyport = Proxyport;
        }
        
        /// <summary>
        /// Gets or Sets Proxyport
        /// </summary>
        [DataMember(Name="proxyport", EmitDefaultValue=false)]
        public int? Proxyport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZeroTierUnforwardRequest {\n");
            sb.Append("  Proxyport: ").Append(Proxyport).Append("\n");
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
            return this.Equals(obj as ZeroTierUnforwardRequest);
        }

        /// <summary>
        /// Returns true if ZeroTierUnforwardRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ZeroTierUnforwardRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZeroTierUnforwardRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Proxyport == other.Proxyport ||
                    this.Proxyport != null &&
                    this.Proxyport.Equals(other.Proxyport)
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
                if (this.Proxyport != null)
                    hash = hash * 59 + this.Proxyport.GetHashCode();
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
