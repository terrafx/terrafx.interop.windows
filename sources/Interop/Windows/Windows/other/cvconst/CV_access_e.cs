// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='CV_access_e.xml' path='doc/member[@name="CV_access_e"]/*' />
public enum CV_access_e
{
    /// <include file='CV_access_e.xml' path='doc/member[@name="CV_access_e.CV_private"]/*' />
    CV_private = 1,

    /// <include file='CV_access_e.xml' path='doc/member[@name="CV_access_e.CV_protected"]/*' />
    CV_protected = 2,

    /// <include file='CV_access_e.xml' path='doc/member[@name="CV_access_e.CV_public"]/*' />
    CV_public = 3,
}
