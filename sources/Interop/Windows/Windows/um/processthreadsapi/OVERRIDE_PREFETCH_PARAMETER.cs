// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='OVERRIDE_PREFETCH_PARAMETER.xml' path='doc/member[@name="OVERRIDE_PREFETCH_PARAMETER"]/*' />
public partial struct OVERRIDE_PREFETCH_PARAMETER
{
    /// <include file='OVERRIDE_PREFETCH_PARAMETER.xml' path='doc/member[@name="OVERRIDE_PREFETCH_PARAMETER.Value"]/*' />
    [NativeTypeName("UINT32")]
    public uint Value;
}
