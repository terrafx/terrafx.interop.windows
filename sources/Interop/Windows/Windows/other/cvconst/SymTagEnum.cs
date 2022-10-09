// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum"]/*' />
public enum SymTagEnum
{
    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagNull"]/*' />
    SymTagNull,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagExe"]/*' />
    SymTagExe,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagCompiland"]/*' />
    SymTagCompiland,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagCompilandDetails"]/*' />
    SymTagCompilandDetails,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagCompilandEnv"]/*' />
    SymTagCompilandEnv,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagFunction"]/*' />
    SymTagFunction,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagBlock"]/*' />
    SymTagBlock,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagData"]/*' />
    SymTagData,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagAnnotation"]/*' />
    SymTagAnnotation,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagLabel"]/*' />
    SymTagLabel,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagPublicSymbol"]/*' />
    SymTagPublicSymbol,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagUDT"]/*' />
    SymTagUDT,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagEnum"]/*' />
    SymTagEnum,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagFunctionType"]/*' />
    SymTagFunctionType,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagPointerType"]/*' />
    SymTagPointerType,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagArrayType"]/*' />
    SymTagArrayType,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagBaseType"]/*' />
    SymTagBaseType,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagTypedef"]/*' />
    SymTagTypedef,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagBaseClass"]/*' />
    SymTagBaseClass,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagFriend"]/*' />
    SymTagFriend,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagFunctionArgType"]/*' />
    SymTagFunctionArgType,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagFuncDebugStart"]/*' />
    SymTagFuncDebugStart,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagFuncDebugEnd"]/*' />
    SymTagFuncDebugEnd,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagUsingNamespace"]/*' />
    SymTagUsingNamespace,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagVTableShape"]/*' />
    SymTagVTableShape,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagVTable"]/*' />
    SymTagVTable,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagCustom"]/*' />
    SymTagCustom,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagThunk"]/*' />
    SymTagThunk,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagCustomType"]/*' />
    SymTagCustomType,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagManagedType"]/*' />
    SymTagManagedType,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagDimension"]/*' />
    SymTagDimension,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagCallSite"]/*' />
    SymTagCallSite,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagInlineSite"]/*' />
    SymTagInlineSite,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagBaseInterface"]/*' />
    SymTagBaseInterface,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagVectorType"]/*' />
    SymTagVectorType,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagMatrixType"]/*' />
    SymTagMatrixType,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagHLSLType"]/*' />
    SymTagHLSLType,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagCaller"]/*' />
    SymTagCaller,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagCallee"]/*' />
    SymTagCallee,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagExport"]/*' />
    SymTagExport,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagHeapAllocationSite"]/*' />
    SymTagHeapAllocationSite,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagCoffGroup"]/*' />
    SymTagCoffGroup,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagInlinee"]/*' />
    SymTagInlinee,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagTaggedUnionCase"]/*' />
    SymTagTaggedUnionCase,

    /// <include file='SymTagEnum.xml' path='doc/member[@name="SymTagEnum.SymTagMax"]/*' />
    SymTagMax,
}
