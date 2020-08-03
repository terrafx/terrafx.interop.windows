// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define AM_AC3_ALTERNATE_AUDIO_1 1")]
        public const int AM_AC3_ALTERNATE_AUDIO_1 = 1;

        [NativeTypeName("#define AM_AC3_ALTERNATE_AUDIO_2 2")]
        public const int AM_AC3_ALTERNATE_AUDIO_2 = 2;

        [NativeTypeName("#define AM_AC3_ALTERNATE_AUDIO_BOTH 3")]
        public const int AM_AC3_ALTERNATE_AUDIO_BOTH = 3;

        [NativeTypeName("#define AM_AC3_SERVICE_MAIN_AUDIO 0")]
        public const int AM_AC3_SERVICE_MAIN_AUDIO = 0;

        [NativeTypeName("#define AM_AC3_SERVICE_NO_DIALOG 1")]
        public const int AM_AC3_SERVICE_NO_DIALOG = 1;

        [NativeTypeName("#define AM_AC3_SERVICE_VISUALLY_IMPAIRED 2")]
        public const int AM_AC3_SERVICE_VISUALLY_IMPAIRED = 2;

        [NativeTypeName("#define AM_AC3_SERVICE_HEARING_IMPAIRED 3")]
        public const int AM_AC3_SERVICE_HEARING_IMPAIRED = 3;

        [NativeTypeName("#define AM_AC3_SERVICE_DIALOG_ONLY 4")]
        public const int AM_AC3_SERVICE_DIALOG_ONLY = 4;

        [NativeTypeName("#define AM_AC3_SERVICE_COMMENTARY 5")]
        public const int AM_AC3_SERVICE_COMMENTARY = 5;

        [NativeTypeName("#define AM_AC3_SERVICE_EMERGENCY_FLASH 6")]
        public const int AM_AC3_SERVICE_EMERGENCY_FLASH = 6;

        [NativeTypeName("#define AM_AC3_SERVICE_VOICE_OVER 7")]
        public const int AM_AC3_SERVICE_VOICE_OVER = 7;

        [NativeTypeName("#define AM_UseNewCSSKey 0x1")]
        public const int AM_UseNewCSSKey = 0x1;

        [NativeTypeName("#define AM_ReverseBlockStart 0x2")]
        public const int AM_ReverseBlockStart = 0x2;

        [NativeTypeName("#define AM_ReverseBlockEnd 0x4")]
        public const int AM_ReverseBlockEnd = 0x4;

        [NativeTypeName("#define AM_DVD_CGMS_RESERVED_MASK 0x00000078")]
        public const int AM_DVD_CGMS_RESERVED_MASK = 0x00000078;

        [NativeTypeName("#define AM_DVD_CGMS_COPY_PROTECT_MASK 0x00000018")]
        public const int AM_DVD_CGMS_COPY_PROTECT_MASK = 0x00000018;

        [NativeTypeName("#define AM_DVD_CGMS_COPY_PERMITTED 0x00000000")]
        public const int AM_DVD_CGMS_COPY_PERMITTED = 0x00000000;

        [NativeTypeName("#define AM_DVD_CGMS_COPY_ONCE 0x00000010")]
        public const int AM_DVD_CGMS_COPY_ONCE = 0x00000010;

        [NativeTypeName("#define AM_DVD_CGMS_NO_COPY 0x00000018")]
        public const int AM_DVD_CGMS_NO_COPY = 0x00000018;

        [NativeTypeName("#define AM_DVD_COPYRIGHT_MASK 0x00000040")]
        public const int AM_DVD_COPYRIGHT_MASK = 0x00000040;

        [NativeTypeName("#define AM_DVD_NOT_COPYRIGHTED 0x00000000")]
        public const int AM_DVD_NOT_COPYRIGHTED = 0x00000000;

        [NativeTypeName("#define AM_DVD_COPYRIGHTED 0x00000040")]
        public const int AM_DVD_COPYRIGHTED = 0x00000040;

        [NativeTypeName("#define AM_DVD_SECTOR_PROTECT_MASK 0x00000020")]
        public const int AM_DVD_SECTOR_PROTECT_MASK = 0x00000020;

        [NativeTypeName("#define AM_DVD_SECTOR_NOT_PROTECTED 0x00000000")]
        public const int AM_DVD_SECTOR_NOT_PROTECTED = 0x00000000;

        [NativeTypeName("#define AM_DVD_SECTOR_PROTECTED 0x00000020")]
        public const int AM_DVD_SECTOR_PROTECTED = 0x00000020;

        [NativeTypeName("#define AMINTERLACE_IsInterlaced 0x00000001")]
        public const int AMINTERLACE_IsInterlaced = 0x00000001;

        [NativeTypeName("#define AMINTERLACE_1FieldPerSample 0x00000002")]
        public const int AMINTERLACE_1FieldPerSample = 0x00000002;

        [NativeTypeName("#define AMINTERLACE_Field1First 0x00000004")]
        public const int AMINTERLACE_Field1First = 0x00000004;

        [NativeTypeName("#define AMINTERLACE_UNUSED 0x00000008")]
        public const int AMINTERLACE_UNUSED = 0x00000008;

        [NativeTypeName("#define AMINTERLACE_FieldPatternMask 0x00000030")]
        public const int AMINTERLACE_FieldPatternMask = 0x00000030;

        [NativeTypeName("#define AMINTERLACE_FieldPatField1Only 0x00000000")]
        public const int AMINTERLACE_FieldPatField1Only = 0x00000000;

        [NativeTypeName("#define AMINTERLACE_FieldPatField2Only 0x00000010")]
        public const int AMINTERLACE_FieldPatField2Only = 0x00000010;

        [NativeTypeName("#define AMINTERLACE_FieldPatBothRegular 0x00000020")]
        public const int AMINTERLACE_FieldPatBothRegular = 0x00000020;

        [NativeTypeName("#define AMINTERLACE_FieldPatBothIrregular 0x00000030")]
        public const int AMINTERLACE_FieldPatBothIrregular = 0x00000030;

        [NativeTypeName("#define AMINTERLACE_DisplayModeMask 0x000000c0")]
        public const int AMINTERLACE_DisplayModeMask = 0x000000c0;

        [NativeTypeName("#define AMINTERLACE_DisplayModeBobOnly 0x00000000")]
        public const int AMINTERLACE_DisplayModeBobOnly = 0x00000000;

        [NativeTypeName("#define AMINTERLACE_DisplayModeWeaveOnly 0x00000040")]
        public const int AMINTERLACE_DisplayModeWeaveOnly = 0x00000040;

        [NativeTypeName("#define AMINTERLACE_DisplayModeBobOrWeave 0x00000080")]
        public const int AMINTERLACE_DisplayModeBobOrWeave = 0x00000080;

        [NativeTypeName("#define AMCOPYPROTECT_RestrictDuplication 0x00000001")]
        public const int AMCOPYPROTECT_RestrictDuplication = 0x00000001;

        [NativeTypeName("#define AMMPEG2_DoPanScan 0x00000001")]
        public const int AMMPEG2_DoPanScan = 0x00000001;

        [NativeTypeName("#define AMMPEG2_DVDLine21Field1 0x00000002")]
        public const int AMMPEG2_DVDLine21Field1 = 0x00000002;

        [NativeTypeName("#define AMMPEG2_DVDLine21Field2 0x00000004")]
        public const int AMMPEG2_DVDLine21Field2 = 0x00000004;

        [NativeTypeName("#define AMMPEG2_SourceIsLetterboxed 0x00000008")]
        public const int AMMPEG2_SourceIsLetterboxed = 0x00000008;

        [NativeTypeName("#define AMMPEG2_FilmCameraMode 0x00000010")]
        public const int AMMPEG2_FilmCameraMode = 0x00000010;

        [NativeTypeName("#define AMMPEG2_LetterboxAnalogOut 0x00000020")]
        public const int AMMPEG2_LetterboxAnalogOut = 0x00000020;

        [NativeTypeName("#define AMMPEG2_DSS_UserData 0x00000040")]
        public const int AMMPEG2_DSS_UserData = 0x00000040;

        [NativeTypeName("#define AMMPEG2_DVB_UserData 0x00000080")]
        public const int AMMPEG2_DVB_UserData = 0x00000080;

        [NativeTypeName("#define AMMPEG2_27MhzTimebase 0x00000100")]
        public const int AMMPEG2_27MhzTimebase = 0x00000100;

        [NativeTypeName("#define AMMPEG2_WidescreenAnalogOut 0x00000200")]
        public const int AMMPEG2_WidescreenAnalogOut = 0x00000200;

        [NativeTypeName("#define AMCONTROL_USED 0x00000001")]
        public const int AMCONTROL_USED = 0x00000001;

        [NativeTypeName("#define AMCONTROL_PAD_TO_4x3 0x00000002")]
        public const int AMCONTROL_PAD_TO_4x3 = 0x00000002;

        [NativeTypeName("#define AMCONTROL_PAD_TO_16x9 0x00000004")]
        public const int AMCONTROL_PAD_TO_16x9 = 0x00000004;

        [NativeTypeName("#define AMCONTROL_COLORINFO_PRESENT 0x00000080")]
        public const int AMCONTROL_COLORINFO_PRESENT = 0x00000080;

        [NativeTypeName("#define AM_VIDEO_FLAG_FIELD_MASK 0x0003L")]
        public const int AM_VIDEO_FLAG_FIELD_MASK = 0x0003;

        [NativeTypeName("#define AM_VIDEO_FLAG_INTERLEAVED_FRAME 0x0000L")]
        public const int AM_VIDEO_FLAG_INTERLEAVED_FRAME = 0x0000;

        [NativeTypeName("#define AM_VIDEO_FLAG_FIELD1 0x0001L")]
        public const int AM_VIDEO_FLAG_FIELD1 = 0x0001;

        [NativeTypeName("#define AM_VIDEO_FLAG_FIELD2 0x0002L")]
        public const int AM_VIDEO_FLAG_FIELD2 = 0x0002;

        [NativeTypeName("#define AM_VIDEO_FLAG_FIELD1FIRST 0x0004L")]
        public const int AM_VIDEO_FLAG_FIELD1FIRST = 0x0004;

        [NativeTypeName("#define AM_VIDEO_FLAG_WEAVE 0x0008L")]
        public const int AM_VIDEO_FLAG_WEAVE = 0x0008;

        [NativeTypeName("#define AM_VIDEO_FLAG_IPB_MASK 0x0030L")]
        public const int AM_VIDEO_FLAG_IPB_MASK = 0x0030;

        [NativeTypeName("#define AM_VIDEO_FLAG_I_SAMPLE 0x0000L")]
        public const int AM_VIDEO_FLAG_I_SAMPLE = 0x0000;

        [NativeTypeName("#define AM_VIDEO_FLAG_P_SAMPLE 0x0010L")]
        public const int AM_VIDEO_FLAG_P_SAMPLE = 0x0010;

        [NativeTypeName("#define AM_VIDEO_FLAG_B_SAMPLE 0x0020L")]
        public const int AM_VIDEO_FLAG_B_SAMPLE = 0x0020;

        [NativeTypeName("#define AM_VIDEO_FLAG_REPEAT_FIELD 0x0040L")]
        public const int AM_VIDEO_FLAG_REPEAT_FIELD = 0x0040;
    }
}
