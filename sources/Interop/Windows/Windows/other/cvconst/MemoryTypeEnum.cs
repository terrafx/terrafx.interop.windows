// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='MemoryTypeEnum.xml' path='doc/member[@name="MemoryTypeEnum"]/*' />
public enum MemoryTypeEnum
{
    /// <include file='MemoryTypeEnum.xml' path='doc/member[@name="MemoryTypeEnum.MemTypeCode"]/*' />
    MemTypeCode,

    /// <include file='MemoryTypeEnum.xml' path='doc/member[@name="MemoryTypeEnum.MemTypeData"]/*' />
    MemTypeData,

    /// <include file='MemoryTypeEnum.xml' path='doc/member[@name="MemoryTypeEnum.MemTypeStack"]/*' />
    MemTypeStack,

    /// <include file='MemoryTypeEnum.xml' path='doc/member[@name="MemoryTypeEnum.MemTypeCodeOnHeap"]/*' />
    MemTypeCodeOnHeap,

    /// <include file='MemoryTypeEnum.xml' path='doc/member[@name="MemoryTypeEnum.MemTypeAny"]/*' />
    MemTypeAny = -1,
}
