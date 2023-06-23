// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CDN
{
    [NativeTypeName("#define CDN_FIRST (0U-601U)")]
    public const uint CDN_FIRST = unchecked(0U - 601U);

    [NativeTypeName("#define CDN_LAST (0U-699U)")]
    public const uint CDN_LAST = unchecked(0U - 699U);
}
