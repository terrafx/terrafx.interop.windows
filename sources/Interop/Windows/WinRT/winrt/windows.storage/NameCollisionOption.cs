// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NameCollisionOption.xml' path='doc/member[@name="NameCollisionOption"]/*' />
public enum NameCollisionOption
{
    /// <include file='NameCollisionOption.xml' path='doc/member[@name="NameCollisionOption.NameCollisionOption_GenerateUniqueName"]/*' />
    NameCollisionOption_GenerateUniqueName = 0,

    /// <include file='NameCollisionOption.xml' path='doc/member[@name="NameCollisionOption.NameCollisionOption_ReplaceExisting"]/*' />
    NameCollisionOption_ReplaceExisting = 1,

    /// <include file='NameCollisionOption.xml' path='doc/member[@name="NameCollisionOption.NameCollisionOption_FailIfExists"]/*' />
    NameCollisionOption_FailIfExists = 2,
}
