// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("HRESULT")]
    public unsafe delegate int PFNProgressNotification(
        [In, NativeTypeName("LPVOID")] void* pvData,
        [In, NativeTypeName("ULONG")] uint uFrameNum,
        [In] WICProgressOperation operation,
        [In] double dblProgress
    );
}
