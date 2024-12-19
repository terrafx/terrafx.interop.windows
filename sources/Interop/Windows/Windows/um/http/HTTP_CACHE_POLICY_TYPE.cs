// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_CACHE_POLICY_TYPE.xml' path='doc/member[@name="HTTP_CACHE_POLICY_TYPE"]/*' />
public enum HTTP_CACHE_POLICY_TYPE
{
    /// <include file='HTTP_CACHE_POLICY_TYPE.xml' path='doc/member[@name="HTTP_CACHE_POLICY_TYPE.HttpCachePolicyNocache"]/*' />
    HttpCachePolicyNocache,

    /// <include file='HTTP_CACHE_POLICY_TYPE.xml' path='doc/member[@name="HTTP_CACHE_POLICY_TYPE.HttpCachePolicyUserInvalidates"]/*' />
    HttpCachePolicyUserInvalidates,

    /// <include file='HTTP_CACHE_POLICY_TYPE.xml' path='doc/member[@name="HTTP_CACHE_POLICY_TYPE.HttpCachePolicyTimeToLive"]/*' />
    HttpCachePolicyTimeToLive,

    /// <include file='HTTP_CACHE_POLICY_TYPE.xml' path='doc/member[@name="HTTP_CACHE_POLICY_TYPE.HttpCachePolicyMaximum"]/*' />
    HttpCachePolicyMaximum,
}
