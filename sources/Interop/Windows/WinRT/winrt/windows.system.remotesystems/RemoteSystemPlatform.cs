// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemPlatform.xml' path='doc/member[@name="RemoteSystemPlatform"]/*' />
public enum RemoteSystemPlatform
{
    /// <include file='RemoteSystemPlatform.xml' path='doc/member[@name="RemoteSystemPlatform.RemoteSystemPlatform_Unknown"]/*' />
    RemoteSystemPlatform_Unknown = 0,

    /// <include file='RemoteSystemPlatform.xml' path='doc/member[@name="RemoteSystemPlatform.RemoteSystemPlatform_Windows"]/*' />
    RemoteSystemPlatform_Windows = 1,

    /// <include file='RemoteSystemPlatform.xml' path='doc/member[@name="RemoteSystemPlatform.RemoteSystemPlatform_Android"]/*' />
    RemoteSystemPlatform_Android = 2,

    /// <include file='RemoteSystemPlatform.xml' path='doc/member[@name="RemoteSystemPlatform.RemoteSystemPlatform_Ios"]/*' />
    RemoteSystemPlatform_Ios = 3,

    /// <include file='RemoteSystemPlatform.xml' path='doc/member[@name="RemoteSystemPlatform.RemoteSystemPlatform_Linux"]/*' />
    RemoteSystemPlatform_Linux = 4,
}
