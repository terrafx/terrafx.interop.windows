// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MESSAGE_RESOURCE_ENTRY.xml' path='doc/member[@name="MESSAGE_RESOURCE_ENTRY"]/*' />
public partial struct MESSAGE_RESOURCE_ENTRY
{
    /// <include file='MESSAGE_RESOURCE_ENTRY.xml' path='doc/member[@name="MESSAGE_RESOURCE_ENTRY.Length"]/*' />
    [NativeTypeName("WORD")]
    public ushort Length;

    /// <include file='MESSAGE_RESOURCE_ENTRY.xml' path='doc/member[@name="MESSAGE_RESOURCE_ENTRY.Flags"]/*' />
    [NativeTypeName("WORD")]
    public ushort Flags;

    /// <include file='MESSAGE_RESOURCE_ENTRY.xml' path='doc/member[@name="MESSAGE_RESOURCE_ENTRY.Text"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _Text_e__FixedBuffer Text;

    /// <include file='_Text_e__FixedBuffer.xml' path='doc/member[@name="_Text_e__FixedBuffer"]/*' />
    public partial struct _Text_e__FixedBuffer
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
