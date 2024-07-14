// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_JPEG_AC_HUFFMAN_TABLE.xml' path='doc/member[@name="DXGI_JPEG_AC_HUFFMAN_TABLE"]/*' />
public partial struct DXGI_JPEG_AC_HUFFMAN_TABLE
{
    /// <include file='DXGI_JPEG_AC_HUFFMAN_TABLE.xml' path='doc/member[@name="DXGI_JPEG_AC_HUFFMAN_TABLE.CodeCounts"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _CodeCounts_e__FixedBuffer CodeCounts;

    /// <include file='DXGI_JPEG_AC_HUFFMAN_TABLE.xml' path='doc/member[@name="DXGI_JPEG_AC_HUFFMAN_TABLE.CodeValues"]/*' />
    [NativeTypeName("BYTE[162]")]
    public _CodeValues_e__FixedBuffer CodeValues;

    /// <include file='_CodeCounts_e__FixedBuffer.xml' path='doc/member[@name="_CodeCounts_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _CodeCounts_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_CodeValues_e__FixedBuffer.xml' path='doc/member[@name="_CodeValues_e__FixedBuffer"]/*' />
    [InlineArray(162)]
    public partial struct _CodeValues_e__FixedBuffer
    {
        public byte e0;
    }
}
