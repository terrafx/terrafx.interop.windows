// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPSHEETPAGEA_V3
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("_PROPSHEETPAGEA_V3::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/prsht.h:213:5)")]
        public _Anonymous_e__Union1 Anonymous1;

        [NativeTypeName("_PROPSHEETPAGEA_V3::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/prsht.h:213:5)")]
        public _Anonymous_e__Union2 Anonymous2;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszTitle;

        [NativeTypeName("DLGPROC")]
        public IntPtr* pfnDlgProc;

        [NativeTypeName("LPARAM")]
        public IntPtr lParam;

        [NativeTypeName("LPFNPSPCALLBACKA")]
        public IntPtr* pfnCallback;

        [NativeTypeName("UINT *")]
        public uint* pcRefParent;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszHeaderTitle;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszHeaderSubTitle;

        [NativeTypeName("HANDLE")]
        public IntPtr hActCtx;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union1
        {
            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pszTemplate;

            [FieldOffset(0)]
            [NativeTypeName("PROPSHEETPAGE_RESOURCE")]
            public DLGTEMPLATE* pResource;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union2
        {
            [FieldOffset(0)]
            [NativeTypeName("HICON")]
            public IntPtr hIcon;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pszIcon;
        }
    }
}
