// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DIPROPCALPOV.xml' path='doc/member[@name="DIPROPCALPOV"]/*' />
public partial struct DIPROPCALPOV
{
    /// <include file='DIPROPCALPOV.xml' path='doc/member[@name="DIPROPCALPOV.diph"]/*' />
    public DIPROPHEADER diph;

    /// <include file='DIPROPCALPOV.xml' path='doc/member[@name="DIPROPCALPOV.lMin"]/*' />
    [NativeTypeName("LONG[5]")]
    public _lMin_e__FixedBuffer lMin;

    /// <include file='DIPROPCALPOV.xml' path='doc/member[@name="DIPROPCALPOV.lMax"]/*' />
    [NativeTypeName("LONG[5]")]
    public _lMax_e__FixedBuffer lMax;

    /// <include file='_lMin_e__FixedBuffer.xml' path='doc/member[@name="_lMin_e__FixedBuffer"]/*' />
    [InlineArray(5)]
    public partial struct _lMin_e__FixedBuffer
    {
        public int e0;
    }

    /// <include file='_lMax_e__FixedBuffer.xml' path='doc/member[@name="_lMax_e__FixedBuffer"]/*' />
    [InlineArray(5)]
    public partial struct _lMax_e__FixedBuffer
    {
        public int e0;
    }
}
