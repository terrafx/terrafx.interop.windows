// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidclass.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DEVINTERFACE_HID = new Guid(0x4D1E55B2, 0xF16F, 0x11CF, 0x88, 0xCB, 0x00, 0x11, 0x11, 0x00, 0x00, 0x30);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_HID_INTERFACE_NOTIFY = new Guid(0x2c4e2e88, 0x25e6, 0x4c33, 0x88, 0x2f, 0x3d, 0x82, 0xe6, 0x07, 0x36, 0x81);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_HID_INTERFACE_HIDPARSE = new Guid(0xf5c315a5, 0x69ac, 0x4bc2, 0x92, 0x79, 0xd0, 0xb6, 0x45, 0x76, 0xf4, 0x4b);

        [NativeTypeName("#define GUID_CLASS_INPUT GUID_DEVINTERFACE_HID")]
        public static readonly Guid GUID_CLASS_INPUT = GUID_DEVINTERFACE_HID;

        [NativeTypeName("#define HID_REVISION 0x00000001")]
        public const int HID_REVISION = 0x00000001;

        [NativeTypeName("#define IOCTL_HID_GET_DRIVER_CONFIG HID_BUFFER_CTL_CODE(100)")]
        public const int IOCTL_HID_GET_DRIVER_CONFIG = (((0x0000000b) << 16) | ((0) << 14) | (((100)) << 2) | (0));

        [NativeTypeName("#define IOCTL_HID_SET_DRIVER_CONFIG HID_BUFFER_CTL_CODE(101)")]
        public const int IOCTL_HID_SET_DRIVER_CONFIG = (((0x0000000b) << 16) | ((0) << 14) | (((101)) << 2) | (0));

        [NativeTypeName("#define IOCTL_HID_GET_POLL_FREQUENCY_MSEC HID_BUFFER_CTL_CODE(102)")]
        public const int IOCTL_HID_GET_POLL_FREQUENCY_MSEC = (((0x0000000b) << 16) | ((0) << 14) | (((102)) << 2) | (0));

        [NativeTypeName("#define IOCTL_HID_SET_POLL_FREQUENCY_MSEC HID_BUFFER_CTL_CODE(103)")]
        public const int IOCTL_HID_SET_POLL_FREQUENCY_MSEC = (((0x0000000b) << 16) | ((0) << 14) | (((103)) << 2) | (0));

        [NativeTypeName("#define IOCTL_GET_NUM_DEVICE_INPUT_BUFFERS HID_BUFFER_CTL_CODE(104)")]
        public const int IOCTL_GET_NUM_DEVICE_INPUT_BUFFERS = (((0x0000000b) << 16) | ((0) << 14) | (((104)) << 2) | (0));

        [NativeTypeName("#define IOCTL_SET_NUM_DEVICE_INPUT_BUFFERS HID_BUFFER_CTL_CODE(105)")]
        public const int IOCTL_SET_NUM_DEVICE_INPUT_BUFFERS = (((0x0000000b) << 16) | ((0) << 14) | (((105)) << 2) | (0));

        [NativeTypeName("#define IOCTL_HID_GET_COLLECTION_INFORMATION HID_BUFFER_CTL_CODE(106)")]
        public const int IOCTL_HID_GET_COLLECTION_INFORMATION = (((0x0000000b) << 16) | ((0) << 14) | (((106)) << 2) | (0));

        [NativeTypeName("#define IOCTL_HID_ENABLE_WAKE_ON_SX HID_BUFFER_CTL_CODE(107)")]
        public const int IOCTL_HID_ENABLE_WAKE_ON_SX = (((0x0000000b) << 16) | ((0) << 14) | (((107)) << 2) | (0));

        [NativeTypeName("#define IOCTL_HID_SET_S0_IDLE_TIMEOUT HID_BUFFER_CTL_CODE(108)")]
        public const int IOCTL_HID_SET_S0_IDLE_TIMEOUT = (((0x0000000b) << 16) | ((0) << 14) | (((108)) << 2) | (0));

        [NativeTypeName("#define IOCTL_HID_GET_COLLECTION_DESCRIPTOR HID_CTL_CODE(100)")]
        public const int IOCTL_HID_GET_COLLECTION_DESCRIPTOR = (((0x0000000b) << 16) | ((0) << 14) | (((100)) << 2) | (3));

        [NativeTypeName("#define IOCTL_HID_FLUSH_QUEUE HID_CTL_CODE(101)")]
        public const int IOCTL_HID_FLUSH_QUEUE = (((0x0000000b) << 16) | ((0) << 14) | (((101)) << 2) | (3));

        [NativeTypeName("#define IOCTL_HID_SET_FEATURE HID_IN_CTL_CODE(100)")]
        public const int IOCTL_HID_SET_FEATURE = (((0x0000000b) << 16) | ((0) << 14) | (((100)) << 2) | (1));

        [NativeTypeName("#define IOCTL_HID_SET_OUTPUT_REPORT HID_IN_CTL_CODE(101)")]
        public const int IOCTL_HID_SET_OUTPUT_REPORT = (((0x0000000b) << 16) | ((0) << 14) | (((101)) << 2) | (1));

        [NativeTypeName("#define IOCTL_HID_GET_FEATURE HID_OUT_CTL_CODE(100)")]
        public const int IOCTL_HID_GET_FEATURE = (((0x0000000b) << 16) | ((0) << 14) | (((100)) << 2) | (2));

        [NativeTypeName("#define IOCTL_GET_PHYSICAL_DESCRIPTOR HID_OUT_CTL_CODE(102)")]
        public const int IOCTL_GET_PHYSICAL_DESCRIPTOR = (((0x0000000b) << 16) | ((0) << 14) | (((102)) << 2) | (2));

        [NativeTypeName("#define IOCTL_HID_GET_HARDWARE_ID HID_OUT_CTL_CODE(103)")]
        public const int IOCTL_HID_GET_HARDWARE_ID = (((0x0000000b) << 16) | ((0) << 14) | (((103)) << 2) | (2));

        [NativeTypeName("#define IOCTL_HID_GET_INPUT_REPORT HID_OUT_CTL_CODE(104)")]
        public const int IOCTL_HID_GET_INPUT_REPORT = (((0x0000000b) << 16) | ((0) << 14) | (((104)) << 2) | (2));

        [NativeTypeName("#define IOCTL_HID_GET_OUTPUT_REPORT HID_OUT_CTL_CODE(105)")]
        public const int IOCTL_HID_GET_OUTPUT_REPORT = (((0x0000000b) << 16) | ((0) << 14) | (((105)) << 2) | (2));

        [NativeTypeName("#define IOCTL_HID_GET_MANUFACTURER_STRING HID_OUT_CTL_CODE(110)")]
        public const int IOCTL_HID_GET_MANUFACTURER_STRING = (((0x0000000b) << 16) | ((0) << 14) | (((110)) << 2) | (2));

        [NativeTypeName("#define IOCTL_HID_GET_PRODUCT_STRING HID_OUT_CTL_CODE(111)")]
        public const int IOCTL_HID_GET_PRODUCT_STRING = (((0x0000000b) << 16) | ((0) << 14) | (((111)) << 2) | (2));

        [NativeTypeName("#define IOCTL_HID_GET_SERIALNUMBER_STRING HID_OUT_CTL_CODE(112)")]
        public const int IOCTL_HID_GET_SERIALNUMBER_STRING = (((0x0000000b) << 16) | ((0) << 14) | (((112)) << 2) | (2));

        [NativeTypeName("#define IOCTL_HID_GET_INDEXED_STRING HID_OUT_CTL_CODE(120)")]
        public const int IOCTL_HID_GET_INDEXED_STRING = (((0x0000000b) << 16) | ((0) << 14) | (((120)) << 2) | (2));

        [NativeTypeName("#define IOCTL_HID_GET_MS_GENRE_DESCRIPTOR HID_OUT_CTL_CODE(121)")]
        public const int IOCTL_HID_GET_MS_GENRE_DESCRIPTOR = (((0x0000000b) << 16) | ((0) << 14) | (((121)) << 2) | (2));

        [NativeTypeName("#define IOCTL_HID_ENABLE_SECURE_READ HID_CTL_CODE(130)")]
        public const int IOCTL_HID_ENABLE_SECURE_READ = (((0x0000000b) << 16) | ((0) << 14) | (((130)) << 2) | (3));

        [NativeTypeName("#define IOCTL_HID_DISABLE_SECURE_READ HID_CTL_CODE(131)")]
        public const int IOCTL_HID_DISABLE_SECURE_READ = (((0x0000000b) << 16) | ((0) << 14) | (((131)) << 2) | (3));

        [NativeTypeName("#define IOCTL_HID_DEVICERESET_NOTIFICATION HID_CTL_CODE(140)")]
        public const int IOCTL_HID_DEVICERESET_NOTIFICATION = (((0x0000000b) << 16) | ((0) << 14) | (((140)) << 2) | (3));
    }
}
