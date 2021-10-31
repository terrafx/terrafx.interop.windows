// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPSHEETPAGEA
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public HINSTANCE hInstance;

        [NativeTypeName("_PROPSHEETPAGEA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:225:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("_PROPSHEETPAGEA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:225:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszTitle;

        [NativeTypeName("DLGPROC")]
        public delegate* unmanaged<HWND, uint, nuint, nint, nint> pfnDlgProc;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("LPFNPSPCALLBACKA")]
        public delegate* unmanaged<HWND, uint, PROPSHEETPAGEA*, uint> pfnCallback;

        [NativeTypeName("UINT *")]
        public uint* pcRefParent;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszHeaderTitle;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszHeaderSubTitle;

        public HANDLE hActCtx;

        [NativeTypeName("_PROPSHEETPAGEA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:232:5)")]
        public _Anonymous3_e__Union Anonymous3;

        public ref sbyte* pszTemplate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union* pField = &Anonymous1)
                {
                    return ref pField->pResource;
                }
            }
        }

        public ref HICON hIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union* pField = &Anonymous2)
                {
                    return ref pField->hIcon;
                }
            }
        }

        public ref sbyte* pszIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union* pField = &Anonymous2)
                {
                    return ref pField->pszIcon;
                }
            }
        }

        public ref HBITMAP hbmHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous3_e__Union* pField = &Anonymous3)
                {
                    return ref pField->hbmHeader;
                }
            }
        }

        public ref sbyte* pszbmHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
            [NativeTypeName("LPCSTR")]
            public sbyte* pszTemplate;

            [FieldOffset(0)]
            [NativeTypeName("PROPSHEETPAGE_RESOURCE")]
            public DLGTEMPLATE* pResource;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            public HICON hIcon;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pszIcon;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            public HBITMAP hbmHeader;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pszbmHeader;
        }
    }
}
