// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIXERCONTROLDETAILS.xml' path='doc/member[@name="MIXERCONTROLDETAILS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERCONTROLDETAILS
{
    /// <include file='MIXERCONTROLDETAILS.xml' path='doc/member[@name="MIXERCONTROLDETAILS.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MIXERCONTROLDETAILS.xml' path='doc/member[@name="MIXERCONTROLDETAILS.dwControlID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwControlID;

    /// <include file='MIXERCONTROLDETAILS.xml' path='doc/member[@name="MIXERCONTROLDETAILS.cChannels"]/*' />
    [NativeTypeName("DWORD")]
    public uint cChannels;

    /// <include file='MIXERCONTROLDETAILS.xml' path='doc/member[@name="MIXERCONTROLDETAILS.Anonymous"]/*' />
    [NativeTypeName("tMIXERCONTROLDETAILS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mmeapi.h:2308:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='MIXERCONTROLDETAILS.xml' path='doc/member[@name="MIXERCONTROLDETAILS.cbDetails"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbDetails;

    /// <include file='MIXERCONTROLDETAILS.xml' path='doc/member[@name="MIXERCONTROLDETAILS.paDetails"]/*' />
    [NativeTypeName("LPVOID")]
    public void* paDetails;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hwndOwner"]/*' />
    public ref HWND hwndOwner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.hwndOwner;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cMultipleItems"]/*' />
    public ref uint cMultipleItems
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cMultipleItems, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hwndOwner"]/*' />
        [FieldOffset(0)]
        public HWND hwndOwner;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cMultipleItems"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cMultipleItems;
    }
}
