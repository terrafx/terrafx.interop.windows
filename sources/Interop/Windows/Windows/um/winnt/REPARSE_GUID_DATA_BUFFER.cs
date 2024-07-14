// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER"]/*' />
public partial struct REPARSE_GUID_DATA_BUFFER
{
    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.ReparseTag"]/*' />
    [NativeTypeName("DWORD")]
    public uint ReparseTag;

    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.ReparseDataLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort ReparseDataLength;

    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.ReparseGuid"]/*' />
    public Guid ReparseGuid;

    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.GenericReparseBuffer"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L14590_C5")]
    public _GenericReparseBuffer_e__Struct GenericReparseBuffer;

    /// <include file='_GenericReparseBuffer_e__Struct.xml' path='doc/member[@name="_GenericReparseBuffer_e__Struct"]/*' />
    public partial struct _GenericReparseBuffer_e__Struct
    {
        /// <include file='_GenericReparseBuffer_e__Struct.xml' path='doc/member[@name="_GenericReparseBuffer_e__Struct.DataBuffer"]/*' />
        [NativeTypeName("BYTE[1]")]
        public _DataBuffer_e__FixedBuffer DataBuffer;

        /// <include file='_DataBuffer_e__FixedBuffer.xml' path='doc/member[@name="_DataBuffer_e__FixedBuffer"]/*' />
        public partial struct _DataBuffer_e__FixedBuffer
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
}
