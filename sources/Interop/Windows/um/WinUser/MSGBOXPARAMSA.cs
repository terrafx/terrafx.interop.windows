// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MSGBOXPARAMSA
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("HWND")]
        public IntPtr hwndOwner;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszText;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszCaption;

        [NativeTypeName("DWORD")]
        public uint dwStyle;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszIcon;

        [NativeTypeName("DWORD_PTR")]
        public nuint dwContextHelpId;

        [NativeTypeName("MSGBOXCALLBACK")]
        public IntPtr lpfnMsgBoxCallback;

        [NativeTypeName("DWORD")]
        public uint dwLanguageId;
    }
}
