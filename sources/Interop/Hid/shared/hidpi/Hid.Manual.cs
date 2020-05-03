// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

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

        public static int HidP_SetButtons(HIDP_REPORT_TYPE ReportType, ushort UsagePage, ushort LinkCollection, ushort* UsageList, uint* UsageLength, HIDP_PREPARSED_DATA* PreparsedData, sbyte* Report, uint ReportLength) =>
            HidP_SetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HidP_UnsetButtons(HIDP_REPORT_TYPE ReportType, ushort UsagePage, ushort LinkCollection, ushort* UsageList, uint* UsageLength, HIDP_PREPARSED_DATA* PreparsedData, sbyte* Report, uint ReportLength) =>
            HidP_UnsetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HidP_GetButtons(HIDP_REPORT_TYPE ReportType, ushort UsagePage, ushort LinkCollection, ushort* UsageList, uint* UsageLength, HIDP_PREPARSED_DATA* PreparsedData, sbyte* Report, uint ReportLength) =>
            HidP_GetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HidP_GetButtonsEx(HIDP_REPORT_TYPE ReportType, ushort LinkCollection, USAGE_AND_PAGE* ButtonList, uint* UsageLength, HIDP_PREPARSED_DATA* PreparsedData, sbyte* Report, uint ReportLength) =>
            HidP_GetUsagesEx(ReportType, LinkCollection, ButtonList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HIDP_ERROR_CODES(int sev, int code) => ((sev) << 28) | (FACILITY_HID_ERROR_CODE << 16) | code;

        public static readonly int HIDP_STATUS_SUCCESS = HIDP_ERROR_CODES(0x0, 0);

        public static readonly int HIDP_STATUS_NULL = HIDP_ERROR_CODES(0x8, 1);

        public static readonly int HIDP_STATUS_INVALID_PREPARSED_DATA = HIDP_ERROR_CODES(0xC, 1);

        public static readonly int HIDP_STATUS_INVALID_REPORT_TYPE = HIDP_ERROR_CODES(0xC, 2);

        public static readonly int HIDP_STATUS_INVALID_REPORT_LENGTH = HIDP_ERROR_CODES(0xC, 3);

        public static readonly int HIDP_STATUS_USAGE_NOT_FOUND = HIDP_ERROR_CODES(0xC, 4);

        public static readonly int HIDP_STATUS_VALUE_OUT_OF_RANGE = HIDP_ERROR_CODES(0xC, 5);

        public static readonly int HIDP_STATUS_BAD_LOG_PHY_VALUES = HIDP_ERROR_CODES(0xC, 6);

        public static readonly int HIDP_STATUS_BUFFER_TOO_SMALL = HIDP_ERROR_CODES(0xC, 7);

        public static readonly int HIDP_STATUS_INTERNAL_ERROR = HIDP_ERROR_CODES(0xC, 8);

        public static readonly int HIDP_STATUS_I8042_TRANS_UNKNOWN = HIDP_ERROR_CODES(0xC, 9);

        public static readonly int HIDP_STATUS_INCOMPATIBLE_REPORT_ID = HIDP_ERROR_CODES(0xC, 0xA);

        public static readonly int HIDP_STATUS_NOT_VALUE_ARRAY = HIDP_ERROR_CODES(0xC, 0xB);

        public static readonly int HIDP_STATUS_IS_VALUE_ARRAY = HIDP_ERROR_CODES(0xC, 0xC);

        public static readonly int HIDP_STATUS_DATA_INDEX_NOT_FOUND = HIDP_ERROR_CODES(0xC, 0xD);

        public static readonly int HIDP_STATUS_DATA_INDEX_OUT_OF_RANGE = HIDP_ERROR_CODES(0xC, 0xE);

        public static readonly int HIDP_STATUS_BUTTON_NOT_PRESSED = HIDP_ERROR_CODES(0xC, 0xF);

        public static readonly int HIDP_STATUS_REPORT_DOES_NOT_EXIST = HIDP_ERROR_CODES(0xC, 0x10);

        public static readonly int HIDP_STATUS_NOT_IMPLEMENTED = HIDP_ERROR_CODES(0xC, 0x20);

        public static readonly int HIDP_STATUS_I8242_TRANS_UNKNOWN = HIDP_STATUS_I8042_TRANS_UNKNOWN;
    }
}
