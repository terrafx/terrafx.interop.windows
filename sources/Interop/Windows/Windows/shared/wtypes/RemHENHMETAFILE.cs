// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RemHENHMETAFILE.xml' path='doc/member[@name="RemHENHMETAFILE"]/*' />
public partial struct RemHENHMETAFILE
{
    /// <include file='RemHENHMETAFILE.xml' path='doc/member[@name="RemHENHMETAFILE.cbData"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbData;

    /// <include file='RemHENHMETAFILE.xml' path='doc/member[@name="RemHENHMETAFILE.data"]/*' />
    [NativeTypeName("byte[1]")]
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
