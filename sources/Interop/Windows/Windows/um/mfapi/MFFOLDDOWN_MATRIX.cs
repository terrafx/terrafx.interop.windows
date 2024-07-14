// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX"]/*' />
public partial struct MFFOLDDOWN_MATRIX
{
    /// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX.cbSize"]/*' />
    [NativeTypeName("UINT32")]
    public uint cbSize;

    /// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX.cSrcChannels"]/*' />
    [NativeTypeName("UINT32")]
    public uint cSrcChannels;

    /// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX.cDstChannels"]/*' />
    [NativeTypeName("UINT32")]
    public uint cDstChannels;

    /// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX.dwChannelMask"]/*' />
    [NativeTypeName("UINT32")]
    public uint dwChannelMask;

    /// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX.Coeff"]/*' />
    [NativeTypeName("LONG[64]")]
    public _Coeff_e__FixedBuffer Coeff;

    /// <include file='_Coeff_e__FixedBuffer.xml' path='doc/member[@name="_Coeff_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _Coeff_e__FixedBuffer
    {
        public int e0;
    }
}
