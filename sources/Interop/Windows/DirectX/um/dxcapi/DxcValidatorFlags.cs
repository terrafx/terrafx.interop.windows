// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

namespace TerraFX.Interop.DirectX;

public static partial class DxcValidatorFlags
{
    /// <include file='DxcValidatorFlags.xml' path='doc/member[@name="DxcValidatorFlags.DxcValidatorFlags_Default"]/*' />
    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_Default = 0;

    /// <include file='DxcValidatorFlags.xml' path='doc/member[@name="DxcValidatorFlags.DxcValidatorFlags_InPlaceEdit"]/*' />
    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_InPlaceEdit = 1;

    /// <include file='DxcValidatorFlags.xml' path='doc/member[@name="DxcValidatorFlags.DxcValidatorFlags_RootSignatureOnly"]/*' />
    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_RootSignatureOnly = 2;

    /// <include file='DxcValidatorFlags.xml' path='doc/member[@name="DxcValidatorFlags.DxcValidatorFlags_ModuleOnly"]/*' />
    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_ModuleOnly = 4;

    /// <include file='DxcValidatorFlags.xml' path='doc/member[@name="DxcValidatorFlags.DxcValidatorFlags_ValidMask"]/*' />
    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_ValidMask = 0x7;
}
