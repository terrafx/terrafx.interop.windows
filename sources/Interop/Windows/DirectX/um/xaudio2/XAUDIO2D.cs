// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

public static partial class XAUDIO2D
{
    /// <include file='XAUDIO2D.xml' path='doc/member[@name="XAUDIO2D.XAUDIO2D_DLL_A"]/*' />
    [NativeTypeName("#define XAUDIO2D_DLL_A \"xaudio2_9d.dll\"")]
    public static ReadOnlySpan<byte> XAUDIO2D_DLL_A => "xaudio2_9d.dll"u8;

    /// <include file='XAUDIO2D.xml' path='doc/member[@name="XAUDIO2D.XAUDIO2D_DLL_W"]/*' />
    [NativeTypeName("#define XAUDIO2D_DLL_W L\"xaudio2_9d.dll\"")]
    public const string XAUDIO2D_DLL_W = "xaudio2_9d.dll";

    /// <include file='XAUDIO2D.xml' path='doc/member[@name="XAUDIO2D.XAUDIO2D_DLL"]/*' />
    [NativeTypeName("#define XAUDIO2D_DLL XAUDIO2D_DLL_W")]
    public const string XAUDIO2D_DLL = "xaudio2_9d.dll";
}
