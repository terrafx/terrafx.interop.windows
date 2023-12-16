// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='COINSTALLER_CONTEXT_DATA.xml' path='doc/member[@name="COINSTALLER_CONTEXT_DATA"]/*' />
public unsafe partial struct COINSTALLER_CONTEXT_DATA
{
    /// <include file='COINSTALLER_CONTEXT_DATA.xml' path='doc/member[@name="COINSTALLER_CONTEXT_DATA.PostProcessing"]/*' />
    public BOOL PostProcessing;

    /// <include file='COINSTALLER_CONTEXT_DATA.xml' path='doc/member[@name="COINSTALLER_CONTEXT_DATA.InstallResult"]/*' />
    [NativeTypeName("DWORD")]
    public uint InstallResult;

    /// <include file='COINSTALLER_CONTEXT_DATA.xml' path='doc/member[@name="COINSTALLER_CONTEXT_DATA.PrivateData"]/*' />
    [NativeTypeName("PVOID")]
    public void* PrivateData;
}
