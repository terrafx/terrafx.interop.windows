// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION"]/*' />
public partial struct SEND_GENERIC_TLS_EXTENSION
{
    /// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION.ExtensionType"]/*' />
    [NativeTypeName("WORD")]
    public ushort ExtensionType;

    /// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION.HandshakeType"]/*' />
    [NativeTypeName("WORD")]
    public ushort HandshakeType;

    /// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION.BufferSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort BufferSize;

    /// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION.Buffer"]/*' />
    [NativeTypeName("UCHAR[1]")]
    public _Buffer_e__FixedBuffer Buffer;

    /// <include file='_Buffer_e__FixedBuffer.xml' path='doc/member[@name="_Buffer_e__FixedBuffer"]/*' />
    public partial struct _Buffer_e__FixedBuffer
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
