// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STYLEBUFW.xml' path='doc/member[@name="STYLEBUFW"]/*' />
public partial struct STYLEBUFW
{
    /// <include file='STYLEBUFW.xml' path='doc/member[@name="STYLEBUFW.dwStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStyle;

    /// <include file='STYLEBUFW.xml' path='doc/member[@name="STYLEBUFW.szDescription"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _szDescription_e__FixedBuffer szDescription;

    /// <include file='_szDescription_e__FixedBuffer.xml' path='doc/member[@name="_szDescription_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szDescription_e__FixedBuffer
    {
        public char e0;
    }
}
