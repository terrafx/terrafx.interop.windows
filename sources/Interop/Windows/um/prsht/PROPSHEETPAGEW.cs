// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPSHEETPAGEW
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("_PROPSHEETPAGEW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:271:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public ref ushort* pszTemplate
        {
            get
            {
                fixed (_Anonymous1_e__Union* pField = &Anonymous1)
                {
                    return ref pField->pszTemplate;
                }
            }
        }

        public ref DLGTEMPLATE* pResource
        {
            get
            {
                fixed (_Anonymous1_e__Union* pField = &Anonymous1)
                {
                    return ref pField->pResource;
                }
            }
        }

        [NativeTypeName("_PROPSHEETPAGEW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:271:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public ref IntPtr hIcon => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.hIcon, 1));

        public ref ushort* pszIcon
        {
            get
            {
                fixed (_Anonymous2_e__Union* pField = &Anonymous2)
                {
                    return ref pField->pszIcon;
                }
            }
        }

        [NativeTypeName("LPCWSTR")]
        public ushort* pszTitle;

        [NativeTypeName("DLGPROC")]
        public delegate* stdcall<IntPtr, uint, nuint, nint, nint> pfnDlgProc;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("LPFNPSPCALLBACKW")]
        public delegate* stdcall<IntPtr, uint, PROPSHEETPAGEW*, uint> pfnCallback;

        [NativeTypeName("UINT *")]
        public uint* pcRefParent;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszHeaderTitle;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszHeaderSubTitle;

        [NativeTypeName("HANDLE")]
        public IntPtr hActCtx;

        [NativeTypeName("_PROPSHEETPAGEW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:278:5)")]
        public _Anonymous3_e__Union Anonymous3;

        public ref IntPtr hbmHeader => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.hbmHeader, 1));

        public ref ushort* pszbmHeader
        {
            get
            {
                fixed (_Anonymous3_e__Union* pField = &Anonymous3)
                {
                    return ref pField->pszbmHeader;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszTemplate;

            [FieldOffset(0)]
            [NativeTypeName("PROPSHEETPAGE_RESOURCE")]
            public DLGTEMPLATE* pResource;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HICON")]
            public IntPtr hIcon;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszIcon;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HBITMAP")]
            public IntPtr hbmHeader;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszbmHeader;
        }
    }
}
