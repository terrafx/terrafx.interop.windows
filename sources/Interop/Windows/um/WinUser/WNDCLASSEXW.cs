// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WNDCLASSEXW
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint style;

        [NativeTypeName("WNDPROC")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpfnWndProc;
#else
        public void* _lpfnWndProc;

        public delegate* unmanaged[Stdcall]<IntPtr, uint, nuint, nint, nint> lpfnWndProc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<IntPtr, uint, nuint, nint, nint>)_lpfnWndProc;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _lpfnWndProc = value;
            }
        }
#endif

        public int cbClsExtra;

        public int cbWndExtra;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("HICON")]
        public IntPtr hIcon;

        [NativeTypeName("HCURSOR")]
        public IntPtr hCursor;

        [NativeTypeName("HBRUSH")]
        public IntPtr hbrBackground;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpszMenuName;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpszClassName;

        [NativeTypeName("HICON")]
        public IntPtr hIconSm;
    }
}
