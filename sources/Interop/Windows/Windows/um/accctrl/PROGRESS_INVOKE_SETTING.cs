// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PROGRESS_INVOKE_SETTING.xml' path='doc/member[@name="PROGRESS_INVOKE_SETTING"]/*' />
public enum PROGRESS_INVOKE_SETTING
{
    /// <include file='PROGRESS_INVOKE_SETTING.xml' path='doc/member[@name="PROGRESS_INVOKE_SETTING.ProgressInvokeNever"]/*' />
    ProgressInvokeNever = 1,

    /// <include file='PROGRESS_INVOKE_SETTING.xml' path='doc/member[@name="PROGRESS_INVOKE_SETTING.ProgressInvokeEveryObject"]/*' />
    ProgressInvokeEveryObject,

    /// <include file='PROGRESS_INVOKE_SETTING.xml' path='doc/member[@name="PROGRESS_INVOKE_SETTING.ProgressInvokeOnError"]/*' />
    ProgressInvokeOnError,

    /// <include file='PROGRESS_INVOKE_SETTING.xml' path='doc/member[@name="PROGRESS_INVOKE_SETTING.ProgressCancelOperation"]/*' />
    ProgressCancelOperation,

    /// <include file='PROGRESS_INVOKE_SETTING.xml' path='doc/member[@name="PROGRESS_INVOKE_SETTING.ProgressRetryOperation"]/*' />
    ProgressRetryOperation,

    /// <include file='PROGRESS_INVOKE_SETTING.xml' path='doc/member[@name="PROGRESS_INVOKE_SETTING.ProgressInvokePrePostError"]/*' />
    ProgressInvokePrePostError,
}
