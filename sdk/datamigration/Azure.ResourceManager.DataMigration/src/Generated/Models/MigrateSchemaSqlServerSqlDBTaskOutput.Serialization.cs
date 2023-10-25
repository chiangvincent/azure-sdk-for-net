// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSchemaSqlServerSqlDBTaskOutput
    {
        internal static MigrateSchemaSqlServerSqlDBTaskOutput DeserializeMigrateSchemaSqlServerSqlDBTaskOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelOutput": return MigrateSchemaSqlServerSqlDBTaskOutputDatabaseLevel.DeserializeMigrateSchemaSqlServerSqlDBTaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigrateSchemaSqlTaskOutputError.DeserializeMigrateSchemaSqlTaskOutputError(element);
                    case "MigrationLevelOutput": return MigrateSchemaSqlServerSqlDBTaskOutputMigrationLevel.DeserializeMigrateSchemaSqlServerSqlDBTaskOutputMigrationLevel(element);
                    case "SchemaErrorOutput": return MigrateSchemaSqlServerSqlDBTaskOutputError.DeserializeMigrateSchemaSqlServerSqlDBTaskOutputError(element);
                }
            }
            return UnknownMigrateSchemaSqlServerSqlDBTaskOutput.DeserializeUnknownMigrateSchemaSqlServerSqlDBTaskOutput(element);
        }
    }
}
