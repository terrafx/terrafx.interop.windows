// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RIDEV
{
    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_REMOVE"]/*' />
    [NativeTypeName("#define RIDEV_REMOVE 0x00000001")]
    public const int RIDEV_REMOVE = 0x00000001;

    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_EXCLUDE"]/*' />
    [NativeTypeName("#define RIDEV_EXCLUDE 0x00000010")]
    public const int RIDEV_EXCLUDE = 0x00000010;

    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_PAGEONLY"]/*' />
    [NativeTypeName("#define RIDEV_PAGEONLY 0x00000020")]
    public const int RIDEV_PAGEONLY = 0x00000020;

    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_NOLEGACY"]/*' />
    [NativeTypeName("#define RIDEV_NOLEGACY 0x00000030")]
    public const int RIDEV_NOLEGACY = 0x00000030;

    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_INPUTSINK"]/*' />
    [NativeTypeName("#define RIDEV_INPUTSINK 0x00000100")]
    public const int RIDEV_INPUTSINK = 0x00000100;

    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_CAPTUREMOUSE"]/*' />
    [NativeTypeName("#define RIDEV_CAPTUREMOUSE 0x00000200")]
    public const int RIDEV_CAPTUREMOUSE = 0x00000200;

    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_NOHOTKEYS"]/*' />
    [NativeTypeName("#define RIDEV_NOHOTKEYS 0x00000200")]
    public const int RIDEV_NOHOTKEYS = 0x00000200;

    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_APPKEYS"]/*' />
    [NativeTypeName("#define RIDEV_APPKEYS 0x00000400")]
    public const int RIDEV_APPKEYS = 0x00000400;

    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_EXINPUTSINK"]/*' />
    [NativeTypeName("#define RIDEV_EXINPUTSINK 0x00001000")]
    public const int RIDEV_EXINPUTSINK = 0x00001000;

    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_DEVNOTIFY"]/*' />
    [NativeTypeName("#define RIDEV_DEVNOTIFY 0x00002000")]
    public const int RIDEV_DEVNOTIFY = 0x00002000;

    /// <include file='RIDEV.xml' path='doc/member[@name="RIDEV.RIDEV_EXMODEMASK"]/*' />
    [NativeTypeName("#define RIDEV_EXMODEMASK 0x000000F0")]
    public const int RIDEV_EXMODEMASK = 0x000000F0;
}
