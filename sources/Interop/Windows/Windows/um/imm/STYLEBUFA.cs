// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STYLEBUFA.xml' path='doc/member[@name="STYLEBUFA"]/*' />
public partial struct STYLEBUFA
{
    /// <include file='STYLEBUFA.xml' path='doc/member[@name="STYLEBUFA.dwStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStyle;

    /// <include file='STYLEBUFA.xml' path='doc/member[@name="STYLEBUFA.szDescription"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _szDescription_e__FixedBuffer szDescription;

    /// <include file='_szDescription_e__FixedBuffer.xml' path='doc/member[@name="_szDescription_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szDescription_e__FixedBuffer
    {
        public sbyte e0;
    }
}
