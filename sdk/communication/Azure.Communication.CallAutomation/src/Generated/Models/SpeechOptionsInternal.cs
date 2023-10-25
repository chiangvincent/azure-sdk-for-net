// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> Options for continuous speech recognition. </summary>
    internal partial class SpeechOptionsInternal
    {
        /// <summary> Initializes a new instance of SpeechOptionsInternal. </summary>
        public SpeechOptionsInternal()
        {
        }

        /// <summary> The length of end silence when user stops speaking and cogservice send response. </summary>
        public long? EndSilenceTimeoutInMs { get; set; }
    }
}
