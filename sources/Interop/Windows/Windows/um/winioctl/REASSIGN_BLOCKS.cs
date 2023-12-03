// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='REASSIGN_BLOCKS.xml' path='doc/member[@name="REASSIGN_BLOCKS"]/*' />
public partial struct REASSIGN_BLOCKS
{
    /// <include file='REASSIGN_BLOCKS.xml' path='doc/member[@name="REASSIGN_BLOCKS.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='REASSIGN_BLOCKS.xml' path='doc/member[@name="REASSIGN_BLOCKS.Count"]/*' />
    [NativeTypeName("WORD")]
    public ushort Count;

    /// <include file='REASSIGN_BLOCKS.xml' path='doc/member[@name="REASSIGN_BLOCKS.BlockNumber"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _BlockNumber_e__FixedBuffer BlockNumber;

    /// <include file='_BlockNumber_e__FixedBuffer.xml' path='doc/member[@name="_BlockNumber_e__FixedBuffer"]/*' />
    public partial struct _BlockNumber_e__FixedBuffer
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
