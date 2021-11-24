// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct CRYPT_3DES_KEY_STATE
{
    [NativeTypeName("unsigned char [24]")]
    public fixed byte Key[24];

    [NativeTypeName("unsigned char [8]")]
    public fixed byte IV[8];

    [NativeTypeName("unsigned char [8]")]
    public fixed byte Feedback[8];
}
