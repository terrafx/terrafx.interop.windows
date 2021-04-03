// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPSHEETHEADERW_V2
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("HWND")]
        public IntPtr hwndParent;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:526:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszCaption;

        [NativeTypeName("UINT")]
        public uint nPages;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:526:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:526:5)")]
        public _Anonymous3_e__Union Anonymous3;

        [NativeTypeName("PFNPROPSHEETCALLBACK")]
        public delegate* unmanaged<IntPtr, uint, nint, int> pfnCallback;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:527:5)")]
        public _Anonymous4_e__Union Anonymous4;

        [NativeTypeName("HPALETTE")]
        public IntPtr hplWatermark;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:533:5)")]
        public _Anonymous5_e__Union Anonymous5;

        public ref IntPtr hIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.hIcon, 1));
            }
        }

        public ref ushort* pszIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union* pField = &Anonymous1)
                {
                    return ref pField->pszIcon;
                }
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
                fixed (_Anonymous2_e__Union* pField = &Anonymous2)
                {
                    return ref pField->pStartPage;
                }
            }
        }

        public ref PROPSHEETPAGEW* ppsp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous3_e__Union* pField = &Anonymous3)
                {
                    return ref pField->ppsp;
                }
            }
        }

        public ref IntPtr* phpage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous3_e__Union* pField = &Anonymous3)
                {
                    return ref pField->phpage;
                }
            }
        }

        public ref IntPtr hbmWatermark
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.hbmWatermark, 1));
            }
        }

        public ref ushort* pszbmWatermark
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous4_e__Union* pField = &Anonymous4)
                {
                    return ref pField->pszbmWatermark;
                }
            }
        }

        public ref IntPtr hbmHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.hbmHeader, 1));
            }
        }

        public ref ushort* pszbmHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous5_e__Union* pField = &Anonymous5)
                {
                    return ref pField->pszbmHeader;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HICON")]
            public IntPtr hIcon;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszIcon;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT")]
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
            [NativeTypeName("HPROPSHEETPAGE *")]
            public IntPtr* phpage;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous4_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HBITMAP")]
            public IntPtr hbmWatermark;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszbmWatermark;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous5_e__Union
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
