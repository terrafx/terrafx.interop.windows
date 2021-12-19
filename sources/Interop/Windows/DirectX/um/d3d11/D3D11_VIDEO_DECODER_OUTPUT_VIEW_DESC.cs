// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC
{
    /// <include file='D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.DecodeProfile"]/*' />
    public Guid DecodeProfile;

    /// <include file='D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.ViewDimension"]/*' />
    public D3D11_VDOV_DIMENSION ViewDimension;

    /// <include file='D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.Anonymous"]/*' />
    [NativeTypeName("D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/d3d11.h:11649:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*' />
    public ref D3D11_TEX2D_VDOV Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2D, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX2D_VDOV Texture2D;
    }
}
