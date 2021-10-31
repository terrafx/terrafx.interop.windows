// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct NOTIFYICONDATA32A
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HWND")]
        public IntPtr hWnd;

        [NativeTypeName("UINT")]
        public uint uID;

        [NativeTypeName("UINT")]
        public uint uFlags;

        [NativeTypeName("UINT")]
        public uint uCallbackMessage;

        [NativeTypeName("HICON")]
        public IntPtr hIcon;

        [NativeTypeName("CHAR [128]")]
        public fixed sbyte szTip[128];

        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("DWORD")]
        public uint dwStateMask;

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte szInfo[256];

        [NativeTypeName("_NOTIFYICONDATAA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/shellapi.h:1026:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("CHAR [64]")]
        public fixed sbyte szInfoTitle[64];

        [NativeTypeName("DWORD")]
        public uint dwInfoFlags;

        [NativeTypeName("GUID")]
        public Guid guidItem;

        [NativeTypeName("HICON")]
        public IntPtr hBalloonIcon;

        public ref uint uTimeout
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.uTimeout, 1));
            }
        }

        public ref uint uVersion
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.uVersion, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint uTimeout;

            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint uVersion;
        }
    }
}
