// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='PSTIME_FLAGS.xml' path='doc/member[@name="PSTIME_FLAGS"]/*' />
[Flags]
public enum PSTIME_FLAGS
{
    /// <include file='PSTIME_FLAGS.xml' path='doc/member[@name="PSTIME_FLAGS.PSTF_UTC"]/*' />
    PSTF_UTC = 0x00000000,

    /// <include file='PSTIME_FLAGS.xml' path='doc/member[@name="PSTIME_FLAGS.PSTF_LOCAL"]/*' />
    PSTF_LOCAL = 0x00000001,
}
