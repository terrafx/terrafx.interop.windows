// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='DRAWPROGRESSFLAGS.xml' path='doc/member[@name="DRAWPROGRESSFLAGS"]/*' />
[Flags]
public enum DRAWPROGRESSFLAGS
{
    /// <include file='DRAWPROGRESSFLAGS.xml' path='doc/member[@name="DRAWPROGRESSFLAGS.DPF_NONE"]/*' />
    DPF_NONE = 0x0,

    /// <include file='DRAWPROGRESSFLAGS.xml' path='doc/member[@name="DRAWPROGRESSFLAGS.DPF_MARQUEE"]/*' />
    DPF_MARQUEE = 0x1,

    /// <include file='DRAWPROGRESSFLAGS.xml' path='doc/member[@name="DRAWPROGRESSFLAGS.DPF_MARQUEE_COMPLETE"]/*' />
    DPF_MARQUEE_COMPLETE = 0x2,

    /// <include file='DRAWPROGRESSFLAGS.xml' path='doc/member[@name="DRAWPROGRESSFLAGS.DPF_ERROR"]/*' />
    DPF_ERROR = 0x4,

    /// <include file='DRAWPROGRESSFLAGS.xml' path='doc/member[@name="DRAWPROGRESSFLAGS.DPF_WARNING"]/*' />
    DPF_WARNING = 0x8,

    /// <include file='DRAWPROGRESSFLAGS.xml' path='doc/member[@name="DRAWPROGRESSFLAGS.DPF_STOPPED"]/*' />
    DPF_STOPPED = 0x10,
}
