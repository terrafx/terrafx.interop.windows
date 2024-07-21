// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SERIALIZEDPROPERTYVALUE.xml' path='doc/member[@name="SERIALIZEDPROPERTYVALUE"]/*' />
public partial struct SERIALIZEDPROPERTYVALUE
{
    /// <include file='SERIALIZEDPROPERTYVALUE.xml' path='doc/member[@name="SERIALIZEDPROPERTYVALUE.dwType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwType;

    /// <include file='SERIALIZEDPROPERTYVALUE.xml' path='doc/member[@name="SERIALIZEDPROPERTYVALUE.rgb"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _rgb_e__FixedBuffer rgb;

    /// <include file='_rgb_e__FixedBuffer.xml' path='doc/member[@name="_rgb_e__FixedBuffer"]/*' />
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
