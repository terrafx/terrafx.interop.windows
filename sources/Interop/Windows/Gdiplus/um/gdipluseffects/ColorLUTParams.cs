// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Gdiplus;

/// <include file='ColorLUTParams.xml' path='doc/member[@name="ColorLUTParams"]/*' />
public partial struct ColorLUTParams
{
    /// <include file='ColorLUTParams.xml' path='doc/member[@name="ColorLUTParams.lutB"]/*' />
    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public _lutB_e__FixedBuffer lutB;

    /// <include file='ColorLUTParams.xml' path='doc/member[@name="ColorLUTParams.lutG"]/*' />
    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public _lutG_e__FixedBuffer lutG;

    /// <include file='ColorLUTParams.xml' path='doc/member[@name="ColorLUTParams.lutR"]/*' />
    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public _lutR_e__FixedBuffer lutR;

    /// <include file='ColorLUTParams.xml' path='doc/member[@name="ColorLUTParams.lutA"]/*' />
    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public _lutA_e__FixedBuffer lutA;

    /// <include file='_lutB_e__FixedBuffer.xml' path='doc/member[@name="_lutB_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _lutB_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_lutG_e__FixedBuffer.xml' path='doc/member[@name="_lutG_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _lutG_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_lutR_e__FixedBuffer.xml' path='doc/member[@name="_lutR_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _lutR_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_lutA_e__FixedBuffer.xml' path='doc/member[@name="_lutA_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _lutA_e__FixedBuffer
    {
        public byte e0;
    }
}
