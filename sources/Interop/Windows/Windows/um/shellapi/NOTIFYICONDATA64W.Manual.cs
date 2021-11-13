// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct NOTIFYICONDATA64W
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public HWND hWnd;

        public uint uID;

        public uint uFlags;

        public uint uCallbackMessage;

        public HICON hIcon;

        [NativeTypeName("WCHAR [128]")]
        public fixed ushort szTip[128];

        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("DWORD")]
        public uint dwStateMask;

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort szInfo[256];

        [NativeTypeName("_NOTIFYICONDATAW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/shellapi.h:1057:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort szInfoTitle[64];

        [NativeTypeName("DWORD")]
        public uint dwInfoFlags;

        public Guid guidItem;

        public HICON hBalloonIcon;

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

        [StructLayout(LayoutKind.Explicit)]
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
