/* 
 * Xpertdoc SmartFlows
 *
 * This describes the REST api for one Xpertdoc SmartFlows project
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
using SwaggerDateConverter = Xpertdoc.SmartFlows.Client.Client.SwaggerDateConverter;

namespace Xpertdoc.SmartFlows.Client.Model
{
    /// <summary>
    /// DocGenSettingsResultChartData
    /// </summary>
    [DataContract]
    public partial class DocGenSettingsResultChartData :  IEquatable<DocGenSettingsResultChartData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocGenSettingsResultChartData" /> class.
        /// </summary>
        /// <param name="Include">Include (default to false).</param>
        /// <param name="InstructionId">InstructionId.</param>
        public DocGenSettingsResultChartData(bool? Include = false, string InstructionId = default(string))
        {
            // use default value if no "Include" provided
            if (Include == null)
            {
                this.Include = false;
            }
            else
            {
                this.Include = Include;
            }
            this.InstructionId = InstructionId;
        }
        
        /// <summary>
        /// Gets or Sets Include
        /// </summary>
        [DataMember(Name="include", EmitDefaultValue=false)]
        public bool? Include { get; set; }

        /// <summary>
        /// Gets or Sets InstructionId
        /// </summary>
        [DataMember(Name="instructionId", EmitDefaultValue=false)]
        public string InstructionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocGenSettingsResultChartData {\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
            sb.Append("  InstructionId: ").Append(InstructionId).Append("\n");
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
            return this.Equals(obj as DocGenSettingsResultChartData);
        }

        /// <summary>
        /// Returns true if DocGenSettingsResultChartData instances are equal
        /// </summary>
        /// <param name="other">Instance of DocGenSettingsResultChartData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocGenSettingsResultChartData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Include == other.Include ||
                    this.Include != null &&
                    this.Include.Equals(other.Include)
                ) && 
                (
                    this.InstructionId == other.InstructionId ||
                    this.InstructionId != null &&
                    this.InstructionId.Equals(other.InstructionId)
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
                if (this.Include != null)
                    hash = hash * 59 + this.Include.GetHashCode();
                if (this.InstructionId != null)
                    hash = hash * 59 + this.InstructionId.GetHashCode();
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