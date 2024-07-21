// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC"]/*' />
public partial struct DXGI_OUTPUT_DESC
{
    /// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC.DeviceName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _DeviceName_e__FixedBuffer DeviceName;

    /// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC.DesktopCoordinates"]/*' />
    public RECT DesktopCoordinates;

    /// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC.AttachedToDesktop"]/*' />
    public BOOL AttachedToDesktop;

    /// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC.Rotation"]/*' />
    public DXGI_MODE_ROTATION Rotation;

    /// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC.Monitor"]/*' />
    public HMONITOR Monitor;

    /// <include file='_DeviceName_e__FixedBuffer.xml' path='doc/member[@name="_DeviceName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _DeviceName_e__FixedBuffer
    {
        public char e0;
    }
}
