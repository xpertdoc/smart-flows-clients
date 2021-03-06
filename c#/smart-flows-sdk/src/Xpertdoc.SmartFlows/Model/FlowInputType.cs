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
    /// Defines flowInputType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FlowInputType
    {
        
        /// <summary>
        /// Enum Plugin for value: plugin
        /// </summary>
        [EnumMember(Value = "plugin")]
        Plugin = 1,
        
        /// <summary>
        /// Enum User for value: user
        /// </summary>
        [EnumMember(Value = "user")]
        User = 2,
        
        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 3
    }

}
