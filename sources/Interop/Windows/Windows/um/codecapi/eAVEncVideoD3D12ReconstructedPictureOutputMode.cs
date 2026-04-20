// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='eAVEncVideoD3D12ReconstructedPictureOutputMode.xml' path='doc/member[@name="eAVEncVideoD3D12ReconstructedPictureOutputMode"]/*' />
public enum eAVEncVideoD3D12ReconstructedPictureOutputMode
{
    /// <include file='eAVEncVideoD3D12ReconstructedPictureOutputMode.xml' path='doc/member[@name="eAVEncVideoD3D12ReconstructedPictureOutputMode.eAVEncVideoEncodeD3D12ReconstructedPictureMode_None"]/*' />
    eAVEncVideoEncodeD3D12ReconstructedPictureMode_None = 0,

    /// <include file='eAVEncVideoD3D12ReconstructedPictureOutputMode.xml' path='doc/member[@name="eAVEncVideoD3D12ReconstructedPictureOutputMode.eAVEncVideoEncodeD3D12ReconstructedPictureMode_Copy"]/*' />
    eAVEncVideoEncodeD3D12ReconstructedPictureMode_Copy = 1,

    /// <include file='eAVEncVideoD3D12ReconstructedPictureOutputMode.xml' path='doc/member[@name="eAVEncVideoD3D12ReconstructedPictureOutputMode.eAVEncVideoEncodeD3D12ReconstructedPictureMode_Shared"]/*' />
    eAVEncVideoEncodeD3D12ReconstructedPictureMode_Shared = 2,
}
