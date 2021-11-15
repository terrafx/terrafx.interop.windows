// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX
{
    public static partial class XAUDIO2D
    {
        [NativeTypeName("#define XAUDIO2D_DLL_A \"xaudio2_9d.dll\"")]
        public static ReadOnlySpan<byte> XAUDIO2D_DLL_A => new byte[] { 0x78, 0x61, 0x75, 0x64, 0x69, 0x6F, 0x32, 0x5F, 0x39, 0x64, 0x2E, 0x64, 0x6C, 0x6C, 0x00 };

        [NativeTypeName("#define XAUDIO2D_DLL_W L\"xaudio2_9d.dll\"")]
        public const string XAUDIO2D_DLL_W = "xaudio2_9d.dll";

        [NativeTypeName("#define XAUDIO2D_DLL XAUDIO2D_DLL_W")]
        public const string XAUDIO2D_DLL = "xaudio2_9d.dll";
    }
}
