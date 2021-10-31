// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SP_PROPSHEETPAGE_REQUEST
    {
        public static uint Size
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SP_PROPSHEETPAGE_REQUEST32));
                }
                else
                {
                    return (uint)(sizeof(SP_PROPSHEETPAGE_REQUEST64));
                }
            }
        }

        [FieldOffset(0)]
        public SP_PROPSHEETPAGE_REQUEST32 _value32;

        [FieldOffset(0)]
        public SP_PROPSHEETPAGE_REQUEST64 _value64;

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

        [NativeTypeName("DWORD")]
        public ref uint PageRequested
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.PageRequested, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.PageRequested, 1));
                }
            }
        }

        public ref HDEVINFO DeviceInfoSet
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.DeviceInfoSet, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.DeviceInfoSet, 1));
                }
            }
        }

        // The following isn't exposed as there isn't a good way to
        // convert from ref SP_DEVINFO_DATA32* to ref SP_DEVINFO_DATA*
        //
        //[NativeTypeName("PSP_DEVINFO_DATA")]
        //public ref SP_DEVINFO_DATA* DeviceInfoData;
    }
}
