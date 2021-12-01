// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='HTTPSPolicyCallbackData.xml' path='doc/member[@name="HTTPSPolicyCallbackData"]/*' />
public unsafe partial struct HTTPSPolicyCallbackData
{
    /// <include file='HTTPSPolicyCallbackData.xml' path='doc/member[@name="HTTPSPolicyCallbackData.Anonymous"]/*' />
    [NativeTypeName("_HTTPSPolicyCallbackData::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wincrypt.h:20180:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='HTTPSPolicyCallbackData.xml' path='doc/member[@name="HTTPSPolicyCallbackData.dwAuthType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAuthType;

    /// <include file='HTTPSPolicyCallbackData.xml' path='doc/member[@name="HTTPSPolicyCallbackData.fdwChecks"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwChecks;

    /// <include file='HTTPSPolicyCallbackData.xml' path='doc/member[@name="HTTPSPolicyCallbackData.pwszServerName"]/*' />
    [NativeTypeName("WCHAR *")]
    public ushort* pwszServerName;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbStruct"]/*' />
    public ref uint cbStruct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cbStruct, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbSize"]/*' />
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cbSize, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbStruct"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbSize"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbSize;
    }
}
