// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_JPEG_QUANTIZATION_TABLE.xml' path='doc/member[@name="DXGI_JPEG_QUANTIZATION_TABLE"]/*' />
public partial struct DXGI_JPEG_QUANTIZATION_TABLE
{
    /// <include file='DXGI_JPEG_QUANTIZATION_TABLE.xml' path='doc/member[@name="DXGI_JPEG_QUANTIZATION_TABLE.Elements"]/*' />
    [NativeTypeName("BYTE[64]")]
    public _Elements_e__FixedBuffer Elements;

    /// <include file='_Elements_e__FixedBuffer.xml' path='doc/member[@name="_Elements_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _Elements_e__FixedBuffer
    {
        public byte e0;
    }
}
