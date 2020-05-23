// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void LPOVERLAPPED_COMPLETION_ROUTINE([NativeTypeName("DWORD")] uint dwErrorCode, [NativeTypeName("DWORD")] uint dwNumberOfBytesTransfered, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);
}
