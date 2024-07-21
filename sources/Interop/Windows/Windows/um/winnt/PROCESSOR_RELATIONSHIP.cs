// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP"]/*' />
public partial struct PROCESSOR_RELATIONSHIP
{
    /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP.Flags"]/*' />
    public byte Flags;

    /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP.EfficiencyClass"]/*' />
    public byte EfficiencyClass;

    /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP.Reserved"]/*' />
    [NativeTypeName("BYTE[20]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP.GroupCount"]/*' />
    [NativeTypeName("WORD")]
    public ushort GroupCount;

    /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP.GroupMask"]/*' />
    [NativeTypeName("GROUP_AFFINITY[1]")]
    public _GroupMask_e__FixedBuffer GroupMask;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_GroupMask_e__FixedBuffer.xml' path='doc/member[@name="_GroupMask_e__FixedBuffer"]/*' />
    public partial struct _GroupMask_e__FixedBuffer
    {
        public GROUP_AFFINITY e0;

        [UnscopedRef]
        public ref GROUP_AFFINITY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<GROUP_AFFINITY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
