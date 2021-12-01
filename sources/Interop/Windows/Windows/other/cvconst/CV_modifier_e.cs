// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e"]/*' />
public enum CV_modifier_e
{
    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_INVALID"]/*' />
    CV_MOD_INVALID = 0x0000,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_CONST"]/*' />
    CV_MOD_CONST = 0x0001,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_VOLATILE"]/*' />
    CV_MOD_VOLATILE = 0x0002,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_UNALIGNED"]/*' />
    CV_MOD_UNALIGNED = 0x0003,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_UNIFORM"]/*' />
    CV_MOD_HLSL_UNIFORM = 0x0200,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_LINE"]/*' />
    CV_MOD_HLSL_LINE = 0x0201,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_TRIANGLE"]/*' />
    CV_MOD_HLSL_TRIANGLE = 0x0202,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_LINEADJ"]/*' />
    CV_MOD_HLSL_LINEADJ = 0x0203,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_TRIANGLEADJ"]/*' />
    CV_MOD_HLSL_TRIANGLEADJ = 0x0204,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_LINEAR"]/*' />
    CV_MOD_HLSL_LINEAR = 0x0205,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_CENTROID"]/*' />
    CV_MOD_HLSL_CENTROID = 0x0206,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_CONSTINTERP"]/*' />
    CV_MOD_HLSL_CONSTINTERP = 0x0207,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_NOPERSPECTIVE"]/*' />
    CV_MOD_HLSL_NOPERSPECTIVE = 0x0208,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_SAMPLE"]/*' />
    CV_MOD_HLSL_SAMPLE = 0x0209,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_CENTER"]/*' />
    CV_MOD_HLSL_CENTER = 0x020a,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_SNORM"]/*' />
    CV_MOD_HLSL_SNORM = 0x020b,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_UNORM"]/*' />
    CV_MOD_HLSL_UNORM = 0x020c,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_PRECISE"]/*' />
    CV_MOD_HLSL_PRECISE = 0x020d,

    /// <include file='CV_modifier_e.xml' path='doc/member[@name="CV_modifier_e.CV_MOD_HLSL_UAV_GLOBALLY_COHERENT"]/*' />
    CV_MOD_HLSL_UAV_GLOBALLY_COHERENT = 0x020e,
}
