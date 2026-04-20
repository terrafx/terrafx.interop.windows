// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='eAVEncVideoQPMapElementDataType.xml' path='doc/member[@name="eAVEncVideoQPMapElementDataType"]/*' />
public enum eAVEncVideoQPMapElementDataType
{
    /// <include file='eAVEncVideoQPMapElementDataType.xml' path='doc/member[@name="eAVEncVideoQPMapElementDataType.CODEC_API_QP_MAP_INT8"]/*' />
    CODEC_API_QP_MAP_INT8 = 0x00000000,

    /// <include file='eAVEncVideoQPMapElementDataType.xml' path='doc/member[@name="eAVEncVideoQPMapElementDataType.CODEC_API_QP_MAP_INT16"]/*' />
    CODEC_API_QP_MAP_INT16 = 0x00000001,

    /// <include file='eAVEncVideoQPMapElementDataType.xml' path='doc/member[@name="eAVEncVideoQPMapElementDataType.CODEC_API_QP_MAP_INT32"]/*' />
    CODEC_API_QP_MAP_INT32 = 0x00000002,

    /// <include file='eAVEncVideoQPMapElementDataType.xml' path='doc/member[@name="eAVEncVideoQPMapElementDataType.CODEC_API_QP_MAP_UINT8"]/*' />
    CODEC_API_QP_MAP_UINT8 = unchecked((int)(0x80000000)),

    /// <include file='eAVEncVideoQPMapElementDataType.xml' path='doc/member[@name="eAVEncVideoQPMapElementDataType.CODEC_API_QP_MAP_UINT16"]/*' />
    CODEC_API_QP_MAP_UINT16 = unchecked((int)(0x80000001)),

    /// <include file='eAVEncVideoQPMapElementDataType.xml' path='doc/member[@name="eAVEncVideoQPMapElementDataType.CODEC_API_QP_MAP_UINT32"]/*' />
    CODEC_API_QP_MAP_UINT32 = unchecked((int)(0x80000002)),
}
