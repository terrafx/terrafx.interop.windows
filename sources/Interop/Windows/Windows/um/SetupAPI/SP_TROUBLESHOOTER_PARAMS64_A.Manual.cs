// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_TROUBLESHOOTER_PARAMS64_A
{
    public SP_CLASSINSTALL_HEADER64 ClassInstallHeader;

    [NativeTypeName("CHAR [260]")]
    public fixed sbyte ChmFile[260];

    [NativeTypeName("CHAR [260]")]
    public fixed sbyte HtmlTroubleShooter[260];
}
