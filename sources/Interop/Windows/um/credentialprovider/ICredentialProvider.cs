// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D27C3481-5A1C-45B2-8AAA-C20EBBE8229E")]
    [NativeTypeName("struct ICredentialProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICredentialProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICredentialProvider*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICredentialProvider*, uint>)(lpVtbl[1]))((ICredentialProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICredentialProvider*, uint>)(lpVtbl[2]))((ICredentialProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetUsageScenario(CREDENTIAL_PROVIDER_USAGE_SCENARIO cpus, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ICredentialProvider*, CREDENTIAL_PROVIDER_USAGE_SCENARIO, uint, int>)(lpVtbl[3]))((ICredentialProvider*)Unsafe.AsPointer(ref this), cpus, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetSerialization([NativeTypeName("const CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *")] CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs)
        {
            return ((delegate* unmanaged<ICredentialProvider*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, int>)(lpVtbl[4]))((ICredentialProvider*)Unsafe.AsPointer(ref this), pcpcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Advise(ICredentialProviderEvents* pcpe, [NativeTypeName("UINT_PTR")] nuint upAdviseContext)
        {
            return ((delegate* unmanaged<ICredentialProvider*, ICredentialProviderEvents*, nuint, int>)(lpVtbl[5]))((ICredentialProvider*)Unsafe.AsPointer(ref this), pcpe, upAdviseContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int UnAdvise()
        {
            return ((delegate* unmanaged<ICredentialProvider*, int>)(lpVtbl[6]))((ICredentialProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetFieldDescriptorCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<ICredentialProvider*, uint*, int>)(lpVtbl[7]))((ICredentialProvider*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetFieldDescriptorAt([NativeTypeName("DWORD")] uint dwIndex, CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR** ppcpfd)
        {
            return ((delegate* unmanaged<ICredentialProvider*, uint, CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR**, int>)(lpVtbl[8]))((ICredentialProvider*)Unsafe.AsPointer(ref this), dwIndex, ppcpfd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetCredentialCount([NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD *")] uint* pdwDefault, BOOL* pbAutoLogonWithDefault)
        {
            return ((delegate* unmanaged<ICredentialProvider*, uint*, uint*, BOOL*, int>)(lpVtbl[9]))((ICredentialProvider*)Unsafe.AsPointer(ref this), pdwCount, pdwDefault, pbAutoLogonWithDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetCredentialAt([NativeTypeName("DWORD")] uint dwIndex, ICredentialProviderCredential** ppcpc)
        {
            return ((delegate* unmanaged<ICredentialProvider*, uint, ICredentialProviderCredential**, int>)(lpVtbl[10]))((ICredentialProvider*)Unsafe.AsPointer(ref this), dwIndex, ppcpc);
        }
    }
}
