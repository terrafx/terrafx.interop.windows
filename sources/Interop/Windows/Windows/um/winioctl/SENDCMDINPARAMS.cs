// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SENDCMDINPARAMS
{
    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.cBufferSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cBufferSize;

    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.irDriveRegs"]/*' />
    public IDEREGS irDriveRegs;

    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.bDriveNumber"]/*' />
    public byte bDriveNumber;

    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.bReserved"]/*' />
    [NativeTypeName("BYTE[3]")]
    public _bReserved_e__FixedBuffer bReserved;

    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.dwReserved"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _dwReserved_e__FixedBuffer dwReserved;

    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.bBuffer"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _bBuffer_e__FixedBuffer bBuffer;

    /// <include file='_bReserved_e__FixedBuffer.xml' path='doc/member[@name="_bReserved_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(3)]
    public partial struct _bReserved_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_dwReserved_e__FixedBuffer.xml' path='doc/member[@name="_dwReserved_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(4)]
    public partial struct _dwReserved_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_bBuffer_e__FixedBuffer.xml' path='doc/member[@name="_bBuffer_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _bBuffer_e__FixedBuffer
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
