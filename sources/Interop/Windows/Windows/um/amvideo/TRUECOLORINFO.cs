// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='TRUECOLORINFO.xml' path='doc/member[@name="TRUECOLORINFO"]/*' />
public unsafe partial struct TRUECOLORINFO
{
    /// <include file='TRUECOLORINFO.xml' path='doc/member[@name="TRUECOLORINFO.dwBitMasks"]/*' />
    [NativeTypeName("DWORD[3]")]
    public fixed uint dwBitMasks[3];

    /// <include file='TRUECOLORINFO.xml' path='doc/member[@name="TRUECOLORINFO.bmiColors"]/*' />
    [NativeTypeName("RGBQUAD[256]")]
    public _bmiColors_e__FixedBuffer bmiColors;

    /// <include file='_bmiColors_e__FixedBuffer.xml' path='doc/member[@name="_bmiColors_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _bmiColors_e__FixedBuffer
    {
        public RGBQUAD e0;
    }
}
