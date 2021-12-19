// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_INF_SIGNER_INFO64_V2_A
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("CHAR [260]")]
    public fixed sbyte CatalogFile[260];

    [NativeTypeName("CHAR [260]")]
    public fixed sbyte DigitalSigner[260];

    [NativeTypeName("CHAR [260]")]
    public fixed sbyte DigitalSignerVersion[260];

    [NativeTypeName("DWORD")]
    public uint SignerScore;
}
