// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Advapi32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LookupPrivilegeValueA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeValueA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("PLUID")] LUID* lpLuid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LookupPrivilegeValueW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeValueW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("PLUID")] LUID* lpLuid);
    }
}
