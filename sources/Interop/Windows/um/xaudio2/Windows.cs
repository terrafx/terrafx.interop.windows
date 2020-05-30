// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("XAudio2_9", EntryPoint = "XAudio2CreateWithVersionInfo", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int XAudio2CreateWithVersionInfo([NativeTypeName("IXAudio2 **")] IXAudio2** ppXAudio2, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("XAUDIO2_PROCESSOR")] uint XAudio2Processor = 0x00000001, [NativeTypeName("DWORD")] uint ntddiVersion = 0x0A000008);
    }
}
