// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct DRAGINFOA
    {
        public static uint SizeOf
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(DRAGINFO32A));
                }
                else
                {
                    return (uint)(sizeof(DRAGINFO64A));
                }
            }
        }

        [FieldOffset(0)]
        public DRAGINFO32A _value32;

        [FieldOffset(0)]
        public DRAGINFO64A _value64;

        public ref uint uSize
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.uSize, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.uSize, 1));
                }
            }
        }

        public ref POINT pt
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.pt, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.pt, 1));
                }
            }
        }

        public ref BOOL fNC
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.fNC, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.fNC, 1));
                }
            }
        }

        [NativeTypeName("PZZSTR")]
        public ref sbyte* lpFileList
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpFileList;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpFileList;
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint grfKeyState
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.grfKeyState, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.grfKeyState, 1));
                }
            }
        }
    }
}
