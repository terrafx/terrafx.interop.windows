// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SP_INSTALLWIZARD_DATA
    {
        public SP_CLASSINSTALL_HEADER ClassInstallHeader;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("HPROPSHEETPAGE [20]")]
        public _DynamicPages_e__FixedBuffer DynamicPages;

        [NativeTypeName("DWORD")]
        public uint NumDynamicPages;

        [NativeTypeName("DWORD")]
        public uint DynamicPageFlags;

        [NativeTypeName("DWORD")]
        public uint PrivateFlags;

        [NativeTypeName("LPARAM")]
        public nint PrivateData;

        [NativeTypeName("HWND")]
        public IntPtr hwndWizardDlg;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _DynamicPages_e__FixedBuffer
        {
            internal IntPtr e0;
            internal IntPtr e1;
            internal IntPtr e2;
            internal IntPtr e3;
            internal IntPtr e4;
            internal IntPtr e5;
            internal IntPtr e6;
            internal IntPtr e7;
            internal IntPtr e8;
            internal IntPtr e9;
            internal IntPtr e10;
            internal IntPtr e11;
            internal IntPtr e12;
            internal IntPtr e13;
            internal IntPtr e14;
            internal IntPtr e15;
            internal IntPtr e16;
            internal IntPtr e17;
            internal IntPtr e18;
            internal IntPtr e19;

            public ref IntPtr this[int index] => ref AsSpan()[index];

            public Span<IntPtr> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 20);
        }
    }
}
