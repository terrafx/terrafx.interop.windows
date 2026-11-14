// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class AMMPEG2
{
    /// <include file='AMMPEG2.xml' path='doc/member[@name="AMMPEG2.AMMPEG2_DoPanScan"]/*' />
    [NativeTypeName("#define AMMPEG2_DoPanScan 0x00000001")]
    public const int AMMPEG2_DoPanScan = 0x00000001;

    /// <include file='AMMPEG2.xml' path='doc/member[@name="AMMPEG2.AMMPEG2_DVDLine21Field1"]/*' />
    [NativeTypeName("#define AMMPEG2_DVDLine21Field1 0x00000002")]
    public const int AMMPEG2_DVDLine21Field1 = 0x00000002;

    /// <include file='AMMPEG2.xml' path='doc/member[@name="AMMPEG2.AMMPEG2_DVDLine21Field2"]/*' />
    [NativeTypeName("#define AMMPEG2_DVDLine21Field2 0x00000004")]
    public const int AMMPEG2_DVDLine21Field2 = 0x00000004;

    /// <include file='AMMPEG2.xml' path='doc/member[@name="AMMPEG2.AMMPEG2_SourceIsLetterboxed"]/*' />
    [NativeTypeName("#define AMMPEG2_SourceIsLetterboxed 0x00000008")]
    public const int AMMPEG2_SourceIsLetterboxed = 0x00000008;

    /// <include file='AMMPEG2.xml' path='doc/member[@name="AMMPEG2.AMMPEG2_FilmCameraMode"]/*' />
    [NativeTypeName("#define AMMPEG2_FilmCameraMode 0x00000010")]
    public const int AMMPEG2_FilmCameraMode = 0x00000010;

    /// <include file='AMMPEG2.xml' path='doc/member[@name="AMMPEG2.AMMPEG2_LetterboxAnalogOut"]/*' />
    [NativeTypeName("#define AMMPEG2_LetterboxAnalogOut 0x00000020")]
    public const int AMMPEG2_LetterboxAnalogOut = 0x00000020;

    /// <include file='AMMPEG2.xml' path='doc/member[@name="AMMPEG2.AMMPEG2_DSS_UserData"]/*' />
    [NativeTypeName("#define AMMPEG2_DSS_UserData 0x00000040")]
    public const int AMMPEG2_DSS_UserData = 0x00000040;

    /// <include file='AMMPEG2.xml' path='doc/member[@name="AMMPEG2.AMMPEG2_DVB_UserData"]/*' />
    [NativeTypeName("#define AMMPEG2_DVB_UserData 0x00000080")]
    public const int AMMPEG2_DVB_UserData = 0x00000080;

    /// <include file='AMMPEG2.xml' path='doc/member[@name="AMMPEG2.AMMPEG2_27MhzTimebase"]/*' />
    [NativeTypeName("#define AMMPEG2_27MhzTimebase 0x00000100")]
    public const int AMMPEG2_27MhzTimebase = 0x00000100;

    /// <include file='AMMPEG2.xml' path='doc/member[@name="AMMPEG2.AMMPEG2_WidescreenAnalogOut"]/*' />
    [NativeTypeName("#define AMMPEG2_WidescreenAnalogOut 0x00000200")]
    public const int AMMPEG2_WidescreenAnalogOut = 0x00000200;
}
