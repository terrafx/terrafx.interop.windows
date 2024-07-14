// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MODULE_TYPE_INFO.xml' path='doc/member[@name="MODULE_TYPE_INFO"]/*' />
public partial struct MODULE_TYPE_INFO
{
    /// <include file='MODULE_TYPE_INFO.xml' path='doc/member[@name="MODULE_TYPE_INFO.dataLength"]/*' />
    public ushort dataLength;

    /// <include file='MODULE_TYPE_INFO.xml' path='doc/member[@name="MODULE_TYPE_INFO.leaf"]/*' />
    public ushort leaf;

    /// <include file='MODULE_TYPE_INFO.xml' path='doc/member[@name="MODULE_TYPE_INFO.data"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _data_e__FixedBuffer data;

    /// <include file='_data_e__FixedBuffer.xml' path='doc/member[@name="_data_e__FixedBuffer"]/*' />
    public partial struct _data_e__FixedBuffer
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
