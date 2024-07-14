// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINTRUST_DETACHED_SIG_FILE_HANDLES.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_FILE_HANDLES"]/*' />
public partial struct WINTRUST_DETACHED_SIG_FILE_HANDLES
{
    /// <include file='WINTRUST_DETACHED_SIG_FILE_HANDLES.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_FILE_HANDLES.hContentFile"]/*' />
    public HANDLE hContentFile;

    /// <include file='WINTRUST_DETACHED_SIG_FILE_HANDLES.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_FILE_HANDLES.hSignatureFile"]/*' />
    public HANDLE hSignatureFile;
}
