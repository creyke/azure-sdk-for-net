// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertProcessingRuleProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("scopes");
            writer.WriteStartArray();
            foreach (var item in Scopes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Conditions))
            {
                writer.WritePropertyName("conditions");
                writer.WriteStartArray();
                foreach (var item in Conditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Schedule))
            {
                writer.WritePropertyName("schedule");
                writer.WriteObjectValue(Schedule);
            }
            writer.WritePropertyName("actions");
            writer.WriteStartArray();
            foreach (var item in Actions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static ServiceAlertProcessingRuleProperties DeserializeServiceAlertProcessingRuleProperties(JsonElement element)
        {
            IList<string> scopes = default;
            Optional<IList<AlertProcessingRuleCondition>> conditions = default;
            Optional<AlertProcessingRuleSchedule> schedule = default;
            IList<AlertProcessingAction> actions = default;
            Optional<string> description = default;
            Optional<bool> enabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scopes"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    scopes = array;
                    continue;
                }
                if (property.NameEquals("conditions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AlertProcessingRuleCondition> array = new List<AlertProcessingRuleCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AlertProcessingRuleCondition.DeserializeAlertProcessingRuleCondition(item));
                    }
                    conditions = array;
                    continue;
                }
                if (property.NameEquals("schedule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schedule = AlertProcessingRuleSchedule.DeserializeAlertProcessingRuleSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("actions"))
                {
                    List<AlertProcessingAction> array = new List<AlertProcessingAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AlertProcessingAction.DeserializeAlertProcessingAction(item));
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ServiceAlertProcessingRuleProperties(scopes, Optional.ToList(conditions), schedule.Value, actions, description.Value, Optional.ToNullable(enabled));
        }
    }
}
