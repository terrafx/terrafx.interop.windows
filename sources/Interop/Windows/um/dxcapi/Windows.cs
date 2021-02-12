// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("dxcompiler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DxcCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("dxcompiler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DxcCreateInstance2([NativeTypeName("IMalloc *")] IMalloc* pMalloc, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [NativeTypeName("const UINT32")]
        public const uint DxcValidatorFlags_Default = 0;

        [NativeTypeName("const UINT32")]
        public const uint DxcValidatorFlags_InPlaceEdit = 1;

        [NativeTypeName("const UINT32")]
        public const uint DxcValidatorFlags_RootSignatureOnly = 2;

        [NativeTypeName("const UINT32")]
        public const uint DxcValidatorFlags_ModuleOnly = 4;

        [NativeTypeName("const UINT32")]
        public const uint DxcValidatorFlags_ValidMask = 0x7;

        [NativeTypeName("const UINT32")]
        public const uint DxcVersionInfoFlags_None = 0;

        [NativeTypeName("const UINT32")]
        public const uint DxcVersionInfoFlags_Debug = 1;

        [NativeTypeName("const UINT32")]
        public const uint DxcVersionInfoFlags_Internal = 2;

        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_DxcCompiler = new Guid(0x73e22d93, 0xe6ce, 0x47f3, 0xb5, 0xbf, 0xf0, 0x66, 0x4f, 0x39, 0xc1, 0xb0);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcLinker = new Guid(0xef6a8087, 0xb0ea, 0x4d56, 0x9e, 0x45, 0xd0, 0x7e, 0x1a, 0x8b, 0x78, 0x6);

        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_DxcDiaDataSource = new Guid(0xcd1f6b73, 0x2ab0, 0x484d, 0x8e, 0xdc, 0xeb, 0xe7, 0xa4, 0x3c, 0xa0, 0x9f);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcLibrary = new Guid(0x6245d6af, 0x66e0, 0x48fd, 0x80, 0xb4, 0x4d, 0x27, 0x17, 0x96, 0x74, 0x8c);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcValidator = new Guid(0x8ca3e215, 0xf728, 0x4cf3, 0x8c, 0xdd, 0x88, 0xaf, 0x91, 0x75, 0x87, 0xa1);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcAssembler = new Guid(0xd728db68, 0xf903, 0x4f80, 0x94, 0xcd, 0xdc, 0xcf, 0x76, 0xec, 0x71, 0x51);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcContainerReflection = new Guid(0xb9f54489, 0x55b8, 0x400c, 0xba, 0x3a, 0x16, 0x75, 0xe4, 0x72, 0x8b, 0x91);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcOptimizer = new Guid(0xae2cd79f, 0xcc22, 0x453f, 0x9b, 0x6b, 0xb1, 0x24, 0xe7, 0xa5, 0x20, 0x4c);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcContainerBuilder = new Guid(0x94134294, 0x411f, 0x4574, 0xb4, 0xd0, 0x87, 0x41, 0xe2, 0x52, 0x40, 0xd2);

        public static readonly Guid IID_IDxcBlob = new Guid(0x8BA5FB08, 0x5195, 0x40E2, 0xAC, 0x58, 0x0D, 0x98, 0x9C, 0x3A, 0x01, 0x02);

        public static readonly Guid IID_IDxcBlobEncoding = new Guid(0x7241D424, 0x2646, 0x4191, 0x97, 0xC0, 0x98, 0xE9, 0x6E, 0x42, 0xFC, 0x68);

        public static readonly Guid IID_IDxcLibrary = new Guid(0xE5204DC7, 0xD18C, 0x4C3C, 0xBD, 0xFB, 0x85, 0x16, 0x73, 0x98, 0x0F, 0xE7);

        public static readonly Guid IID_IDxcOperationResult = new Guid(0xCEDB484A, 0xD4E9, 0x445A, 0xB9, 0x91, 0xCA, 0x21, 0xCA, 0x15, 0x7D, 0xC2);

        public static readonly Guid IID_IDxcIncludeHandler = new Guid(0x7F61FC7D, 0x950D, 0x467F, 0xB3, 0xE3, 0x3C, 0x02, 0xFB, 0x49, 0x18, 0x7C);

        public static readonly Guid IID_IDxcCompiler = new Guid(0x8C210BF3, 0x011F, 0x4422, 0x8D, 0x70, 0x6F, 0x9A, 0xCB, 0x8D, 0xB6, 0x17);

        public static readonly Guid IID_IDxcCompiler2 = new Guid(0xA005A9D9, 0xB8BB, 0x4594, 0xB5, 0xC9, 0x0E, 0x63, 0x3B, 0xEC, 0x4D, 0x37);

        public static readonly Guid IID_IDxcLinker = new Guid(0xF1B5BE2A, 0x62DD, 0x4327, 0xA1, 0xC2, 0x42, 0xAC, 0x1E, 0x1E, 0x78, 0xE6);

        public static readonly Guid IID_IDxcValidator = new Guid(0xA6E82BD2, 0x1FD7, 0x4826, 0x98, 0x11, 0x28, 0x57, 0xE7, 0x97, 0xF4, 0x9A);

        public static readonly Guid IID_IDxcContainerBuilder = new Guid(0x334B1F50, 0x2292, 0x4B35, 0x99, 0xA1, 0x25, 0x58, 0x8D, 0x8C, 0x17, 0xFE);

        public static readonly Guid IID_IDxcAssembler = new Guid(0x091F7A26, 0x1C1F, 0x4948, 0x90, 0x4B, 0xE6, 0xE3, 0xA8, 0xA7, 0x71, 0xD5);

        public static readonly Guid IID_IDxcContainerReflection = new Guid(0xD2C21B26, 0x8350, 0x4BDC, 0x97, 0x6A, 0x33, 0x1C, 0xE6, 0xF4, 0xC5, 0x4C);

        public static readonly Guid IID_IDxcOptimizerPass = new Guid(0xAE2CD79F, 0xCC22, 0x453F, 0x9B, 0x6B, 0xB1, 0x24, 0xE7, 0xA5, 0x20, 0x4C);

        public static readonly Guid IID_IDxcOptimizer = new Guid(0x25740E2E, 0x9CBA, 0x401B, 0x91, 0x19, 0x4F, 0xB4, 0x2F, 0x39, 0xF2, 0x70);

        public static readonly Guid IID_IDxcVersionInfo = new Guid(0xB04F5B50, 0x2059, 0x4F12, 0xA8, 0xFF, 0xA1, 0xE0, 0xCD, 0xE1, 0xCC, 0x7E);

        public static readonly Guid IID_IDxcVersionInfo2 = new Guid(0xFB6904C4, 0x42F0, 0x4B62, 0x9C, 0x46, 0x98, 0x3A, 0xF7, 0xDA, 0x7C, 0x83);
    }
}
