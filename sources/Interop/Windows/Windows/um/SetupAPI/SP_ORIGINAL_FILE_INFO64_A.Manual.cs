// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_ORIGINAL_FILE_INFO64_A
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("CHAR [260]")]
    public fixed sbyte OriginalInfName[260];

    [NativeTypeName("CHAR [260]")]
    public fixed sbyte OriginalCatalogName[260];
}
