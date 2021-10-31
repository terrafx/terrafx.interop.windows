// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SP_DRVINFO_DATA_V1_A
    {
        public static uint SizeOf
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SP_DRVINFO_DATA32_V1_A));
                }
                else
                {
                    return (uint)(sizeof(SP_DRVINFO_DATA64_V1_A));
                }
            }
        }

        [FieldOffset(0)]
        public SP_DRVINFO_DATA32_V1_A _value32;

        [FieldOffset(0)]
        public SP_DRVINFO_DATA64_V1_A _value64;

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
        public ref uint DriverType
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.DriverType, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.DriverType, 1));
                }
            }
        }

        [NativeTypeName("ULONG_PTR")]
        public ref nuint Reserved
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Reserved, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Reserved, 1));
                }
            }
        }

        [NativeTypeName("CHAR [256]")]
        public Span<sbyte> Description
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.Description[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.Description[0], 1);
                }
            }
        }

        [NativeTypeName("CHAR [256]")]
        public Span<sbyte> MfgName
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.MfgName[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.MfgName[0], 1);
                }
            }
        }

        [NativeTypeName("CHAR [256]")]
        public Span<sbyte> ProviderName
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.ProviderName[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.ProviderName[0], 1);
                }
            }
        }
    }
}
