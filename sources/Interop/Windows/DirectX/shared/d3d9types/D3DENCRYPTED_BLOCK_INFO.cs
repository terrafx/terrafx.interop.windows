// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DENCRYPTED_BLOCK_INFO.xml' path='doc/member[@name="D3DENCRYPTED_BLOCK_INFO"]/*' />
public partial struct D3DENCRYPTED_BLOCK_INFO
{
    /// <include file='D3DENCRYPTED_BLOCK_INFO.xml' path='doc/member[@name="D3DENCRYPTED_BLOCK_INFO.NumEncryptedBytesAtBeginning"]/*' />
    public uint NumEncryptedBytesAtBeginning;

    /// <include file='D3DENCRYPTED_BLOCK_INFO.xml' path='doc/member[@name="D3DENCRYPTED_BLOCK_INFO.NumBytesInSkipPattern"]/*' />
    public uint NumBytesInSkipPattern;

    /// <include file='D3DENCRYPTED_BLOCK_INFO.xml' path='doc/member[@name="D3DENCRYPTED_BLOCK_INFO.NumBytesInEncryptPattern"]/*' />
    public uint NumBytesInEncryptPattern;
}
