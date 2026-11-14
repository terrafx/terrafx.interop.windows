// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ICM
{
    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_ADDPROFILE"]/*' />
    [NativeTypeName("#define ICM_ADDPROFILE 1")]
    public const int ICM_ADDPROFILE = 1;

    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_DELETEPROFILE"]/*' />
    [NativeTypeName("#define ICM_DELETEPROFILE 2")]
    public const int ICM_DELETEPROFILE = 2;

    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_QUERYPROFILE"]/*' />
    [NativeTypeName("#define ICM_QUERYPROFILE 3")]
    public const int ICM_QUERYPROFILE = 3;

    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_SETDEFAULTPROFILE"]/*' />
    [NativeTypeName("#define ICM_SETDEFAULTPROFILE 4")]
    public const int ICM_SETDEFAULTPROFILE = 4;

    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_REGISTERICMATCHER"]/*' />
    [NativeTypeName("#define ICM_REGISTERICMATCHER 5")]
    public const int ICM_REGISTERICMATCHER = 5;

    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_UNREGISTERICMATCHER"]/*' />
    [NativeTypeName("#define ICM_UNREGISTERICMATCHER 6")]
    public const int ICM_UNREGISTERICMATCHER = 6;

    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_QUERYMATCH"]/*' />
    [NativeTypeName("#define ICM_QUERYMATCH 7")]
    public const int ICM_QUERYMATCH = 7;

    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_OFF"]/*' />
    [NativeTypeName("#define ICM_OFF 1")]
    public const int ICM_OFF = 1;

    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_ON"]/*' />
    [NativeTypeName("#define ICM_ON 2")]
    public const int ICM_ON = 2;

    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_QUERY"]/*' />
    [NativeTypeName("#define ICM_QUERY 3")]
    public const int ICM_QUERY = 3;

    /// <include file='ICM.xml' path='doc/member[@name="ICM.ICM_DONE_OUTSIDEDC"]/*' />
    [NativeTypeName("#define ICM_DONE_OUTSIDEDC 4")]
    public const int ICM_DONE_OUTSIDEDC = 4;
}
