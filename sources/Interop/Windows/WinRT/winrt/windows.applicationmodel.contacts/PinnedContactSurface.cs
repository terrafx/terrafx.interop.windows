// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PinnedContactSurface.xml' path='doc/member[@name="PinnedContactSurface"]/*' />
public enum PinnedContactSurface
{
    /// <include file='PinnedContactSurface.xml' path='doc/member[@name="PinnedContactSurface.PinnedContactSurface_StartMenu"]/*' />
    PinnedContactSurface_StartMenu = 0,

    /// <include file='PinnedContactSurface.xml' path='doc/member[@name="PinnedContactSurface.PinnedContactSurface_Taskbar"]/*' />
    PinnedContactSurface_Taskbar = 1,
}
