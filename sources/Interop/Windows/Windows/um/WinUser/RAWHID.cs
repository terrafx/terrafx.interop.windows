// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RAWHID.xml' path='doc/member[@name="RAWHID"]/*' />
public partial struct RAWHID
{
    /// <include file='RAWHID.xml' path='doc/member[@name="RAWHID.dwSizeHid"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSizeHid;

    /// <include file='RAWHID.xml' path='doc/member[@name="RAWHID.dwCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCount;

    /// <include file='RAWHID.xml' path='doc/member[@name="RAWHID.bRawData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _bRawData_e__FixedBuffer bRawData;

    /// <include file='_bRawData_e__FixedBuffer.xml' path='doc/member[@name="_bRawData_e__FixedBuffer"]/*' />
    public partial struct _bRawData_e__FixedBuffer
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
