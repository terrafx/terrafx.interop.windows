// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public unsafe delegate int OLDFONTENUMPROC([NativeTypeName("const LOGFONTW *")] LOGFONT* param0, [NativeTypeName("const TEXTMETRICW *")] TEXTMETRIC* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPARAM")] IntPtr param3);
}
