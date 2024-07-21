// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA"]/*' />
public partial struct STORAGE_DIAGNOSTIC_DATA
{
    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.ProviderId"]/*' />
    public Guid ProviderId;

    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.BufferSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint BufferSize;

    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.DiagnosticDataBuffer"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _DiagnosticDataBuffer_e__FixedBuffer DiagnosticDataBuffer;

    /// <include file='_DiagnosticDataBuffer_e__FixedBuffer.xml' path='doc/member[@name="_DiagnosticDataBuffer_e__FixedBuffer"]/*' />
    public partial struct _DiagnosticDataBuffer_e__FixedBuffer
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
