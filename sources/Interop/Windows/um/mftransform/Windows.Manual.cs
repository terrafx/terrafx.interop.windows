// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid IID_IMFTransform = new Guid(0xBF94C121, 0x5B05, 0x4E6F, 0x80, 0x00, 0xBA, 0x59, 0x89, 0x61, 0x41, 0x4D);

        public static readonly Guid MEDeviceStreamCreated = new Guid(0X396CE1C9, 0X67A9, 0X454C, 0X87, 0X97, 0X95, 0XA4, 0X57, 0X99, 0XD8, 0X04);

        public static readonly PROPERTYKEY MFPKEY_CLSID = new PROPERTYKEY { fmtid = new Guid(0XC57A84C0, 0X1A80, 0X40A3, 0X97, 0XB5, 0X92, 0X72, 0XA4, 0X3, 0XC8, 0XAE), pid = 0X01 };

        public static readonly PROPERTYKEY MFPKEY_CATEGORY = new PROPERTYKEY { fmtid = new Guid(0XC57A84C0, 0X1A80, 0X40A3, 0X97, 0XB5, 0X92, 0X72, 0XA4, 0X3, 0XC8, 0XAE), pid = 0X02 };

        public static readonly PROPERTYKEY MFPKEY_EXATTRIBUTE_SUPPORTED = new PROPERTYKEY { fmtid = new Guid(0X456FE843, 0X3C87, 0X40C0, 0X94, 0X9D, 0X14, 0X9, 0XC9, 0X7D, 0XAB, 0X2C), pid = 0X01 };

        public static readonly PROPERTYKEY MFPKEY_MULTICHANNEL_CHANNEL_MASK = new PROPERTYKEY { fmtid = new Guid(0X58BDAF8C, 0X3224, 0X4692, 0X86, 0XD0, 0X44, 0XD6, 0X5C, 0X5B, 0XF8, 0X2B), pid = 0X01 };

        public static readonly Guid MF_SA_D3D_AWARE = new Guid(0XEAA35C29, 0X775E, 0X488E, 0X9B, 0X61, 0XB3, 0X28, 0X3E, 0X49, 0X58, 0X3B);

        public static readonly Guid MF_SA_REQUIRED_SAMPLE_COUNT = new Guid(0X18802C61, 0X324B, 0X4952, 0XAB, 0XD0, 0X17, 0X6F, 0XF5, 0XC6, 0X96, 0XFF);

        public static readonly Guid MFT_END_STREAMING_AWARE = new Guid(0X70FBC845, 0XB07E, 0X4089, 0XB0, 0X64, 0X39, 0X9D, 0XC6, 0X11, 0XF, 0X29);

        public static readonly Guid MF_SA_AUDIO_ENDPOINT_AWARE = new Guid(0XC0381701, 0X805C, 0X42B2, 0XAC, 0X8D, 0XE2, 0XB4, 0XBF, 0X21, 0XF4, 0XF8);

        public static readonly Guid MFT_AUDIO_DECODER_AUDIO_ENDPOINT_ID = new Guid(0XC7CCDD6E, 0X5398, 0X4695, 0X8B, 0XE7, 0X51, 0XB3, 0XE9, 0X51, 0X11, 0XBD);

        public static readonly Guid MFT_AUDIO_DECODER_SPATIAL_METADATA_CLIENT = new Guid(0X5987DF4, 0X1270, 0X4999, 0X92, 0X5F, 0X8E, 0X93, 0X9A, 0X7C, 0XA, 0XF7);

        public static readonly Guid IID_IMFDeviceTransform = new Guid(0xD818FBD8, 0xFC46, 0x42F2, 0x87, 0xAC, 0x1E, 0xA2, 0xD1, 0xF9, 0xBF, 0x32);

        public static readonly Guid MF_DMFT_FRAME_BUFFER_INFO = new Guid(0x396CE1C9, 0x67A9, 0x454C, 0x87, 0x97, 0x95, 0xA4, 0x57, 0x99, 0xD8, 0x04);

        public static readonly Guid IID_IMFDeviceTransformCallback = new Guid(0x6D5CB646, 0x29EC, 0x41FB, 0x81, 0x79, 0x8C, 0x4C, 0x6D, 0x75, 0x08, 0x11);

        public static readonly Guid MF_SA_REQUIRED_SAMPLE_COUNT_PROGRESSIVE = new Guid(0XB172D58E, 0XFA77, 0X4E48, 0X8D, 0X2A, 0X1D, 0XF2, 0XD8, 0X50, 0XEA, 0XC2);

        public static readonly Guid MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT = new Guid(0X851745D5, 0XC3D6, 0X476D, 0X95, 0X27, 0X49, 0X8E, 0XF2, 0XD1, 0X0D, 0X18);

        public static readonly Guid MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT_PROGRESSIVE = new Guid(0X0F5523A5, 0X1CB2, 0X47C5, 0XA5, 0X50, 0X2E, 0XEB, 0X84, 0XB4, 0XD1, 0X4A);

        public static readonly Guid MFT_SUPPORT_3DVIDEO = new Guid(0X093F81B1, 0X4F2E, 0X4631, 0X81, 0X68, 0X79, 0X34, 0X03, 0X2A, 0X01, 0XD3);

        public static readonly Guid MF_ENABLE_3DVIDEO_OUTPUT = new Guid(0XBDAD7BCA, 0X0E5F, 0X4B10, 0XAB, 0X16, 0X26, 0XDE, 0X38, 0X1B, 0X62, 0X93);

        public static readonly Guid MF_SA_D3D11_BINDFLAGS = new Guid(0XEACF97AD, 0X065C, 0X4408, 0XBE, 0XE3, 0XFD, 0XCB, 0XFD, 0X12, 0X8B, 0XE2);

        public static readonly Guid MF_SA_D3D11_USAGE = new Guid(0XE85FE442, 0X2CA3, 0X486E, 0XA9, 0XC7, 0X10, 0X9D, 0XDA, 0X60, 0X98, 0X80);

        public static readonly Guid MF_SA_D3D11_AWARE = new Guid(0X206B4FC8, 0XFCF9, 0X4C51, 0XAF, 0XE3, 0X97, 0X64, 0X36, 0X9E, 0X33, 0XA0);

        public static readonly Guid MF_SA_D3D11_SHARED = new Guid(0X7B8F32C3, 0X6D96, 0X4B89, 0X92, 0X03, 0XDD, 0X38, 0XB6, 0X14, 0X14, 0XF3);

        public static readonly Guid MF_SA_D3D11_SHARED_WITHOUT_MUTEX = new Guid(0X39DBD44D, 0X2E44, 0X4931, 0XA4, 0XC8, 0X35, 0X2D, 0X3D, 0XC4, 0X21, 0X15);

        public static readonly Guid MF_SA_D3D11_ALLOW_DYNAMIC_YUV_TEXTURE = new Guid(0XCE06D49F, 0X0613, 0X4B9D, 0X86, 0XA6, 0XD8, 0XC4, 0XF9, 0XC1, 0X00, 0X75);

        public static readonly Guid MF_SA_D3D11_HW_PROTECTED = new Guid(0X3A8BA9D9, 0X92CA, 0X4307, 0XA3, 0X91, 0X69, 0X99, 0XDB, 0XF3, 0XB6, 0XCE);

        public static readonly Guid MF_SA_BUFFERS_PER_SAMPLE = new Guid(0X873C5171, 0X1E3D, 0X4E25, 0X98, 0X8D, 0XB4, 0X33, 0XCE, 0X04, 0X19, 0X83);

        public static readonly Guid MFT_DECODER_EXPOSE_OUTPUT_TYPES_IN_NATIVE_ORDER = new Guid(0XEF80833F, 0XF8FA, 0X44D9, 0X80, 0XD8, 0X41, 0XED, 0X62, 0X32, 0X67, 0X0C);

        public static readonly Guid MFT_DECODER_QUALITY_MANAGEMENT_CUSTOM_CONTROL = new Guid(0XA24E30D7, 0XDE25, 0X4558, 0XBB, 0XFB, 0X71, 0X07, 0X0A, 0X2D, 0X33, 0X2E);

        public static readonly Guid MFT_DECODER_QUALITY_MANAGEMENT_RECOVERY_WITHOUT_ARTIFACTS = new Guid(0XD8980DEB, 0X0A48, 0X425F, 0X86, 0X23, 0X61, 0X1D, 0XB4, 0X1D, 0X38, 0X10);

        public static readonly Guid MFT_REMUX_MARK_I_PICTURE_AS_CLEAN_POINT = new Guid(0X364E8F85, 0X3F2E, 0X436C, 0XB2, 0XA2, 0X44, 0X40, 0XA0, 0X12, 0XA9, 0XE8);

        public static readonly Guid MFT_DECODER_FINAL_VIDEO_RESOLUTION_HINT = new Guid(0XDC2F8496, 0X15C4, 0X407A, 0XB6, 0XF0, 0X1B, 0X66, 0XAB, 0X5F, 0XBF, 0X53);

        public static readonly Guid MFT_ENCODER_SUPPORTS_CONFIG_EVENT = new Guid(0X86A355AE, 0X3A77, 0X4EC4, 0X9F, 0X31, 0X01, 0X14, 0X9A, 0X4E, 0X92, 0XDE);

        public static readonly Guid MFT_ENUM_HARDWARE_VENDOR_ID_Attribute = new Guid(0X3AECB0CC, 0X035B, 0X4BCC, 0X81, 0X85, 0X2B, 0X8D, 0X55, 0X1E, 0XF3, 0XAF);

        public static readonly Guid MF_TRANSFORM_ASYNC = new Guid(0XF81A699A, 0X649A, 0X497D, 0X8C, 0X73, 0X29, 0XF8, 0XFE, 0XD6, 0XAD, 0X7A);

        public static readonly Guid MF_TRANSFORM_ASYNC_UNLOCK = new Guid(0XE5666D6B, 0X3422, 0X4EB6, 0XA4, 0X21, 0XDA, 0X7D, 0XB1, 0XF8, 0XE2, 0X07);

        public static readonly Guid MF_TRANSFORM_FLAGS_Attribute = new Guid(0X9359BB7E, 0X6275, 0X46C4, 0XA0, 0X25, 0X1C, 0X01, 0XE4, 0X5F, 0X1A, 0X86);

        public static readonly Guid MF_TRANSFORM_CATEGORY_Attribute = new Guid(0XCEABBA49, 0X506D, 0X4757, 0XA6, 0XFF, 0X66, 0XC1, 0X84, 0X98, 0X7E, 0X4E);

        public static readonly Guid MFT_TRANSFORM_CLSID_Attribute = new Guid(0X6821C42B, 0X65A4, 0X4E82, 0X99, 0XBC, 0X9A, 0X88, 0X20, 0X5E, 0XCD, 0X0C);

        public static readonly Guid MFT_INPUT_TYPES_Attributes = new Guid(0X4276C9B1, 0X759D, 0X4BF3, 0X9C, 0XD0, 0X0D, 0X72, 0X3D, 0X13, 0X8F, 0X96);

        public static readonly Guid MFT_OUTPUT_TYPES_Attributes = new Guid(0X8EAE8CF3, 0XA44F, 0X4306, 0XBA, 0X5C, 0XBF, 0X5D, 0XDA, 0X24, 0X28, 0X18);

        public static readonly Guid MFT_ENUM_HARDWARE_URL_Attribute = new Guid(0X2FB866AC, 0XB078, 0X4942, 0XAB, 0X6C, 0X00, 0X3D, 0X05, 0XCD, 0XA6, 0X74);

        public static readonly Guid MFT_FRIENDLY_NAME_Attribute = new Guid(0X314FFBAE, 0X5B41, 0X4C95, 0X9C, 0X19, 0X4E, 0X7D, 0X58, 0X6F, 0XAC, 0XE3);

        public static readonly Guid MFT_CONNECTED_STREAM_ATTRIBUTE = new Guid(0X71EEB820, 0XA59F, 0X4DE2, 0XBC, 0XEC, 0X38, 0XDB, 0X1D, 0XD6, 0X11, 0XA4);

        public static readonly Guid MFT_CONNECTED_TO_HW_STREAM = new Guid(0X34E6E728, 0X06D6, 0X4491, 0XA5, 0X53, 0X47, 0X95, 0X65, 0X0D, 0XB9, 0X12);

        public static readonly Guid MFT_PREFERRED_OUTPUTTYPE_Attribute = new Guid(0X7E700499, 0X396A, 0X49EE, 0XB1, 0XB4, 0XF6, 0X28, 0X02, 0X1E, 0X8C, 0X9D);

        public static readonly Guid MFT_PROCESS_LOCAL_Attribute = new Guid(0X543186E4, 0X4649, 0X4E65, 0XB5, 0X88, 0X4A, 0XA3, 0X52, 0XAF, 0XF3, 0X79);

        public static readonly Guid MFT_PREFERRED_ENCODER_PROFILE = new Guid(0X53004909, 0X1EF5, 0X46D7, 0XA1, 0X8E, 0X5A, 0X75, 0XF8, 0XB5, 0X90, 0X5F);

        public static readonly Guid MFT_HW_TIMESTAMP_WITH_QPC_Attribute = new Guid(0X8D030FB8, 0XCC43, 0X4258, 0XA2, 0X2E, 0X92, 0X10, 0XBE, 0XF8, 0X9B, 0XE4);

        public static readonly Guid MFT_FIELDOFUSE_UNLOCK_Attribute = new Guid(0X8EC2E9FD, 0X9148, 0X410D, 0X83, 0X1E, 0X70, 0X24, 0X39, 0X46, 0X1A, 0X8E);

        public static readonly Guid MFT_CODEC_MERIT_Attribute = new Guid(0X88A7CB15, 0X7B07, 0X4A34, 0X91, 0X28, 0XE6, 0X4C, 0X67, 0X03, 0XC4, 0XD3);

        public static readonly Guid MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTE = new Guid(0X111EA8CD, 0XB62A, 0X4BDB, 0X89, 0XF6, 0X67, 0XFF, 0XCD, 0XC2, 0X45, 0X8B);

        public static readonly Guid MFT_AUDIO_DECODER_DEGRADATION_INFO_ATTRIBUTE = new Guid(0X6C3386AD, 0XEC20, 0X430D, 0XB2, 0XA5, 0X50, 0X5C, 0X71, 0X78, 0XD9, 0XC4);

        public static readonly Guid MFT_POLICY_SET_AWARE = new Guid(0X5A633B19, 0XCC39, 0X4FA8, 0X8C, 0XA5, 0X59, 0X98, 0X1B, 0X7A, 0X00, 0X18);

        public static readonly Guid MFT_USING_HARDWARE_DRM = new Guid(0X34FAA77D, 0XD79E, 0X4957, 0XB8, 0XCE, 0X36, 0X2B, 0X26, 0X84, 0X99, 0X6C);
    }
}
