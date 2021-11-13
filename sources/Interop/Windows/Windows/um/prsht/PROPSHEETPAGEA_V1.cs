// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct PROPSHEETPAGEA_V1
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public HINSTANCE hInstance;

        [NativeTypeName("_PROPSHEETPAGEA_V1::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:198:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("_PROPSHEETPAGEA_V1::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:198:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszTitle;

        [NativeTypeName("DLGPROC")]
        public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> pfnDlgProc;

        public LPARAM lParam;

        [NativeTypeName("LPFNPSPCALLBACKA")]
        public delegate* unmanaged<HWND, uint, PROPSHEETPAGEA*, uint> pfnCallback;

        public uint* pcRefParent;

        public ref sbyte* pszTemplate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.pszTemplate;
            }
        }

        public ref DLGTEMPLATE* pResource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.pResource;
            }
        }

        public ref HICON hIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.hIcon;
            }
        }

        public ref sbyte* pszIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.pszIcon;
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
    }
}
