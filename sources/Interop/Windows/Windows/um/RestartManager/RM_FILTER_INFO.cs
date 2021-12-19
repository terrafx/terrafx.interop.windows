// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RM_FILTER_INFO.xml' path='doc/member[@name="RM_FILTER_INFO"]/*' />
public unsafe partial struct RM_FILTER_INFO
{
    /// <include file='RM_FILTER_INFO.xml' path='doc/member[@name="RM_FILTER_INFO.FilterAction"]/*' />
    public RM_FILTER_ACTION FilterAction;

    /// <include file='RM_FILTER_INFO.xml' path='doc/member[@name="RM_FILTER_INFO.FilterTrigger"]/*' />
    public RM_FILTER_TRIGGER FilterTrigger;

    /// <include file='RM_FILTER_INFO.xml' path='doc/member[@name="RM_FILTER_INFO.cbNextOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbNextOffset;

    /// <include file='RM_FILTER_INFO.xml' path='doc/member[@name="RM_FILTER_INFO.Anonymous"]/*' />
    [NativeTypeName("_RM_FILTER_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/RestartManager.h:124:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strFilename"]/*' />
    public ref ushort* strFilename
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.strFilename;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Process"]/*' />
    public ref RM_UNIQUE_PROCESS Process
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Process, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strServiceShortName"]/*' />
    public ref ushort* strServiceShortName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.strServiceShortName;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strFilename"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* strFilename;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Process"]/*' />
        [FieldOffset(0)]
        public RM_UNIQUE_PROCESS Process;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strServiceShortName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* strServiceShortName;
    }
}
