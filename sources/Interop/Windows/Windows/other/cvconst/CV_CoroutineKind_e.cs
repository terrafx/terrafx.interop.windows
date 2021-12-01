// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='CV_CoroutineKind_e.xml' path='doc/member[@name="CV_CoroutineKind_e"]/*' />
public enum CV_CoroutineKind_e
{
    /// <include file='CV_CoroutineKind_e.xml' path='doc/member[@name="CV_CoroutineKind_e.CV_COROUTINEKIND_NONE"]/*' />
    CV_COROUTINEKIND_NONE,

    /// <include file='CV_CoroutineKind_e.xml' path='doc/member[@name="CV_CoroutineKind_e.CV_COROUTINEKIND_PRIMARY"]/*' />
    CV_COROUTINEKIND_PRIMARY,

    /// <include file='CV_CoroutineKind_e.xml' path='doc/member[@name="CV_CoroutineKind_e.CV_COROUTINEKIND_INIT"]/*' />
    CV_COROUTINEKIND_INIT,

    /// <include file='CV_CoroutineKind_e.xml' path='doc/member[@name="CV_CoroutineKind_e.CV_COROUTINEKIND_RESUME"]/*' />
    CV_COROUTINEKIND_RESUME,

    /// <include file='CV_CoroutineKind_e.xml' path='doc/member[@name="CV_CoroutineKind_e.CV_COROUTINEKIND_DESTROY"]/*' />
    CV_COROUTINEKIND_DESTROY,
}
