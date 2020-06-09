// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
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
        public static readonly Guid CLSID_DxcCompiler = new Guid(0X73E22D93, 0XE6CE, 0X47F3, 0XB5, 0XBF, 0XF0, 0X66, 0X4F, 0X39, 0XC1, 0XB0);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcLinker = new Guid(0XEF6A8087, 0XB0EA, 0X4D56, 0X9E, 0X45, 0XD0, 0X7E, 0X1A, 0X8B, 0X78, 0X6);

        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_DxcDiaDataSource = new Guid(0XCD1F6B73, 0X2AB0, 0X484D, 0X8E, 0XDC, 0XEB, 0XE7, 0XA4, 0X3C, 0XA0, 0X9F);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcValidator = new Guid(0X8CA3E215, 0XF728, 0X4CF3, 0X8C, 0XDD, 0X88, 0XAF, 0X91, 0X75, 0X87, 0XA1);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcAssembler = new Guid(0XD728DB68, 0XF903, 0X4F80, 0X94, 0XCD, 0XDC, 0XCF, 0X76, 0XEC, 0X71, 0X51);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcContainerReflection = new Guid(0XB9F54489, 0X55B8, 0X400C, 0XBA, 0X3A, 0X16, 0X75, 0XE4, 0X72, 0X8B, 0X91);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcOptimizer = new Guid(0XAE2CD79F, 0XCC22, 0X453F, 0X9B, 0X6B, 0XB1, 0X24, 0XE7, 0XA5, 0X20, 0X4C);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcContainerBuilder = new Guid(0X94134294, 0X411F, 0X4574, 0XB4, 0XD0, 0X87, 0X41, 0XE2, 0X52, 0X40, 0XD2);

        public static readonly Guid IID_IDxcAssembly = new Guid(0X091F7A26, 0X1C1F, 0X4948, 0X90, 0X4B, 0XE6, 0XE3, 0XA8, 0XA7, 0X71, 0XD5);

        public static readonly Guid IID_IDxcBlob = new Guid(0X8BA5FB08, 0X5195, 0X40E2, 0XAC, 0X58, 0X0D, 0X98, 0X9C, 0X3A, 0X01, 0X02);

        public static readonly Guid IID_IDxcBlobEncoding = new Guid(0X7241D424, 0X2646, 0X4191, 0X97, 0XC0, 0X98, 0XE9, 0X6E, 0X42, 0XFC, 0X68);

        public static readonly Guid IID_IDxcIncludeHandler = new Guid(0X7F61FC7D, 0X950D, 0X467F, 0XB3, 0XE3, 0X3C, 0X02, 0XFB, 0X49, 0X18, 0X7C);

        public static readonly Guid IID_IDxcLibrary = new Guid(0XE5204DC7, 0XD18C, 0X4C3C, 0XBD, 0XFB, 0X85, 0X16, 0X73, 0X98, 0X0F, 0XE7);

        public static readonly Guid IID_IDxcOperationResult = new Guid(0XCEDB484A, 0XD4E9, 0X445A, 0XB9, 0X91, 0XCA, 0X21, 0XCA, 0X15, 0X7D, 0XC2);

        public static readonly Guid IID_IDxcCompiler = new Guid(0X8C210BF3, 0X011F, 0X4422, 0X8D, 0X70, 0X6F, 0X9A, 0XCB, 0X8D, 0XB6, 0X17);

        public static readonly Guid IID_IDxcCompiler2 = new Guid(0XA005A9D9, 0XB8BB, 0X4594, 0XB5, 0XC9, 0X0E, 0X63, 0X3B, 0XEC, 0X4D, 0X37);

        public static readonly Guid IID_IDxcLinker = new Guid(0XF1B5BE2A, 0X62DD, 0X4327, 0XA1, 0XC2, 0X42, 0XAC, 0X1E, 0X1E, 0X78, 0XE6);

        public static readonly Guid IID_IDxcValidator = new Guid(0XA6E82BD2, 0X1FD7, 0X4826, 0X98, 0X11, 0X28, 0X57, 0XE7, 0X97, 0XF4, 0X9A);

        public static readonly Guid IID_IDxcContainerBuilder = new Guid(0X334B1F50, 0X2292, 0X4B35, 0X99, 0XA1, 0X25, 0X58, 0X8D, 0X8C, 0X17, 0XFE);

        public static readonly Guid IID_IDxcAssembler = new Guid(0X091F7A26, 0X1C1F, 0X4948, 0X90, 0X4B, 0XE6, 0XE3, 0XA8, 0XA7, 0X71, 0XD5);

        public static readonly Guid IID_IDxcContainerReflection = new Guid(0XD2C21B26, 0X8350, 0X4BDC, 0X97, 0X6A, 0X33, 0X1C, 0XE6, 0XF4, 0XC5, 0X4C);

        public static readonly Guid IID_IDxcOptimizerPass = new Guid(0XAE2CD79F, 0XCC22, 0X453F, 0X9B, 0X6B, 0XB1, 0X24, 0XE7, 0XA5, 0X20, 0X4C);

        public static readonly Guid IID_IDxcOptimizer = new Guid(0X25740E2E, 0X9CBA, 0X401B, 0X91, 0X19, 0X4F, 0XB4, 0X2F, 0X39, 0XF2, 0X70);

        public static readonly Guid IID_IDxcVersionInfo = new Guid(0XB04F5B50, 0X2059, 0X4F12, 0XA8, 0XFF, 0XA1, 0XE0, 0XCD, 0XE1, 0XCC, 0X7E);

        public static readonly Guid IID_IDxcVersionInfo2 = new Guid(0XFB6904C4, 0X42F0, 0X4B62, 0X9C, 0X46, 0X98, 0X3A, 0XF7, 0XDA, 0X7C, 0X83);
    }
}
