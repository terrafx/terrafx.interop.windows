// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FileOpenDisposition.xml' path='doc/member[@name="FileOpenDisposition"]/*' />
public enum FileOpenDisposition
{
    /// <include file='FileOpenDisposition.xml' path='doc/member[@name="FileOpenDisposition.FileOpenDisposition_OpenExisting"]/*' />
    FileOpenDisposition_OpenExisting = 0,

    /// <include file='FileOpenDisposition.xml' path='doc/member[@name="FileOpenDisposition.FileOpenDisposition_OpenAlways"]/*' />
    FileOpenDisposition_OpenAlways = 1,

    /// <include file='FileOpenDisposition.xml' path='doc/member[@name="FileOpenDisposition.FileOpenDisposition_CreateNew"]/*' />
    FileOpenDisposition_CreateNew = 2,

    /// <include file='FileOpenDisposition.xml' path='doc/member[@name="FileOpenDisposition.FileOpenDisposition_CreateAlways"]/*' />
    FileOpenDisposition_CreateAlways = 3,

    /// <include file='FileOpenDisposition.xml' path='doc/member[@name="FileOpenDisposition.FileOpenDisposition_TruncateExisting"]/*' />
    FileOpenDisposition_TruncateExisting = 4,
}
