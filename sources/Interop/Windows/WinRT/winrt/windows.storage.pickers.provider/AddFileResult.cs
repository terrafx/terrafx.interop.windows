// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AddFileResult.xml' path='doc/member[@name="AddFileResult"]/*' />
public enum AddFileResult
{
    /// <include file='AddFileResult.xml' path='doc/member[@name="AddFileResult.AddFileResult_Added"]/*' />
    AddFileResult_Added = 0,

    /// <include file='AddFileResult.xml' path='doc/member[@name="AddFileResult.AddFileResult_AlreadyAdded"]/*' />
    AddFileResult_AlreadyAdded = 1,

    /// <include file='AddFileResult.xml' path='doc/member[@name="AddFileResult.AddFileResult_NotAllowed"]/*' />
    AddFileResult_NotAllowed = 2,

    /// <include file='AddFileResult.xml' path='doc/member[@name="AddFileResult.AddFileResult_Unavailable"]/*' />
    AddFileResult_Unavailable = 3,
}
