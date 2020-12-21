// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SD_GLOBAL_CHANGE_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint ChangeType;

        [NativeTypeName("_SD_GLOBAL_CHANGE_OUTPUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:13677:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref SD_CHANGE_MACHINE_SID_OUTPUT SdChange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SdChange, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->SdChange;
#endif
            }
        }

        public unsafe ref SD_QUERY_STATS_OUTPUT SdQueryStats
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SdQueryStats, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->SdQueryStats;
#endif
            }
        }

        public unsafe ref SD_ENUM_SDS_OUTPUT SdEnumSds
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SdEnumSds, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->SdEnumSds;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public SD_CHANGE_MACHINE_SID_OUTPUT SdChange;

            [FieldOffset(0)]
            public SD_QUERY_STATS_OUTPUT SdQueryStats;

            [FieldOffset(0)]
            public SD_ENUM_SDS_OUTPUT SdEnumSds;
        }
    }
}
