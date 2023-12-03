// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IP_UNIDIRECTIONAL_ADAPTER_ADDRESS.xml' path='doc/member[@name="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS"]/*' />
public partial struct IP_UNIDIRECTIONAL_ADAPTER_ADDRESS
{
    /// <include file='IP_UNIDIRECTIONAL_ADAPTER_ADDRESS.xml' path='doc/member[@name="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS.NumAdapters"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumAdapters;

    /// <include file='IP_UNIDIRECTIONAL_ADAPTER_ADDRESS.xml' path='doc/member[@name="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS.Address"]/*' />
    [NativeTypeName("IPAddr[1]")]
    public _Address_e__FixedBuffer Address;

    /// <include file='_Address_e__FixedBuffer.xml' path='doc/member[@name="_Address_e__FixedBuffer"]/*' />
    public partial struct _Address_e__FixedBuffer
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
