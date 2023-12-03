// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_HDR_METADATA_HDR10PLUS.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10PLUS"]/*' />
public partial struct DXGI_HDR_METADATA_HDR10PLUS
{
    /// <include file='DXGI_HDR_METADATA_HDR10PLUS.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10PLUS.Data"]/*' />
    [NativeTypeName("BYTE[72]")]
    public _Data_e__FixedBuffer Data;

    /// <include file='_Data_e__FixedBuffer.xml' path='doc/member[@name="_Data_e__FixedBuffer"]/*' />
    [InlineArray(72)]
    public partial struct _Data_e__FixedBuffer
    {
        public byte e0;
    }
}
