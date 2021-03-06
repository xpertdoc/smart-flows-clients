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
    /// DocGenSettingsTemplate
    /// </summary>
    [DataContract]
    public partial class DocGenSettingsTemplate :  IEquatable<DocGenSettingsTemplate>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 1,
            
            /// <summary>
            /// Enum Composed for value: composed
            /// </summary>
            [EnumMember(Value = "composed")]
            Composed = 2
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocGenSettingsTemplate" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Standard">Standard.</param>
        /// <param name="Composed">Composed.</param>
        public DocGenSettingsTemplate(TypeEnum? Type = default(TypeEnum?), string DisplayName = default(string), DocGenSettingsTemplateStandard Standard = default(DocGenSettingsTemplateStandard), DocGenSettingsTemplateComposed Composed = default(DocGenSettingsTemplateComposed))
        {
            this.Type = Type;
            this.DisplayName = DisplayName;
            this.Standard = Standard;
            this.Composed = Composed;
        }
        

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Standard
        /// </summary>
        [DataMember(Name="standard", EmitDefaultValue=false)]
        public DocGenSettingsTemplateStandard Standard { get; set; }

        /// <summary>
        /// Gets or Sets Composed
        /// </summary>
        [DataMember(Name="composed", EmitDefaultValue=false)]
        public DocGenSettingsTemplateComposed Composed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocGenSettingsTemplate {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Standard: ").Append(Standard).Append("\n");
            sb.Append("  Composed: ").Append(Composed).Append("\n");
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
            return this.Equals(input as DocGenSettingsTemplate);
        }

        /// <summary>
        /// Returns true if DocGenSettingsTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of DocGenSettingsTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocGenSettingsTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Standard == input.Standard ||
                    (this.Standard != null &&
                    this.Standard.Equals(input.Standard))
                ) && 
                (
                    this.Composed == input.Composed ||
                    (this.Composed != null &&
                    this.Composed.Equals(input.Composed))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Standard != null)
                    hashCode = hashCode * 59 + this.Standard.GetHashCode();
                if (this.Composed != null)
                    hashCode = hashCode * 59 + this.Composed.GetHashCode();
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
