// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct OPEN_PRINTER_PROPS_INFOA
    {
        public static uint SizeOf
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(OPEN_PRINTER_PROPS_INFO32A));
                }
                else
                {
                    return (uint)(sizeof(OPEN_PRINTER_PROPS_INFO64A));
                }
            }
        }

        [FieldOffset(0)]
        public OPEN_PRINTER_PROPS_INFO32A _value32;

        [FieldOffset(0)]
        public OPEN_PRINTER_PROPS_INFO64A _value64;

        [NativeTypeName("DWORD")]
        public ref uint dwSize
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.dwSize, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.dwSize, 1));
                }
            }
        }

        [NativeTypeName("LPSTR")]
        public ref sbyte* pszSheetName
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pszSheetName;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pszSheetName;
                }
            }
        }

        public ref uint uSheetIndex
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.uSheetIndex, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.uSheetIndex, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint dwFlags
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.dwFlags, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.dwFlags, 1));
                }
            }
        }

        public ref BOOL bModal
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.bModal, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.bModal, 1));
                }
            }
        }
    }
}
