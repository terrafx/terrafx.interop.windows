// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PID
{
    /// <include file='PID.xml' path='doc/member[@name="PID.PID_FINDDATA"]/*' />
    [NativeTypeName("#define PID_FINDDATA 0")]
    public const int PID_FINDDATA = 0;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_NETRESOURCE"]/*' />
    [NativeTypeName("#define PID_NETRESOURCE 1")]
    public const int PID_NETRESOURCE = 1;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_DESCRIPTIONID"]/*' />
    [NativeTypeName("#define PID_DESCRIPTIONID 2")]
    public const int PID_DESCRIPTIONID = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_WHICHFOLDER"]/*' />
    [NativeTypeName("#define PID_WHICHFOLDER 3")]
    public const int PID_WHICHFOLDER = 3;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_NETWORKLOCATION"]/*' />
    [NativeTypeName("#define PID_NETWORKLOCATION 4")]
    public const int PID_NETWORKLOCATION = 4;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_COMPUTERNAME"]/*' />
    [NativeTypeName("#define PID_COMPUTERNAME 5")]
    public const int PID_COMPUTERNAME = 5;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_DISPLACED_FROM"]/*' />
    [NativeTypeName("#define PID_DISPLACED_FROM 2")]
    public const int PID_DISPLACED_FROM = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_DISPLACED_DATE"]/*' />
    [NativeTypeName("#define PID_DISPLACED_DATE 3")]
    public const int PID_DISPLACED_DATE = 3;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_SYNC_COPY_IN"]/*' />
    [NativeTypeName("#define PID_SYNC_COPY_IN 2")]
    public const int PID_SYNC_COPY_IN = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_MISC_STATUS"]/*' />
    [NativeTypeName("#define PID_MISC_STATUS 2")]
    public const int PID_MISC_STATUS = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_MISC_ACCESSCOUNT"]/*' />
    [NativeTypeName("#define PID_MISC_ACCESSCOUNT 3")]
    public const int PID_MISC_ACCESSCOUNT = 3;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_MISC_OWNER"]/*' />
    [NativeTypeName("#define PID_MISC_OWNER 4")]
    public const int PID_MISC_OWNER = 4;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_HTMLINFOTIPFILE"]/*' />
    [NativeTypeName("#define PID_HTMLINFOTIPFILE 5")]
    public const int PID_HTMLINFOTIPFILE = 5;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_MISC_PICS"]/*' />
    [NativeTypeName("#define PID_MISC_PICS 6")]
    public const int PID_MISC_PICS = 6;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_DISPLAY_PROPERTIES"]/*' />
    [NativeTypeName("#define PID_DISPLAY_PROPERTIES 0")]
    public const int PID_DISPLAY_PROPERTIES = 0;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTROTEXT"]/*' />
    [NativeTypeName("#define PID_INTROTEXT 1")]
    public const int PID_INTROTEXT = 1;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_CONTROLPANEL_CATEGORY"]/*' />
    [NativeTypeName("#define PID_CONTROLPANEL_CATEGORY 2")]
    public const int PID_CONTROLPANEL_CATEGORY = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_VOLUME_FREE"]/*' />
    [NativeTypeName("#define PID_VOLUME_FREE 2")]
    public const int PID_VOLUME_FREE = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_VOLUME_CAPACITY"]/*' />
    [NativeTypeName("#define PID_VOLUME_CAPACITY 3")]
    public const int PID_VOLUME_CAPACITY = 3;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_VOLUME_FILESYSTEM"]/*' />
    [NativeTypeName("#define PID_VOLUME_FILESYSTEM 4")]
    public const int PID_VOLUME_FILESYSTEM = 4;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_SHARE_CSC_STATUS"]/*' />
    [NativeTypeName("#define PID_SHARE_CSC_STATUS 2")]
    public const int PID_SHARE_CSC_STATUS = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_LINK_TARGET"]/*' />
    [NativeTypeName("#define PID_LINK_TARGET 2")]
    public const int PID_LINK_TARGET = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_LINK_TARGET_TYPE"]/*' />
    [NativeTypeName("#define PID_LINK_TARGET_TYPE 3")]
    public const int PID_LINK_TARGET_TYPE = 3;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_QUERY_RANK"]/*' />
    [NativeTypeName("#define PID_QUERY_RANK 2")]
    public const int PID_QUERY_RANK = 2;
}
