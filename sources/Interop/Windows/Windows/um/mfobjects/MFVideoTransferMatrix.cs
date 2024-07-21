// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix"]/*' />
public enum MFVideoTransferMatrix
{
    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_Unknown"]/*' />
    MFVideoTransferMatrix_Unknown = 0,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_BT709"]/*' />
    MFVideoTransferMatrix_BT709 = 1,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_BT601"]/*' />
    MFVideoTransferMatrix_BT601 = 2,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_SMPTE240M"]/*' />
    MFVideoTransferMatrix_SMPTE240M = 3,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_BT2020_10"]/*' />
    MFVideoTransferMatrix_BT2020_10 = 4,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_BT2020_12"]/*' />
    MFVideoTransferMatrix_BT2020_12 = 5,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_Identity"]/*' />
    MFVideoTransferMatrix_Identity = 6,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_FCC47"]/*' />
    MFVideoTransferMatrix_FCC47 = 7,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_YCgCo"]/*' />
    MFVideoTransferMatrix_YCgCo = 8,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_SMPTE2085"]/*' />
    MFVideoTransferMatrix_SMPTE2085 = 9,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_Chroma"]/*' />
    MFVideoTransferMatrix_Chroma = 10,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_Chroma_const"]/*' />
    MFVideoTransferMatrix_Chroma_const = 11,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_ICtCp"]/*' />
    MFVideoTransferMatrix_ICtCp = 12,

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_Last"]/*' />
    MFVideoTransferMatrix_Last = (MFVideoTransferMatrix_ICtCp + 1),

    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_ForceDWORD"]/*' />
    MFVideoTransferMatrix_ForceDWORD = 0x7fffffff,
}
