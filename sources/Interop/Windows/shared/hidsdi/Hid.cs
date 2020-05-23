// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidsdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Hid
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetAttributes", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetAttributes([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PHIDD_ATTRIBUTES")] HIDD_ATTRIBUTES* Attributes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetHidGuid", ExactSpelling = true)]
        public static extern void HidD_GetHidGuid([NativeTypeName("LPGUID")] Guid* HidGuid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetPreparsedData", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetPreparsedData([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PHIDP_PREPARSED_DATA *")] IntPtr* PreparsedData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_FreePreparsedData", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_FreePreparsedData([NativeTypeName("PHIDP_PREPARSED_DATA")] IntPtr PreparsedData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_FlushQueue", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_FlushQueue([NativeTypeName("HANDLE")] IntPtr HidDeviceObject);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetConfiguration", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetConfiguration([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PHIDD_CONFIGURATION")] HIDD_CONFIGURATION* Configuration, [NativeTypeName("ULONG")] uint ConfigurationLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_SetConfiguration", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_SetConfiguration([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PHIDD_CONFIGURATION")] HIDD_CONFIGURATION* Configuration, [NativeTypeName("ULONG")] uint ConfigurationLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetFeature", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetFeature([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_SetFeature", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_SetFeature([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetInputReport", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetInputReport([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_SetOutputReport", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_SetOutputReport([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetNumInputBuffers", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetNumInputBuffers([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PULONG")] uint* NumberBuffers);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_SetNumInputBuffers", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_SetNumInputBuffers([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("ULONG")] uint NumberBuffers);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetPhysicalDescriptor", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetPhysicalDescriptor([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetManufacturerString", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetManufacturerString([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetProductString", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetProductString([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetIndexedString", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetIndexedString([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("ULONG")] uint StringIndex, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetSerialNumberString", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetSerialNumberString([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "HidD_GetMsGenreDescriptor", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte HidD_GetMsGenreDescriptor([NativeTypeName("HANDLE")] IntPtr HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);
    }
}
