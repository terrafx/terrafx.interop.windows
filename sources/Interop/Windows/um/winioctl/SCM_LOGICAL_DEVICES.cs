// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SCM_LOGICAL_DEVICES
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint DeviceCount;

        [NativeTypeName("SCM_LOGICAL_DEVICE_INSTANCE [1]")]
        public _Devices_e__FixedBuffer Devices;

        public partial struct _Devices_e__FixedBuffer
        {
            public SCM_LOGICAL_DEVICE_INSTANCE e0;

            public unsafe ref SCM_LOGICAL_DEVICE_INSTANCE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<SCM_LOGICAL_DEVICE_INSTANCE> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<SCM_LOGICAL_DEVICE_INSTANCE>((SCM_LOGICAL_DEVICE_INSTANCE*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
