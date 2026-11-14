// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class ACCESS
{
    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_SYSTEM_SECURITY"]/*' />
    [NativeTypeName("#define ACCESS_SYSTEM_SECURITY (0x01000000L)")]
    public const int ACCESS_SYSTEM_SECURITY = (0x01000000);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_MIN_MS_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_MIN_MS_ACE_TYPE (0x0)")]
    public const int ACCESS_MIN_MS_ACE_TYPE = (0x0);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_ALLOWED_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_ALLOWED_ACE_TYPE (0x0)")]
    public const int ACCESS_ALLOWED_ACE_TYPE = (0x0);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_DENIED_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_DENIED_ACE_TYPE (0x1)")]
    public const int ACCESS_DENIED_ACE_TYPE = (0x1);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_MAX_MS_V2_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_MAX_MS_V2_ACE_TYPE (0x3)")]
    public const int ACCESS_MAX_MS_V2_ACE_TYPE = (0x3);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_ALLOWED_COMPOUND_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_ALLOWED_COMPOUND_ACE_TYPE (0x4)")]
    public const int ACCESS_ALLOWED_COMPOUND_ACE_TYPE = (0x4);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_MAX_MS_V3_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_MAX_MS_V3_ACE_TYPE (0x4)")]
    public const int ACCESS_MAX_MS_V3_ACE_TYPE = (0x4);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_MIN_MS_OBJECT_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_MIN_MS_OBJECT_ACE_TYPE (0x5)")]
    public const int ACCESS_MIN_MS_OBJECT_ACE_TYPE = (0x5);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_ALLOWED_OBJECT_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_ALLOWED_OBJECT_ACE_TYPE (0x5)")]
    public const int ACCESS_ALLOWED_OBJECT_ACE_TYPE = (0x5);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_DENIED_OBJECT_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_DENIED_OBJECT_ACE_TYPE (0x6)")]
    public const int ACCESS_DENIED_OBJECT_ACE_TYPE = (0x6);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_MAX_MS_OBJECT_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_MAX_MS_OBJECT_ACE_TYPE (0x8)")]
    public const int ACCESS_MAX_MS_OBJECT_ACE_TYPE = (0x8);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_MAX_MS_V4_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_MAX_MS_V4_ACE_TYPE (0x8)")]
    public const int ACCESS_MAX_MS_V4_ACE_TYPE = (0x8);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_MAX_MS_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_MAX_MS_ACE_TYPE (0x8)")]
    public const int ACCESS_MAX_MS_ACE_TYPE = (0x8);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_ALLOWED_CALLBACK_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_ALLOWED_CALLBACK_ACE_TYPE (0x9)")]
    public const int ACCESS_ALLOWED_CALLBACK_ACE_TYPE = (0x9);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_DENIED_CALLBACK_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_DENIED_CALLBACK_ACE_TYPE (0xA)")]
    public const int ACCESS_DENIED_CALLBACK_ACE_TYPE = (0xA);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE (0xB)")]
    public const int ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE = (0xB);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE (0xC)")]
    public const int ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE = (0xC);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_MAX_MS_V5_ACE_TYPE"]/*' />
    [NativeTypeName("#define ACCESS_MAX_MS_V5_ACE_TYPE (0x17)")]
    public const int ACCESS_MAX_MS_V5_ACE_TYPE = (0x17);

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_OBJECT_GUID"]/*' />
    [NativeTypeName("#define ACCESS_OBJECT_GUID 0")]
    public const int ACCESS_OBJECT_GUID = 0;

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_PROPERTY_SET_GUID"]/*' />
    [NativeTypeName("#define ACCESS_PROPERTY_SET_GUID 1")]
    public const int ACCESS_PROPERTY_SET_GUID = 1;

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_PROPERTY_GUID"]/*' />
    [NativeTypeName("#define ACCESS_PROPERTY_GUID 2")]
    public const int ACCESS_PROPERTY_GUID = 2;

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_MAX_LEVEL"]/*' />
    [NativeTypeName("#define ACCESS_MAX_LEVEL 4")]
    public const int ACCESS_MAX_LEVEL = 4;

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_DS_SOURCE_A"]/*' />
    [NativeTypeName("#define ACCESS_DS_SOURCE_A \"DS\"")]
    public static ReadOnlySpan<byte> ACCESS_DS_SOURCE_A => "DS"u8;

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_DS_SOURCE_W"]/*' />
    [NativeTypeName("#define ACCESS_DS_SOURCE_W L\"DS\"")]
    public const string ACCESS_DS_SOURCE_W = "DS";

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_DS_OBJECT_TYPE_NAME_A"]/*' />
    [NativeTypeName("#define ACCESS_DS_OBJECT_TYPE_NAME_A \"Directory Service Object\"")]
    public static ReadOnlySpan<byte> ACCESS_DS_OBJECT_TYPE_NAME_A => "Directory Service Object"u8;

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_DS_OBJECT_TYPE_NAME_W"]/*' />
    [NativeTypeName("#define ACCESS_DS_OBJECT_TYPE_NAME_W L\"Directory Service Object\"")]
    public const string ACCESS_DS_OBJECT_TYPE_NAME_W = "Directory Service Object";

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_REASON_TYPE_MASK"]/*' />
    [NativeTypeName("#define ACCESS_REASON_TYPE_MASK 0x00ff0000")]
    public const int ACCESS_REASON_TYPE_MASK = 0x00ff0000;

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_REASON_DATA_MASK"]/*' />
    [NativeTypeName("#define ACCESS_REASON_DATA_MASK 0x0000ffff")]
    public const int ACCESS_REASON_DATA_MASK = 0x0000ffff;

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_REASON_STAGING_MASK"]/*' />
    [NativeTypeName("#define ACCESS_REASON_STAGING_MASK 0x80000000")]
    public const uint ACCESS_REASON_STAGING_MASK = 0x80000000;

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_REASON_EXDATA_MASK"]/*' />
    [NativeTypeName("#define ACCESS_REASON_EXDATA_MASK 0x7f000000")]
    public const int ACCESS_REASON_EXDATA_MASK = 0x7f000000;

    /// <include file='ACCESS.xml' path='doc/member[@name="ACCESS.ACCESS_FILTER_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define ACCESS_FILTER_SECURITY_INFORMATION (0x00000100L)")]
    public const int ACCESS_FILTER_SECURITY_INFORMATION = (0x00000100);
}
