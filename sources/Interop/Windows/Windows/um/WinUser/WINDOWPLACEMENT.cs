// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct WINDOWPLACEMENT
{
    public uint length;

    public uint flags;

    public uint showCmd;

    public POINT ptMinPosition;

    public POINT ptMaxPosition;

    public RECT rcNormalPosition;
}
