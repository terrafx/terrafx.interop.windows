// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_TROUBLESHOOTER_PARAMS64_W
{
    public SP_CLASSINSTALL_HEADER64 ClassInstallHeader;

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort ChmFile[260];

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort HtmlTroubleShooter[260];
}
