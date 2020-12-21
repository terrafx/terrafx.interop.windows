// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/hstring.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct HSTRING_HEADER
    {
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/winrt/hstring.h:80:5)")]
        public _Reserved_e__Union Reserved;

        // The definition of this anonymous union in hstring.h is different on 64 bit compared to 32 bit.
        // On 64 bit, Reserved1 is a 24 byte buffer. On 32 bit, Reserved1 is only a 20 byte buffer.
        // To avoid producing multiple builds of the managed bindings, we use a 16 byte buffer and a native int instead, preserving the same layout.
        // Using this strategy, trying to match the native definition of this union would be too contrived.
        // Since the contents of this structure are undefined, it is not important to provide the same definitions.
        public unsafe partial struct _Reserved_e__Union
        {
            public fixed byte Reserved1_0[16];

            public nuint Reserved1_1;

            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<byte> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref Reserved1_0[0], sizeof(_Reserved_e__Union));
#else
                return new Span<byte>((byte*)Unsafe.AsPointer(ref this), sizeof(_Reserved_e__Union));
#endif
            }
        }
    }
}
