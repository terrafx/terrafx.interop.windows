// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetCaps"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetCaps(PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PHIDP_CAPS")] HIDP_CAPS* Capabilities);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetLinkCollectionNodes"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetLinkCollectionNodes([NativeTypeName("PHIDP_LINK_COLLECTION_NODE")] HIDP_LINK_COLLECTION_NODE* LinkCollectionNodes, [NativeTypeName("PULONG")] uint* LinkCollectionNodesLength, PHIDP_PREPARSED_DATA PreparsedData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetSpecificButtonCaps"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetSpecificButtonCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PHIDP_BUTTON_CAPS")] HIDP_BUTTON_CAPS* ButtonCaps, [NativeTypeName("PUSHORT")] ushort* ButtonCapsLength, PHIDP_PREPARSED_DATA PreparsedData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetButtonCaps"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetButtonCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_BUTTON_CAPS")] HIDP_BUTTON_CAPS* ButtonCaps, [NativeTypeName("PUSHORT")] ushort* ButtonCapsLength, PHIDP_PREPARSED_DATA PreparsedData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetSpecificValueCaps"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetSpecificValueCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PHIDP_VALUE_CAPS")] HIDP_VALUE_CAPS* ValueCaps, [NativeTypeName("PUSHORT")] ushort* ValueCapsLength, PHIDP_PREPARSED_DATA PreparsedData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetValueCaps"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetValueCaps(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_VALUE_CAPS")] HIDP_VALUE_CAPS* ValueCaps, [NativeTypeName("PUSHORT")] ushort* ValueCapsLength, PHIDP_PREPARSED_DATA PreparsedData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetExtendedAttributes"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetExtendedAttributes(HIDP_REPORT_TYPE ReportType, ushort DataIndex, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PHIDP_EXTENDED_ATTRIBUTES")] HIDP_EXTENDED_ATTRIBUTES* Attributes, [NativeTypeName("PULONG")] uint* LengthAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_InitializeReportForID"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_InitializeReportForID(HIDP_REPORT_TYPE ReportType, [NativeTypeName("UCHAR")] byte ReportID, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_SetData"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_SetData(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_DATA")] HIDP_DATA* DataList, [NativeTypeName("PULONG")] uint* DataLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetData"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetData(HIDP_REPORT_TYPE ReportType, [NativeTypeName("PHIDP_DATA")] HIDP_DATA* DataList, [NativeTypeName("PULONG")] uint* DataLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_MaxDataListLength"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HidP_MaxDataListLength(HIDP_REPORT_TYPE ReportType, PHIDP_PREPARSED_DATA PreparsedData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_SetUsages"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_SetUsages(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_UnsetUsages"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_UnsetUsages(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetUsages"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetUsages(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetUsagesEx"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetUsagesEx(HIDP_REPORT_TYPE ReportType, ushort LinkCollection, [NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* ButtonList, [NativeTypeName("ULONG *")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_MaxUsageListLength"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HidP_MaxUsageListLength(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, PHIDP_PREPARSED_DATA PreparsedData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_SetUsageValue"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_SetUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("ULONG")] uint UsageValue, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_SetScaledUsageValue"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_SetScaledUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("LONG")] int UsageValue, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_SetUsageValueArray"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_SetUsageValueArray(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PCHAR")] sbyte* UsageValue, ushort UsageValueByteLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetUsageValue"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PULONG")] uint* UsageValue, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetScaledUsageValue"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetScaledUsageValue(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PLONG")] int* UsageValue, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetUsageValueArray"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetUsageValueArray(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PCHAR")] sbyte* UsageValue, ushort UsageValueByteLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_UsageListDifference"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_UsageListDifference([NativeTypeName("PUSAGE")] ushort* PreviousUsageList, [NativeTypeName("PUSAGE")] ushort* CurrentUsageList, [NativeTypeName("PUSAGE")] ushort* BreakUsageList, [NativeTypeName("PUSAGE")] ushort* MakeUsageList, [NativeTypeName("ULONG")] uint UsageListLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetButtonArray"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_GetButtonArray(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PHIDP_BUTTON_ARRAY_DATA")] HIDP_BUTTON_ARRAY_DATA* ButtonData, [NativeTypeName("PUSHORT")] ushort* ButtonDataLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_SetButtonArray"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_SetButtonArray(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("USAGE")] ushort Usage, [NativeTypeName("PHIDP_BUTTON_ARRAY_DATA")] HIDP_BUTTON_ARRAY_DATA* ButtonData, ushort ButtonDataLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_TranslateUsagesToI8042ScanCodes"]/*' />
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int HidP_TranslateUsagesToI8042ScanCodes([NativeTypeName("PUSAGE")] ushort* ChangedUsageList, [NativeTypeName("ULONG")] uint UsageListLength, HIDP_KEYBOARD_DIRECTION KeyAction, [NativeTypeName("PHIDP_KEYBOARD_MODIFIER_STATE")] HIDP_KEYBOARD_MODIFIER_STATE* ModifierState, [NativeTypeName("PHIDP_INSERT_SCANCODES")] delegate* unmanaged<void*, sbyte*, uint, byte> InsertCodesProcedure, [NativeTypeName("PVOID")] void* InsertCodesContext);
}
