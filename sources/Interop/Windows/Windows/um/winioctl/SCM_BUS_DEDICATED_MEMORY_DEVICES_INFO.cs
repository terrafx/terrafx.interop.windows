// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint DeviceCount;

        [NativeTypeName("SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO [1]")]
        public _Devices_e__FixedBuffer Devices;

        public partial struct _Devices_e__FixedBuffer
        {
            public SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO e0;

            public ref SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
