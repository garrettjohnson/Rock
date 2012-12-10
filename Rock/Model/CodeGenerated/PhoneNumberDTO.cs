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
    /// Data Transfer Object for PhoneNumber object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class PhoneNumberDto : DtoSecured<PhoneNumberDto>
    {
        /// <summary />
        [DataMember]
        public bool IsSystem { get; set; }

        /// <summary />
        [DataMember]
        public int PersonId { get; set; }

        /// <summary />
        [DataMember]
        public string Number { get; set; }

        /// <summary />
        [DataMember]
        public string Extension { get; set; }

        /// <summary />
        [DataMember]
        public int? NumberTypeValueId { get; set; }

        /// <summary />
        [DataMember]
        public bool IsMessagingEnabled { get; set; }

        /// <summary />
        [DataMember]
        public bool IsUnlisted { get; set; }

        /// <summary />
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public PhoneNumberDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="phoneNumber"></param>
        public PhoneNumberDto ( PhoneNumber phoneNumber )
        {
            CopyFromModel( phoneNumber );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, object> ToDictionary()
        {
            var dictionary = base.ToDictionary();
            dictionary.Add( "IsSystem", this.IsSystem );
            dictionary.Add( "PersonId", this.PersonId );
            dictionary.Add( "Number", this.Number );
            dictionary.Add( "Extension", this.Extension );
            dictionary.Add( "NumberTypeValueId", this.NumberTypeValueId );
            dictionary.Add( "IsMessagingEnabled", this.IsMessagingEnabled );
            dictionary.Add( "IsUnlisted", this.IsUnlisted );
            dictionary.Add( "Description", this.Description );
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
            expando.PersonId = this.PersonId;
            expando.Number = this.Number;
            expando.Extension = this.Extension;
            expando.NumberTypeValueId = this.NumberTypeValueId;
            expando.IsMessagingEnabled = this.IsMessagingEnabled;
            expando.IsUnlisted = this.IsUnlisted;
            expando.Description = this.Description;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyFromModel( IEntity model )
        {
            base.CopyFromModel( model );

            if ( model is PhoneNumber )
            {
                var phoneNumber = (PhoneNumber)model;
                this.IsSystem = phoneNumber.IsSystem;
                this.PersonId = phoneNumber.PersonId;
                this.Number = phoneNumber.Number;
                this.Extension = phoneNumber.Extension;
                this.NumberTypeValueId = phoneNumber.NumberTypeValueId;
                this.IsMessagingEnabled = phoneNumber.IsMessagingEnabled;
                this.IsUnlisted = phoneNumber.IsUnlisted;
                this.Description = phoneNumber.Description;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyToModel ( IEntity model )
        {
            base.CopyToModel( model );

            if ( model is PhoneNumber )
            {
                var phoneNumber = (PhoneNumber)model;
                phoneNumber.IsSystem = this.IsSystem;
                phoneNumber.PersonId = this.PersonId;
                phoneNumber.Number = this.Number;
                phoneNumber.Extension = this.Extension;
                phoneNumber.NumberTypeValueId = this.NumberTypeValueId;
                phoneNumber.IsMessagingEnabled = this.IsMessagingEnabled;
                phoneNumber.IsUnlisted = this.IsUnlisted;
                phoneNumber.Description = this.Description;
            }
        }

    }


    /// <summary>
    /// PhoneNumber Extension Methods
    /// </summary>
    public static class PhoneNumberExtensions
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static PhoneNumber ToModel( this PhoneNumberDto value )
        {
            PhoneNumber result = new PhoneNumber();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<PhoneNumber> ToModel( this List<PhoneNumberDto> value )
        {
            List<PhoneNumber> result = new List<PhoneNumber>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<PhoneNumberDto> ToDto( this List<PhoneNumber> value )
        {
            List<PhoneNumberDto> result = new List<PhoneNumberDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static PhoneNumberDto ToDto( this PhoneNumber value )
        {
            return new PhoneNumberDto( value );
        }

        /// <summary>
        /// To the json.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public static string ToJson( this PhoneNumber value, bool deep = false )
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject( ToDynamic( value, deep ) );
        }

        /// <summary>
        /// To the dynamic.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public static List<dynamic> ToDynamic( this ICollection<PhoneNumber> values )
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
        public static dynamic ToDynamic( this PhoneNumber value, bool deep = false )
        {
            dynamic dynamicPhoneNumber = new PhoneNumberDto( value ).ToDynamic();

            if ( !deep )
            {
                return dynamicPhoneNumber;
            }

            dynamicPhoneNumber.NumberTypeValue = value.NumberTypeValue.ToDynamic();
            dynamicPhoneNumber.Person = value.Person.ToDynamic();

            return dynamicPhoneNumber;
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
        public static void FromDynamic( this PhoneNumber value, object obj, bool deep = false )
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
                        new DefinedValueDto().FromDynamic( dict["NumberTypeValue"] ).CopyToModel(value.NumberTypeValue);
                        new PersonDto().FromDynamic( dict["Person"] ).CopyToModel(value.Person);

                    }
                }
            }
        }

    }
}