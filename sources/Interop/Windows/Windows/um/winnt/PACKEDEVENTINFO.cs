// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PACKEDEVENTINFO.xml' path='doc/member[@name="PACKEDEVENTINFO"]/*' />
public partial struct PACKEDEVENTINFO
{
    /// <include file='PACKEDEVENTINFO.xml' path='doc/member[@name="PACKEDEVENTINFO.ulSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulSize;

    /// <include file='PACKEDEVENTINFO.xml' path='doc/member[@name="PACKEDEVENTINFO.ulNumEventsForLogFile"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulNumEventsForLogFile;

    /// <include file='PACKEDEVENTINFO.xml' path='doc/member[@name="PACKEDEVENTINFO.ulOffsets"]/*' />
    [NativeTypeName("DWORD[]")]
    public _ulOffsets_e__FixedBuffer ulOffsets;

    /// <include file='_ulOffsets_e__FixedBuffer.xml' path='doc/member[@name="_ulOffsets_e__FixedBuffer"]/*' />
    public partial struct _ulOffsets_e__FixedBuffer
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
