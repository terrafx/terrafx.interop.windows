// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectXShaderCompiler, include/dxc/dxcapi.h, at commit d356a8bc546da38612cac13d1e643de17a0ba38f
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class DXC
    {
        private const string LibraryPath = "DXC";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "DxcCreateInstance", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DxcCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "DxcCreateInstance2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DxcCreateInstance2([NativeTypeName("IMalloc *")] IMalloc* pMalloc, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        // [NativeTypeName("const UINT32")]
        // public static extern uint DxcValidatorFlags_Default;

        // [NativeTypeName("const UINT32")]
        // public static extern uint DxcValidatorFlags_InPlaceEdit;

        // [NativeTypeName("const UINT32")]
        // public static extern uint DxcValidatorFlags_RootSignatureOnly;

        // [NativeTypeName("const UINT32")]
        // public static extern uint DxcValidatorFlags_ModuleOnly;

        // [NativeTypeName("const UINT32")]
        // public static extern uint DxcValidatorFlags_ValidMask;

        // [NativeTypeName("const UINT32")]
        // public static extern uint D3D_SIT_RTACCELERATIONSTRUCTURE;

        // [NativeTypeName("const UINT32")]
        // public static extern uint DxcVersionInfoFlags_None;

        // [NativeTypeName("const UINT32")]
        // public static extern uint DxcVersionInfoFlags_Debug;

        // [NativeTypeName("const UINT32")]
        // public static extern uint DxcVersionInfoFlags_Internal;

        // [NativeTypeName("const CLSID")]
        // public static extern Guid CLSID_DxcCompiler;

        // [NativeTypeName("const GUID")]
        // public static extern Guid CLSID_DxcLinker;

        // [NativeTypeName("const CLSID")]
        // public static extern Guid CLSID_DxcDiaDataSource;

        // [NativeTypeName("const GUID")]
        // public static extern Guid CLSID_DxcLibrary;

        // [NativeTypeName("const GUID")]
        // public static extern Guid CLSID_DxcValidator;

        // [NativeTypeName("const GUID")]
        // public static extern Guid CLSID_DxcAssembler;

        // [NativeTypeName("const GUID")]
        // public static extern Guid CLSID_DxcContainerReflection;

        // [NativeTypeName("const GUID")]
        // public static extern Guid CLSID_DxcOptimizer;

        // [NativeTypeName("const GUID")]
        // public static extern Guid CLSID_DxcContainerBuilder;
    }
}
