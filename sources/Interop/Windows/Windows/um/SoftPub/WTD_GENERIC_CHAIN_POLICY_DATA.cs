// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct WTD_GENERIC_CHAIN_POLICY_DATA
{
    [NativeTypeName("_WTD_GENERIC_CHAIN_POLICY_DATA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/SoftPub.h:172:5)")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("PWTD_GENERIC_CHAIN_POLICY_CREATE_INFO")]
    public WTD_GENERIC_CHAIN_POLICY_CREATE_INFO* pSignerChainInfo;

    [NativeTypeName("PWTD_GENERIC_CHAIN_POLICY_CREATE_INFO")]
    public WTD_GENERIC_CHAIN_POLICY_CREATE_INFO* pCounterSignerChainInfo;

    [NativeTypeName("PFN_WTD_GENERIC_CHAIN_POLICY_CALLBACK")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, uint, uint, uint, WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO**, void*, HRESULT> pfnPolicyCallback;

    public void* pvPolicyArg;

    public ref uint cbStruct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cbStruct, 1));
        }
    }

    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cbSize, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbSize;
    }
}
