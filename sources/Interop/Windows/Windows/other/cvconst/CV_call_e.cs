// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e"]/*' />
public enum CV_call_e
{
    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_NEAR_C"]/*' />
    CV_CALL_NEAR_C = 0x00,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_FAR_C"]/*' />
    CV_CALL_FAR_C = 0x01,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_NEAR_PASCAL"]/*' />
    CV_CALL_NEAR_PASCAL = 0x02,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_FAR_PASCAL"]/*' />
    CV_CALL_FAR_PASCAL = 0x03,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_NEAR_FAST"]/*' />
    CV_CALL_NEAR_FAST = 0x04,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_FAR_FAST"]/*' />
    CV_CALL_FAR_FAST = 0x05,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_SKIPPED"]/*' />
    CV_CALL_SKIPPED = 0x06,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_NEAR_STD"]/*' />
    CV_CALL_NEAR_STD = 0x07,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_FAR_STD"]/*' />
    CV_CALL_FAR_STD = 0x08,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_NEAR_SYS"]/*' />
    CV_CALL_NEAR_SYS = 0x09,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_FAR_SYS"]/*' />
    CV_CALL_FAR_SYS = 0x0a,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_THISCALL"]/*' />
    CV_CALL_THISCALL = 0x0b,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_MIPSCALL"]/*' />
    CV_CALL_MIPSCALL = 0x0c,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_GENERIC"]/*' />
    CV_CALL_GENERIC = 0x0d,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_ALPHACALL"]/*' />
    CV_CALL_ALPHACALL = 0x0e,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_PPCCALL"]/*' />
    CV_CALL_PPCCALL = 0x0f,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_SHCALL"]/*' />
    CV_CALL_SHCALL = 0x10,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_ARMCALL"]/*' />
    CV_CALL_ARMCALL = 0x11,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_AM33CALL"]/*' />
    CV_CALL_AM33CALL = 0x12,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_TRICALL"]/*' />
    CV_CALL_TRICALL = 0x13,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_SH5CALL"]/*' />
    CV_CALL_SH5CALL = 0x14,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_M32RCALL"]/*' />
    CV_CALL_M32RCALL = 0x15,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_CLRCALL"]/*' />
    CV_CALL_CLRCALL = 0x16,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_INLINE"]/*' />
    CV_CALL_INLINE = 0x17,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_NEAR_VECTOR"]/*' />
    CV_CALL_NEAR_VECTOR = 0x18,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_SWIFT"]/*' />
    CV_CALL_SWIFT = 0x19,

    /// <include file='CV_call_e.xml' path='doc/member[@name="CV_call_e.CV_CALL_RESERVED"]/*' />
    CV_CALL_RESERVED = 0x20,
}
