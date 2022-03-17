// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS"]/*' />
[Flags]
public enum D3D_SHADER_CBUFFER_FLAGS
{
    /// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS.D3D_CBF_USERPACKED"]/*' />
    D3D_CBF_USERPACKED = 1,

    /// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS.D3D10_CBF_USERPACKED"]/*' />
    D3D10_CBF_USERPACKED = D3D_CBF_USERPACKED,

    /// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS.D3D_CBF_FORCE_DWORD"]/*' />
    D3D_CBF_FORCE_DWORD = 0x7fffffff,
}
