// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIA_MICR.xml' path='doc/member[@name="WIA_MICR"]/*' />
public partial struct WIA_MICR
{
    /// <include file='WIA_MICR.xml' path='doc/member[@name="WIA_MICR.Tag"]/*' />
    [NativeTypeName("DWORD")]
    public uint Tag;

    /// <include file='WIA_MICR.xml' path='doc/member[@name="WIA_MICR.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='WIA_MICR.xml' path='doc/member[@name="WIA_MICR.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='WIA_MICR.xml' path='doc/member[@name="WIA_MICR.Placeholder"]/*' />
    [NativeTypeName("WCHAR")]
    public char Placeholder;

    /// <include file='WIA_MICR.xml' path='doc/member[@name="WIA_MICR.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='WIA_MICR.xml' path='doc/member[@name="WIA_MICR.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;

    /// <include file='WIA_MICR.xml' path='doc/member[@name="WIA_MICR.Micr"]/*' />
    [NativeTypeName("WIA_MICR_INFO[1]")]
    public _Micr_e__FixedBuffer Micr;

    /// <include file='_Micr_e__FixedBuffer.xml' path='doc/member[@name="_Micr_e__FixedBuffer"]/*' />
    public partial struct _Micr_e__FixedBuffer
    {
        public WIA_MICR_INFO e0;

        [UnscopedRef]
        public ref WIA_MICR_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<WIA_MICR_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
