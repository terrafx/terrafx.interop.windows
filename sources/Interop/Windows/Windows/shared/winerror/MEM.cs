// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MEM
{
    /// <include file='MEM.xml' path='doc/member[@name="MEM.MEM_E_INVALID_ROOT"]/*' />
    [NativeTypeName("#define MEM_E_INVALID_ROOT _HRESULT_TYPEDEF_(0x80080009L)")]
    public const int MEM_E_INVALID_ROOT = unchecked((int)(0x80080009));

    /// <include file='MEM.xml' path='doc/member[@name="MEM.MEM_E_INVALID_LINK"]/*' />
    [NativeTypeName("#define MEM_E_INVALID_LINK _HRESULT_TYPEDEF_(0x80080010L)")]
    public const int MEM_E_INVALID_LINK = unchecked((int)(0x80080010));

    /// <include file='MEM.xml' path='doc/member[@name="MEM.MEM_E_INVALID_SIZE"]/*' />
    [NativeTypeName("#define MEM_E_INVALID_SIZE _HRESULT_TYPEDEF_(0x80080011L)")]
    public const int MEM_E_INVALID_SIZE = unchecked((int)(0x80080011));
}
