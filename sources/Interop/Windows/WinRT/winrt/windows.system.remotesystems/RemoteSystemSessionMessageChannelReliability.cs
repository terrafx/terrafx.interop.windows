// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemSessionMessageChannelReliability.xml' path='doc/member[@name="RemoteSystemSessionMessageChannelReliability"]/*' />
public enum RemoteSystemSessionMessageChannelReliability
{
    /// <include file='RemoteSystemSessionMessageChannelReliability.xml' path='doc/member[@name="RemoteSystemSessionMessageChannelReliability.RemoteSystemSessionMessageChannelReliability_Reliable"]/*' />
    RemoteSystemSessionMessageChannelReliability_Reliable = 0,

    /// <include file='RemoteSystemSessionMessageChannelReliability.xml' path='doc/member[@name="RemoteSystemSessionMessageChannelReliability.RemoteSystemSessionMessageChannelReliability_Unreliable"]/*' />
    RemoteSystemSessionMessageChannelReliability_Unreliable = 1,
}
