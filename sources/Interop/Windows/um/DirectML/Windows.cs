// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const UINT")]
        public const uint DML_TENSOR_DIMENSION_COUNT_MAX = 5;

        [NativeTypeName("const UINT")]
        public const uint DML_TEMPORARY_BUFFER_ALIGNMENT = 256;

        [NativeTypeName("const UINT")]
        public const uint DML_PERSISTENT_BUFFER_ALIGNMENT = 256;

        [NativeTypeName("const UINT")]
        public const uint DML_MINIMUM_BUFFER_TENSOR_ALIGNMENT = 16;

        [DllImport("DirectML", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DMLCreateDevice([NativeTypeName("ID3D12Device *")] ID3D12Device* d3d12Device, DML_CREATE_DEVICE_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("DirectML", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DMLCreateDevice1([NativeTypeName("ID3D12Device *")] ID3D12Device* d3d12Device, DML_CREATE_DEVICE_FLAGS flags, DML_FEATURE_LEVEL minimumFeatureLevel, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        public static readonly Guid IID_IDMLObject = new Guid(0xC8263AAC, 0x9E0C, 0x4A2D, 0x9B, 0x8E, 0x00, 0x75, 0x21, 0xA3, 0x31, 0x7C);

        public static readonly Guid IID_IDMLDevice = new Guid(0x6DBD6437, 0x96FD, 0x423F, 0xA9, 0x8C, 0xAE, 0x5E, 0x7C, 0x2A, 0x57, 0x3F);

        public static readonly Guid IID_IDMLDeviceChild = new Guid(0x27E83142, 0x8165, 0x49E3, 0x97, 0x4E, 0x2F, 0xD6, 0x6E, 0x4C, 0xB6, 0x9D);

        public static readonly Guid IID_IDMLPageable = new Guid(0xB1AB0825, 0x4542, 0x4A4B, 0x86, 0x17, 0x6D, 0xDE, 0x6E, 0x8F, 0x62, 0x01);

        public static readonly Guid IID_IDMLOperator = new Guid(0x26CAAE7A, 0x3081, 0x4633, 0x95, 0x81, 0x22, 0x6F, 0xBE, 0x57, 0x69, 0x5D);

        public static readonly Guid IID_IDMLDispatchable = new Guid(0xDCB821A8, 0x1039, 0x441E, 0x9F, 0x1C, 0xB1, 0x75, 0x9C, 0x2F, 0x3C, 0xEC);

        public static readonly Guid IID_IDMLCompiledOperator = new Guid(0x6B15E56A, 0xBF5C, 0x4902, 0x92, 0xD8, 0xDA, 0x3A, 0x65, 0x0A, 0xFE, 0xA4);

        public static readonly Guid IID_IDMLOperatorInitializer = new Guid(0x427C1113, 0x435C, 0x469C, 0x86, 0x76, 0x4D, 0x5D, 0xD0, 0x72, 0xF8, 0x13);

        public static readonly Guid IID_IDMLBindingTable = new Guid(0x29C687DC, 0xDE74, 0x4E3B, 0xAB, 0x00, 0x11, 0x68, 0xF2, 0xFC, 0x3C, 0xFC);

        public static readonly Guid IID_IDMLCommandRecorder = new Guid(0xE6857A76, 0x2E3E, 0x4FDD, 0xBF, 0xF4, 0x5D, 0x2B, 0xA1, 0x0F, 0xB4, 0x53);

        public static readonly Guid IID_IDMLDebugDevice = new Guid(0x7D6F3AC9, 0x394A, 0x4AC3, 0x92, 0xA7, 0x39, 0x0C, 0xC5, 0x7A, 0x82, 0x17);
    }
}
