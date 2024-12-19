// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_PERFORMANCE_PARAM.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM"]/*' />
public unsafe partial struct HTTP_PERFORMANCE_PARAM
{
    /// <include file='HTTP_PERFORMANCE_PARAM.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM.Type"]/*' />
    public HTTP_PERFORMANCE_PARAM_TYPE Type;

    /// <include file='HTTP_PERFORMANCE_PARAM.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM.BufferSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint BufferSize;

    /// <include file='HTTP_PERFORMANCE_PARAM.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM.Buffer"]/*' />
    [NativeTypeName("PVOID")]
    public void* Buffer;
}
