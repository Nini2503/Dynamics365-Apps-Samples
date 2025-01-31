﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using DataExportSales.Models;
using Microsoft.Rest;
using Newtonsoft.Json.Linq;

namespace DataExportSales.Models
{
    public partial class ProfileDetailsDTO
    {
        private DateTimeOffset? _activationTime;
        
        /// <summary>
        /// Optional. Activation Time
        /// </summary>
        public DateTimeOffset? ActivationTime
        {
            get { return this._activationTime; }
            set { this._activationTime = value; }
        }
        
        private DateTimeOffset? _creationTime;
        
        /// <summary>
        /// Optional. Creation Time
        /// </summary>
        public DateTimeOffset? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }
        
        private string _destinationKeyVaultUri;
        
        /// <summary>
        /// Optional. Destination KeyVault URI
        /// </summary>
        public string DestinationKeyVaultUri
        {
            get { return this._destinationKeyVaultUri; }
            set { this._destinationKeyVaultUri = value; }
        }
        
        private string _destinationPrefix;
        
        /// <summary>
        /// Optional. Destination prefix
        /// </summary>
        public string DestinationPrefix
        {
            get { return this._destinationPrefix; }
            set { this._destinationPrefix = value; }
        }
        
        private string _destinationSchemaName;
        
        /// <summary>
        /// Optional. Destination schema name
        /// </summary>
        public string DestinationSchemaName
        {
            get { return this._destinationSchemaName; }
            set { this._destinationSchemaName = value; }
        }
        
        private string _destinationType;
        
        /// <summary>
        /// Optional. Destination type
        /// </summary>
        public string DestinationType
        {
            get { return this._destinationType; }
            set { this._destinationType = value; }
        }
        
        private IList<EntityDetailsDTO> _entities;
        
        /// <summary>
        /// Optional. Entities
        /// </summary>
        public IList<EntityDetailsDTO> Entities
        {
            get { return this._entities; }
            set { this._entities = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. Id
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private DateTimeOffset? _lastModified;
        
        /// <summary>
        /// Optional. Last modified timestamp for the last action performed-
        /// create/update/activate/delete
        /// </summary>
        public DateTimeOffset? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Name
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _organizationId;
        
        /// <summary>
        /// Optional. Orgnaization Id
        /// </summary>
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }
        
        private RetryPolicyDescription _retryPolicy;
        
        /// <summary>
        /// Optional. Retry policy
        /// </summary>
        public RetryPolicyDescription RetryPolicy
        {
            get { return this._retryPolicy; }
            set { this._retryPolicy = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. State
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private ProfileStatus _status;
        
        /// <summary>
        /// Optional. Status details
        /// </summary>
        public ProfileStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private DateTimeOffset? _updateTime;
        
        /// <summary>
        /// Optional. Update time- the time when an update to a profile was
        /// successful
        /// </summary>
        public DateTimeOffset? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }
        
        private string _version;
        
        /// <summary>
        /// Optional. Version
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }
        
        private bool? _writeDeleteLog;
        
        /// <summary>
        /// Optional. Should write to delete log
        /// </summary>
        public bool? WriteDeleteLog
        {
            get { return this._writeDeleteLog; }
            set { this._writeDeleteLog = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProfileDetailsDTO class.
        /// </summary>
        public ProfileDetailsDTO()
        {
            this.Entities = new LazyList<EntityDetailsDTO>();
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken activationTimeValue = inputObject["ActivationTime"];
                if (activationTimeValue != null && activationTimeValue.Type != JTokenType.Null)
                {
                    this.ActivationTime = ((DateTimeOffset)activationTimeValue);
                }
                JToken creationTimeValue = inputObject["CreationTime"];
                if (creationTimeValue != null && creationTimeValue.Type != JTokenType.Null)
                {
                    this.CreationTime = ((DateTimeOffset)creationTimeValue);
                }
                JToken destinationKeyVaultUriValue = inputObject["DestinationKeyVaultUri"];
                if (destinationKeyVaultUriValue != null && destinationKeyVaultUriValue.Type != JTokenType.Null)
                {
                    this.DestinationKeyVaultUri = ((string)destinationKeyVaultUriValue);
                }
                JToken destinationPrefixValue = inputObject["DestinationPrefix"];
                if (destinationPrefixValue != null && destinationPrefixValue.Type != JTokenType.Null)
                {
                    this.DestinationPrefix = ((string)destinationPrefixValue);
                }
                JToken destinationSchemaNameValue = inputObject["DestinationSchemaName"];
                if (destinationSchemaNameValue != null && destinationSchemaNameValue.Type != JTokenType.Null)
                {
                    this.DestinationSchemaName = ((string)destinationSchemaNameValue);
                }
                JToken destinationTypeValue = inputObject["DestinationType"];
                if (destinationTypeValue != null && destinationTypeValue.Type != JTokenType.Null)
                {
                    this.DestinationType = ((string)destinationTypeValue);
                }
                JToken entitiesSequence = ((JToken)inputObject["Entities"]);
                if (entitiesSequence != null && entitiesSequence.Type != JTokenType.Null)
                {
                    foreach (JToken entitiesValue in ((JArray)entitiesSequence))
                    {
                        EntityDetailsDTO entityDetailsDTO = new EntityDetailsDTO();
                        entityDetailsDTO.DeserializeJson(entitiesValue);
                        this.Entities.Add(entityDetailsDTO);
                    }
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((string)idValue);
                }
                JToken lastModifiedValue = inputObject["LastModified"];
                if (lastModifiedValue != null && lastModifiedValue.Type != JTokenType.Null)
                {
                    this.LastModified = ((DateTimeOffset)lastModifiedValue);
                }
                JToken nameValue = inputObject["Name"];
                if (nameValue != null && nameValue.Type != JTokenType.Null)
                {
                    this.Name = ((string)nameValue);
                }
                JToken organizationIdValue = inputObject["OrganizationId"];
                if (organizationIdValue != null && organizationIdValue.Type != JTokenType.Null)
                {
                    this.OrganizationId = ((string)organizationIdValue);
                }
                JToken retryPolicyValue = inputObject["RetryPolicy"];
                if (retryPolicyValue != null && retryPolicyValue.Type != JTokenType.Null)
                {
                    RetryPolicyDescription retryPolicyDescription = new RetryPolicyDescription();
                    retryPolicyDescription.DeserializeJson(retryPolicyValue);
                    this.RetryPolicy = retryPolicyDescription;
                }
                JToken stateValue = inputObject["State"];
                if (stateValue != null && stateValue.Type != JTokenType.Null)
                {
                    this.State = ((string)stateValue);
                }
                JToken statusValue = inputObject["Status"];
                if (statusValue != null && statusValue.Type != JTokenType.Null)
                {
                    ProfileStatus profileStatus = new ProfileStatus();
                    profileStatus.DeserializeJson(statusValue);
                    this.Status = profileStatus;
                }
                JToken updateTimeValue = inputObject["UpdateTime"];
                if (updateTimeValue != null && updateTimeValue.Type != JTokenType.Null)
                {
                    this.UpdateTime = ((DateTimeOffset)updateTimeValue);
                }
                JToken versionValue = inputObject["Version"];
                if (versionValue != null && versionValue.Type != JTokenType.Null)
                {
                    this.Version = ((string)versionValue);
                }
                JToken writeDeleteLogValue = inputObject["WriteDeleteLog"];
                if (writeDeleteLogValue != null && writeDeleteLogValue.Type != JTokenType.Null)
                {
                    this.WriteDeleteLog = ((bool)writeDeleteLogValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type ProfileDetailsDTO
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.ActivationTime != null)
            {
                outputObject["ActivationTime"] = this.ActivationTime.Value;
            }
            if (this.CreationTime != null)
            {
                outputObject["CreationTime"] = this.CreationTime.Value;
            }
            if (this.DestinationKeyVaultUri != null)
            {
                outputObject["DestinationKeyVaultUri"] = this.DestinationKeyVaultUri;
            }
            if (this.DestinationPrefix != null)
            {
                outputObject["DestinationPrefix"] = this.DestinationPrefix;
            }
            if (this.DestinationSchemaName != null)
            {
                outputObject["DestinationSchemaName"] = this.DestinationSchemaName;
            }
            if (this.DestinationType != null)
            {
                outputObject["DestinationType"] = this.DestinationType;
            }
            JArray entitiesSequence = null;
            if (this.Entities != null)
            {
                if (this.Entities is ILazyCollection<EntityDetailsDTO> == false || ((ILazyCollection<EntityDetailsDTO>)this.Entities).IsInitialized)
                {
                    entitiesSequence = new JArray();
                    outputObject["Entities"] = entitiesSequence;
                    foreach (EntityDetailsDTO entitiesItem in this.Entities)
                    {
                        if (entitiesItem != null)
                        {
                            entitiesSequence.Add(entitiesItem.SerializeJson(null));
                        }
                    }
                }
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id;
            }
            if (this.LastModified != null)
            {
                outputObject["LastModified"] = this.LastModified.Value;
            }
            if (this.Name != null)
            {
                outputObject["Name"] = this.Name;
            }
            if (this.OrganizationId != null)
            {
                outputObject["OrganizationId"] = this.OrganizationId;
            }
            if (this.RetryPolicy != null)
            {
                outputObject["RetryPolicy"] = this.RetryPolicy.SerializeJson(null);
            }
            if (this.State != null)
            {
                outputObject["State"] = this.State;
            }
            if (this.Status != null)
            {
                outputObject["Status"] = this.Status.SerializeJson(null);
            }
            if (this.UpdateTime != null)
            {
                outputObject["UpdateTime"] = this.UpdateTime.Value;
            }
            if (this.Version != null)
            {
                outputObject["Version"] = this.Version;
            }
            if (this.WriteDeleteLog != null)
            {
                outputObject["WriteDeleteLog"] = this.WriteDeleteLog.Value;
            }
            return outputObject;
        }
    }
}
