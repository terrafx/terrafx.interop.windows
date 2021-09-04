// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A5DA53F9-D475-4080-A120-910C4A739880")]
    [NativeTypeName("struct ICredentialProviderFilter : IUnknown")]
    public unsafe partial struct ICredentialProviderFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICredentialProviderFilter*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICredentialProviderFilter*, uint>)(lpVtbl[1]))((ICredentialProviderFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICredentialProviderFilter*, uint>)(lpVtbl[2]))((ICredentialProviderFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Filter(CREDENTIAL_PROVIDER_USAGE_SCENARIO cpus, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("GUID *")] Guid* rgclsidProviders, [NativeTypeName("BOOL *")] int* rgbAllow, [NativeTypeName("DWORD")] uint cProviders)
        {
            return ((delegate* unmanaged<ICredentialProviderFilter*, CREDENTIAL_PROVIDER_USAGE_SCENARIO, uint, Guid*, int*, uint, int>)(lpVtbl[3]))((ICredentialProviderFilter*)Unsafe.AsPointer(ref this), cpus, dwFlags, rgclsidProviders, rgbAllow, cProviders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateRemoteCredential([NativeTypeName("const CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *")] CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcsIn, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcsOut)
        {
            return ((delegate* unmanaged<ICredentialProviderFilter*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, int>)(lpVtbl[4]))((ICredentialProviderFilter*)Unsafe.AsPointer(ref this), pcpcsIn, pcpcsOut);
        }
    }
}
