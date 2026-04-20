// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHARED_COMPUTE_UNIT_RELATIONSHIP.xml' path='doc/member[@name="SHARED_COMPUTE_UNIT_RELATIONSHIP"]/*' />
public partial struct SHARED_COMPUTE_UNIT_RELATIONSHIP
{
    /// <include file='SHARED_COMPUTE_UNIT_RELATIONSHIP.xml' path='doc/member[@name="SHARED_COMPUTE_UNIT_RELATIONSHIP.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='SHARED_COMPUTE_UNIT_RELATIONSHIP.xml' path='doc/member[@name="SHARED_COMPUTE_UNIT_RELATIONSHIP.ComputeUnitCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ComputeUnitCount;

    /// <include file='SHARED_COMPUTE_UNIT_RELATIONSHIP.xml' path='doc/member[@name="SHARED_COMPUTE_UNIT_RELATIONSHIP.Reserved"]/*' />
    [NativeTypeName("BYTE[14]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='SHARED_COMPUTE_UNIT_RELATIONSHIP.xml' path='doc/member[@name="SHARED_COMPUTE_UNIT_RELATIONSHIP.GroupCount"]/*' />
    [NativeTypeName("WORD")]
    public ushort GroupCount;

    /// <include file='SHARED_COMPUTE_UNIT_RELATIONSHIP.xml' path='doc/member[@name="SHARED_COMPUTE_UNIT_RELATIONSHIP.GroupMasks"]/*' />
    [NativeTypeName("GROUP_AFFINITY[1]")]
    public _GroupMasks_e__FixedBuffer GroupMasks;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(14)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_GroupMasks_e__FixedBuffer.xml' path='doc/member[@name="_GroupMasks_e__FixedBuffer"]/*' />
    public partial struct _GroupMasks_e__FixedBuffer
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
