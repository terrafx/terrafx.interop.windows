// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ScrnSave.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IDS_DESCRIPTION"]/*' />
    [NativeTypeName("#define IDS_DESCRIPTION 1")]
    public const int IDS_DESCRIPTION = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLG_SCRNSAVECONFIGURE"]/*' />
    [NativeTypeName("#define DLG_SCRNSAVECONFIGURE 2003")]
    public const int DLG_SCRNSAVECONFIGURE = 2003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsIsPassword"]/*' />
    [NativeTypeName("#define idsIsPassword 1000")]
    public const int idsIsPassword = 1000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsIniFile"]/*' />
    [NativeTypeName("#define idsIniFile 1001")]
    public const int idsIniFile = 1001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsScreenSaver"]/*' />
    [NativeTypeName("#define idsScreenSaver 1002")]
    public const int idsScreenSaver = 1002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsPassword"]/*' />
    [NativeTypeName("#define idsPassword 1003")]
    public const int idsPassword = 1003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsDifferentPW"]/*' />
    [NativeTypeName("#define idsDifferentPW 1004")]
    public const int idsDifferentPW = 1004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsChangePW"]/*' />
    [NativeTypeName("#define idsChangePW 1005")]
    public const int idsChangePW = 1005;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsBadOldPW"]/*' />
    [NativeTypeName("#define idsBadOldPW 1006")]
    public const int idsBadOldPW = 1006;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsAppName"]/*' />
    [NativeTypeName("#define idsAppName 1007")]
    public const int idsAppName = 1007;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsNoHelpMemory"]/*' />
    [NativeTypeName("#define idsNoHelpMemory 1008")]
    public const int idsNoHelpMemory = 1008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsHelpFile"]/*' />
    [NativeTypeName("#define idsHelpFile 1009")]
    public const int idsHelpFile = 1009;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.idsDefKeyword"]/*' />
    [NativeTypeName("#define idsDefKeyword 1010")]
    public const int idsDefKeyword = 1010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXFILELEN"]/*' />
    [NativeTypeName("#define MAXFILELEN 13")]
    public const int MAXFILELEN = 13;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TITLEBARNAMELEN"]/*' />
    [NativeTypeName("#define TITLEBARNAMELEN 40")]
    public const int TITLEBARNAMELEN = 40;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPNAMEBUFFERLEN"]/*' />
    [NativeTypeName("#define APPNAMEBUFFERLEN 40")]
    public const int APPNAMEBUFFERLEN = 40;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BUFFLEN"]/*' />
    [NativeTypeName("#define BUFFLEN 255")]
    public const int BUFFLEN = 255;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SCRM_VERIFYPW"]/*' />
    [NativeTypeName("#define SCRM_VERIFYPW WM_APP")]
    public const int SCRM_VERIFYPW = 0x8000;
}
