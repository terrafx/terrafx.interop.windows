// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='SP_DEVINFO_DATA.xml' path='doc/member[@name="SP_DEVINFO_DATA"]/*' />
public partial struct SP_DEVINFO_DATA
{
    /// <include file='SP_DEVINFO_DATA.xml' path='doc/member[@name="SP_DEVINFO_DATA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_DEVINFO_DATA.xml' path='doc/member[@name="SP_DEVINFO_DATA.ClassGuid"]/*' />
    public Guid ClassGuid;

    /// <include file='SP_DEVINFO_DATA.xml' path='doc/member[@name="SP_DEVINFO_DATA.DevInst"]/*' />
    [NativeTypeName("DWORD")]
    public uint DevInst;

    /// <include file='SP_DEVINFO_DATA.xml' path='doc/member[@name="SP_DEVINFO_DATA.Reserved"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved;
}
