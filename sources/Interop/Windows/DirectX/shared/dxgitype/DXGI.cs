// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DXGI
{
    /// <include file='DXGI.xml' path='doc/member[@name="DXGI.DXGI_CPU_ACCESS_NONE"]/*' />
    [NativeTypeName("#define DXGI_CPU_ACCESS_NONE ( 0 )")]
    public const int DXGI_CPU_ACCESS_NONE = (0);

    /// <include file='DXGI.xml' path='doc/member[@name="DXGI.DXGI_CPU_ACCESS_DYNAMIC"]/*' />
    [NativeTypeName("#define DXGI_CPU_ACCESS_DYNAMIC ( 1 )")]
    public const int DXGI_CPU_ACCESS_DYNAMIC = (1);

    /// <include file='DXGI.xml' path='doc/member[@name="DXGI.DXGI_CPU_ACCESS_READ_WRITE"]/*' />
    [NativeTypeName("#define DXGI_CPU_ACCESS_READ_WRITE ( 2 )")]
    public const int DXGI_CPU_ACCESS_READ_WRITE = (2);

    /// <include file='DXGI.xml' path='doc/member[@name="DXGI.DXGI_CPU_ACCESS_SCRATCH"]/*' />
    [NativeTypeName("#define DXGI_CPU_ACCESS_SCRATCH ( 3 )")]
    public const int DXGI_CPU_ACCESS_SCRATCH = (3);

    /// <include file='DXGI.xml' path='doc/member[@name="DXGI.DXGI_CPU_ACCESS_FIELD"]/*' />
    [NativeTypeName("#define DXGI_CPU_ACCESS_FIELD 15")]
    public const int DXGI_CPU_ACCESS_FIELD = 15;
}
