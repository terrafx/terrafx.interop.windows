// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SCH_CRED_PUBLIC_CERTCHAIN
{
    [NativeTypeName("DWORD")]
    public uint dwType;

    [NativeTypeName("DWORD")]
    public uint cbCertChain;

    [NativeTypeName("PBYTE")]
    public byte* pCertChain;
}
