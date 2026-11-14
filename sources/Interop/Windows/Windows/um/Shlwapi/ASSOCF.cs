// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ASSOCF
{
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_NONE"]/*' />
    public const int ASSOCF_NONE = 0x00000000;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_INIT_NOREMAPCLSID"]/*' />
    public const int ASSOCF_INIT_NOREMAPCLSID = 0x00000001;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_INIT_BYEXENAME"]/*' />
    public const int ASSOCF_INIT_BYEXENAME = 0x00000002;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_OPEN_BYEXENAME"]/*' />
    public const int ASSOCF_OPEN_BYEXENAME = 0x00000002;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_INIT_DEFAULTTOSTAR"]/*' />
    public const int ASSOCF_INIT_DEFAULTTOSTAR = 0x00000004;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_INIT_DEFAULTTOFOLDER"]/*' />
    public const int ASSOCF_INIT_DEFAULTTOFOLDER = 0x00000008;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_NOUSERSETTINGS"]/*' />
    public const int ASSOCF_NOUSERSETTINGS = 0x00000010;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_NOTRUNCATE"]/*' />
    public const int ASSOCF_NOTRUNCATE = 0x00000020;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_VERIFY"]/*' />
    public const int ASSOCF_VERIFY = 0x00000040;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_REMAPRUNDLL"]/*' />
    public const int ASSOCF_REMAPRUNDLL = 0x00000080;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_NOFIXUPS"]/*' />
    public const int ASSOCF_NOFIXUPS = 0x00000100;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_IGNOREBASECLASS"]/*' />
    public const int ASSOCF_IGNOREBASECLASS = 0x00000200;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_INIT_IGNOREUNKNOWN"]/*' />
    public const int ASSOCF_INIT_IGNOREUNKNOWN = 0x00000400;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_INIT_FIXED_PROGID"]/*' />
    public const int ASSOCF_INIT_FIXED_PROGID = 0x00000800;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_IS_PROTOCOL"]/*' />
    public const int ASSOCF_IS_PROTOCOL = 0x00001000;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_INIT_FOR_FILE"]/*' />
    public const int ASSOCF_INIT_FOR_FILE = 0x00002000;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_IS_FULL_URI"]/*' />
    public const int ASSOCF_IS_FULL_URI = 0x00004000;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_PER_MACHINE_ONLY"]/*' />
    public const int ASSOCF_PER_MACHINE_ONLY = 0x00008000;
    /// <include file='ASSOCF.xml' path='doc/member[@name="ASSOCF.ASSOCF_APP_TO_APP"]/*' />
    public const int ASSOCF_APP_TO_APP = 0x00010000;
}
