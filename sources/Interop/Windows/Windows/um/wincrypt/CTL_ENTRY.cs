// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct CTL_ENTRY
{
    public CRYPT_DATA_BLOB SubjectIdentifier;

    [NativeTypeName("DWORD")]
    public uint cAttribute;

    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgAttribute;
}
