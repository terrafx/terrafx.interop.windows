// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public unsafe partial struct CERT_STRONG_SIGN_SERIALIZED_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("LPWSTR")]
    public ushort* pwszCNGSignHashAlgids;

    [NativeTypeName("LPWSTR")]
    public ushort* pwszCNGPubKeyMinBitLengths;
}
