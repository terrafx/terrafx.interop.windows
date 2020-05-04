// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Hid
    {
        public const int FACILITY_HID_ERROR_CODE = 0x11;

        public const ushort HIDP_LINK_COLLECTION_ROOT = unchecked((ushort)-1);

        public const ushort HIDP_LINK_COLLECTION_UNSPECIFIED = 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HidP_IsSameUsageAndPage(USAGE_AND_PAGE* u1, USAGE_AND_PAGE* u2) => *(uint*)u1 == *(uint*)u2;

        public static int HidP_SetButtons(HIDP_REPORT_TYPE ReportType, ushort UsagePage, ushort LinkCollection, ushort* UsageList, uint* UsageLength, IntPtr PreparsedData, sbyte* Report, uint ReportLength) =>
            HidP_SetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HidP_UnsetButtons(HIDP_REPORT_TYPE ReportType, ushort UsagePage, ushort LinkCollection, ushort* UsageList, uint* UsageLength, IntPtr PreparsedData, sbyte* Report, uint ReportLength) =>
            HidP_UnsetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HidP_GetButtons(HIDP_REPORT_TYPE ReportType, ushort UsagePage, ushort LinkCollection, ushort* UsageList, uint* UsageLength, IntPtr PreparsedData, sbyte* Report, uint ReportLength) =>
            HidP_GetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HidP_GetButtonsEx(HIDP_REPORT_TYPE ReportType, ushort LinkCollection, USAGE_AND_PAGE* ButtonList, uint* UsageLength, IntPtr PreparsedData, sbyte* Report, uint ReportLength) =>
            HidP_GetUsagesEx(ReportType, LinkCollection, ButtonList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HIDP_ERROR_CODES(int sev, int code) => (sev << 28) | (FACILITY_HID_ERROR_CODE << 16) | code;

        public const int HIDP_STATUS_SUCCESS = 0x00110000;

        public const int HIDP_STATUS_NULL = unchecked((int)0x80110001);

        public const int HIDP_STATUS_INVALID_PREPARSED_DATA = unchecked((int)0xC0110001);

        public const int HIDP_STATUS_INVALID_REPORT_TYPE = unchecked((int)0xC0110002);

        public const int HIDP_STATUS_INVALID_REPORT_LENGTH = unchecked((int)0xC0110003);

        public const int HIDP_STATUS_USAGE_NOT_FOUND = unchecked((int)0xC0110004);

        public const int HIDP_STATUS_VALUE_OUT_OF_RANGE = unchecked((int)0xC0110005);

        public const int HIDP_STATUS_BAD_LOG_PHY_VALUES = unchecked((int)0xC0110006);

        public const int HIDP_STATUS_BUFFER_TOO_SMALL = unchecked((int)0xC0110007);

        public const int HIDP_STATUS_INTERNAL_ERROR = unchecked((int)0xC0110008);

        public const int HIDP_STATUS_I8042_TRANS_UNKNOWN = unchecked((int)0xC0110009);

        public const int HIDP_STATUS_INCOMPATIBLE_REPORT_ID = unchecked((int)0xC011000A);

        public const int HIDP_STATUS_NOT_VALUE_ARRAY = unchecked((int)0xC011000B);

        public const int HIDP_STATUS_IS_VALUE_ARRAY = unchecked((int)0xC011000C);

        public const int HIDP_STATUS_DATA_INDEX_NOT_FOUND = unchecked((int)0xC011000D);

        public const int HIDP_STATUS_DATA_INDEX_OUT_OF_RANGE = unchecked((int)0xC011000E);

        public const int HIDP_STATUS_BUTTON_NOT_PRESSED = unchecked((int)0xC011000F);

        public const int HIDP_STATUS_REPORT_DOES_NOT_EXIST = unchecked((int)0xC0110010);

        public const int HIDP_STATUS_NOT_IMPLEMENTED = unchecked((int)0xC0110020);

        public const int HIDP_STATUS_I8242_TRANS_UNKNOWN = unchecked((int)0xC0110009);
    }
}
