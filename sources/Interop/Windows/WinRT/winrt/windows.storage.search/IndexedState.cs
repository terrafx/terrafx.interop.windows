// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='IndexedState.xml' path='doc/member[@name="IndexedState"]/*' />
public enum IndexedState
{
    /// <include file='IndexedState.xml' path='doc/member[@name="IndexedState.IndexedState_Unknown"]/*' />
    IndexedState_Unknown = 0,

    /// <include file='IndexedState.xml' path='doc/member[@name="IndexedState.IndexedState_NotIndexed"]/*' />
    IndexedState_NotIndexed = 1,

    /// <include file='IndexedState.xml' path='doc/member[@name="IndexedState.IndexedState_PartiallyIndexed"]/*' />
    IndexedState_PartiallyIndexed = 2,

    /// <include file='IndexedState.xml' path='doc/member[@name="IndexedState.IndexedState_FullyIndexed"]/*' />
    IndexedState_FullyIndexed = 3,
}
