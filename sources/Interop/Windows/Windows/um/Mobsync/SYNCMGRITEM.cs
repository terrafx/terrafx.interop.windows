// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SYNCMGRITEM.xml' path='doc/member[@name="SYNCMGRITEM"]/*' />
public partial struct SYNCMGRITEM
{
    /// <include file='SYNCMGRITEM.xml' path='doc/member[@name="SYNCMGRITEM.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SYNCMGRITEM.xml' path='doc/member[@name="SYNCMGRITEM.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='SYNCMGRITEM.xml' path='doc/member[@name="SYNCMGRITEM.ItemID"]/*' />
    public Guid ItemID;

    /// <include file='SYNCMGRITEM.xml' path='doc/member[@name="SYNCMGRITEM.dwItemState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwItemState;

    /// <include file='SYNCMGRITEM.xml' path='doc/member[@name="SYNCMGRITEM.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='SYNCMGRITEM.xml' path='doc/member[@name="SYNCMGRITEM.wszItemName"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _wszItemName_e__FixedBuffer wszItemName;

    /// <include file='SYNCMGRITEM.xml' path='doc/member[@name="SYNCMGRITEM.ftLastUpdate"]/*' />
    public FILETIME ftLastUpdate;

    /// <include file='_wszItemName_e__FixedBuffer.xml' path='doc/member[@name="_wszItemName_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _wszItemName_e__FixedBuffer
    {
        public char e0;
    }
}
