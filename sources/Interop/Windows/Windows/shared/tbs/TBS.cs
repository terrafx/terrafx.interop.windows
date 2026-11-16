// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TBS
{
    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_CONTEXT_VERSION_ONE"]/*' />
    [NativeTypeName("#define TBS_CONTEXT_VERSION_ONE 1")]
    public const int TBS_CONTEXT_VERSION_ONE = 1;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_COMMAND_PRIORITY_LOW"]/*' />
    [NativeTypeName("#define TBS_COMMAND_PRIORITY_LOW 100")]
    public const int TBS_COMMAND_PRIORITY_LOW = 100;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_COMMAND_PRIORITY_NORMAL"]/*' />
    [NativeTypeName("#define TBS_COMMAND_PRIORITY_NORMAL 200")]
    public const int TBS_COMMAND_PRIORITY_NORMAL = 200;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_COMMAND_PRIORITY_HIGH"]/*' />
    [NativeTypeName("#define TBS_COMMAND_PRIORITY_HIGH 300")]
    public const int TBS_COMMAND_PRIORITY_HIGH = 300;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_COMMAND_PRIORITY_SYSTEM"]/*' />
    [NativeTypeName("#define TBS_COMMAND_PRIORITY_SYSTEM 400")]
    public const int TBS_COMMAND_PRIORITY_SYSTEM = 400;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_COMMAND_PRIORITY_MAX"]/*' />
    [NativeTypeName("#define TBS_COMMAND_PRIORITY_MAX 0x80000000")]
    public const uint TBS_COMMAND_PRIORITY_MAX = 0x80000000;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_COMMAND_LOCALITY_ZERO"]/*' />
    [NativeTypeName("#define TBS_COMMAND_LOCALITY_ZERO 0")]
    public const int TBS_COMMAND_LOCALITY_ZERO = 0;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_COMMAND_LOCALITY_ONE"]/*' />
    [NativeTypeName("#define TBS_COMMAND_LOCALITY_ONE 1")]
    public const int TBS_COMMAND_LOCALITY_ONE = 1;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_COMMAND_LOCALITY_TWO"]/*' />
    [NativeTypeName("#define TBS_COMMAND_LOCALITY_TWO 2")]
    public const int TBS_COMMAND_LOCALITY_TWO = 2;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_COMMAND_LOCALITY_THREE"]/*' />
    [NativeTypeName("#define TBS_COMMAND_LOCALITY_THREE 3")]
    public const int TBS_COMMAND_LOCALITY_THREE = 3;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_COMMAND_LOCALITY_FOUR"]/*' />
    [NativeTypeName("#define TBS_COMMAND_LOCALITY_FOUR 4")]
    public const int TBS_COMMAND_LOCALITY_FOUR = 4;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_SUCCESS"]/*' />
    [NativeTypeName("#define TBS_SUCCESS 0")]
    public const int TBS_SUCCESS = 0;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_IN_OUT_BUF_SIZE_MAX"]/*' />
    [NativeTypeName("#define TBS_IN_OUT_BUF_SIZE_MAX (256*1024)")]
    public const int TBS_IN_OUT_BUF_SIZE_MAX = (256 * 1024);

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_OWNERAUTH_TYPE_FULL"]/*' />
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_FULL 1")]
    public const int TBS_OWNERAUTH_TYPE_FULL = 1;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_OWNERAUTH_TYPE_ADMIN"]/*' />
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_ADMIN 2")]
    public const int TBS_OWNERAUTH_TYPE_ADMIN = 2;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_OWNERAUTH_TYPE_USER"]/*' />
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_USER 3")]
    public const int TBS_OWNERAUTH_TYPE_USER = 3;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_OWNERAUTH_TYPE_ENDORSEMENT"]/*' />
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_ENDORSEMENT 4")]
    public const int TBS_OWNERAUTH_TYPE_ENDORSEMENT = 4;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_OWNERAUTH_TYPE_ENDORSEMENT_20"]/*' />
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_ENDORSEMENT_20 12")]
    public const int TBS_OWNERAUTH_TYPE_ENDORSEMENT_20 = 12;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_OWNERAUTH_TYPE_STORAGE_20"]/*' />
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_STORAGE_20 13")]
    public const int TBS_OWNERAUTH_TYPE_STORAGE_20 = 13;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_CONTEXT_VERSION_TWO"]/*' />
    [NativeTypeName("#define TBS_CONTEXT_VERSION_TWO 2")]
    public const int TBS_CONTEXT_VERSION_TWO = 2;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_TCGLOG_SRTM_CURRENT"]/*' />
    [NativeTypeName("#define TBS_TCGLOG_SRTM_CURRENT 0")]
    public const int TBS_TCGLOG_SRTM_CURRENT = 0;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_TCGLOG_DRTM_CURRENT"]/*' />
    [NativeTypeName("#define TBS_TCGLOG_DRTM_CURRENT 1")]
    public const int TBS_TCGLOG_DRTM_CURRENT = 1;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_TCGLOG_SRTM_BOOT"]/*' />
    [NativeTypeName("#define TBS_TCGLOG_SRTM_BOOT 2")]
    public const int TBS_TCGLOG_SRTM_BOOT = 2;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_TCGLOG_SRTM_RESUME"]/*' />
    [NativeTypeName("#define TBS_TCGLOG_SRTM_RESUME 3")]
    public const int TBS_TCGLOG_SRTM_RESUME = 3;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_TCGLOG_DRTM_BOOT"]/*' />
    [NativeTypeName("#define TBS_TCGLOG_DRTM_BOOT 4")]
    public const int TBS_TCGLOG_DRTM_BOOT = 4;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_TCGLOG_DRTM_RESUME"]/*' />
    [NativeTypeName("#define TBS_TCGLOG_DRTM_RESUME 5")]
    public const int TBS_TCGLOG_DRTM_RESUME = 5;
}
