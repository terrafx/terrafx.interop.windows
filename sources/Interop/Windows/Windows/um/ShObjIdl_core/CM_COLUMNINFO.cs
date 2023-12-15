// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CM_COLUMNINFO.xml' path='doc/member[@name="CM_COLUMNINFO"]/*' />
public partial struct CM_COLUMNINFO
{
    /// <include file='CM_COLUMNINFO.xml' path='doc/member[@name="CM_COLUMNINFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CM_COLUMNINFO.xml' path='doc/member[@name="CM_COLUMNINFO.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='CM_COLUMNINFO.xml' path='doc/member[@name="CM_COLUMNINFO.dwState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwState;

    /// <include file='CM_COLUMNINFO.xml' path='doc/member[@name="CM_COLUMNINFO.uWidth"]/*' />
    public uint uWidth;

    /// <include file='CM_COLUMNINFO.xml' path='doc/member[@name="CM_COLUMNINFO.uDefaultWidth"]/*' />
    public uint uDefaultWidth;

    /// <include file='CM_COLUMNINFO.xml' path='doc/member[@name="CM_COLUMNINFO.uIdealWidth"]/*' />
    public uint uIdealWidth;

    /// <include file='CM_COLUMNINFO.xml' path='doc/member[@name="CM_COLUMNINFO.wszName"]/*' />
    [NativeTypeName("WCHAR[80]")]
    public _wszName_e__FixedBuffer wszName;

    /// <include file='_wszName_e__FixedBuffer.xml' path='doc/member[@name="_wszName_e__FixedBuffer"]/*' />
    [InlineArray(80)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _wszName_e__FixedBuffer
    {
        public char e0;
    }
}
