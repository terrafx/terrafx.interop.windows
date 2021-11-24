// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct IMECHARPOSITION
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwCharPos;

    public POINT pt;

    public uint cLineHeight;

    public RECT rcDocument;
}
