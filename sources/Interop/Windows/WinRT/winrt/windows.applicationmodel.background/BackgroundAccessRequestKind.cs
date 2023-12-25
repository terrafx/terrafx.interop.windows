// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundAccessRequestKind.xml' path='doc/member[@name="BackgroundAccessRequestKind"]/*' />
public enum BackgroundAccessRequestKind
{
    /// <include file='BackgroundAccessRequestKind.xml' path='doc/member[@name="BackgroundAccessRequestKind.BackgroundAccessRequestKind_AlwaysAllowed"]/*' />
    BackgroundAccessRequestKind_AlwaysAllowed = 0,

    /// <include file='BackgroundAccessRequestKind.xml' path='doc/member[@name="BackgroundAccessRequestKind.BackgroundAccessRequestKind_AllowedSubjectToSystemPolicy"]/*' />
    BackgroundAccessRequestKind_AllowedSubjectToSystemPolicy = 1,
}
