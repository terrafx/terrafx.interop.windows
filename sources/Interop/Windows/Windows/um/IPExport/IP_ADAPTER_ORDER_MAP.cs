// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IP_ADAPTER_ORDER_MAP.xml' path='doc/member[@name="IP_ADAPTER_ORDER_MAP"]/*' />
public partial struct IP_ADAPTER_ORDER_MAP
{
    /// <include file='IP_ADAPTER_ORDER_MAP.xml' path='doc/member[@name="IP_ADAPTER_ORDER_MAP.NumAdapters"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumAdapters;

    /// <include file='IP_ADAPTER_ORDER_MAP.xml' path='doc/member[@name="IP_ADAPTER_ORDER_MAP.AdapterOrder"]/*' />
    [NativeTypeName("ULONG[1]")]
    public _AdapterOrder_e__FixedBuffer AdapterOrder;

    /// <include file='_AdapterOrder_e__FixedBuffer.xml' path='doc/member[@name="_AdapterOrder_e__FixedBuffer"]/*' />
    public partial struct _AdapterOrder_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
