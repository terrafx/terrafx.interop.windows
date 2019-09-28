// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "lstrlenW", ExactSpelling = true)]
        public static extern int lstrlen([NativeTypeName("LPCWSTR")] ushort* lpString);
    }
}
