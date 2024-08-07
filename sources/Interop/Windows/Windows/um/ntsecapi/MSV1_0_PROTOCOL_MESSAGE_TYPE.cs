// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE"]/*' />
public enum MSV1_0_PROTOCOL_MESSAGE_TYPE
{
    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0Lm20ChallengeRequest"]/*' />
    MsV1_0Lm20ChallengeRequest = 0,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0Lm20GetChallengeResponse"]/*' />
    MsV1_0Lm20GetChallengeResponse,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0EnumerateUsers"]/*' />
    MsV1_0EnumerateUsers,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0GetUserInfo"]/*' />
    MsV1_0GetUserInfo,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0ReLogonUsers"]/*' />
    MsV1_0ReLogonUsers,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0ChangePassword"]/*' />
    MsV1_0ChangePassword,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0ChangeCachedPassword"]/*' />
    MsV1_0ChangeCachedPassword,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0GenericPassthrough"]/*' />
    MsV1_0GenericPassthrough,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0CacheLogon"]/*' />
    MsV1_0CacheLogon,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0SubAuth"]/*' />
    MsV1_0SubAuth,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0DeriveCredential"]/*' />
    MsV1_0DeriveCredential,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0CacheLookup"]/*' />
    MsV1_0CacheLookup,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0SetProcessOption"]/*' />
    MsV1_0SetProcessOption,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0ConfigLocalAliases"]/*' />
    MsV1_0ConfigLocalAliases,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0ClearCachedCredentials"]/*' />
    MsV1_0ClearCachedCredentials,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0LookupToken"]/*' />
    MsV1_0LookupToken,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0ValidateAuth"]/*' />
    MsV1_0ValidateAuth,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0CacheLookupEx"]/*' />
    MsV1_0CacheLookupEx,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0GetCredentialKey"]/*' />
    MsV1_0GetCredentialKey,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0SetThreadOption"]/*' />
    MsV1_0SetThreadOption,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0DecryptDpapiMasterKey"]/*' />
    MsV1_0DecryptDpapiMasterKey,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0GetStrongCredentialKey"]/*' />
    MsV1_0GetStrongCredentialKey,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0TransferCred"]/*' />
    MsV1_0TransferCred,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0ProvisionTbal"]/*' />
    MsV1_0ProvisionTbal,

    /// <include file='MSV1_0_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="MSV1_0_PROTOCOL_MESSAGE_TYPE.MsV1_0DeleteTbalSecrets"]/*' />
    MsV1_0DeleteTbalSecrets,
}
