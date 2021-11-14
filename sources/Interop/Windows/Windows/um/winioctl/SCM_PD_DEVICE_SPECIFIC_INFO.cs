// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct SCM_PD_DEVICE_SPECIFIC_INFO
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint NumberOfProperties;

        [NativeTypeName("SCM_PD_DEVICE_SPECIFIC_PROPERTY [1]")]
        public _DeviceSpecificProperties_e__FixedBuffer DeviceSpecificProperties;

        public partial struct _DeviceSpecificProperties_e__FixedBuffer
        {
            public SCM_PD_DEVICE_SPECIFIC_PROPERTY e0;

            public ref SCM_PD_DEVICE_SPECIFIC_PROPERTY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<SCM_PD_DEVICE_SPECIFIC_PROPERTY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
