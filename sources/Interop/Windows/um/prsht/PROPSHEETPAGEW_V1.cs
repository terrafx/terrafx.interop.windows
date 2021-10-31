// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPSHEETPAGEW_V1
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public HINSTANCE hInstance;

        [NativeTypeName("_PROPSHEETPAGEW_V1::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:244:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("_PROPSHEETPAGEW_V1::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:244:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszTitle;

        [NativeTypeName("DLGPROC")]
        public delegate* unmanaged<HWND, uint, nuint, nint, nint> pfnDlgProc;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("LPFNPSPCALLBACKW")]
        public delegate* unmanaged<HWND, uint, PROPSHEETPAGEW*, uint> pfnCallback;

        public uint* pcRefParent;

        public ref ushort* pszTemplate
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

        public ref ushort* pszIcon
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
            public HICON hIcon;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszIcon;
        }
    }
}
