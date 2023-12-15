// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DIPROPSTRING.xml' path='doc/member[@name="DIPROPSTRING"]/*' />
public partial struct DIPROPSTRING
{
    /// <include file='DIPROPSTRING.xml' path='doc/member[@name="DIPROPSTRING.diph"]/*' />
    public DIPROPHEADER diph;

    /// <include file='DIPROPSTRING.xml' path='doc/member[@name="DIPROPSTRING.wsz"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _wsz_e__FixedBuffer wsz;

    /// <include file='_wsz_e__FixedBuffer.xml' path='doc/member[@name="_wsz_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _wsz_e__FixedBuffer
    {
        public char e0;
    }
}
