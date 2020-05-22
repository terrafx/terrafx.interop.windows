// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class ComCtl32
    {
        private const string LibraryPath = "comctl32";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreatePropertySheetPageA", ExactSpelling = true)]
        [return: NativeTypeName("HPROPSHEETPAGE")]
        public static extern IntPtr CreatePropertySheetPageA([NativeTypeName("LPCPROPSHEETPAGEA")] PROPSHEETPAGEA* constPropSheetPagePointer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreatePropertySheetPageW", ExactSpelling = true)]
        [return: NativeTypeName("HPROPSHEETPAGE")]
        public static extern IntPtr CreatePropertySheetPageW([NativeTypeName("LPCPROPSHEETPAGEW")] PROPSHEETPAGEW* constPropSheetPagePointer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DestroyPropertySheetPage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyPropertySheetPage([NativeTypeName("HPROPSHEETPAGE")] IntPtr param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PropertySheetA", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint PropertySheetA([NativeTypeName("LPCPROPSHEETHEADERA")] PROPSHEETHEADERA_V2* param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PropertySheetW", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint PropertySheetW([NativeTypeName("LPCPROPSHEETHEADERW")] PROPSHEETHEADERW_V2* param0);
    }
}
