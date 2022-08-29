// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SE_LEARNING_MODE_DATA_TYPE.xml' path='doc/member[@name="SE_LEARNING_MODE_DATA_TYPE"]/*' />
public enum SE_LEARNING_MODE_DATA_TYPE
{
    /// <include file='SE_LEARNING_MODE_DATA_TYPE.xml' path='doc/member[@name="SE_LEARNING_MODE_DATA_TYPE.SeLearningModeInvalidType"]/*' />
    SeLearningModeInvalidType = 0,

    /// <include file='SE_LEARNING_MODE_DATA_TYPE.xml' path='doc/member[@name="SE_LEARNING_MODE_DATA_TYPE.SeLearningModeSettings"]/*' />
    SeLearningModeSettings,

    /// <include file='SE_LEARNING_MODE_DATA_TYPE.xml' path='doc/member[@name="SE_LEARNING_MODE_DATA_TYPE.SeLearningModeMax"]/*' />
    SeLearningModeMax,
}
