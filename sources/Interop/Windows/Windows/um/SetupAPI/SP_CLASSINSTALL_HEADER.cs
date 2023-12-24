// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SP_CLASSINSTALL_HEADER.xml' path='doc/member[@name="SP_CLASSINSTALL_HEADER"]/*' />
public partial struct SP_CLASSINSTALL_HEADER
{
    /// <include file='SP_CLASSINSTALL_HEADER.xml' path='doc/member[@name="SP_CLASSINSTALL_HEADER.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_CLASSINSTALL_HEADER.xml' path='doc/member[@name="SP_CLASSINSTALL_HEADER.InstallFunction"]/*' />
    [NativeTypeName("DI_FUNCTION")]
    public uint InstallFunction;
}
