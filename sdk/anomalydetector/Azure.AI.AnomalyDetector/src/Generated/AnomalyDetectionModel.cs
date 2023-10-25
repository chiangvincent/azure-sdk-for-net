// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Response of getting a model. </summary>
    public partial class AnomalyDetectionModel
    {
        /// <summary> Initializes a new instance of AnomalyDetectionModel. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        internal AnomalyDetectionModel(Guid modelId, DateTimeOffset createdTime, DateTimeOffset lastUpdatedTime)
        {
            ModelId = modelId;
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
        }

        /// <summary> Initializes a new instance of AnomalyDetectionModel. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        /// <param name="modelInfo">
        /// Training result of a model, including its status, errors, and diagnostics
        /// information.
        /// </param>
        internal AnomalyDetectionModel(Guid modelId, DateTimeOffset createdTime, DateTimeOffset lastUpdatedTime, ModelInfo modelInfo)
        {
            ModelId = modelId;
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
            ModelInfo = modelInfo;
        }

        /// <summary> Model identifier. </summary>
        public Guid ModelId { get; }
        /// <summary> Date and time (UTC) when the model was created. </summary>
        public DateTimeOffset CreatedTime { get; }
        /// <summary> Date and time (UTC) when the model was last updated. </summary>
        public DateTimeOffset LastUpdatedTime { get; }
        /// <summary>
        /// Training result of a model, including its status, errors, and diagnostics
        /// information.
        /// </summary>
        public ModelInfo ModelInfo { get; }
    }
}
