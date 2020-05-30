// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DRVCALLBACK([NativeTypeName("HDRVR")] IntPtr hdrvr, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dwUser, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);
}
