// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINTRUST_DETACHED_SIG_BLOBS.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_BLOBS"]/*' />
public unsafe partial struct WINTRUST_DETACHED_SIG_BLOBS
{
    /// <include file='WINTRUST_DETACHED_SIG_BLOBS.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_BLOBS.cbContentObject"]/*' />
    public LARGE_INTEGER cbContentObject;

    /// <include file='WINTRUST_DETACHED_SIG_BLOBS.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_BLOBS.pbContentObject"]/*' />
    public byte* pbContentObject;

    /// <include file='WINTRUST_DETACHED_SIG_BLOBS.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_BLOBS.cbSignatureObject"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSignatureObject;

    /// <include file='WINTRUST_DETACHED_SIG_BLOBS.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_BLOBS.pbSignatureObject"]/*' />
    public byte* pbSignatureObject;
}
