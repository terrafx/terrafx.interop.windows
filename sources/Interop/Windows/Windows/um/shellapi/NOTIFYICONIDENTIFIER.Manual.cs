// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct NOTIFYICONIDENTIFIER
    {
        public static uint SizeOf
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(NOTIFYICONIDENTIFIER32));
                }
                else
                {
                    return (uint)(sizeof(NOTIFYICONIDENTIFIER64));
                }
            }
        }

        [FieldOffset(0)]
        public NOTIFYICONIDENTIFIER32 _value32;

        [FieldOffset(0)]
        public NOTIFYICONIDENTIFIER64 _value64;

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

        public ref HWND hWnd
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hWnd, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hWnd, 1));
                }
            }
        }

        public ref uint uID
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.uID, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.uID, 1));
                }
            }
        }

        public ref Guid guidItem
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.guidItem, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.guidItem, 1));
                }
            }
        }
    }
}
