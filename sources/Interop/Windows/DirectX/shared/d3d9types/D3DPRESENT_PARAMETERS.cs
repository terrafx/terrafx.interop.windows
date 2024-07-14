// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS"]/*' />
public partial struct D3DPRESENT_PARAMETERS
{
    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferWidth"]/*' />
    public uint BackBufferWidth;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferHeight"]/*' />
    public uint BackBufferHeight;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferFormat"]/*' />
    public D3DFORMAT BackBufferFormat;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferCount"]/*' />
    public uint BackBufferCount;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.MultiSampleType"]/*' />
    public D3DMULTISAMPLE_TYPE MultiSampleType;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.MultiSampleQuality"]/*' />
    [NativeTypeName("DWORD")]
    public uint MultiSampleQuality;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.SwapEffect"]/*' />
    public D3DSWAPEFFECT SwapEffect;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.hDeviceWindow"]/*' />
    public HWND hDeviceWindow;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.Windowed"]/*' />
    public BOOL Windowed;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.EnableAutoDepthStencil"]/*' />
    public BOOL EnableAutoDepthStencil;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.AutoDepthStencilFormat"]/*' />
    public D3DFORMAT AutoDepthStencilFormat;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.FullScreen_RefreshRateInHz"]/*' />
    public uint FullScreen_RefreshRateInHz;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.PresentationInterval"]/*' />
    public uint PresentationInterval;
}
