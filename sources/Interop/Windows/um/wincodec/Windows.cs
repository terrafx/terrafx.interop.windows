// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("WindowsCodecs", EntryPoint = "WICConvertBitmapSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICConvertBitmapSource([NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pISrc, [NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppIDst);

        [DllImport("WindowsCodecs", EntryPoint = "WICCreateBitmapFromSection", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICCreateBitmapFromSection([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("HANDLE")] IntPtr hSection, [NativeTypeName("UINT")] uint stride, [NativeTypeName("UINT")] uint offset, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap);

        [DllImport("WindowsCodecs", EntryPoint = "WICCreateBitmapFromSectionEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICCreateBitmapFromSectionEx([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("HANDLE")] IntPtr hSection, [NativeTypeName("UINT")] uint stride, [NativeTypeName("UINT")] uint offset, WICSectionAccessLevel desiredAccessLevel, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap);

        [DllImport("WindowsCodecs", EntryPoint = "WICMapGuidToShortName", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMapGuidToShortName([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint cchName, [NativeTypeName("WCHAR *")] ushort* wzName, [NativeTypeName("UINT *")] uint* pcchActual);

        [DllImport("WindowsCodecs", EntryPoint = "WICMapShortNameToGuid", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMapShortNameToGuid([NativeTypeName("PCWSTR")] ushort* wzName, [NativeTypeName("GUID *")] Guid* pguid);

        [DllImport("WindowsCodecs", EntryPoint = "WICMapSchemaToName", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMapSchemaToName([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("LPWSTR")] ushort* pwzSchema, [NativeTypeName("UINT")] uint cchName, [NativeTypeName("WCHAR *")] ushort* wzName, [NativeTypeName("UINT *")] uint* pcchActual);

        [DllImport("WindowsCodecs", EntryPoint = "BSTR_UserSize", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint BSTR_UserSize([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned long")] uint param1, [NativeTypeName("BSTR *")] ushort** param2);

        [DllImport("WindowsCodecs", EntryPoint = "BSTR_UserMarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* BSTR_UserMarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("BSTR *")] ushort** param2);

        [DllImport("WindowsCodecs", EntryPoint = "BSTR_UserUnmarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* BSTR_UserUnmarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("BSTR *")] ushort** param2);

        [DllImport("WindowsCodecs", EntryPoint = "BSTR_UserFree", ExactSpelling = true)]
        public static extern void BSTR_UserFree([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("BSTR *")] ushort** param1);

        [DllImport("WindowsCodecs", EntryPoint = "HBITMAP_UserSize", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint HBITMAP_UserSize([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned long")] uint param1, [NativeTypeName("HBITMAP *")] IntPtr* param2);

        [DllImport("WindowsCodecs", EntryPoint = "HBITMAP_UserMarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* HBITMAP_UserMarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("HBITMAP *")] IntPtr* param2);

        [DllImport("WindowsCodecs", EntryPoint = "HBITMAP_UserUnmarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* HBITMAP_UserUnmarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("HBITMAP *")] IntPtr* param2);

        [DllImport("WindowsCodecs", EntryPoint = "HBITMAP_UserFree", ExactSpelling = true)]
        public static extern void HBITMAP_UserFree([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("HBITMAP *")] IntPtr* param1);

        [DllImport("WindowsCodecs", EntryPoint = "HICON_UserSize", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint HICON_UserSize([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned long")] uint param1, [NativeTypeName("HICON *")] IntPtr* param2);

        [DllImport("WindowsCodecs", EntryPoint = "HICON_UserMarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* HICON_UserMarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("HICON *")] IntPtr* param2);

        [DllImport("WindowsCodecs", EntryPoint = "HICON_UserUnmarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* HICON_UserUnmarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("HICON *")] IntPtr* param2);

        [DllImport("WindowsCodecs", EntryPoint = "HICON_UserFree", ExactSpelling = true)]
        public static extern void HICON_UserFree([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("HICON *")] IntPtr* param1);

        [DllImport("WindowsCodecs", EntryPoint = "HPALETTE_UserSize", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint HPALETTE_UserSize([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned long")] uint param1, [NativeTypeName("HPALETTE *")] IntPtr* param2);

        [DllImport("WindowsCodecs", EntryPoint = "HPALETTE_UserMarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* HPALETTE_UserMarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("HPALETTE *")] IntPtr* param2);

        [DllImport("WindowsCodecs", EntryPoint = "HPALETTE_UserUnmarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* HPALETTE_UserUnmarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("HPALETTE *")] IntPtr* param2);

        [DllImport("WindowsCodecs", EntryPoint = "HPALETTE_UserFree", ExactSpelling = true)]
        public static extern void HPALETTE_UserFree([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("HPALETTE *")] IntPtr* param1);

        [DllImport("WindowsCodecs", EntryPoint = "LPSAFEARRAY_UserSize", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint LPSAFEARRAY_UserSize([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned long")] uint param1, [NativeTypeName("LPSAFEARRAY *")] SAFEARRAY** param2);

        [DllImport("WindowsCodecs", EntryPoint = "LPSAFEARRAY_UserMarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* LPSAFEARRAY_UserMarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("LPSAFEARRAY *")] SAFEARRAY** param2);

        [DllImport("WindowsCodecs", EntryPoint = "LPSAFEARRAY_UserUnmarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* LPSAFEARRAY_UserUnmarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("LPSAFEARRAY *")] SAFEARRAY** param2);

        [DllImport("WindowsCodecs", EntryPoint = "LPSAFEARRAY_UserFree", ExactSpelling = true)]
        public static extern void LPSAFEARRAY_UserFree([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("LPSAFEARRAY *")] SAFEARRAY** param1);

        [DllImport("WindowsCodecs", EntryPoint = "WICInProcPointer_UserSize", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint WICInProcPointer_UserSize([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned long")] uint param1, [NativeTypeName("WICInProcPointer *")] byte** param2);

        [DllImport("WindowsCodecs", EntryPoint = "WICInProcPointer_UserMarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* WICInProcPointer_UserMarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("WICInProcPointer *")] byte** param2);

        [DllImport("WindowsCodecs", EntryPoint = "WICInProcPointer_UserUnmarshal", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* WICInProcPointer_UserUnmarshal([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("WICInProcPointer *")] byte** param2);

        [DllImport("WindowsCodecs", EntryPoint = "WICInProcPointer_UserFree", ExactSpelling = true)]
        public static extern void WICInProcPointer_UserFree([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("WICInProcPointer *")] byte** param1);
    }
}
