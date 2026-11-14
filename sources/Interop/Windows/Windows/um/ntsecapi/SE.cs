// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SE
{
    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ADT_OBJECT_ONLY"]/*' />
    [NativeTypeName("#define SE_ADT_OBJECT_ONLY 0x1")]
    public const int SE_ADT_OBJECT_ONLY = 0x1;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_MAX_AUDIT_PARAMETERS"]/*' />
    [NativeTypeName("#define SE_MAX_AUDIT_PARAMETERS 32")]
    public const int SE_MAX_AUDIT_PARAMETERS = 32;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_MAX_GENERIC_AUDIT_PARAMETERS"]/*' />
    [NativeTypeName("#define SE_MAX_GENERIC_AUDIT_PARAMETERS 28")]
    public const int SE_MAX_GENERIC_AUDIT_PARAMETERS = 28;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ADT_PARAMETERS_SELF_RELATIVE"]/*' />
    [NativeTypeName("#define SE_ADT_PARAMETERS_SELF_RELATIVE 0x00000001")]
    public const int SE_ADT_PARAMETERS_SELF_RELATIVE = 0x00000001;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ADT_PARAMETERS_SEND_TO_LSA"]/*' />
    [NativeTypeName("#define SE_ADT_PARAMETERS_SEND_TO_LSA 0x00000002")]
    public const int SE_ADT_PARAMETERS_SEND_TO_LSA = 0x00000002;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ADT_PARAMETER_EXTENSIBLE_AUDIT"]/*' />
    [NativeTypeName("#define SE_ADT_PARAMETER_EXTENSIBLE_AUDIT 0x00000004")]
    public const int SE_ADT_PARAMETER_EXTENSIBLE_AUDIT = 0x00000004;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ADT_PARAMETER_GENERIC_AUDIT"]/*' />
    [NativeTypeName("#define SE_ADT_PARAMETER_GENERIC_AUDIT 0x00000008")]
    public const int SE_ADT_PARAMETER_GENERIC_AUDIT = 0x00000008;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ADT_PARAMETER_WRITE_SYNCHRONOUS"]/*' />
    [NativeTypeName("#define SE_ADT_PARAMETER_WRITE_SYNCHRONOUS 0x00000010")]
    public const int SE_ADT_PARAMETER_WRITE_SYNCHRONOUS = 0x00000010;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_INTERACTIVE_LOGON_NAME"]/*' />
    [NativeTypeName("#define SE_INTERACTIVE_LOGON_NAME TEXT(\"SeInteractiveLogonRight\")")]
    public const string SE_INTERACTIVE_LOGON_NAME = "SeInteractiveLogonRight";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_NETWORK_LOGON_NAME"]/*' />
    [NativeTypeName("#define SE_NETWORK_LOGON_NAME TEXT(\"SeNetworkLogonRight\")")]
    public const string SE_NETWORK_LOGON_NAME = "SeNetworkLogonRight";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_BATCH_LOGON_NAME"]/*' />
    [NativeTypeName("#define SE_BATCH_LOGON_NAME TEXT(\"SeBatchLogonRight\")")]
    public const string SE_BATCH_LOGON_NAME = "SeBatchLogonRight";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SERVICE_LOGON_NAME"]/*' />
    [NativeTypeName("#define SE_SERVICE_LOGON_NAME TEXT(\"SeServiceLogonRight\")")]
    public const string SE_SERVICE_LOGON_NAME = "SeServiceLogonRight";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DENY_INTERACTIVE_LOGON_NAME"]/*' />
    [NativeTypeName("#define SE_DENY_INTERACTIVE_LOGON_NAME TEXT(\"SeDenyInteractiveLogonRight\")")]
    public const string SE_DENY_INTERACTIVE_LOGON_NAME = "SeDenyInteractiveLogonRight";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DENY_NETWORK_LOGON_NAME"]/*' />
    [NativeTypeName("#define SE_DENY_NETWORK_LOGON_NAME TEXT(\"SeDenyNetworkLogonRight\")")]
    public const string SE_DENY_NETWORK_LOGON_NAME = "SeDenyNetworkLogonRight";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DENY_BATCH_LOGON_NAME"]/*' />
    [NativeTypeName("#define SE_DENY_BATCH_LOGON_NAME TEXT(\"SeDenyBatchLogonRight\")")]
    public const string SE_DENY_BATCH_LOGON_NAME = "SeDenyBatchLogonRight";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DENY_SERVICE_LOGON_NAME"]/*' />
    [NativeTypeName("#define SE_DENY_SERVICE_LOGON_NAME TEXT(\"SeDenyServiceLogonRight\")")]
    public const string SE_DENY_SERVICE_LOGON_NAME = "SeDenyServiceLogonRight";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_REMOTE_INTERACTIVE_LOGON_NAME"]/*' />
    [NativeTypeName("#define SE_REMOTE_INTERACTIVE_LOGON_NAME TEXT(\"SeRemoteInteractiveLogonRight\")")]
    public const string SE_REMOTE_INTERACTIVE_LOGON_NAME = "SeRemoteInteractiveLogonRight";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DENY_REMOTE_INTERACTIVE_LOGON_NAME"]/*' />
    [NativeTypeName("#define SE_DENY_REMOTE_INTERACTIVE_LOGON_NAME TEXT(\"SeDenyRemoteInteractiveLogonRight\")")]
    public const string SE_DENY_REMOTE_INTERACTIVE_LOGON_NAME = "SeDenyRemoteInteractiveLogonRight";
}
