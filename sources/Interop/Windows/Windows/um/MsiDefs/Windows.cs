// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows._WIN32_MSI"]/*' />
    [NativeTypeName("#define _WIN32_MSI 500")]
    public const int _WIN32_MSI = 500;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IACTIONNAME_INSTALL"]/*' />
    [NativeTypeName("#define IACTIONNAME_INSTALL TEXT(\"INSTALL\")")]
    public const string IACTIONNAME_INSTALL = "INSTALL";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IACTIONNAME_ADVERTISE"]/*' />
    [NativeTypeName("#define IACTIONNAME_ADVERTISE TEXT(\"ADVERTISE\")")]
    public const string IACTIONNAME_ADVERTISE = "ADVERTISE";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IACTIONNAME_ADMIN"]/*' />
    [NativeTypeName("#define IACTIONNAME_ADMIN TEXT(\"ADMIN\")")]
    public const string IACTIONNAME_ADMIN = "ADMIN";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IACTIONNAME_SEQUENCE"]/*' />
    [NativeTypeName("#define IACTIONNAME_SEQUENCE TEXT(\"SEQUENCE\")")]
    public const string IACTIONNAME_SEQUENCE = "SEQUENCE";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IACTIONNAME_COLLECTUSERINFO"]/*' />
    [NativeTypeName("#define IACTIONNAME_COLLECTUSERINFO TEXT(\"CollectUserInfo\")")]
    public const string IACTIONNAME_COLLECTUSERINFO = "CollectUserInfo";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IACTIONNAME_FIRSTRUN"]/*' />
    [NativeTypeName("#define IACTIONNAME_FIRSTRUN TEXT(\"FirstRun\")")]
    public const string IACTIONNAME_FIRSTRUN = "FirstRun";
}
