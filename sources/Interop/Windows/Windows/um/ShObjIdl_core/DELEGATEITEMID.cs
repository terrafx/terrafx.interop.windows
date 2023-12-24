// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DELEGATEITEMID.xml' path='doc/member[@name="DELEGATEITEMID"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DELEGATEITEMID
{
    /// <include file='DELEGATEITEMID.xml' path='doc/member[@name="DELEGATEITEMID.cbSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort cbSize;

    /// <include file='DELEGATEITEMID.xml' path='doc/member[@name="DELEGATEITEMID.wOuter"]/*' />
    [NativeTypeName("WORD")]
    public ushort wOuter;

    /// <include file='DELEGATEITEMID.xml' path='doc/member[@name="DELEGATEITEMID.cbInner"]/*' />
    [NativeTypeName("WORD")]
    public ushort cbInner;

    /// <include file='DELEGATEITEMID.xml' path='doc/member[@name="DELEGATEITEMID.rgb"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _rgb_e__FixedBuffer rgb;

    /// <include file='_rgb_e__FixedBuffer.xml' path='doc/member[@name="_rgb_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _rgb_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
