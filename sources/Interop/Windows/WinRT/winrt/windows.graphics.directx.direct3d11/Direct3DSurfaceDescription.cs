// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.directx.direct3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Direct3DSurfaceDescription.xml' path='doc/member[@name="Direct3DSurfaceDescription"]/*' />
public partial struct Direct3DSurfaceDescription
{
    /// <include file='Direct3DSurfaceDescription.xml' path='doc/member[@name="Direct3DSurfaceDescription.Width"]/*' />
    [NativeTypeName("INT32")]
    public int Width;

    /// <include file='Direct3DSurfaceDescription.xml' path='doc/member[@name="Direct3DSurfaceDescription.Height"]/*' />
    [NativeTypeName("INT32")]
    public int Height;

    /// <include file='Direct3DSurfaceDescription.xml' path='doc/member[@name="Direct3DSurfaceDescription.Format"]/*' />
    [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")]
    public DirectXPixelFormat Format;

    /// <include file='Direct3DSurfaceDescription.xml' path='doc/member[@name="Direct3DSurfaceDescription.MultisampleDescription"]/*' />
    [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::Direct3DMultisampleDescription")]
    public Direct3DMultisampleDescription MultisampleDescription;
}
