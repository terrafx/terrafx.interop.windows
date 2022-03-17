// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_LEVEL_SETTING.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_LEVEL_SETTING"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_LEVEL_SETTING
{
    /// <include file='D3D12_VIDEO_ENCODER_LEVEL_SETTING.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_LEVEL_SETTING.DataSize"]/*' />
    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_LEVEL_SETTING.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_LEVEL_SETTING.Anonymous"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_LEVEL_SETTING::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/d3d12video.h:5730:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264LevelSetting"]/*' />
    public ref D3D12_VIDEO_ENCODER_LEVELS_H264* pH264LevelSetting
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pH264LevelSetting;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCLevelSetting"]/*' />
    public ref D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC* pHEVCLevelSetting
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pHEVCLevelSetting;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264LevelSetting"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_LEVELS_H264* pH264LevelSetting;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCLevelSetting"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC* pHEVCLevelSetting;
    }
}
