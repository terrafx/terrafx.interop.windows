// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/profileapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "QueryPerformanceCounter", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryPerformanceCounter([NativeTypeName("LARGE_INTEGER *")] LARGE_INTEGER* lpPerformanceCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "QueryPerformanceFrequency", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryPerformanceFrequency([NativeTypeName("LARGE_INTEGER *")] LARGE_INTEGER* lpFrequency);
    }
}
