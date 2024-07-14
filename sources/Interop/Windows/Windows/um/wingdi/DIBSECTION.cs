// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION"]/*' />
public partial struct DIBSECTION
{
    /// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION.dsBm"]/*' />
    public BITMAP dsBm;

    /// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION.dsBmih"]/*' />
    public BITMAPINFOHEADER dsBmih;

    /// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION.dsBitfields"]/*' />
    [NativeTypeName("DWORD[3]")]
    public _dsBitfields_e__FixedBuffer dsBitfields;

    /// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION.dshSection"]/*' />
    public HANDLE dshSection;

    /// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION.dsOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dsOffset;

    /// <include file='_dsBitfields_e__FixedBuffer.xml' path='doc/member[@name="_dsBitfields_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _dsBitfields_e__FixedBuffer
    {
        public uint e0;
    }
}
