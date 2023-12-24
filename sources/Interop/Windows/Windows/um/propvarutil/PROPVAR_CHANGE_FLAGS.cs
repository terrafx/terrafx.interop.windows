// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='PROPVAR_CHANGE_FLAGS.xml' path='doc/member[@name="PROPVAR_CHANGE_FLAGS"]/*' />
[Flags]
public enum PROPVAR_CHANGE_FLAGS
{
    /// <include file='PROPVAR_CHANGE_FLAGS.xml' path='doc/member[@name="PROPVAR_CHANGE_FLAGS.PVCHF_DEFAULT"]/*' />
    PVCHF_DEFAULT = 0x00000000,

    /// <include file='PROPVAR_CHANGE_FLAGS.xml' path='doc/member[@name="PROPVAR_CHANGE_FLAGS.PVCHF_NOVALUEPROP"]/*' />
    PVCHF_NOVALUEPROP = 0x00000001,

    /// <include file='PROPVAR_CHANGE_FLAGS.xml' path='doc/member[@name="PROPVAR_CHANGE_FLAGS.PVCHF_ALPHABOOL"]/*' />
    PVCHF_ALPHABOOL = 0x00000002,

    /// <include file='PROPVAR_CHANGE_FLAGS.xml' path='doc/member[@name="PROPVAR_CHANGE_FLAGS.PVCHF_NOUSEROVERRIDE"]/*' />
    PVCHF_NOUSEROVERRIDE = 0x00000004,

    /// <include file='PROPVAR_CHANGE_FLAGS.xml' path='doc/member[@name="PROPVAR_CHANGE_FLAGS.PVCHF_LOCALBOOL"]/*' />
    PVCHF_LOCALBOOL = 0x00000008,

    /// <include file='PROPVAR_CHANGE_FLAGS.xml' path='doc/member[@name="PROPVAR_CHANGE_FLAGS.PVCHF_NOHEXSTRING"]/*' />
    PVCHF_NOHEXSTRING = 0x00000010,
}
