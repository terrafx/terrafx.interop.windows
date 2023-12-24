// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='TI_FINDCHILDREN_PARAMS.xml' path='doc/member[@name="TI_FINDCHILDREN_PARAMS"]/*' />
public partial struct TI_FINDCHILDREN_PARAMS
{
    /// <include file='TI_FINDCHILDREN_PARAMS.xml' path='doc/member[@name="TI_FINDCHILDREN_PARAMS.Count"]/*' />
    [NativeTypeName("ULONG")]
    public uint Count;

    /// <include file='TI_FINDCHILDREN_PARAMS.xml' path='doc/member[@name="TI_FINDCHILDREN_PARAMS.Start"]/*' />
    [NativeTypeName("ULONG")]
    public uint Start;

    /// <include file='TI_FINDCHILDREN_PARAMS.xml' path='doc/member[@name="TI_FINDCHILDREN_PARAMS.ChildId"]/*' />
    [NativeTypeName("ULONG[1]")]
    public _ChildId_e__FixedBuffer ChildId;

    /// <include file='_ChildId_e__FixedBuffer.xml' path='doc/member[@name="_ChildId_e__FixedBuffer"]/*' />
    public partial struct _ChildId_e__FixedBuffer
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
