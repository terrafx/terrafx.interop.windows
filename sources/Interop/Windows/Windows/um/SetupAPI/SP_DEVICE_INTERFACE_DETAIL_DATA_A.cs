// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_DEVICE_INTERFACE_DETAIL_DATA_A.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DETAIL_DATA_A"]/*' />
public partial struct SP_DEVICE_INTERFACE_DETAIL_DATA_A
{
    /// <include file='SP_DEVICE_INTERFACE_DETAIL_DATA_A.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DETAIL_DATA_A.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_DEVICE_INTERFACE_DETAIL_DATA_A.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DETAIL_DATA_A.DevicePath"]/*' />
    [NativeTypeName("CHAR[1]")]
    public _DevicePath_e__FixedBuffer DevicePath;

    /// <include file='_DevicePath_e__FixedBuffer.xml' path='doc/member[@name="_DevicePath_e__FixedBuffer"]/*' />
    public partial struct _DevicePath_e__FixedBuffer
    {
        public sbyte e0;

        [UnscopedRef]
        public ref sbyte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<sbyte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
