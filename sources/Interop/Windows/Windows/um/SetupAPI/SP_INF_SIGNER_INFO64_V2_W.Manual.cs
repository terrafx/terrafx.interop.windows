// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_INF_SIGNER_INFO64_V2_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort CatalogFile[260];

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort DigitalSigner[260];

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort DigitalSignerVersion[260];

    [NativeTypeName("DWORD")]
    public uint SignerScore;
}
