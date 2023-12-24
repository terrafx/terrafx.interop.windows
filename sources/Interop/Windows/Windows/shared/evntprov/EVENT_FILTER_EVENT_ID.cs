// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EVENT_FILTER_EVENT_ID.xml' path='doc/member[@name="EVENT_FILTER_EVENT_ID"]/*' />
public partial struct EVENT_FILTER_EVENT_ID
{
    /// <include file='EVENT_FILTER_EVENT_ID.xml' path='doc/member[@name="EVENT_FILTER_EVENT_ID.FilterIn"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte FilterIn;

    /// <include file='EVENT_FILTER_EVENT_ID.xml' path='doc/member[@name="EVENT_FILTER_EVENT_ID.Reserved"]/*' />
    [NativeTypeName("UCHAR")]
    public byte Reserved;

    /// <include file='EVENT_FILTER_EVENT_ID.xml' path='doc/member[@name="EVENT_FILTER_EVENT_ID.Count"]/*' />
    public ushort Count;

    /// <include file='EVENT_FILTER_EVENT_ID.xml' path='doc/member[@name="EVENT_FILTER_EVENT_ID.Events"]/*' />
    [NativeTypeName("USHORT[1]")]
    public _Events_e__FixedBuffer Events;

    /// <include file='_Events_e__FixedBuffer.xml' path='doc/member[@name="_Events_e__FixedBuffer"]/*' />
    public partial struct _Events_e__FixedBuffer
    {
        public ushort e0;

        [UnscopedRef]
        public ref ushort this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
