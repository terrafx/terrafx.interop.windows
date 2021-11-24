// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SID
{
    public byte Revision;

    public byte SubAuthorityCount;

    public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;

    [NativeTypeName("DWORD [1]")]
    public fixed uint SubAuthority[1];

    [NativeTypeName("#define SID_REVISION (1)")]
    public const int SID_REVISION = (1);

    [NativeTypeName("#define SID_MAX_SUB_AUTHORITIES (15)")]
    public const int SID_MAX_SUB_AUTHORITIES = (15);

    [NativeTypeName("#define SID_RECOMMENDED_SUB_AUTHORITIES (1)")]
    public const int SID_RECOMMENDED_SUB_AUTHORITIES = (1);

    [NativeTypeName("#define SID_HASH_SIZE 32")]
    public const int SID_HASH_SIZE = 32;
}
