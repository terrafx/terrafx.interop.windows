// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetCaps(PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PHIDP_CAPS")] HIDP_CAPS* Capabilities);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetLinkCollectionNodes([NativeTypeName("PHIDP_LINK_COLLECTION_NODE")] HIDP_LINK_COLLECTION_NODE* LinkCollectionNodes, [NativeTypeName("PULONG")] uint* LinkCollectionNodesLength, PHIDP_PREPARSED_DATA PreparsedData);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetSpecificButtonCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PHIDP_BUTTON_CAPS")] HIDP_BUTTON_CAPS* ButtonCaps, [NativeTypeName("PUSHORT")] ushort* ButtonCapsLength, PHIDP_PREPARSED_DATA PreparsedData);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetButtonCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_BUTTON_CAPS")] HIDP_BUTTON_CAPS* ButtonCaps, [NativeTypeName("PUSHORT")] ushort* ButtonCapsLength, PHIDP_PREPARSED_DATA PreparsedData);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetSpecificValueCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PHIDP_VALUE_CAPS")] HIDP_VALUE_CAPS* ValueCaps, [NativeTypeName("PUSHORT")] ushort* ValueCapsLength, PHIDP_PREPARSED_DATA PreparsedData);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetValueCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_VALUE_CAPS")] HIDP_VALUE_CAPS* ValueCaps, [NativeTypeName("PUSHORT")] ushort* ValueCapsLength, PHIDP_PREPARSED_DATA PreparsedData);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetExtendedAttributes(HIDP_REPORT_TYPE ReportType, ushort DataIndex, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PHIDP_EXTENDED_ATTRIBUTES")] HIDP_EXTENDED_ATTRIBUTES* Attributes, [NativeTypeName("PULONG")] uint* LengthAttributes);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_InitializeReportForID(HIDP_REPORT_TYPE ReportType, [NativeTypeName("UCHAR")] byte ReportID, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_SetData(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_DATA")] HIDP_DATA* DataList, [NativeTypeName("PULONG")] uint* DataLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetData(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_DATA")] HIDP_DATA* DataList, [NativeTypeName("PULONG")] uint* DataLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint HidP_MaxDataListLength(HIDP_REPORT_TYPE ReportType, PHIDP_PREPARSED_DATA PreparsedData);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_SetUsages(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_UnsetUsages(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetUsages(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetUsagesEx(HIDP_REPORT_TYPE ReportType, ushort LinkCollection, [NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* ButtonList, [NativeTypeName("ULONG *")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint HidP_MaxUsageListLength(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, PHIDP_PREPARSED_DATA PreparsedData);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_SetUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("ULONG")] uint UsageValue, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_SetScaledUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("LONG")] int UsageValue, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_SetUsageValueArray(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PCHAR")] sbyte* UsageValue, ushort UsageValueByteLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PULONG")] uint* UsageValue, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetScaledUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PLONG")] int* UsageValue, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetUsageValueArray(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PCHAR")] sbyte* UsageValue, ushort UsageValueByteLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_UsageListDifference([NativeTypeName("PUSAGE")] ushort* PreviousUsageList, [NativeTypeName("PUSAGE")] ushort* CurrentUsageList, [NativeTypeName("PUSAGE")] ushort* BreakUsageList, [NativeTypeName("PUSAGE")] ushort* MakeUsageList, [NativeTypeName("ULONG")] uint UsageListLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_TranslateUsagesToI8042ScanCodes([NativeTypeName("PUSAGE")] ushort* ChangedUsageList, [NativeTypeName("ULONG")] uint UsageListLength, HIDP_KEYBOARD_DIRECTION KeyAction, [NativeTypeName("PHIDP_KEYBOARD_MODIFIER_STATE")] HIDP_KEYBOARD_MODIFIER_STATE* ModifierState, [NativeTypeName("PHIDP_INSERT_SCANCODES")] delegate* unmanaged<void*, sbyte*, uint, byte> InsertCodesProcedure, [NativeTypeName("PVOID")] void* InsertCodesContext);

        [NativeTypeName("#define HIDP_LINK_COLLECTION_ROOT ((USHORT) -1)")]
        public const ushort HIDP_LINK_COLLECTION_ROOT = unchecked((ushort)(-1));

        [NativeTypeName("#define HIDP_LINK_COLLECTION_UNSPECIFIED ((USHORT) 0)")]
        public const ushort HIDP_LINK_COLLECTION_UNSPECIFIED = ((ushort)(0));

        [NativeTypeName("#define HIDP_STATUS_SUCCESS (HIDP_ERROR_CODES(0x0,0))")]
        public const int HIDP_STATUS_SUCCESS = (((int)(((0x0) << 28) | (0x11 << 16) | (0))));

        [NativeTypeName("#define HIDP_STATUS_NULL (HIDP_ERROR_CODES(0x8,1))")]
        public const int HIDP_STATUS_NULL = (((int)(((0x8) << 28) | (0x11 << 16) | (1))));

        [NativeTypeName("#define HIDP_STATUS_INVALID_PREPARSED_DATA (HIDP_ERROR_CODES(0xC,1))")]
        public const int HIDP_STATUS_INVALID_PREPARSED_DATA = (((int)(((0xC) << 28) | (0x11 << 16) | (1))));

        [NativeTypeName("#define HIDP_STATUS_INVALID_REPORT_TYPE (HIDP_ERROR_CODES(0xC,2))")]
        public const int HIDP_STATUS_INVALID_REPORT_TYPE = (((int)(((0xC) << 28) | (0x11 << 16) | (2))));

        [NativeTypeName("#define HIDP_STATUS_INVALID_REPORT_LENGTH (HIDP_ERROR_CODES(0xC,3))")]
        public const int HIDP_STATUS_INVALID_REPORT_LENGTH = (((int)(((0xC) << 28) | (0x11 << 16) | (3))));

        [NativeTypeName("#define HIDP_STATUS_USAGE_NOT_FOUND (HIDP_ERROR_CODES(0xC,4))")]
        public const int HIDP_STATUS_USAGE_NOT_FOUND = (((int)(((0xC) << 28) | (0x11 << 16) | (4))));

        [NativeTypeName("#define HIDP_STATUS_VALUE_OUT_OF_RANGE (HIDP_ERROR_CODES(0xC,5))")]
        public const int HIDP_STATUS_VALUE_OUT_OF_RANGE = (((int)(((0xC) << 28) | (0x11 << 16) | (5))));

        [NativeTypeName("#define HIDP_STATUS_BAD_LOG_PHY_VALUES (HIDP_ERROR_CODES(0xC,6))")]
        public const int HIDP_STATUS_BAD_LOG_PHY_VALUES = (((int)(((0xC) << 28) | (0x11 << 16) | (6))));

        [NativeTypeName("#define HIDP_STATUS_BUFFER_TOO_SMALL (HIDP_ERROR_CODES(0xC,7))")]
        public const int HIDP_STATUS_BUFFER_TOO_SMALL = (((int)(((0xC) << 28) | (0x11 << 16) | (7))));

        [NativeTypeName("#define HIDP_STATUS_INTERNAL_ERROR (HIDP_ERROR_CODES(0xC,8))")]
        public const int HIDP_STATUS_INTERNAL_ERROR = (((int)(((0xC) << 28) | (0x11 << 16) | (8))));

        [NativeTypeName("#define HIDP_STATUS_I8042_TRANS_UNKNOWN (HIDP_ERROR_CODES(0xC,9))")]
        public const int HIDP_STATUS_I8042_TRANS_UNKNOWN = (((int)(((0xC) << 28) | (0x11 << 16) | (9))));

        [NativeTypeName("#define HIDP_STATUS_INCOMPATIBLE_REPORT_ID (HIDP_ERROR_CODES(0xC,0xA))")]
        public const int HIDP_STATUS_INCOMPATIBLE_REPORT_ID = (((int)(((0xC) << 28) | (0x11 << 16) | (0xA))));

        [NativeTypeName("#define HIDP_STATUS_NOT_VALUE_ARRAY (HIDP_ERROR_CODES(0xC,0xB))")]
        public const int HIDP_STATUS_NOT_VALUE_ARRAY = (((int)(((0xC) << 28) | (0x11 << 16) | (0xB))));

        [NativeTypeName("#define HIDP_STATUS_IS_VALUE_ARRAY (HIDP_ERROR_CODES(0xC,0xC))")]
        public const int HIDP_STATUS_IS_VALUE_ARRAY = (((int)(((0xC) << 28) | (0x11 << 16) | (0xC))));

        [NativeTypeName("#define HIDP_STATUS_DATA_INDEX_NOT_FOUND (HIDP_ERROR_CODES(0xC,0xD))")]
        public const int HIDP_STATUS_DATA_INDEX_NOT_FOUND = (((int)(((0xC) << 28) | (0x11 << 16) | (0xD))));

        [NativeTypeName("#define HIDP_STATUS_DATA_INDEX_OUT_OF_RANGE (HIDP_ERROR_CODES(0xC,0xE))")]
        public const int HIDP_STATUS_DATA_INDEX_OUT_OF_RANGE = (((int)(((0xC) << 28) | (0x11 << 16) | (0xE))));

        [NativeTypeName("#define HIDP_STATUS_BUTTON_NOT_PRESSED (HIDP_ERROR_CODES(0xC,0xF))")]
        public const int HIDP_STATUS_BUTTON_NOT_PRESSED = (((int)(((0xC) << 28) | (0x11 << 16) | (0xF))));

        [NativeTypeName("#define HIDP_STATUS_REPORT_DOES_NOT_EXIST (HIDP_ERROR_CODES(0xC,0x10))")]
        public const int HIDP_STATUS_REPORT_DOES_NOT_EXIST = (((int)(((0xC) << 28) | (0x11 << 16) | (0x10))));

        [NativeTypeName("#define HIDP_STATUS_NOT_IMPLEMENTED (HIDP_ERROR_CODES(0xC,0x20))")]
        public const int HIDP_STATUS_NOT_IMPLEMENTED = (((int)(((0xC) << 28) | (0x11 << 16) | (0x20))));

        [NativeTypeName("#define HIDP_STATUS_I8242_TRANS_UNKNOWN HIDP_STATUS_I8042_TRANS_UNKNOWN")]
        public const int HIDP_STATUS_I8242_TRANS_UNKNOWN = (((int)(((0xC) << 28) | (0x11 << 16) | (9))));
    }
}
