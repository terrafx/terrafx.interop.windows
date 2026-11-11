// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION"]/*' />
public partial struct _SECURITY_ISOLATION_CONFIGURATION
{
    /// <include file='_SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='_SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION.GeneralConfiguration"]/*' />
    [NativeTypeName("SECURITY_ISOLATION_CONFIGURATION_GENERAL")]
    public _SECURITY_ISOLATION_CONFIGURATION_GENERAL GeneralConfiguration;

    /// <include file='_SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION.DebugConfiguration"]/*' />
    [NativeTypeName("SECURITY_ISOLATION_CONFIGURATION_DEBUG")]
    public _SECURITY_ISOLATION_CONFIGURATION_DEBUG DebugConfiguration;

    /// <include file='_SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION.UiConfiguration"]/*' />
    [NativeTypeName("SECURITY_ISOLATION_CONFIGURATION_UI")]
    public _SECURITY_ISOLATION_CONFIGURATION_UI UiConfiguration;

    /// <include file='_SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION.ProcessConfiguration"]/*' />
    [NativeTypeName("SECURITY_ISOLATION_CONFIGURATION_PROCESS")]
    public _SECURITY_ISOLATION_CONFIGURATION_PROCESS ProcessConfiguration;

    /// <include file='_SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION.SigningConfiguration"]/*' />
    [NativeTypeName("SECURITY_ISOLATION_CONFIGURATION_SIGNING")]
    public _SECURITY_ISOLATION_CONFIGURATION_SIGNING SigningConfiguration;
}
