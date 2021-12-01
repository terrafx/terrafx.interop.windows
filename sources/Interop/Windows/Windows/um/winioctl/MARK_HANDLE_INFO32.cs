// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='MARK_HANDLE_INFO32.xml' path='doc/member[@name="MARK_HANDLE_INFO32"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct MARK_HANDLE_INFO32
{
    /// <include file='MARK_HANDLE_INFO32.xml' path='doc/member[@name="MARK_HANDLE_INFO32.Anonymous"]/*' />
    [NativeTypeName("_MARK_HANDLE_INFO32::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:11717:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='MARK_HANDLE_INFO32.xml' path='doc/member[@name="MARK_HANDLE_INFO32.VolumeHandle"]/*' />
    [NativeTypeName("UINT32")]
    public uint VolumeHandle;

    /// <include file='MARK_HANDLE_INFO32.xml' path='doc/member[@name="MARK_HANDLE_INFO32.HandleInfo"]/*' />
    [NativeTypeName("DWORD")]
    public uint HandleInfo;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UsnSourceInfo"]/*' />
    public ref uint UsnSourceInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.UsnSourceInfo, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CopyNumber"]/*' />
    public ref uint CopyNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.CopyNumber, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UsnSourceInfo"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint UsnSourceInfo;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CopyNumber"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint CopyNumber;
    }
}
