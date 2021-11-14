// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SHFILEINFOA
    {
        public static uint SizeOf
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SHFILEINFO32A));
                }
                else
                {
                    return (uint)(sizeof(SHFILEINFO64A));
                }
            }
        }

        [FieldOffset(0)]
        public SHFILEINFO32A _value32;

        [FieldOffset(0)]
        public SHFILEINFO64A _value64;

        public ref HICON hIcon
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hIcon, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hIcon, 1));
                }
            }
        }

        public ref int iIcon
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.iIcon, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.iIcon, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint dwAttributes
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.dwAttributes, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.dwAttributes, 1));
                }
            }
        }

        [NativeTypeName("CHAR [260]")]
        public Span<sbyte> szDisplayName
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.szDisplayName[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.szDisplayName[0], 1);
                }
            }
        }

        [NativeTypeName("CHAR [80]")]
        public Span<sbyte> szTypeName
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.szTypeName[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.szTypeName[0], 1);
                }
            }
        }
    }
}
