// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct SPC_INDIRECT_DATA_CONTENT
{
    public CRYPT_ATTRIBUTE_TYPE_VALUE Data;

    public CRYPT_ALGORITHM_IDENTIFIER DigestAlgorithm;

    [NativeTypeName("CRYPT_HASH_BLOB")]
    public CRYPT_DATA_BLOB Digest;
}
