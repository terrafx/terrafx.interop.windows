// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int HID_REVISION = 0x00000001;

        public static readonly Guid GUID_DEVINTERFACE_HID = new Guid(0x4D1E55B2, 0xF16F, 0x11CF, 0x88, 0xCB, 0x00, 0x11, 0x11, 0x00, 0x00, 0x30);

        public static readonly Guid GUID_HID_INTERFACE_NOTIFY = new Guid(0x2c4e2e88, 0x25e6, 0x4c33, 0x88, 0x2f, 0x3d, 0x82, 0xe6, 0x07, 0x36, 0x81);

        public static readonly Guid GUID_HID_INTERFACE_HIDPARSE = new Guid(0xf5c315a5, 0x69ac, 0x4bc2, 0x92, 0x79, 0xd0, 0xb6, 0x45, 0x76, 0xf4, 0x4b);

        public static readonly Guid GUID_CLASS_INPUT = GUID_DEVINTERFACE_HID;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int HID_CTL_CODE(int id) => CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_NEITHER, FILE_ANY_ACCESS);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int HID_BUFFER_CTL_CODE(int id) => CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_BUFFERED, FILE_ANY_ACCESS);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int HID_IN_CTL_CODE(int id) => CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_IN_DIRECT, FILE_ANY_ACCESS);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int HID_OUT_CTL_CODE(int id) => CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_OUT_DIRECT, FILE_ANY_ACCESS);

        public const int IOCTL_HID_GET_DRIVER_CONFIG = 0x000B0190;

        public const int IOCTL_HID_SET_DRIVER_CONFIG = 0x000B0194;

        public const int IOCTL_HID_GET_POLL_FREQUENCY_MSEC = 0x000B0198;

        public const int IOCTL_HID_SET_POLL_FREQUENCY_MSEC = 0x000B019C;

        public const int IOCTL_GET_NUM_DEVICE_INPUT_BUFFERS = 0x000B01A0;

        public const int IOCTL_SET_NUM_DEVICE_INPUT_BUFFERS = 0x000B01A4;

        public const int IOCTL_HID_GET_COLLECTION_INFORMATION = 0x000B01A8;

        public const int IOCTL_HID_ENABLE_WAKE_ON_SX = 0x000B01AC;

        public const int IOCTL_HID_SET_S0_IDLE_TIMEOUT = 0x000B01B0;

        public const int IOCTL_HID_GET_COLLECTION_DESCRIPTOR = 0x000B0193;

        public const int IOCTL_HID_FLUSH_QUEUE = 0x000B0197;

        public const int IOCTL_HID_SET_FEATURE = 0x000B0191;

        public const int IOCTL_HID_SET_OUTPUT_REPORT = 0x000B0195;

        public const int IOCTL_HID_GET_FEATURE = 0x000B0192;

        public const int IOCTL_GET_PHYSICAL_DESCRIPTOR = 0x000B019A;

        public const int IOCTL_HID_GET_HARDWARE_ID = 0x000B019E;

        public const int IOCTL_HID_GET_INPUT_REPORT = 0x000B01A2;

        public const int IOCTL_HID_GET_OUTPUT_REPORT = 0x000B01A6;

        public const int IOCTL_HID_GET_MANUFACTURER_STRING = 0x000B01BA;

        public const int IOCTL_HID_GET_PRODUCT_STRING = 0x000B01BE;

        public const int IOCTL_HID_GET_SERIALNUMBER_STRING = 0x000B01C2;

        public const int IOCTL_HID_GET_INDEXED_STRING = 0x000B01E2;

        public const int IOCTL_HID_GET_MS_GENRE_DESCRIPTOR = 0x000B01E6;

        public const int IOCTL_HID_ENABLE_SECURE_READ = 0x000B020B;

        public const int IOCTL_HID_DISABLE_SECURE_READ = 0x000B020F;

        public const int IOCTL_HID_DEVICERESET_NOTIFICATION = 0x000B0233;
    }
}
