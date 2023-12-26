// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CreationCollisionOption.xml' path='doc/member[@name="CreationCollisionOption"]/*' />
public enum CreationCollisionOption
{
    /// <include file='CreationCollisionOption.xml' path='doc/member[@name="CreationCollisionOption.CreationCollisionOption_GenerateUniqueName"]/*' />
    CreationCollisionOption_GenerateUniqueName = 0,

    /// <include file='CreationCollisionOption.xml' path='doc/member[@name="CreationCollisionOption.CreationCollisionOption_ReplaceExisting"]/*' />
    CreationCollisionOption_ReplaceExisting = 1,

    /// <include file='CreationCollisionOption.xml' path='doc/member[@name="CreationCollisionOption.CreationCollisionOption_FailIfExists"]/*' />
    CreationCollisionOption_FailIfExists = 2,

    /// <include file='CreationCollisionOption.xml' path='doc/member[@name="CreationCollisionOption.CreationCollisionOption_OpenIfExists"]/*' />
    CreationCollisionOption_OpenIfExists = 3,
}
