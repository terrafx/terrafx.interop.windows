// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/inspectable.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("ComBase", EntryPoint = "HSTRING_UserSize", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint HSTRING_UserSize([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned long")] uint param1, [NativeTypeName("HSTRING *")] IntPtr* param2);

        [DllImport("ComBase", EntryPoint = "HSTRING_UserMarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* HSTRING_UserMarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("HSTRING *")] IntPtr* param2);

        [DllImport("ComBase", EntryPoint = "HSTRING_UserUnmarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* HSTRING_UserUnmarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("HSTRING *")] IntPtr* param2);

        [DllImport("ComBase", EntryPoint = "HSTRING_UserFree", ExactSpelling = true)]
        public static extern void HSTRING_UserFree([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("HSTRING *")] IntPtr* param1);

        [DllImport("ComBase", EntryPoint = "HSTRING_UserSize64", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint HSTRING_UserSize64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned long")] uint param1, [NativeTypeName("HSTRING *")] IntPtr* param2);

        [DllImport("ComBase", EntryPoint = "HSTRING_UserMarshal64", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* HSTRING_UserMarshal64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("HSTRING *")] IntPtr* param2);

        [DllImport("ComBase", EntryPoint = "HSTRING_UserUnmarshal64", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* HSTRING_UserUnmarshal64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("HSTRING *")] IntPtr* param2);

        [DllImport("ComBase", EntryPoint = "HSTRING_UserFree64", ExactSpelling = true)]
        public static extern void HSTRING_UserFree64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("HSTRING *")] IntPtr* param1);
    }
}
