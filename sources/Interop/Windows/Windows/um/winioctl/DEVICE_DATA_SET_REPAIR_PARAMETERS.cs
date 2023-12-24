// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICE_DATA_SET_REPAIR_PARAMETERS.xml' path='doc/member[@name="DEVICE_DATA_SET_REPAIR_PARAMETERS"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct DEVICE_DATA_SET_REPAIR_PARAMETERS
{
    /// <include file='DEVICE_DATA_SET_REPAIR_PARAMETERS.xml' path='doc/member[@name="DEVICE_DATA_SET_REPAIR_PARAMETERS.NumberOfRepairCopies"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfRepairCopies;

    /// <include file='DEVICE_DATA_SET_REPAIR_PARAMETERS.xml' path='doc/member[@name="DEVICE_DATA_SET_REPAIR_PARAMETERS.SourceCopy"]/*' />
    [NativeTypeName("DWORD")]
    public uint SourceCopy;

    /// <include file='DEVICE_DATA_SET_REPAIR_PARAMETERS.xml' path='doc/member[@name="DEVICE_DATA_SET_REPAIR_PARAMETERS.RepairCopies"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _RepairCopies_e__FixedBuffer RepairCopies;

    /// <include file='_RepairCopies_e__FixedBuffer.xml' path='doc/member[@name="_RepairCopies_e__FixedBuffer"]/*' />
    public partial struct _RepairCopies_e__FixedBuffer
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
