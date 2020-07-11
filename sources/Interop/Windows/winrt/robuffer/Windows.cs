// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/robuffer.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("WinTypes", EntryPoint = "RoGetBufferMarshaler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoGetBufferMarshaler([NativeTypeName("IMarshal **")] IMarshal** bufferMarshaler);
    }
}
