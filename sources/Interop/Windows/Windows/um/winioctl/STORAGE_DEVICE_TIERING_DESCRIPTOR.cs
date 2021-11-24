// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct STORAGE_DEVICE_TIERING_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint TotalNumberOfTiers;

    [NativeTypeName("DWORD")]
    public uint NumberOfTiersReturned;

    [NativeTypeName("STORAGE_TIER [1]")]
    public _Tiers_e__FixedBuffer Tiers;

    public partial struct _Tiers_e__FixedBuffer
    {
        public STORAGE_TIER e0;

        public ref STORAGE_TIER this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<STORAGE_TIER> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
