// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WTD_GENERIC_CHAIN_POLICY_DATA.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_DATA"]/*' />
public unsafe partial struct WTD_GENERIC_CHAIN_POLICY_DATA
{
    /// <include file='WTD_GENERIC_CHAIN_POLICY_DATA.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_DATA.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_SoftPub_L172_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_DATA.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_DATA.pSignerChainInfo"]/*' />
    [NativeTypeName("PWTD_GENERIC_CHAIN_POLICY_CREATE_INFO")]
    public WTD_GENERIC_CHAIN_POLICY_CREATE_INFO* pSignerChainInfo;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_DATA.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_DATA.pCounterSignerChainInfo"]/*' />
    [NativeTypeName("PWTD_GENERIC_CHAIN_POLICY_CREATE_INFO")]
    public WTD_GENERIC_CHAIN_POLICY_CREATE_INFO* pCounterSignerChainInfo;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_DATA.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_DATA.pfnPolicyCallback"]/*' />
    [NativeTypeName("PFN_WTD_GENERIC_CHAIN_POLICY_CALLBACK")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, uint, uint, uint, WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO**, void*, HRESULT> pfnPolicyCallback;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_DATA.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_DATA.pvPolicyArg"]/*' />
    public void* pvPolicyArg;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbStruct"]/*' />
    [UnscopedRef]
    public ref uint cbStruct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.cbStruct;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbSize"]/*' />
    [UnscopedRef]
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.cbSize;
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
