// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_CACHE_POLICY.xml' path='doc/member[@name="HTTP_CACHE_POLICY"]/*' />
public partial struct HTTP_CACHE_POLICY
{
    /// <include file='HTTP_CACHE_POLICY.xml' path='doc/member[@name="HTTP_CACHE_POLICY.Policy"]/*' />
    public HTTP_CACHE_POLICY_TYPE Policy;

    /// <include file='HTTP_CACHE_POLICY.xml' path='doc/member[@name="HTTP_CACHE_POLICY.SecondsToLive"]/*' />
    [NativeTypeName("ULONG")]
    public uint SecondsToLive;
}
