// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    public unsafe partial struct STORAGE_TEMPERATURE_DATA_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public short CriticalTemperature;

        public short WarningTemperature;

        [NativeTypeName("WORD")]
        public ushort InfoCount;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Reserved0[2];

        [NativeTypeName("DWORD [2]")]
        public fixed uint Reserved1[2];

        [NativeTypeName("STORAGE_TEMPERATURE_INFO [1]")]
        public _TemperatureInfo_e__FixedBuffer TemperatureInfo;

        public partial struct _TemperatureInfo_e__FixedBuffer
        {
            public STORAGE_TEMPERATURE_INFO e0;

            public ref STORAGE_TEMPERATURE_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<STORAGE_TEMPERATURE_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
