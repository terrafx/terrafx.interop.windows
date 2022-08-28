// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.FACILITY;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HidP_IsSameUsageAndPage(USAGE_AND_PAGE* u1, USAGE_AND_PAGE* u2) => *(uint*)u1 == *(uint*)u2;

    public static int HidP_SetButtons(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
        HidP_SetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

    public static int HidP_UnsetButtons(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
        HidP_UnsetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

    public static int HidP_GetButtons(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
        HidP_GetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

    public static int HidP_GetButtonsEx(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* ButtonList, [NativeTypeName("ULONG *")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
        HidP_GetUsagesEx(ReportType, LinkCollection, ButtonList, UsageLength, PreparsedData, Report, ReportLength);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int HIDP_ERROR_CODES(int sev, int code) => (sev << 28) | (FACILITY_HID_ERROR_CODE << 16) | code;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetVersion"]/*' />
    [return: NativeTypeName("NTSTATUS")]
    public static int HidP_GetVersion([NativeTypeName("ULONG *")] uint* Version)
    {
        int status = (((int)(((0x0) << 28) | (0x11 << 16) | (0))));

        *Version = 1;
        HMODULE module = (HMODULE)NativeLibrary.Load("hid.dll");

        if (module == HMODULE.NULL)
        {
            return (((int)(((0xC) << 28) | (0x11 << 16) | (8))));
        }

        ReadOnlySpan<sbyte> HidP_GetVersionInternal = new sbyte[] { 0x48, 0x69, 0x64, 0x50, 0x5F, 0x47, 0x65, 0x74, 0x56, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x49, 0x6E, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x00 };
        delegate* unmanaged<uint*, int> fnVersionInternal = (delegate* unmanaged<uint*, int>)(GetProcAddress(module, (sbyte*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(HidP_GetVersionInternal))));

        if (fnVersionInternal != null)
        {
            status = fnVersionInternal(Version);
        }
        else
        {
        }

        return status;
    }
}
