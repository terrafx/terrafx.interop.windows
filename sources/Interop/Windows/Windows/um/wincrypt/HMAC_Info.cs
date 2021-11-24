// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct HMAC_INFO
{
    [NativeTypeName("ALG_ID")]
    public uint HashAlgid;

    public byte* pbInnerString;

    [NativeTypeName("DWORD")]
    public uint cbInnerString;

    public byte* pbOuterString;

    [NativeTypeName("DWORD")]
    public uint cbOuterString;
}
