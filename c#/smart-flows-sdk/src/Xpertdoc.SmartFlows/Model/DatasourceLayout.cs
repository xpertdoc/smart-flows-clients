/* 
 * SmartFlows
 *
 * This describes the REST api for one SmartFlows project 
 *
 * OpenAPI spec version: 4.0.0
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
using SwaggerDateConverter = Xpertdoc.SmartFlows.Client.SwaggerDateConverter;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// DatasourceLayout
    /// </summary>
    [DataContract]
    public partial class DatasourceLayout :  IEquatable<DatasourceLayout>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Hierarchical for value: hierarchical
            /// </summary>
            [EnumMember(Value = "hierarchical")]
            Hierarchical = 1,
            
            /// <summary>
            /// Enum Relational for value: relational
            /// </summary>
            [EnumMember(Value = "relational")]
            Relational = 2
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasourceLayout" /> class.
        /// </summary>
        /// <param name="DatasourceType">DatasourceType.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Entities">Entities.</param>
        public DatasourceLayout(IdWithName DatasourceType = default(IdWithName), TypeEnum? Type = default(TypeEnum?), List<EntityDefinition> Entities = default(List<EntityDefinition>))
        {
            this.DatasourceType = DatasourceType;
            this.Type = Type;
            this.Entities = Entities;
        }
        
        /// <summary>
        /// Gets or Sets DatasourceType
        /// </summary>
        [DataMember(Name="datasourceType", EmitDefaultValue=false)]
        public IdWithName DatasourceType { get; set; }


        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<EntityDefinition> Entities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatasourceLayout {\n");
            sb.Append("  DatasourceType: ").Append(DatasourceType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatasourceLayout);
        }

        /// <summary>
        /// Returns true if DatasourceLayout instances are equal
        /// </summary>
        /// <param name="input">Instance of DatasourceLayout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasourceLayout input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatasourceType == input.DatasourceType ||
                    (this.DatasourceType != null &&
                    this.DatasourceType.Equals(input.DatasourceType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DatasourceType != null)
                    hashCode = hashCode * 59 + this.DatasourceType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Entities != null)
                    hashCode = hashCode * 59 + this.Entities.GetHashCode();
                return hashCode;
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
