// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WIA
{
    /// <include file='WIA.xml' path='doc/member[@name="WIA.WIA_INCOMPAT_XP"]/*' />
    [NativeTypeName("#define WIA_INCOMPAT_XP 0x00000001")]
    public const int WIA_INCOMPAT_XP = 0x00000001;
}
