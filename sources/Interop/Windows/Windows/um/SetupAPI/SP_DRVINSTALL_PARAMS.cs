// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SP_DRVINSTALL_PARAMS.xml' path='doc/member[@name="SP_DRVINSTALL_PARAMS"]/*' />
public partial struct SP_DRVINSTALL_PARAMS
{
    /// <include file='SP_DRVINSTALL_PARAMS.xml' path='doc/member[@name="SP_DRVINSTALL_PARAMS.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_DRVINSTALL_PARAMS.xml' path='doc/member[@name="SP_DRVINSTALL_PARAMS.Rank"]/*' />
    [NativeTypeName("DWORD")]
    public uint Rank;

    /// <include file='SP_DRVINSTALL_PARAMS.xml' path='doc/member[@name="SP_DRVINSTALL_PARAMS.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SP_DRVINSTALL_PARAMS.xml' path='doc/member[@name="SP_DRVINSTALL_PARAMS.PrivateData"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint PrivateData;

    /// <include file='SP_DRVINSTALL_PARAMS.xml' path='doc/member[@name="SP_DRVINSTALL_PARAMS.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;
}
