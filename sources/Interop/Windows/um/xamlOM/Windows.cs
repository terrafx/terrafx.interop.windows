// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Windows.UI.Xaml.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int InitializeXamlDiagnosticsEx([NativeTypeName("LPCWSTR")] ushort* endPointName, [NativeTypeName("DWORD")] uint pid, [NativeTypeName("LPCWSTR")] ushort* wszDllXamlDiagnostics, [NativeTypeName("LPCWSTR")] ushort* wszTAPDllName, [NativeTypeName("CLSID")] Guid tapClsid, [NativeTypeName("LPCWSTR")] ushort* wszInitializationData);

        [NativeTypeName("#define E_UNKNOWNTYPE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_XAML, 40L)")]
        public const int E_UNKNOWNTYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(43) << 16) | ((uint)(40))));

        public static readonly Guid IID_IVisualTreeServiceCallback = new Guid(0xAA7A8931, 0x80E4, 0x4FEC, 0x8F, 0x3B, 0x55, 0x3F, 0x87, 0xB4, 0x96, 0x6E);

        public static readonly Guid IID_IVisualTreeServiceCallback2 = new Guid(0xBAD9EB88, 0xAE77, 0x4397, 0xB9, 0x48, 0x5F, 0xA2, 0xDB, 0x0A, 0x19, 0xEA);

        public static readonly Guid IID_IVisualTreeService = new Guid(0xA593B11A, 0xD17F, 0x48BB, 0x8F, 0x66, 0x83, 0x91, 0x07, 0x31, 0xC8, 0xA5);

        public static readonly Guid IID_IXamlDiagnostics = new Guid(0x18C9E2B6, 0x3F43, 0x4116, 0x9F, 0x2B, 0xFF, 0x93, 0x5D, 0x77, 0x70, 0xD2);

        public static readonly Guid IID_IBitmapData = new Guid(0xD1A34EF2, 0xCAD8, 0x4635, 0xA3, 0xD2, 0xFC, 0xDA, 0x8D, 0x3F, 0x3C, 0xAF);

        public static readonly Guid IID_IVisualTreeService2 = new Guid(0x130F5136, 0xEC43, 0x4F61, 0x89, 0xC7, 0x98, 0x01, 0xA3, 0x6D, 0x2E, 0x95);

        public static readonly Guid IID_IVisualTreeService3 = new Guid(0x0E79C6E0, 0x85A0, 0x4BE8, 0xB4, 0x1A, 0x65, 0x5C, 0xF1, 0xFD, 0x19, 0xBD);
    }
}
