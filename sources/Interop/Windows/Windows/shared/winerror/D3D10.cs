// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static partial class D3D10
{
    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS"]/*' />
    [NativeTypeName("#define D3D10_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS _HRESULT_TYPEDEF_(0x88790001L)")]
    public const int D3D10_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS = unchecked((int)(0x88790001));

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_ERROR_FILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define D3D10_ERROR_FILE_NOT_FOUND _HRESULT_TYPEDEF_(0x88790002L)")]
    public const int D3D10_ERROR_FILE_NOT_FOUND = unchecked((int)(0x88790002));
}
