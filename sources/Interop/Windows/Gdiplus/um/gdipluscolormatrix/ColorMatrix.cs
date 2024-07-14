// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluscolormatrix.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Gdiplus;

/// <include file='ColorMatrix.xml' path='doc/member[@name="ColorMatrix"]/*' />
public partial struct ColorMatrix
{
    /// <include file='ColorMatrix.xml' path='doc/member[@name="ColorMatrix.m"]/*' />
    [NativeTypeName("REAL[5][5]")]
    public _m_e__FixedBuffer m;

    /// <include file='_m_e__FixedBuffer.xml' path='doc/member[@name="_m_e__FixedBuffer"]/*' />
    [InlineArray(5 * 5)]
    public partial struct _m_e__FixedBuffer
    {
        public float e0_0;
    }
}
