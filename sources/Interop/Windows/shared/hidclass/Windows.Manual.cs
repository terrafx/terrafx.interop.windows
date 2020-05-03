// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int HID_REVISION = 0x00000001;

        public static readonly Guid GUID_DEVINTERFACE_HID = new Guid(0x4D1E55B2, 0xF16F, 0x11CF, 0x88, 0xCB, 0x00, 0x11, 0x11, 0x00, 0x00, 0x30);

        public static readonly Guid GUID_HID_INTERFACE_NOTIFY = new Guid(0x2c4e2e88, 0x25e6, 0x4c33, 0x88, 0x2f, 0x3d, 0x82, 0xe6, 0x07, 0x36, 0x81);

        public static readonly Guid GUID_HID_INTERFACE_HIDPARSE = new Guid(0xf5c315a5, 0x69ac, 0x4bc2, 0x92, 0x79, 0xd0, 0xb6, 0x45, 0x76, 0xf4, 0x4b);

        public static readonly Guid GUID_CLASS_INPUT = GUID_DEVINTERFACE_HID;

        public static int HID_CTL_CODE(int id) => CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_NEITHER, FILE_ANY_ACCESS);

        public static int HID_BUFFER_CTL_CODE(int id) => CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_BUFFERED, FILE_ANY_ACCESS);

        public static int HID_IN_CTL_CODE(int id) => CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_IN_DIRECT, FILE_ANY_ACCESS);

        public static int HID_OUT_CTL_CODE(int id) => CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_OUT_DIRECT, FILE_ANY_ACCESS);

        public static readonly int IOCTL_HID_GET_DRIVER_CONFIG = HID_BUFFER_CTL_CODE(100);

        public static readonly int IOCTL_HID_SET_DRIVER_CONFIG = HID_BUFFER_CTL_CODE(101);

        public static readonly int IOCTL_HID_GET_POLL_FREQUENCY_MSEC = HID_BUFFER_CTL_CODE(102);

        public static readonly int IOCTL_HID_SET_POLL_FREQUENCY_MSEC = HID_BUFFER_CTL_CODE(103);

        public static readonly int IOCTL_GET_NUM_DEVICE_INPUT_BUFFERS = HID_BUFFER_CTL_CODE(104);

        public static readonly int IOCTL_SET_NUM_DEVICE_INPUT_BUFFERS = HID_BUFFER_CTL_CODE(105);

        public static readonly int IOCTL_HID_GET_COLLECTION_INFORMATION = HID_BUFFER_CTL_CODE(106);

        public static readonly int IOCTL_HID_ENABLE_WAKE_ON_SX = HID_BUFFER_CTL_CODE(107);

        public static readonly int IOCTL_HID_SET_S0_IDLE_TIMEOUT = HID_BUFFER_CTL_CODE(108);

        public static readonly int IOCTL_HID_GET_COLLECTION_DESCRIPTOR = HID_CTL_CODE(100);

        public static readonly int IOCTL_HID_FLUSH_QUEUE = HID_CTL_CODE(101);

        public static readonly int IOCTL_HID_SET_FEATURE = HID_IN_CTL_CODE(100);

        public static readonly int IOCTL_HID_SET_OUTPUT_REPORT = HID_IN_CTL_CODE(101);

        public static readonly int IOCTL_HID_GET_FEATURE = HID_OUT_CTL_CODE(100);

        public static readonly int IOCTL_GET_PHYSICAL_DESCRIPTOR = HID_OUT_CTL_CODE(102);

        public static readonly int IOCTL_HID_GET_HARDWARE_ID = HID_OUT_CTL_CODE(103);

        public static readonly int IOCTL_HID_GET_INPUT_REPORT = HID_OUT_CTL_CODE(104);

        public static readonly int IOCTL_HID_GET_OUTPUT_REPORT = HID_OUT_CTL_CODE(105);

        public static readonly int IOCTL_HID_GET_MANUFACTURER_STRING = HID_OUT_CTL_CODE(110);

        public static readonly int IOCTL_HID_GET_PRODUCT_STRING = HID_OUT_CTL_CODE(111);

        public static readonly int IOCTL_HID_GET_SERIALNUMBER_STRING = HID_OUT_CTL_CODE(112);

        public static readonly int IOCTL_HID_GET_INDEXED_STRING = HID_OUT_CTL_CODE(120);

        public static readonly int IOCTL_HID_GET_MS_GENRE_DESCRIPTOR = HID_OUT_CTL_CODE(121);

        public static readonly int IOCTL_HID_ENABLE_SECURE_READ = HID_CTL_CODE(130);

        public static readonly int IOCTL_HID_DISABLE_SECURE_READ = HID_CTL_CODE(131);

        public static readonly int IOCTL_HID_DEVICERESET_NOTIFICATION = HID_CTL_CODE(140);
    }
}
