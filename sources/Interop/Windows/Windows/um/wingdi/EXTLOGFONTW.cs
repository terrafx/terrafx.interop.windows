// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW"]/*' />
public partial struct EXTLOGFONTW
{
    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfLogFont"]/*' />
    public LOGFONTW elfLogFont;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfFullName"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _elfFullName_e__FixedBuffer elfFullName;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfStyle"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _elfStyle_e__FixedBuffer elfStyle;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfVersion;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfStyleSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfStyleSize;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfMatch"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfMatch;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfReserved;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfVendorId"]/*' />
    [NativeTypeName("BYTE[4]")]
    public _elfVendorId_e__FixedBuffer elfVendorId;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfCulture"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfCulture;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfPanose"]/*' />
    public PANOSE elfPanose;

    /// <include file='_elfFullName_e__FixedBuffer.xml' path='doc/member[@name="_elfFullName_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _elfFullName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_elfStyle_e__FixedBuffer.xml' path='doc/member[@name="_elfStyle_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _elfStyle_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_elfVendorId_e__FixedBuffer.xml' path='doc/member[@name="_elfVendorId_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _elfVendorId_e__FixedBuffer
    {
        public byte e0;
    }
}
