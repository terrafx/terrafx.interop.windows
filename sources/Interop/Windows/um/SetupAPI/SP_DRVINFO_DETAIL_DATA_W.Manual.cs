// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SP_DRVINFO_DETAIL_DATA_W
    {
        public static uint Size
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SP_DRVINFO_DETAIL_DATA32_W));
                }
                else
                {
                    return (uint)(sizeof(SP_DRVINFO_DETAIL_DATA64_W));
                }
            }
        }

        [FieldOffset(0)]
        public SP_DRVINFO_DETAIL_DATA32_W _value32;

        [FieldOffset(0)]
        public SP_DRVINFO_DETAIL_DATA64_W _value64;

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

        public ref FILETIME InfDate
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.InfDate, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.InfDate, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint CompatIDsOffset
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.CompatIDsOffset, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.CompatIDsOffset, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint CompatIDsLength
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.CompatIDsLength, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.CompatIDsLength, 1));
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

        [NativeTypeName("WCHAR [256]")]
        public Span<ushort> SectionName
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.SectionName[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.SectionName[0], 1);
                }
            }
        }

        [NativeTypeName("WCHAR [260]")]
        public Span<ushort> InfFileName
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.InfFileName[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.InfFileName[0], 1);
                }
            }
        }

        [NativeTypeName("WCHAR [256]")]
        public Span<ushort> DrvDescription
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.DrvDescription[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.DrvDescription[0], 1);
                }
            }
        }

        [NativeTypeName("WCHAR [1]")]
        public Span<ushort> HardwareID
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.HardwareID[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.HardwareID[0], 1);
                }
            }
        }
    }
}
