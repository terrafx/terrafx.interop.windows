// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/microsoft/DirectXShaderCompiler/blob/main/projects/dxilconv/include/DxbcConverter.h
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DxilConv
{
    /// <include file='DxilConv.xml' path='doc/member[@name="DxilConv.DxcCreateInstance"]/*' />
    [DllImport("dxilconv", ExactSpelling = true)]
    public static extern HRESULT DxcCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

    /// <include file='DxilConv.xml' path='doc/member[@name="DxilConv.DxcCreateInstance2"]/*' />
    [DllImport("dxilconv", ExactSpelling = true)]
    public static extern HRESULT DxcCreateInstance2(IMalloc* pMalloc, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
}
