// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct BYTE_BLOB
{
    [NativeTypeName("ULONG")]
    public uint clSize;

    [NativeTypeName("byte [1]")]
    public fixed byte abData[1];
}
