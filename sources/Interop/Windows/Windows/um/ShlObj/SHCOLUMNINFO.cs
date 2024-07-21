// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHCOLUMNINFO
{
    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.scid"]/*' />
    [NativeTypeName("SHCOLUMNID")]
    public PROPERTYKEY scid;

    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.vt"]/*' />
    [NativeTypeName("VARTYPE")]
    public ushort vt;

    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.fmt"]/*' />
    [NativeTypeName("DWORD")]
    public uint fmt;

    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.cChars"]/*' />
    public uint cChars;

    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.csFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint csFlags;

    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.wszTitle"]/*' />
    [NativeTypeName("WCHAR[80]")]
    public _wszTitle_e__FixedBuffer wszTitle;

    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.wszDescription"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _wszDescription_e__FixedBuffer wszDescription;

    /// <include file='_wszTitle_e__FixedBuffer.xml' path='doc/member[@name="_wszTitle_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(80)]
    public partial struct _wszTitle_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_wszDescription_e__FixedBuffer.xml' path='doc/member[@name="_wszDescription_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(128)]
    public partial struct _wszDescription_e__FixedBuffer
    {
        public char e0;
    }
}
