// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("DWORD")]
    public unsafe delegate uint LPFNDEVCAPS([NativeTypeName("LPSTR")] sbyte* param0, [NativeTypeName("LPSTR")] sbyte* param1, [NativeTypeName("UINT")] uint param2, [NativeTypeName("LPSTR")] sbyte* param3, [NativeTypeName("LPDEVMODE")] DEVMODE* param4);
}
