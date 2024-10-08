// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The type of the entity. </summary>
    public readonly partial struct SecurityInsightsEntityType : IEquatable<SecurityInsightsEntityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsEntityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsEntityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccountValue = "Account";
        private const string HostValue = "Host";
        private const string FileValue = "File";
        private const string AzureResourceValue = "AzureResource";
        private const string CloudApplicationValue = "CloudApplication";
        private const string DnsValue = "DNS";
        private const string FileHashValue = "FileHash";
        private const string IPValue = "IP";
        private const string MalwareValue = "Malware";
        private const string ProcessValue = "Process";
        private const string RegistryKeyValue = "RegistryKey";
        private const string RegistryValueValue = "RegistryValue";
        private const string SecurityGroupValue = "SecurityGroup";
        private const string URLValue = "URL";
        private const string IotDeviceValue = "IoTDevice";
        private const string SecurityAlertValue = "SecurityAlert";
        private const string HuntingBookmarkValue = "HuntingBookmark";
        private const string MailClusterValue = "MailCluster";
        private const string MailMessageValue = "MailMessage";
        private const string MailboxValue = "Mailbox";
        private const string SubmissionMailValue = "SubmissionMail";
        private const string NicValue = "Nic";

        /// <summary> Entity represents account in the system. </summary>
        public static SecurityInsightsEntityType Account { get; } = new SecurityInsightsEntityType(AccountValue);
        /// <summary> Entity represents host in the system. </summary>
        public static SecurityInsightsEntityType Host { get; } = new SecurityInsightsEntityType(HostValue);
        /// <summary> Entity represents file in the system. </summary>
        public static SecurityInsightsEntityType File { get; } = new SecurityInsightsEntityType(FileValue);
        /// <summary> Entity represents azure resource in the system. </summary>
        public static SecurityInsightsEntityType AzureResource { get; } = new SecurityInsightsEntityType(AzureResourceValue);
        /// <summary> Entity represents cloud application in the system. </summary>
        public static SecurityInsightsEntityType CloudApplication { get; } = new SecurityInsightsEntityType(CloudApplicationValue);
        /// <summary> Entity represents dns in the system. </summary>
        public static SecurityInsightsEntityType Dns { get; } = new SecurityInsightsEntityType(DnsValue);
        /// <summary> Entity represents file hash in the system. </summary>
        public static SecurityInsightsEntityType FileHash { get; } = new SecurityInsightsEntityType(FileHashValue);
        /// <summary> Entity represents ip in the system. </summary>
        public static SecurityInsightsEntityType IP { get; } = new SecurityInsightsEntityType(IPValue);
        /// <summary> Entity represents malware in the system. </summary>
        public static SecurityInsightsEntityType Malware { get; } = new SecurityInsightsEntityType(MalwareValue);
        /// <summary> Entity represents process in the system. </summary>
        public static SecurityInsightsEntityType Process { get; } = new SecurityInsightsEntityType(ProcessValue);
        /// <summary> Entity represents registry key in the system. </summary>
        public static SecurityInsightsEntityType RegistryKey { get; } = new SecurityInsightsEntityType(RegistryKeyValue);
        /// <summary> Entity represents registry value in the system. </summary>
        public static SecurityInsightsEntityType RegistryValue { get; } = new SecurityInsightsEntityType(RegistryValueValue);
        /// <summary> Entity represents security group in the system. </summary>
        public static SecurityInsightsEntityType SecurityGroup { get; } = new SecurityInsightsEntityType(SecurityGroupValue);
        /// <summary> Entity represents url in the system. </summary>
        public static SecurityInsightsEntityType URL { get; } = new SecurityInsightsEntityType(URLValue);
        /// <summary> Entity represents IoT device in the system. </summary>
        public static SecurityInsightsEntityType IotDevice { get; } = new SecurityInsightsEntityType(IotDeviceValue);
        /// <summary> Entity represents security alert in the system. </summary>
        public static SecurityInsightsEntityType SecurityAlert { get; } = new SecurityInsightsEntityType(SecurityAlertValue);
        /// <summary> Entity represents HuntingBookmark in the system. </summary>
        public static SecurityInsightsEntityType HuntingBookmark { get; } = new SecurityInsightsEntityType(HuntingBookmarkValue);
        /// <summary> Entity represents mail cluster in the system. </summary>
        public static SecurityInsightsEntityType MailCluster { get; } = new SecurityInsightsEntityType(MailClusterValue);
        /// <summary> Entity represents mail message in the system. </summary>
        public static SecurityInsightsEntityType MailMessage { get; } = new SecurityInsightsEntityType(MailMessageValue);
        /// <summary> Entity represents mailbox in the system. </summary>
        public static SecurityInsightsEntityType Mailbox { get; } = new SecurityInsightsEntityType(MailboxValue);
        /// <summary> Entity represents submission mail in the system. </summary>
        public static SecurityInsightsEntityType SubmissionMail { get; } = new SecurityInsightsEntityType(SubmissionMailValue);
        /// <summary> Entity represents network interface in the system. </summary>
        public static SecurityInsightsEntityType Nic { get; } = new SecurityInsightsEntityType(NicValue);
        /// <summary> Determines if two <see cref="SecurityInsightsEntityType"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsEntityType left, SecurityInsightsEntityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsEntityType"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsEntityType left, SecurityInsightsEntityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsEntityType"/>. </summary>
        public static implicit operator SecurityInsightsEntityType(string value) => new SecurityInsightsEntityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsEntityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsEntityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
