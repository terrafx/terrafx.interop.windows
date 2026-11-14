// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DXGI
{
    /// <include file='DXGI.xml' path='doc/member[@name="DXGI.DXGI_CREATE_FACTORY_DEBUG"]/*' />
    [NativeTypeName("#define DXGI_CREATE_FACTORY_DEBUG 0x1")]
    public const int DXGI_CREATE_FACTORY_DEBUG = 0x1;
}
