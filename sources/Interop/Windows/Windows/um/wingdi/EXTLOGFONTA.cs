// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA"]/*' />
public partial struct EXTLOGFONTA
{
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfLogFont"]/*' />
    public LOGFONTA elfLogFont;

    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfFullName"]/*' />
    [NativeTypeName("BYTE[64]")]
    public _elfFullName_e__FixedBuffer elfFullName;

    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfStyle"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _elfStyle_e__FixedBuffer elfStyle;

    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfVersion;

    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfStyleSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfStyleSize;

    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfMatch"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfMatch;

    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfReserved;

    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfVendorId"]/*' />
    [NativeTypeName("BYTE[4]")]
    public _elfVendorId_e__FixedBuffer elfVendorId;

    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfCulture"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfCulture;

    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfPanose"]/*' />
    public PANOSE elfPanose;

    /// <include file='_elfFullName_e__FixedBuffer.xml' path='doc/member[@name="_elfFullName_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _elfFullName_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_elfStyle_e__FixedBuffer.xml' path='doc/member[@name="_elfStyle_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _elfStyle_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_elfVendorId_e__FixedBuffer.xml' path='doc/member[@name="_elfVendorId_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _elfVendorId_e__FixedBuffer
    {
        public byte e0;
    }
}
