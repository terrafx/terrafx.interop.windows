// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SP_DEVINFO_LIST_DETAIL_DATA_W
    {
        public static uint SizeOf
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SP_DEVINFO_LIST_DETAIL_DATA32_W));
                }
                else
                {
                    return (uint)(sizeof(SP_DEVINFO_LIST_DETAIL_DATA64_W));
                }
            }
        }

        [FieldOffset(0)]
        public SP_DEVINFO_LIST_DETAIL_DATA32_W _value32;

        [FieldOffset(0)]
        public SP_DEVINFO_LIST_DETAIL_DATA64_W _value64;

        [NativeTypeName("DWORD")]
        public ref uint cbSize
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cbSize, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cbSize, 1));
                }
            }
        }

        public ref Guid ClassGuid
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.ClassGuid, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.ClassGuid, 1));
                }
            }
        }

        public ref HANDLE RemoteMachineHandle
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.RemoteMachineHandle, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.RemoteMachineHandle, 1));
                }
            }
        }

        [NativeTypeName("WCHAR [263]")]
        public Span<ushort> RemoteMachineName
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.RemoteMachineName[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.RemoteMachineName[0], 1);
                }
            }
        }
    }
}
