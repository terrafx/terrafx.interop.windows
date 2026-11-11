// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="SECURITY_ISOLATION_CONFIGURATION"]/*' />
public partial struct SECURITY_ISOLATION_CONFIGURATION
{
    /// <include file='SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="SECURITY_ISOLATION_CONFIGURATION.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="SECURITY_ISOLATION_CONFIGURATION.GeneralConfiguration"]/*' />
    public SECURITY_ISOLATION_CONFIGURATION_GENERAL GeneralConfiguration;

    /// <include file='SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="SECURITY_ISOLATION_CONFIGURATION.DebugConfiguration"]/*' />
    public SECURITY_ISOLATION_CONFIGURATION_DEBUG DebugConfiguration;

    /// <include file='SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="SECURITY_ISOLATION_CONFIGURATION.UiConfiguration"]/*' />
    public SECURITY_ISOLATION_CONFIGURATION_UI UiConfiguration;

    /// <include file='SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="SECURITY_ISOLATION_CONFIGURATION.ProcessConfiguration"]/*' />
    public SECURITY_ISOLATION_CONFIGURATION_PROCESS ProcessConfiguration;

    /// <include file='SECURITY_ISOLATION_CONFIGURATION.xml' path='doc/member[@name="SECURITY_ISOLATION_CONFIGURATION.SigningConfiguration"]/*' />
    public SECURITY_ISOLATION_CONFIGURATION_SIGNING SigningConfiguration;
}
