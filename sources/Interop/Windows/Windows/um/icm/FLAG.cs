// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FLAG
{
    /// <include file='FLAG.xml' path='doc/member[@name="FLAG.FLAG_EMBEDDEDPROFILE"]/*' />
    [NativeTypeName("#define FLAG_EMBEDDEDPROFILE 0x00000001")]
    public const int FLAG_EMBEDDEDPROFILE = 0x00000001;

    /// <include file='FLAG.xml' path='doc/member[@name="FLAG.FLAG_DEPENDENTONDATA"]/*' />
    [NativeTypeName("#define FLAG_DEPENDENTONDATA 0x00000002")]
    public const int FLAG_DEPENDENTONDATA = 0x00000002;

    /// <include file='FLAG.xml' path='doc/member[@name="FLAG.FLAG_ENABLE_CHROMATIC_ADAPTATION"]/*' />
    [NativeTypeName("#define FLAG_ENABLE_CHROMATIC_ADAPTATION 0x02000000")]
    public const int FLAG_ENABLE_CHROMATIC_ADAPTATION = 0x02000000;
}
