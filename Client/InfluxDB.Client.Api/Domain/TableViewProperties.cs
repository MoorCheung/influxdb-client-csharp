/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// TableViewProperties
    /// </summary>
    [DataContract]
    public partial class TableViewProperties : ViewProperties,  IEquatable<TableViewProperties>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Table for value: table
            /// </summary>
            [EnumMember(Value = "table")]
            Table = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines Shape
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShapeEnum
        {
            /// <summary>
            /// Enum ChronografV2 for value: chronograf-v2
            /// </summary>
            [EnumMember(Value = "chronograf-v2")]
            ChronografV2 = 1

        }

        /// <summary>
        /// Gets or Sets Shape
        /// </summary>
        [DataMember(Name="shape", EmitDefaultValue=false)]
        public ShapeEnum Shape { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewProperties" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TableViewProperties() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewProperties" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="queries">queries (required).</param>
        /// <param name="colors">Colors define color encoding of data into a visualization (required).</param>
        /// <param name="shape">shape (required).</param>
        /// <param name="note">note (required).</param>
        /// <param name="showNoteWhenEmpty">if true, will display note when empty (required).</param>
        /// <param name="tableOptions">tableOptions (required).</param>
        /// <param name="fieldOptions">fieldOptions represent the fields retrieved by the query with customization options (required).</param>
        /// <param name="timeFormat">timeFormat describes the display format for time values according to moment.js date formatting (required).</param>
        /// <param name="decimalPlaces">decimalPlaces (required).</param>
        public TableViewProperties(TypeEnum type = default(TypeEnum), List<DashboardQuery> queries = default(List<DashboardQuery>), List<DashboardColor> colors = default(List<DashboardColor>), ShapeEnum shape = default(ShapeEnum), string note = default(string), bool? showNoteWhenEmpty = default(bool?), Object tableOptions = default(Object), List<RenamableField> fieldOptions = default(List<RenamableField>), string timeFormat = default(string), DecimalPlaces decimalPlaces = default(DecimalPlaces)) : base()
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for TableViewProperties and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "queries" is required (not null)
            if (queries == null)
            {
                throw new InvalidDataException("queries is a required property for TableViewProperties and cannot be null");
            }
            else
            {
                this.Queries = queries;
            }
            // to ensure "colors" is required (not null)
            if (colors == null)
            {
                throw new InvalidDataException("colors is a required property for TableViewProperties and cannot be null");
            }
            else
            {
                this.Colors = colors;
            }
            // to ensure "shape" is required (not null)
            if (shape == null)
            {
                throw new InvalidDataException("shape is a required property for TableViewProperties and cannot be null");
            }
            else
            {
                this.Shape = shape;
            }
            // to ensure "note" is required (not null)
            if (note == null)
            {
                throw new InvalidDataException("note is a required property for TableViewProperties and cannot be null");
            }
            else
            {
                this.Note = note;
            }
            // to ensure "showNoteWhenEmpty" is required (not null)
            if (showNoteWhenEmpty == null)
            {
                throw new InvalidDataException("showNoteWhenEmpty is a required property for TableViewProperties and cannot be null");
            }
            else
            {
                this.ShowNoteWhenEmpty = showNoteWhenEmpty;
            }
            // to ensure "tableOptions" is required (not null)
            if (tableOptions == null)
            {
                throw new InvalidDataException("tableOptions is a required property for TableViewProperties and cannot be null");
            }
            else
            {
                this.TableOptions = tableOptions;
            }
            // to ensure "fieldOptions" is required (not null)
            if (fieldOptions == null)
            {
                throw new InvalidDataException("fieldOptions is a required property for TableViewProperties and cannot be null");
            }
            else
            {
                this.FieldOptions = fieldOptions;
            }
            // to ensure "timeFormat" is required (not null)
            if (timeFormat == null)
            {
                throw new InvalidDataException("timeFormat is a required property for TableViewProperties and cannot be null");
            }
            else
            {
                this.TimeFormat = timeFormat;
            }
            // to ensure "decimalPlaces" is required (not null)
            if (decimalPlaces == null)
            {
                throw new InvalidDataException("decimalPlaces is a required property for TableViewProperties and cannot be null");
            }
            else
            {
                this.DecimalPlaces = decimalPlaces;
            }
        }


        /// <summary>
        /// Gets or Sets Queries
        /// </summary>
        [DataMember(Name="queries", EmitDefaultValue=false)]
        public List<DashboardQuery> Queries { get; set; }

        /// <summary>
        /// Colors define color encoding of data into a visualization
        /// </summary>
        /// <value>Colors define color encoding of data into a visualization</value>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public List<DashboardColor> Colors { get; set; }


        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// if true, will display note when empty
        /// </summary>
        /// <value>if true, will display note when empty</value>
        [DataMember(Name="showNoteWhenEmpty", EmitDefaultValue=false)]
        public bool? ShowNoteWhenEmpty { get; set; }

        /// <summary>
        /// Gets or Sets TableOptions
        /// </summary>
        [DataMember(Name="tableOptions", EmitDefaultValue=false)]
        public Object TableOptions { get; set; }

        /// <summary>
        /// fieldOptions represent the fields retrieved by the query with customization options
        /// </summary>
        /// <value>fieldOptions represent the fields retrieved by the query with customization options</value>
        [DataMember(Name="fieldOptions", EmitDefaultValue=false)]
        public List<RenamableField> FieldOptions { get; set; }

        /// <summary>
        /// timeFormat describes the display format for time values according to moment.js date formatting
        /// </summary>
        /// <value>timeFormat describes the display format for time values according to moment.js date formatting</value>
        [DataMember(Name="timeFormat", EmitDefaultValue=false)]
        public string TimeFormat { get; set; }

        /// <summary>
        /// Gets or Sets DecimalPlaces
        /// </summary>
        [DataMember(Name="decimalPlaces", EmitDefaultValue=false)]
        public DecimalPlaces DecimalPlaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableViewProperties {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ShowNoteWhenEmpty: ").Append(ShowNoteWhenEmpty).Append("\n");
            sb.Append("  TableOptions: ").Append(TableOptions).Append("\n");
            sb.Append("  FieldOptions: ").Append(FieldOptions).Append("\n");
            sb.Append("  TimeFormat: ").Append(TimeFormat).Append("\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as TableViewProperties);
        }

        /// <summary>
        /// Returns true if TableViewProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of TableViewProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableViewProperties input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Queries == input.Queries ||
                    this.Queries != null &&
                    this.Queries.SequenceEqual(input.Queries)
                ) && base.Equals(input) && 
                (
                    this.Colors == input.Colors ||
                    this.Colors != null &&
                    this.Colors.SequenceEqual(input.Colors)
                ) && base.Equals(input) && 
                (
                    this.Shape == input.Shape ||
                    (this.Shape != null &&
                    this.Shape.Equals(input.Shape))
                ) && base.Equals(input) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && base.Equals(input) && 
                (
                    this.ShowNoteWhenEmpty == input.ShowNoteWhenEmpty ||
                    (this.ShowNoteWhenEmpty != null &&
                    this.ShowNoteWhenEmpty.Equals(input.ShowNoteWhenEmpty))
                ) && base.Equals(input) && 
                (
                    this.TableOptions == input.TableOptions ||
                    (this.TableOptions != null &&
                    this.TableOptions.Equals(input.TableOptions))
                ) && base.Equals(input) && 
                (
                    this.FieldOptions == input.FieldOptions ||
                    this.FieldOptions != null &&
                    this.FieldOptions.SequenceEqual(input.FieldOptions)
                ) && base.Equals(input) && 
                (
                    this.TimeFormat == input.TimeFormat ||
                    (this.TimeFormat != null &&
                    this.TimeFormat.Equals(input.TimeFormat))
                ) && base.Equals(input) && 
                (
                    
                    (this.DecimalPlaces != null &&
                    this.DecimalPlaces.Equals(input.DecimalPlaces))
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Queries != null)
                    hashCode = hashCode * 59 + this.Queries.GetHashCode();
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
                if (this.Shape != null)
                    hashCode = hashCode * 59 + this.Shape.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.ShowNoteWhenEmpty != null)
                    hashCode = hashCode * 59 + this.ShowNoteWhenEmpty.GetHashCode();
                if (this.TableOptions != null)
                    hashCode = hashCode * 59 + this.TableOptions.GetHashCode();
                if (this.FieldOptions != null)
                    hashCode = hashCode * 59 + this.FieldOptions.GetHashCode();
                if (this.TimeFormat != null)
                    hashCode = hashCode * 59 + this.TimeFormat.GetHashCode();
                if (this.DecimalPlaces != null)
                    hashCode = hashCode * 59 + this.DecimalPlaces.GetHashCode();
                return hashCode;
            }
        }

    }

}