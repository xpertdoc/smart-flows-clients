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
    /// TextCondition
    /// </summary>
    [DataContract]
    public partial class TextCondition :  IEquatable<TextCondition>, IValidatableObject
    {
        /// <summary>
        /// Defines _Operator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            
            /// <summary>
            /// Enum Contains for value: contains
            /// </summary>
            [EnumMember(Value = "contains")]
            Contains = 1,
            
            /// <summary>
            /// Enum NotContains for value: notContains
            /// </summary>
            [EnumMember(Value = "notContains")]
            NotContains = 2,
            
            /// <summary>
            /// Enum EqualTo for value: equalTo
            /// </summary>
            [EnumMember(Value = "equalTo")]
            EqualTo = 3,
            
            /// <summary>
            /// Enum NotEqualTo for value: notEqualTo
            /// </summary>
            [EnumMember(Value = "notEqualTo")]
            NotEqualTo = 4,
            
            /// <summary>
            /// Enum IsBlank for value: isBlank
            /// </summary>
            [EnumMember(Value = "isBlank")]
            IsBlank = 5,
            
            /// <summary>
            /// Enum NotIsBlank for value: notIsBlank
            /// </summary>
            [EnumMember(Value = "notIsBlank")]
            NotIsBlank = 6
        }

        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextCondition" /> class.
        /// </summary>
        /// <param name="_Operator">_Operator.</param>
        /// <param name="Value1">Value1.</param>
        /// <param name="Value2">Value2.</param>
        public TextCondition(OperatorEnum? _Operator = default(OperatorEnum?), ConditionValue Value1 = default(ConditionValue), ConditionValue Value2 = default(ConditionValue))
        {
            this._Operator = _Operator;
            this.Value1 = Value1;
            this.Value2 = Value2;
        }
        

        /// <summary>
        /// Gets or Sets Value1
        /// </summary>
        [DataMember(Name="value1", EmitDefaultValue=false)]
        public ConditionValue Value1 { get; set; }

        /// <summary>
        /// Gets or Sets Value2
        /// </summary>
        [DataMember(Name="value2", EmitDefaultValue=false)]
        public ConditionValue Value2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextCondition {\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Value1: ").Append(Value1).Append("\n");
            sb.Append("  Value2: ").Append(Value2).Append("\n");
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
            return this.Equals(input as TextCondition);
        }

        /// <summary>
        /// Returns true if TextCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of TextCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Operator == input._Operator ||
                    (this._Operator != null &&
                    this._Operator.Equals(input._Operator))
                ) && 
                (
                    this.Value1 == input.Value1 ||
                    (this.Value1 != null &&
                    this.Value1.Equals(input.Value1))
                ) && 
                (
                    this.Value2 == input.Value2 ||
                    (this.Value2 != null &&
                    this.Value2.Equals(input.Value2))
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
                if (this._Operator != null)
                    hashCode = hashCode * 59 + this._Operator.GetHashCode();
                if (this.Value1 != null)
                    hashCode = hashCode * 59 + this.Value1.GetHashCode();
                if (this.Value2 != null)
                    hashCode = hashCode * 59 + this.Value2.GetHashCode();
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
