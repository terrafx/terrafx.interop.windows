// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='CV_SourceChksum_t.xml' path='doc/member[@name="CV_SourceChksum_t"]/*' />
public enum CV_SourceChksum_t
{
    /// <include file='CV_SourceChksum_t.xml' path='doc/member[@name="CV_SourceChksum_t.CHKSUM_TYPE_NONE"]/*' />
    CHKSUM_TYPE_NONE = 0,

    /// <include file='CV_SourceChksum_t.xml' path='doc/member[@name="CV_SourceChksum_t.CHKSUM_TYPE_MD5"]/*' />
    CHKSUM_TYPE_MD5,

    /// <include file='CV_SourceChksum_t.xml' path='doc/member[@name="CV_SourceChksum_t.CHKSUM_TYPE_SHA1"]/*' />
    CHKSUM_TYPE_SHA1,

    /// <include file='CV_SourceChksum_t.xml' path='doc/member[@name="CV_SourceChksum_t.CHKSUM_TYPE_SHA_256"]/*' />
    CHKSUM_TYPE_SHA_256,
}
