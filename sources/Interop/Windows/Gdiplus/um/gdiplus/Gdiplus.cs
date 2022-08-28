// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplus.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

public static partial class Gdiplus
{
    [NativeTypeName("#define GDIPVER 0x0100")]
    public const int GDIPVER = 0x0100;
}
