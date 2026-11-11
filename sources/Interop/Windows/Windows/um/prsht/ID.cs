// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ID
{
    /// <include file='ID.xml' path='doc/member[@name="ID.ID_PSRESTARTWINDOWS"]/*' />
    [NativeTypeName("#define ID_PSRESTARTWINDOWS 0x2")]
    public const int ID_PSRESTARTWINDOWS = 0x2;

    /// <include file='ID.xml' path='doc/member[@name="ID.ID_PSREBOOTSYSTEM"]/*' />
    [NativeTypeName("#define ID_PSREBOOTSYSTEM (ID_PSRESTARTWINDOWS | 0x1)")]
    public const int ID_PSREBOOTSYSTEM = (0x2 | 0x1);
}
