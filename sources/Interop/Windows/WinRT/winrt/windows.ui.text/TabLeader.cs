// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TabLeader.xml' path='doc/member[@name="TabLeader"]/*' />
public enum TabLeader
{
    /// <include file='TabLeader.xml' path='doc/member[@name="TabLeader.TabLeader_Spaces"]/*' />
    TabLeader_Spaces = 0,

    /// <include file='TabLeader.xml' path='doc/member[@name="TabLeader.TabLeader_Dots"]/*' />
    TabLeader_Dots = 1,

    /// <include file='TabLeader.xml' path='doc/member[@name="TabLeader.TabLeader_Dashes"]/*' />
    TabLeader_Dashes = 2,

    /// <include file='TabLeader.xml' path='doc/member[@name="TabLeader.TabLeader_Lines"]/*' />
    TabLeader_Lines = 3,

    /// <include file='TabLeader.xml' path='doc/member[@name="TabLeader.TabLeader_ThickLines"]/*' />
    TabLeader_ThickLines = 4,

    /// <include file='TabLeader.xml' path='doc/member[@name="TabLeader.TabLeader_Equals"]/*' />
    TabLeader_Equals = 5,
}
