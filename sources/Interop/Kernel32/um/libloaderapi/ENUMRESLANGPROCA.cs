// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int ENUMRESLANGPROCA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("WORD")] ushort wLanguage, [NativeTypeName("LONG_PTR")] IntPtr lParam);
}
