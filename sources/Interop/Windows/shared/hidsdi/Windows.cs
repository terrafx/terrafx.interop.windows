// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidsdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetAttributes([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PHIDD_ATTRIBUTES")] HIDD_ATTRIBUTES* Attributes);

        [DllImport("hid", ExactSpelling = true)]
        public static extern void HidD_GetHidGuid([NativeTypeName("LPGUID")] Guid* HidGuid);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetPreparsedData([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PHIDP_PREPARSED_DATA *")] IntPtr* PreparsedData);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_FreePreparsedData([NativeTypeName("PHIDP_PREPARSED_DATA")] IntPtr PreparsedData);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_FlushQueue([NativeTypeName("HANDLE")] IntPtr HidDeviceObject);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetConfiguration([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PHIDD_CONFIGURATION")] HIDD_CONFIGURATION* Configuration, [NativeTypeName("ULONG")] uint ConfigurationLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_SetConfiguration([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PHIDD_CONFIGURATION")] HIDD_CONFIGURATION* Configuration, [NativeTypeName("ULONG")] uint ConfigurationLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetFeature([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_SetFeature([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetInputReport([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_SetOutputReport([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetNumInputBuffers([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PULONG")] uint* NumberBuffers);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_SetNumInputBuffers([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("ULONG")] uint NumberBuffers);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetPhysicalDescriptor([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetManufacturerString([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetProductString([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetIndexedString([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("ULONG")] uint StringIndex, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetSerialNumberString([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);

        [DllImport("hid", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetMsGenreDescriptor([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);
    }
}
