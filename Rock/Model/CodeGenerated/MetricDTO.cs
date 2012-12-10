//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Data Transfer Object for Metric object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class MetricDto : DtoSecured<MetricDto>
    {
        /// <summary />
        [DataMember]
        public bool IsSystem { get; set; }

        /// <summary />
        [DataMember]
        public bool Type { get; set; }

        /// <summary />
        [DataMember]
        public string Category { get; set; }

        /// <summary />
        [DataMember]
        public string Title { get; set; }

        /// <summary />
        [DataMember]
        public string Subtitle { get; set; }

        /// <summary />
        [DataMember]
        public string Description { get; set; }

        /// <summary />
        [DataMember]
        public int? MinValue { get; set; }

        /// <summary />
        [DataMember]
        public int? MaxValue { get; set; }

        /// <summary />
        [DataMember]
        public int? CollectionFrequencyValueId { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? LastCollected { get; set; }

        /// <summary />
        [DataMember]
        public string Source { get; set; }

        /// <summary />
        [DataMember]
        public string SourceSQL { get; set; }

        /// <summary />
        [DataMember]
        public int Order { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public MetricDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="metric"></param>
        public MetricDto ( Metric metric )
        {
            CopyFromModel( metric );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, object> ToDictionary()
        {
            var dictionary = base.ToDictionary();
            dictionary.Add( "IsSystem", this.IsSystem );
            dictionary.Add( "Type", this.Type );
            dictionary.Add( "Category", this.Category );
            dictionary.Add( "Title", this.Title );
            dictionary.Add( "Subtitle", this.Subtitle );
            dictionary.Add( "Description", this.Description );
            dictionary.Add( "MinValue", this.MinValue );
            dictionary.Add( "MaxValue", this.MaxValue );
            dictionary.Add( "CollectionFrequencyValueId", this.CollectionFrequencyValueId );
            dictionary.Add( "LastCollected", this.LastCollected );
            dictionary.Add( "Source", this.Source );
            dictionary.Add( "SourceSQL", this.SourceSQL );
            dictionary.Add( "Order", this.Order );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public override dynamic ToDynamic()
        {
            dynamic expando = base.ToDynamic();
            expando.IsSystem = this.IsSystem;
            expando.Type = this.Type;
            expando.Category = this.Category;
            expando.Title = this.Title;
            expando.Subtitle = this.Subtitle;
            expando.Description = this.Description;
            expando.MinValue = this.MinValue;
            expando.MaxValue = this.MaxValue;
            expando.CollectionFrequencyValueId = this.CollectionFrequencyValueId;
            expando.LastCollected = this.LastCollected;
            expando.Source = this.Source;
            expando.SourceSQL = this.SourceSQL;
            expando.Order = this.Order;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyFromModel( IEntity model )
        {
            base.CopyFromModel( model );

            if ( model is Metric )
            {
                var metric = (Metric)model;
                this.IsSystem = metric.IsSystem;
                this.Type = metric.Type;
                this.Category = metric.Category;
                this.Title = metric.Title;
                this.Subtitle = metric.Subtitle;
                this.Description = metric.Description;
                this.MinValue = metric.MinValue;
                this.MaxValue = metric.MaxValue;
                this.CollectionFrequencyValueId = metric.CollectionFrequencyValueId;
                this.LastCollected = metric.LastCollected;
                this.Source = metric.Source;
                this.SourceSQL = metric.SourceSQL;
                this.Order = metric.Order;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyToModel ( IEntity model )
        {
            base.CopyToModel( model );

            if ( model is Metric )
            {
                var metric = (Metric)model;
                metric.IsSystem = this.IsSystem;
                metric.Type = this.Type;
                metric.Category = this.Category;
                metric.Title = this.Title;
                metric.Subtitle = this.Subtitle;
                metric.Description = this.Description;
                metric.MinValue = this.MinValue;
                metric.MaxValue = this.MaxValue;
                metric.CollectionFrequencyValueId = this.CollectionFrequencyValueId;
                metric.LastCollected = this.LastCollected;
                metric.Source = this.Source;
                metric.SourceSQL = this.SourceSQL;
                metric.Order = this.Order;
            }
        }

    }


    /// <summary>
    /// Metric Extension Methods
    /// </summary>
    public static class MetricExtensions
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Metric ToModel( this MetricDto value )
        {
            Metric result = new Metric();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<Metric> ToModel( this List<MetricDto> value )
        {
            List<Metric> result = new List<Metric>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<MetricDto> ToDto( this List<Metric> value )
        {
            List<MetricDto> result = new List<MetricDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static MetricDto ToDto( this Metric value )
        {
            return new MetricDto( value );
        }

        /// <summary>
        /// To the json.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public static string ToJson( this Metric value, bool deep = false )
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject( ToDynamic( value, deep ) );
        }

        /// <summary>
        /// To the dynamic.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public static List<dynamic> ToDynamic( this ICollection<Metric> values )
        {
            var dynamicList = new List<dynamic>();
            foreach ( var value in values )
            {
                dynamicList.Add( value.ToDynamic( true ) );
            }
            return dynamicList;
        }

        /// <summary>
        /// To the dynamic.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public static dynamic ToDynamic( this Metric value, bool deep = false )
        {
            dynamic dynamicMetric = new MetricDto( value ).ToDynamic();

            if ( !deep )
            {
                return dynamicMetric;
            }

            dynamicMetric.MetricValues = value.MetricValues.ToDynamic();
            dynamicMetric.CollectionFrequencyValue = value.CollectionFrequencyValue.ToDynamic();

            return dynamicMetric;
        }

        /// <summary>
        /// Froms the json.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="json">The json.</param>
        public static void FromJson( this Page value, string json )
        {
            //Newtonsoft.Json.JsonConvert.PopulateObject( json, value );
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject( json, typeof( ExpandoObject ) );
            value.FromDynamic( obj, true );
        }

        /// <summary>
        /// Froms the dynamic.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="obj">The obj.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        public static void FromDynamic( this Metric value, object obj, bool deep = false )
        {
            new PageDto().FromDynamic(obj).CopyToModel(value);

            if (deep)
            {
                var expando = obj as ExpandoObject;
                if (obj != null)
                {
                    var dict = obj as IDictionary<string, object>;
                    if (dict != null)
                    {

                        // MetricValues
                        var MetricValuesList = dict["MetricValues"] as List<object>;
                        if (MetricValuesList != null)
                        {
                            value.MetricValues = new List<MetricValue>();
                            foreach(object childObj in MetricValuesList)
                            {
                                var MetricValue = new MetricValue();
                                new MetricValueDto().FromDynamic(childObj).CopyToModel(MetricValue);
                                value.MetricValues.Add(MetricValue);
                            }
                        }
                        new DefinedValueDto().FromDynamic( dict["CollectionFrequencyValue"] ).CopyToModel(value.CollectionFrequencyValue);

                    }
                }
            }
        }

    }
}