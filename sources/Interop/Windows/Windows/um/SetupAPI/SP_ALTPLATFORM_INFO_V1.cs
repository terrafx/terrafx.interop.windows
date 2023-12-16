// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SP_ALTPLATFORM_INFO_V1.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V1"]/*' />
public partial struct SP_ALTPLATFORM_INFO_V1
{
    /// <include file='SP_ALTPLATFORM_INFO_V1.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V1.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_ALTPLATFORM_INFO_V1.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V1.Platform"]/*' />
    [NativeTypeName("DWORD")]
    public uint Platform;

    /// <include file='SP_ALTPLATFORM_INFO_V1.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V1.MajorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint MajorVersion;

    /// <include file='SP_ALTPLATFORM_INFO_V1.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V1.MinorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint MinorVersion;

    /// <include file='SP_ALTPLATFORM_INFO_V1.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V1.ProcessorArchitecture"]/*' />
    [NativeTypeName("WORD")]
    public ushort ProcessorArchitecture;

    /// <include file='SP_ALTPLATFORM_INFO_V1.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V1.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;
}
