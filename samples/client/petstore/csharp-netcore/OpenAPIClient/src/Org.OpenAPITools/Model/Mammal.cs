/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Mammal
    /// </summary>
    [DataContract(Name = "mammal")]
    [JsonConverter(typeof(JsonSubtypes), "ClassName")]
    public partial class Mammal : IEquatable<Mammal>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Plains for value: plains
            /// </summary>
            [EnumMember(Value = "plains")]
            Plains = 1,

            /// <summary>
            /// Enum Mountain for value: mountain
            /// </summary>
            [EnumMember(Value = "mountain")]
            Mountain = 2,

            /// <summary>
            /// Enum Grevys for value: grevys
            /// </summary>
            [EnumMember(Value = "grevys")]
            Grevys = 3

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Mammal()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class.
        /// </summary>
        /// <param name="hasBaleen">hasBaleen.</param>
        /// <param name="hasTeeth">hasTeeth.</param>
        /// <param name="className">className (required).</param>
        /// <param name="type">type.</param>
        public Mammal(bool hasBaleen = default(bool), bool hasTeeth = default(bool), string className = default(string), TypeEnum? type = default(TypeEnum?))
        {
            // to ensure "className" is required (not null)
            this.ClassName = className ?? throw new ArgumentNullException("className is a required property for Mammal and cannot be null");
            this.HasBaleen = hasBaleen;
            this.HasTeeth = hasTeeth;
            this.Type = type;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets HasBaleen
        /// </summary>
        [DataMember(Name = "hasBaleen", EmitDefaultValue = false)]
        public bool HasBaleen { get; set; }

        /// <summary>
        /// Gets or Sets HasTeeth
        /// </summary>
        [DataMember(Name = "hasTeeth", EmitDefaultValue = false)]
        public bool HasTeeth { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name = "className", EmitDefaultValue = false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mammal {\n");
            sb.Append("  HasBaleen: ").Append(HasBaleen).Append("\n");
            sb.Append("  HasTeeth: ").Append(HasTeeth).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Mammal).AreEqual;
        }

        /// <summary>
        /// Returns true if Mammal instances are equal
        /// </summary>
        /// <param name="input">Instance of Mammal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mammal input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                hashCode = hashCode * 59 + this.HasBaleen.GetHashCode();
                hashCode = hashCode * 59 + this.HasTeeth.GetHashCode();
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
