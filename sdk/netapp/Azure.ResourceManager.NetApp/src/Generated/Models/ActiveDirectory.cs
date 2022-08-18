// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Active Directory. </summary>
    public partial class ActiveDirectory
    {
        /// <summary> Initializes a new instance of ActiveDirectory. </summary>
        public ActiveDirectory()
        {
            BackupOperators = new ChangeTrackingList<string>();
            Administrators = new ChangeTrackingList<string>();
            SecurityOperators = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ActiveDirectory. </summary>
        /// <param name="activeDirectoryId"> Id of the Active Directory. </param>
        /// <param name="username"> Username of Active Directory domain administrator. </param>
        /// <param name="password"> Plain text password of Active Directory domain administrator, value is masked in the response. </param>
        /// <param name="domain"> Name of the Active Directory domain. </param>
        /// <param name="dns"> Comma separated list of DNS server IP addresses (IPv4 only) for the Active Directory domain. </param>
        /// <param name="status"> Status of the Active Directory. </param>
        /// <param name="statusDetails"> Any details in regards to the Status of the Active Directory. </param>
        /// <param name="smbServerName"> NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes. </param>
        /// <param name="organizationalUnit"> The Organizational Unit (OU) within the Windows Active Directory. </param>
        /// <param name="site"> The Active Directory site the service will limit Domain Controller discovery to. </param>
        /// <param name="backupOperators"> Users to be added to the Built-in Backup Operator active directory group. A list of unique usernames without domain specifier. </param>
        /// <param name="administrators"> Users to be added to the Built-in Administrators active directory group. A list of unique usernames without domain specifier. </param>
        /// <param name="kdcIP"> kdc server IP addresses for the active directory machine. This optional parameter is used only while creating kerberos volume. </param>
        /// <param name="adName"> Name of the active directory machine. This optional parameter is used only while creating kerberos volume. </param>
        /// <param name="serverRootCACertificate"> When LDAP over SSL/TLS is enabled, the LDAP client is required to have base64 encoded Active Directory Certificate Service&apos;s self-signed root CA certificate, this optional parameter is used only for dual protocol with LDAP user-mapping volumes. </param>
        /// <param name="aesEncryption"> If enabled, AES encryption will be enabled for SMB communication. </param>
        /// <param name="ldapSigning"> Specifies whether or not the LDAP traffic needs to be signed. </param>
        /// <param name="securityOperators"> Domain Users in the Active directory to be given SeSecurityPrivilege privilege (Needed for SMB Continuously available shares for SQL). A list of unique usernames without domain specifier. </param>
        /// <param name="ldapOverTLS"> Specifies whether or not the LDAP traffic needs to be secured via TLS. </param>
        /// <param name="allowLocalNfsUsersWithLdap"> If enabled, NFS client local users can also (in addition to LDAP users) access the NFS volumes. </param>
        /// <param name="encryptDCConnections"> If enabled, Traffic between the SMB server to Domain Controller (DC) will be encrypted. </param>
        /// <param name="ldapSearchScope"> LDAP Search scope options. </param>
        internal ActiveDirectory(string activeDirectoryId, string username, string password, string domain, string dns, ActiveDirectoryStatus? status, string statusDetails, string smbServerName, string organizationalUnit, string site, IList<string> backupOperators, IList<string> administrators, string kdcIP, string adName, string serverRootCACertificate, bool? aesEncryption, bool? ldapSigning, IList<string> securityOperators, bool? ldapOverTLS, bool? allowLocalNfsUsersWithLdap, bool? encryptDCConnections, LdapSearchScopeOpt ldapSearchScope)
        {
            ActiveDirectoryId = activeDirectoryId;
            Username = username;
            Password = password;
            Domain = domain;
            Dns = dns;
            Status = status;
            StatusDetails = statusDetails;
            SmbServerName = smbServerName;
            OrganizationalUnit = organizationalUnit;
            Site = site;
            BackupOperators = backupOperators;
            Administrators = administrators;
            KdcIP = kdcIP;
            AdName = adName;
            ServerRootCACertificate = serverRootCACertificate;
            AesEncryption = aesEncryption;
            LdapSigning = ldapSigning;
            SecurityOperators = securityOperators;
            LdapOverTLS = ldapOverTLS;
            AllowLocalNfsUsersWithLdap = allowLocalNfsUsersWithLdap;
            EncryptDCConnections = encryptDCConnections;
            LdapSearchScope = ldapSearchScope;
        }

        /// <summary> Id of the Active Directory. </summary>
        public string ActiveDirectoryId { get; set; }
        /// <summary> Username of Active Directory domain administrator. </summary>
        public string Username { get; set; }
        /// <summary> Plain text password of Active Directory domain administrator, value is masked in the response. </summary>
        public string Password { get; set; }
        /// <summary> Name of the Active Directory domain. </summary>
        public string Domain { get; set; }
        /// <summary> Comma separated list of DNS server IP addresses (IPv4 only) for the Active Directory domain. </summary>
        public string Dns { get; set; }
        /// <summary> Status of the Active Directory. </summary>
        public ActiveDirectoryStatus? Status { get; }
        /// <summary> Any details in regards to the Status of the Active Directory. </summary>
        public string StatusDetails { get; }
        /// <summary> NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes. </summary>
        public string SmbServerName { get; set; }
        /// <summary> The Organizational Unit (OU) within the Windows Active Directory. </summary>
        public string OrganizationalUnit { get; set; }
        /// <summary> The Active Directory site the service will limit Domain Controller discovery to. </summary>
        public string Site { get; set; }
        /// <summary> Users to be added to the Built-in Backup Operator active directory group. A list of unique usernames without domain specifier. </summary>
        public IList<string> BackupOperators { get; }
        /// <summary> Users to be added to the Built-in Administrators active directory group. A list of unique usernames without domain specifier. </summary>
        public IList<string> Administrators { get; }
        /// <summary> kdc server IP addresses for the active directory machine. This optional parameter is used only while creating kerberos volume. </summary>
        public string KdcIP { get; set; }
        /// <summary> Name of the active directory machine. This optional parameter is used only while creating kerberos volume. </summary>
        public string AdName { get; set; }
        /// <summary> When LDAP over SSL/TLS is enabled, the LDAP client is required to have base64 encoded Active Directory Certificate Service&apos;s self-signed root CA certificate, this optional parameter is used only for dual protocol with LDAP user-mapping volumes. </summary>
        public string ServerRootCACertificate { get; set; }
        /// <summary> If enabled, AES encryption will be enabled for SMB communication. </summary>
        public bool? AesEncryption { get; set; }
        /// <summary> Specifies whether or not the LDAP traffic needs to be signed. </summary>
        public bool? LdapSigning { get; set; }
        /// <summary> Domain Users in the Active directory to be given SeSecurityPrivilege privilege (Needed for SMB Continuously available shares for SQL). A list of unique usernames without domain specifier. </summary>
        public IList<string> SecurityOperators { get; }
        /// <summary> Specifies whether or not the LDAP traffic needs to be secured via TLS. </summary>
        public bool? LdapOverTLS { get; set; }
        /// <summary> If enabled, NFS client local users can also (in addition to LDAP users) access the NFS volumes. </summary>
        public bool? AllowLocalNfsUsersWithLdap { get; set; }
        /// <summary> If enabled, Traffic between the SMB server to Domain Controller (DC) will be encrypted. </summary>
        public bool? EncryptDCConnections { get; set; }
        /// <summary> LDAP Search scope options. </summary>
        public LdapSearchScopeOpt LdapSearchScope { get; set; }
    }
}
