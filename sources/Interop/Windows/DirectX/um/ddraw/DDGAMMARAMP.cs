// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DDGAMMARAMP.xml' path='doc/member[@name="DDGAMMARAMP"]/*' />
public partial struct DDGAMMARAMP
{
    /// <include file='DDGAMMARAMP.xml' path='doc/member[@name="DDGAMMARAMP.red"]/*' />
    [NativeTypeName("WORD[256]")]
    public _red_e__FixedBuffer red;

    /// <include file='DDGAMMARAMP.xml' path='doc/member[@name="DDGAMMARAMP.green"]/*' />
    [NativeTypeName("WORD[256]")]
    public _green_e__FixedBuffer green;

    /// <include file='DDGAMMARAMP.xml' path='doc/member[@name="DDGAMMARAMP.blue"]/*' />
    [NativeTypeName("WORD[256]")]
    public _blue_e__FixedBuffer blue;

    /// <include file='_red_e__FixedBuffer.xml' path='doc/member[@name="_red_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _red_e__FixedBuffer
    {
        public ushort e0;
    }

    /// <include file='_green_e__FixedBuffer.xml' path='doc/member[@name="_green_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _green_e__FixedBuffer
    {
        public ushort e0;
    }

    /// <include file='_blue_e__FixedBuffer.xml' path='doc/member[@name="_blue_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _blue_e__FixedBuffer
    {
        public ushort e0;
    }
}
