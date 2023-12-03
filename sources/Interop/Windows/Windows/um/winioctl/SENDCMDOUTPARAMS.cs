// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SENDCMDOUTPARAMS.xml' path='doc/member[@name="SENDCMDOUTPARAMS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SENDCMDOUTPARAMS
{
    /// <include file='SENDCMDOUTPARAMS.xml' path='doc/member[@name="SENDCMDOUTPARAMS.cBufferSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cBufferSize;

    /// <include file='SENDCMDOUTPARAMS.xml' path='doc/member[@name="SENDCMDOUTPARAMS.DriverStatus"]/*' />
    public DRIVERSTATUS DriverStatus;

    /// <include file='SENDCMDOUTPARAMS.xml' path='doc/member[@name="SENDCMDOUTPARAMS.bBuffer"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _bBuffer_e__FixedBuffer bBuffer;

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
