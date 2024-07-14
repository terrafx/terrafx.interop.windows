// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemStatusType.xml' path='doc/member[@name="RemoteSystemStatusType"]/*' />
public enum RemoteSystemStatusType
{
    /// <include file='RemoteSystemStatusType.xml' path='doc/member[@name="RemoteSystemStatusType.RemoteSystemStatusType_Any"]/*' />
    RemoteSystemStatusType_Any = 0,

    /// <include file='RemoteSystemStatusType.xml' path='doc/member[@name="RemoteSystemStatusType.RemoteSystemStatusType_Available"]/*' />
    RemoteSystemStatusType_Available = 1,
}
