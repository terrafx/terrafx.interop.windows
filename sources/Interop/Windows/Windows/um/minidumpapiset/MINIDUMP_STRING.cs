// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_STRING.xml' path='doc/member[@name="MINIDUMP_STRING"]/*' />
public partial struct MINIDUMP_STRING
{
    /// <include file='MINIDUMP_STRING.xml' path='doc/member[@name="MINIDUMP_STRING.Length"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Length;

    /// <include file='MINIDUMP_STRING.xml' path='doc/member[@name="MINIDUMP_STRING.Buffer"]/*' />
    [NativeTypeName("WCHAR[0]")]
    public _Buffer_e__FixedBuffer Buffer;

    /// <include file='_Buffer_e__FixedBuffer.xml' path='doc/member[@name="_Buffer_e__FixedBuffer"]/*' />
    public partial struct _Buffer_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
