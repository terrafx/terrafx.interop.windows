// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SP_CLASSIMAGELIST_DATA.xml' path='doc/member[@name="SP_CLASSIMAGELIST_DATA"]/*' />
public partial struct SP_CLASSIMAGELIST_DATA
{
    /// <include file='SP_CLASSIMAGELIST_DATA.xml' path='doc/member[@name="SP_CLASSIMAGELIST_DATA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_CLASSIMAGELIST_DATA.xml' path='doc/member[@name="SP_CLASSIMAGELIST_DATA.ImageList"]/*' />
    public HIMAGELIST ImageList;

    /// <include file='SP_CLASSIMAGELIST_DATA.xml' path='doc/member[@name="SP_CLASSIMAGELIST_DATA.Reserved"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved;
}
