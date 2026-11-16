// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SFVM
{
    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_REARRANGE"]/*' />
    [NativeTypeName("#define SFVM_REARRANGE 0x00000001")]
    public const int SFVM_REARRANGE = 0x00000001;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_ADDOBJECT"]/*' />
    [NativeTypeName("#define SFVM_ADDOBJECT 0x00000003")]
    public const int SFVM_ADDOBJECT = 0x00000003;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_REMOVEOBJECT"]/*' />
    [NativeTypeName("#define SFVM_REMOVEOBJECT 0x00000006")]
    public const int SFVM_REMOVEOBJECT = 0x00000006;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_UPDATEOBJECT"]/*' />
    [NativeTypeName("#define SFVM_UPDATEOBJECT 0x00000007")]
    public const int SFVM_UPDATEOBJECT = 0x00000007;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETSELECTEDOBJECTS"]/*' />
    [NativeTypeName("#define SFVM_GETSELECTEDOBJECTS 0x00000009")]
    public const int SFVM_GETSELECTEDOBJECTS = 0x00000009;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_SETITEMPOS"]/*' />
    [NativeTypeName("#define SFVM_SETITEMPOS 0x0000000e")]
    public const int SFVM_SETITEMPOS = 0x0000000e;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_SETCLIPBOARD"]/*' />
    [NativeTypeName("#define SFVM_SETCLIPBOARD 0x00000010")]
    public const int SFVM_SETCLIPBOARD = 0x00000010;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_SETPOINTS"]/*' />
    [NativeTypeName("#define SFVM_SETPOINTS 0x00000017")]
    public const int SFVM_SETPOINTS = 0x00000017;
}
