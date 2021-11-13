// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct PROPSHEETHEADERW_V2
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public HWND hwndParent;

        public HINSTANCE hInstance;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:526:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszCaption;

        public uint nPages;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:526:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:526:5)")]
        public _Anonymous3_e__Union Anonymous3;

        [NativeTypeName("PFNPROPSHEETCALLBACK")]
        public delegate* unmanaged<HWND, uint, LPARAM, int> pfnCallback;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:527:5)")]
        public _Anonymous4_e__Union Anonymous4;

        public HPALETTE hplWatermark;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:533:5)")]
        public _Anonymous5_e__Union Anonymous5;

        public ref HICON hIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.hIcon;
            }
        }

        public ref ushort* pszIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.pszIcon;
            }
        }

        public ref uint nStartPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.nStartPage, 1));
            }
        }

        public ref ushort* pStartPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.pStartPage;
            }
        }

        public ref PROPSHEETPAGEW* ppsp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous3.ppsp;
            }
        }

        public ref HPROPSHEETPAGE* phpage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous3.phpage;
            }
        }

        public ref HBITMAP hbmWatermark
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous4.hbmWatermark;
            }
        }

        public ref ushort* pszbmWatermark
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous4.pszbmWatermark;
            }
        }

        public ref HBITMAP hbmHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous5.hbmHeader;
            }
        }

        public ref ushort* pszbmHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous5.pszbmHeader;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            public HICON hIcon;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszIcon;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            public uint nStartPage;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pStartPage;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPCPROPSHEETPAGEW")]
            public PROPSHEETPAGEW* ppsp;

            [FieldOffset(0)]
            public HPROPSHEETPAGE* phpage;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous4_e__Union
        {
            [FieldOffset(0)]
            public HBITMAP hbmWatermark;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszbmWatermark;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous5_e__Union
        {
            [FieldOffset(0)]
            public HBITMAP hbmHeader;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszbmHeader;
        }
    }
}
