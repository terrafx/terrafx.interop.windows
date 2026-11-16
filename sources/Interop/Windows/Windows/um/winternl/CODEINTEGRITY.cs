// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CODEINTEGRITY
{
    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_ENABLED"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_ENABLED 0x01")]
    public const int CODEINTEGRITY_OPTION_ENABLED = 0x01;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_TESTSIGN"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_TESTSIGN 0x02")]
    public const int CODEINTEGRITY_OPTION_TESTSIGN = 0x02;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_UMCI_ENABLED"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_UMCI_ENABLED 0x04")]
    public const int CODEINTEGRITY_OPTION_UMCI_ENABLED = 0x04;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_UMCI_AUDITMODE_ENABLED"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_UMCI_AUDITMODE_ENABLED 0x08")]
    public const int CODEINTEGRITY_OPTION_UMCI_AUDITMODE_ENABLED = 0x08;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_UMCI_EXCLUSIONPATHS_ENABLED"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_UMCI_EXCLUSIONPATHS_ENABLED 0x10")]
    public const int CODEINTEGRITY_OPTION_UMCI_EXCLUSIONPATHS_ENABLED = 0x10;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_TEST_BUILD"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_TEST_BUILD 0x20")]
    public const int CODEINTEGRITY_OPTION_TEST_BUILD = 0x20;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_PREPRODUCTION_BUILD"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_PREPRODUCTION_BUILD 0x40")]
    public const int CODEINTEGRITY_OPTION_PREPRODUCTION_BUILD = 0x40;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_DEBUGMODE_ENABLED"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_DEBUGMODE_ENABLED 0x80")]
    public const int CODEINTEGRITY_OPTION_DEBUGMODE_ENABLED = 0x80;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_FLIGHT_BUILD"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_FLIGHT_BUILD 0x100")]
    public const int CODEINTEGRITY_OPTION_FLIGHT_BUILD = 0x100;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_FLIGHTING_ENABLED"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_FLIGHTING_ENABLED 0x200")]
    public const int CODEINTEGRITY_OPTION_FLIGHTING_ENABLED = 0x200;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_HVCI_KMCI_ENABLED"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_HVCI_KMCI_ENABLED 0x400")]
    public const int CODEINTEGRITY_OPTION_HVCI_KMCI_ENABLED = 0x400;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_HVCI_KMCI_AUDITMODE_ENABLED"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_HVCI_KMCI_AUDITMODE_ENABLED 0x800")]
    public const int CODEINTEGRITY_OPTION_HVCI_KMCI_AUDITMODE_ENABLED = 0x800;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_HVCI_KMCI_STRICTMODE_ENABLED"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_HVCI_KMCI_STRICTMODE_ENABLED 0x1000")]
    public const int CODEINTEGRITY_OPTION_HVCI_KMCI_STRICTMODE_ENABLED = 0x1000;

    /// <include file='CODEINTEGRITY.xml' path='doc/member[@name="CODEINTEGRITY.CODEINTEGRITY_OPTION_HVCI_IUM_ENABLED"]/*' />
    [NativeTypeName("#define CODEINTEGRITY_OPTION_HVCI_IUM_ENABLED 0x2000")]
    public const int CODEINTEGRITY_OPTION_HVCI_IUM_ENABLED = 0x2000;
}
