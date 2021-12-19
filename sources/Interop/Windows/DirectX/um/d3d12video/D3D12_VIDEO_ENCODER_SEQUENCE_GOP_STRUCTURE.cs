// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE
{
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE.DataSize"]/*' />
    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE.Anonymous"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/d3d12video.h:6145:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264GroupOfPictures"]/*' />
    public ref D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264* pH264GroupOfPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pH264GroupOfPictures;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCGroupOfPictures"]/*' />
    public ref D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC* pHEVCGroupOfPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pHEVCGroupOfPictures;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264GroupOfPictures"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264* pH264GroupOfPictures;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCGroupOfPictures"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC* pHEVCGroupOfPictures;
    }
}
