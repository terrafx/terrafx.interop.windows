// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Hid
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetCaps", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetCaps([NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PHIDP_CAPS")] HIDP_CAPS* Capabilities);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetLinkCollectionNodes", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetLinkCollectionNodes([NativeTypeName("PHIDP_LINK_COLLECTION_NODE")] HIDP_LINK_COLLECTION_NODE* LinkCollectionNodes, [NativeTypeName("PULONG")] uint* LinkCollectionNodesLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetSpecificButtonCaps", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetSpecificButtonCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PHIDP_BUTTON_CAPS")] HIDP_BUTTON_CAPS* ButtonCaps, [NativeTypeName("PUSHORT")] ushort* ButtonCapsLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetButtonCaps", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetButtonCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_BUTTON_CAPS")] HIDP_BUTTON_CAPS* ButtonCaps, [NativeTypeName("PUSHORT")] ushort* ButtonCapsLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetSpecificValueCaps", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetSpecificValueCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PHIDP_VALUE_CAPS")] HIDP_VALUE_CAPS* ValueCaps, [NativeTypeName("PUSHORT")] ushort* ValueCapsLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetValueCaps", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetValueCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_VALUE_CAPS")] HIDP_VALUE_CAPS* ValueCaps, [NativeTypeName("PUSHORT")] ushort* ValueCapsLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetExtendedAttributes", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetExtendedAttributes(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USHORT")] ushort DataIndex, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PHIDP_EXTENDED_ATTRIBUTES")] HIDP_EXTENDED_ATTRIBUTES* Attributes, [NativeTypeName("PULONG")] uint* LengthAttributes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_InitializeReportForID", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_InitializeReportForID(HIDP_REPORT_TYPE ReportType, [NativeTypeName("UCHAR")] byte ReportID, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_SetData", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_SetData(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_DATA")] HIDP_DATA* DataList, [NativeTypeName("PULONG")] uint* DataLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetData", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetData(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_DATA")] HIDP_DATA* DataList, [NativeTypeName("PULONG")] uint* DataLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_MaxDataListLength", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint HidP_MaxDataListLength(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_SetUsages", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_SetUsages(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_UnsetUsages", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_UnsetUsages(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetUsages", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetUsages(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetUsagesEx", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetUsagesEx(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* ButtonList, [NativeTypeName("ULONG *")] uint* UsageLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_MaxUsageListLength", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint HidP_MaxUsageListLength(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_SetUsageValue", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_SetUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("ULONG")] uint UsageValue, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_SetScaledUsageValue", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_SetScaledUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("LONG")] int UsageValue, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_SetUsageValueArray", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_SetUsageValueArray(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PCHAR")] sbyte* UsageValue, [NativeTypeName("USHORT")] ushort UsageValueByteLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetUsageValue", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PULONG")] uint* UsageValue, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetScaledUsageValue", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetScaledUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PLONG")] int* UsageValue, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_GetUsageValueArray", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_GetUsageValueArray(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PCHAR")] sbyte* UsageValue, [NativeTypeName("USHORT")] ushort UsageValueByteLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] HIDP_PREPARSED_DATA* PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_UsageListDifference", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_UsageListDifference([NativeTypeName("PUSAGE")] ushort* PreviousUsageList, [NativeTypeName("PUSAGE")] ushort* CurrentUsageList, [NativeTypeName("PUSAGE")] ushort* BreakUsageList, [NativeTypeName("PUSAGE")] ushort* MakeUsageList, [NativeTypeName("ULONG")] uint UsageListLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_UsageAndPageListDifference", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_UsageAndPageListDifference([NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* PreviousUsageList, [NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* CurrentUsageList, [NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* BreakUsageList, [NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* MakeUsageList, [NativeTypeName("ULONG")] uint UsageListLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_TranslateUsageAndPagesToI8042ScanCodes", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_TranslateUsageAndPagesToI8042ScanCodes([NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* ChangedUsageList, [NativeTypeName("ULONG")] uint UsageListLength, HIDP_KEYBOARD_DIRECTION KeyAction, [NativeTypeName("PHIDP_KEYBOARD_MODIFIER_STATE")] HIDP_KEYBOARD_MODIFIER_STATE* ModifierState, [NativeTypeName("PHIDP_INSERT_SCANCODES")] IntPtr* InsertCodesProcedure, [NativeTypeName("PVOID")] void* InsertCodesContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidP_TranslateUsagesToI8042ScanCodes", ExactSpelling = true)]
        [return: NativeTypeName("NTSTATUS")]
        public static extern int HidP_TranslateUsagesToI8042ScanCodes([NativeTypeName("PUSAGE")] ushort* ChangedUsageList, [NativeTypeName("ULONG")] uint UsageListLength, HIDP_KEYBOARD_DIRECTION KeyAction, [NativeTypeName("PHIDP_KEYBOARD_MODIFIER_STATE")] HIDP_KEYBOARD_MODIFIER_STATE* ModifierState, [NativeTypeName("PHIDP_INSERT_SCANCODES")] IntPtr* InsertCodesProcedure, [NativeTypeName("PVOID")] void* InsertCodesContext);
    }
}
