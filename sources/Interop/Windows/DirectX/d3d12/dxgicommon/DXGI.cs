// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxgicommon.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public static partial class DXGI
{
    /// <include file='DXGI.xml' path='doc/member[@name="DXGI.DXGI_STANDARD_MULTISAMPLE_QUALITY_PATTERN"]/*' />
    [NativeTypeName("#define DXGI_STANDARD_MULTISAMPLE_QUALITY_PATTERN 0xffffffff")]
    public const uint DXGI_STANDARD_MULTISAMPLE_QUALITY_PATTERN = 0xffffffff;

    /// <include file='DXGI.xml' path='doc/member[@name="DXGI.DXGI_CENTER_MULTISAMPLE_QUALITY_PATTERN"]/*' />
    [NativeTypeName("#define DXGI_CENTER_MULTISAMPLE_QUALITY_PATTERN 0xfffffffe")]
    public const uint DXGI_CENTER_MULTISAMPLE_QUALITY_PATTERN = 0xfffffffe;
}
