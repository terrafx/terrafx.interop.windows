// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_SECONDARY_FLAGS.xml' path='doc/member[@name="MINIDUMP_SECONDARY_FLAGS"]/*' />
public enum MINIDUMP_SECONDARY_FLAGS
{
    /// <include file='MINIDUMP_SECONDARY_FLAGS.xml' path='doc/member[@name="MINIDUMP_SECONDARY_FLAGS.MiniSecondaryWithoutPowerInfo"]/*' />
    MiniSecondaryWithoutPowerInfo = 0x00000001,

    /// <include file='MINIDUMP_SECONDARY_FLAGS.xml' path='doc/member[@name="MINIDUMP_SECONDARY_FLAGS.MiniSecondaryValidFlags"]/*' />
    MiniSecondaryValidFlags = 0x00000001,
}
