// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DEVICE_LOCATION
    {
        [NativeTypeName("DWORD")]
        public uint Socket;

        [NativeTypeName("DWORD")]
        public uint Slot;

        [NativeTypeName("DWORD")]
        public uint Adapter;

        [NativeTypeName("DWORD")]
        public uint Port;

        [NativeTypeName("_DEVICE_LOCATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:2922:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint Channel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.Channel, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous1))->Channel;
#endif
            }
        }

        public unsafe ref uint Device
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.Device, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous1))->Device;
#endif
            }
        }

        public unsafe ref uint Target
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2.Target, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous2))->Target;
#endif
            }
        }

        public unsafe ref uint Lun
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2.Lun, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous2))->Lun;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("_DEVICE_LOCATION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:2924:9)")]
            public _Anonymous1_e__Struct Anonymous1;

            [FieldOffset(0)]
            [NativeTypeName("_DEVICE_LOCATION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:2932:9)")]
            public _Anonymous2_e__Struct Anonymous2;

            public partial struct _Anonymous1_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint Channel;

                [NativeTypeName("DWORD")]
                public uint Device;
            }

            public partial struct _Anonymous2_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint Target;

                [NativeTypeName("DWORD")]
                public uint Lun;
            }
        }
    }
}
