// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EXP_SZ_LINK.xml' path='doc/member[@name="EXP_SZ_LINK"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EXP_SZ_LINK
{
    /// <include file='EXP_SZ_LINK.xml' path='doc/member[@name="EXP_SZ_LINK.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='EXP_SZ_LINK.xml' path='doc/member[@name="EXP_SZ_LINK.dwSignature"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSignature;

    /// <include file='EXP_SZ_LINK.xml' path='doc/member[@name="EXP_SZ_LINK.szTarget"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _szTarget_e__FixedBuffer szTarget;

    /// <include file='EXP_SZ_LINK.xml' path='doc/member[@name="EXP_SZ_LINK.swzTarget"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _swzTarget_e__FixedBuffer swzTarget;

    /// <include file='_szTarget_e__FixedBuffer.xml' path='doc/member[@name="_szTarget_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szTarget_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_swzTarget_e__FixedBuffer.xml' path='doc/member[@name="_swzTarget_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _swzTarget_e__FixedBuffer
    {
        public char e0;
    }
}
