// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_FRU_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_FRU_ID_DESCRIPTOR"]/*' />
public partial struct STORAGE_FRU_ID_DESCRIPTOR
{
    /// <include file='STORAGE_FRU_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_FRU_ID_DESCRIPTOR.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_FRU_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_FRU_ID_DESCRIPTOR.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_FRU_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_FRU_ID_DESCRIPTOR.IdentifierSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint IdentifierSize;

    /// <include file='STORAGE_FRU_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_FRU_ID_DESCRIPTOR.Identifier"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _Identifier_e__FixedBuffer Identifier;

    /// <include file='_Identifier_e__FixedBuffer.xml' path='doc/member[@name="_Identifier_e__FixedBuffer"]/*' />
    public partial struct _Identifier_e__FixedBuffer
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
