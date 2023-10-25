// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The TranscriptionFailed. </summary>
    public partial class TranscriptionFailed
    {
        /// <summary> Initializes a new instance of TranscriptionFailed. </summary>
        internal TranscriptionFailed()
        {
        }

        /// <summary> Initializes a new instance of TranscriptionFailed. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling answerCall action to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="transcriptionUpdateResult"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        internal TranscriptionFailed(string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation, TranscriptionUpdate transcriptionUpdateResult)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            TranscriptionUpdateResult = transcriptionUpdateResult;
        }
        /// <summary> Defines the result for TranscriptionUpdate with the current status and the details about the status. </summary>
        public TranscriptionUpdate TranscriptionUpdateResult { get; }
    }
}
