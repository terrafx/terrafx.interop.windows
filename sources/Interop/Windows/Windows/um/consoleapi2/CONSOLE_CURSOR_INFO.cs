// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct CONSOLE_CURSOR_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    public BOOL bVisible;
}
