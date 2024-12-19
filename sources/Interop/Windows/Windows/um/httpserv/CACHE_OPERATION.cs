// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CACHE_OPERATION.xml' path='doc/member[@name="CACHE_OPERATION"]/*' />
public enum CACHE_OPERATION
{
    /// <include file='CACHE_OPERATION.xml' path='doc/member[@name="CACHE_OPERATION.CACHE_OPERATION_RETRIEVE"]/*' />
    CACHE_OPERATION_RETRIEVE,

    /// <include file='CACHE_OPERATION.xml' path='doc/member[@name="CACHE_OPERATION.CACHE_OPERATION_ADD"]/*' />
    CACHE_OPERATION_ADD,

    /// <include file='CACHE_OPERATION.xml' path='doc/member[@name="CACHE_OPERATION.CACHE_OPERATION_DELETE"]/*' />
    CACHE_OPERATION_DELETE,

    /// <include file='CACHE_OPERATION.xml' path='doc/member[@name="CACHE_OPERATION.CACHE_OPERATION_FLUSH_PREFIX"]/*' />
    CACHE_OPERATION_FLUSH_PREFIX,

    /// <include file='CACHE_OPERATION.xml' path='doc/member[@name="CACHE_OPERATION.CACHE_OPERATION_ENUM"]/*' />
    CACHE_OPERATION_ENUM,
}
