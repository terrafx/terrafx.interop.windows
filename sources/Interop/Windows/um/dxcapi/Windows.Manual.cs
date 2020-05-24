using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const UINT32")]
        public static readonly uint DxcValidatorFlags_Default = 0;

        [NativeTypeName("const UINT32")]
        public static readonly uint DxcValidatorFlags_InPlaceEdit = 1;

        [NativeTypeName("const UINT32")]
        public static readonly uint DxcValidatorFlags_RootSignatureOnly = 2;

        [NativeTypeName("const UINT32")]
        public static readonly uint DxcValidatorFlags_ModuleOnly = 4;

        [NativeTypeName("const UINT32")]
        public static readonly uint DxcValidatorFlags_ValidMask = 0x7;

        [NativeTypeName("const UINT32")]
        public static readonly uint DxcVersionInfoFlags_None = 0;

        [NativeTypeName("const UINT32")]
        public static readonly uint DxcVersionInfoFlags_Debug = 1;

        [NativeTypeName("const UINT32")]
        public static readonly uint DxcVersionInfoFlags_Internal = 2;

        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_DxcCompiler = new Guid(0xef6a8087, 0xb0ea, 0x4d56, 0x9e, 0x45, 0xd0, 0x7e, 0x1a, 0x8b, 0x78, 0x6);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcLinker = new Guid(0xcd1f6b73, 0x2ab0, 0x484d, 0x8e, 0xdc, 0xeb, 0xe7, 0xa4, 0x3c, 0xa0, 0x9f);

        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_DxcDiaDataSource = new Guid(0x3e56ae82, 0x224d, 0x470f, 0xa1, 0xa1, 0xfe, 0x30, 0x16, 0xee, 0x9f, 0x9d);

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
    }
}