// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='StackFrameTypeEnum.xml' path='doc/member[@name="StackFrameTypeEnum"]/*' />
public enum StackFrameTypeEnum
{
    /// <include file='StackFrameTypeEnum.xml' path='doc/member[@name="StackFrameTypeEnum.FrameTypeFPO"]/*' />
    FrameTypeFPO,

    /// <include file='StackFrameTypeEnum.xml' path='doc/member[@name="StackFrameTypeEnum.FrameTypeTrap"]/*' />
    FrameTypeTrap,

    /// <include file='StackFrameTypeEnum.xml' path='doc/member[@name="StackFrameTypeEnum.FrameTypeTSS"]/*' />
    FrameTypeTSS,

    /// <include file='StackFrameTypeEnum.xml' path='doc/member[@name="StackFrameTypeEnum.FrameTypeStandard"]/*' />
    FrameTypeStandard,

    /// <include file='StackFrameTypeEnum.xml' path='doc/member[@name="StackFrameTypeEnum.FrameTypeFrameData"]/*' />
    FrameTypeFrameData,

    /// <include file='StackFrameTypeEnum.xml' path='doc/member[@name="StackFrameTypeEnum.FrameTypeUnknown"]/*' />
    FrameTypeUnknown = -1,
}
