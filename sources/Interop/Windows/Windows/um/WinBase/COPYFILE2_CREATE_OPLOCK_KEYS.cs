// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='COPYFILE2_CREATE_OPLOCK_KEYS.xml' path='doc/member[@name="COPYFILE2_CREATE_OPLOCK_KEYS"]/*' />
public partial struct COPYFILE2_CREATE_OPLOCK_KEYS
{
    /// <include file='COPYFILE2_CREATE_OPLOCK_KEYS.xml' path='doc/member[@name="COPYFILE2_CREATE_OPLOCK_KEYS.ParentOplockKey"]/*' />
    public Guid ParentOplockKey;

    /// <include file='COPYFILE2_CREATE_OPLOCK_KEYS.xml' path='doc/member[@name="COPYFILE2_CREATE_OPLOCK_KEYS.TargetOplockKey"]/*' />
    public Guid TargetOplockKey;
}
