// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMAPI_SECTOR_SIZE"]/*' />
    [NativeTypeName("#define IMAPI_SECTOR_SIZE ( 2048 )")]
    public const int IMAPI_SECTOR_SIZE = (2048);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMAPI2_DEFAULT_COMMAND_TIMEOUT"]/*' />
    [NativeTypeName("#define IMAPI2_DEFAULT_COMMAND_TIMEOUT 10")]
    public const int IMAPI2_DEFAULT_COMMAND_TIMEOUT = 10;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMAPI_SECTORS_PER_SECOND_AT_1X_CD"]/*' />
    [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_CD 75")]
    public const int IMAPI_SECTORS_PER_SECOND_AT_1X_CD = 75;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMAPI_SECTORS_PER_SECOND_AT_1X_DVD"]/*' />
    [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_DVD 680")]
    public const int IMAPI_SECTORS_PER_SECOND_AT_1X_DVD = 680;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMAPI_SECTORS_PER_SECOND_AT_1X_BD"]/*' />
    [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_BD 2195")]
    public const int IMAPI_SECTORS_PER_SECOND_AT_1X_BD = 2195;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMAPI_SECTORS_PER_SECOND_AT_1X_HD_DVD"]/*' />
    [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_HD_DVD 4568")]
    public const int IMAPI_SECTORS_PER_SECOND_AT_1X_HD_DVD = 4568;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMAPILib2_MajorVersion"]/*' />
    [NativeTypeName("#define IMAPILib2_MajorVersion 1")]
    public const int IMAPILib2_MajorVersion = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMAPILib2_MinorVersion"]/*' />
    [NativeTypeName("#define IMAPILib2_MinorVersion 0")]
    public const int IMAPILib2_MinorVersion = 0;
}
