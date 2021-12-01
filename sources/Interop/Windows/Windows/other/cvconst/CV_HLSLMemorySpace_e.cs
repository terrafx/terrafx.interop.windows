// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='CV_HLSLMemorySpace_e.xml' path='doc/member[@name="CV_HLSLMemorySpace_e"]/*' />
public enum CV_HLSLMemorySpace_e
{
    /// <include file='CV_HLSLMemorySpace_e.xml' path='doc/member[@name="CV_HLSLMemorySpace_e.CV_HLSL_MEMSPACE_DATA"]/*' />
    CV_HLSL_MEMSPACE_DATA = 0x00,

    /// <include file='CV_HLSLMemorySpace_e.xml' path='doc/member[@name="CV_HLSLMemorySpace_e.CV_HLSL_MEMSPACE_SAMPLER"]/*' />
    CV_HLSL_MEMSPACE_SAMPLER = 0x01,

    /// <include file='CV_HLSLMemorySpace_e.xml' path='doc/member[@name="CV_HLSLMemorySpace_e.CV_HLSL_MEMSPACE_RESOURCE"]/*' />
    CV_HLSL_MEMSPACE_RESOURCE = 0x02,

    /// <include file='CV_HLSLMemorySpace_e.xml' path='doc/member[@name="CV_HLSLMemorySpace_e.CV_HLSL_MEMSPACE_RWRESOURCE"]/*' />
    CV_HLSL_MEMSPACE_RWRESOURCE = 0x03,

    /// <include file='CV_HLSLMemorySpace_e.xml' path='doc/member[@name="CV_HLSLMemorySpace_e.CV_HLSL_MEMSPACE_MAX"]/*' />
    CV_HLSL_MEMSPACE_MAX = 0x0F,
}
