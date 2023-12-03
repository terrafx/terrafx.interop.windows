// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC"]/*' />
public partial struct IMAGE_DEBUG_MISC
{
    /// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC.DataType"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataType;

    /// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC.Length"]/*' />
    [NativeTypeName("DWORD")]
    public uint Length;

    /// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC.Unicode"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Unicode;

    /// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC.Reserved"]/*' />
    [NativeTypeName("BYTE[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC.Data"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _Data_e__FixedBuffer Data;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Data_e__FixedBuffer.xml' path='doc/member[@name="_Data_e__FixedBuffer"]/*' />
    public partial struct _Data_e__FixedBuffer
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
