// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("D27C3481-5A1C-45B2-8AAA-C20EBBE8229E")]
    [NativeTypeName("struct ICredentialProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICredentialProvider : ICredentialProvider.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT SetUsageScenario(CREDENTIAL_PROVIDER_USAGE_SCENARIO cpus, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ICredentialProvider*, CREDENTIAL_PROVIDER_USAGE_SCENARIO, uint, int>)(lpVtbl[3]))((ICredentialProvider*)Unsafe.AsPointer(ref this), cpus, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetSerialization([NativeTypeName("const CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *")] CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs)
        {
            return ((delegate* unmanaged<ICredentialProvider*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, int>)(lpVtbl[4]))((ICredentialProvider*)Unsafe.AsPointer(ref this), pcpcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Advise(ICredentialProviderEvents* pcpe, [NativeTypeName("UINT_PTR")] nuint upAdviseContext)
        {
            return ((delegate* unmanaged<ICredentialProvider*, ICredentialProviderEvents*, nuint, int>)(lpVtbl[5]))((ICredentialProvider*)Unsafe.AsPointer(ref this), pcpe, upAdviseContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT UnAdvise()
        {
            return ((delegate* unmanaged<ICredentialProvider*, int>)(lpVtbl[6]))((ICredentialProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetFieldDescriptorCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<ICredentialProvider*, uint*, int>)(lpVtbl[7]))((ICredentialProvider*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetFieldDescriptorAt([NativeTypeName("DWORD")] uint dwIndex, CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR** ppcpfd)
        {
            return ((delegate* unmanaged<ICredentialProvider*, uint, CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR**, int>)(lpVtbl[8]))((ICredentialProvider*)Unsafe.AsPointer(ref this), dwIndex, ppcpfd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetCredentialCount([NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD *")] uint* pdwDefault, BOOL* pbAutoLogonWithDefault)
        {
            return ((delegate* unmanaged<ICredentialProvider*, uint*, uint*, BOOL*, int>)(lpVtbl[9]))((ICredentialProvider*)Unsafe.AsPointer(ref this), pdwCount, pdwDefault, pbAutoLogonWithDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetCredentialAt([NativeTypeName("DWORD")] uint dwIndex, ICredentialProviderCredential** ppcpc)
        {
            return ((delegate* unmanaged<ICredentialProvider*, uint, ICredentialProviderCredential**, int>)(lpVtbl[10]))((ICredentialProvider*)Unsafe.AsPointer(ref this), dwIndex, ppcpc);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetUsageScenario(CREDENTIAL_PROVIDER_USAGE_SCENARIO cpus, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(4)]
            HRESULT SetSerialization([NativeTypeName("const CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *")] CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs);

            [VtblIndex(5)]
            HRESULT Advise(ICredentialProviderEvents* pcpe, [NativeTypeName("UINT_PTR")] nuint upAdviseContext);

            [VtblIndex(6)]
            HRESULT UnAdvise();

            [VtblIndex(7)]
            HRESULT GetFieldDescriptorCount([NativeTypeName("DWORD *")] uint* pdwCount);

            [VtblIndex(8)]
            HRESULT GetFieldDescriptorAt([NativeTypeName("DWORD")] uint dwIndex, CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR** ppcpfd);

            [VtblIndex(9)]
            HRESULT GetCredentialCount([NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD *")] uint* pdwDefault, BOOL* pbAutoLogonWithDefault);

            [VtblIndex(10)]
            HRESULT GetCredentialAt([NativeTypeName("DWORD")] uint dwIndex, ICredentialProviderCredential** ppcpc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, uint> Release;

            [NativeTypeName("HRESULT (CREDENTIAL_PROVIDER_USAGE_SCENARIO, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, CREDENTIAL_PROVIDER_USAGE_SCENARIO, uint, int> SetUsageScenario;

            [NativeTypeName("HRESULT (const CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, int> SetSerialization;

            [NativeTypeName("HRESULT (ICredentialProviderEvents *, UINT_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, ICredentialProviderEvents*, nuint, int> Advise;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, int> UnAdvise;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, uint*, int> GetFieldDescriptorCount;

            [NativeTypeName("HRESULT (DWORD, CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, uint, CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR**, int> GetFieldDescriptorAt;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, uint*, uint*, BOOL*, int> GetCredentialCount;

            [NativeTypeName("HRESULT (DWORD, ICredentialProviderCredential **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProvider*, uint, ICredentialProviderCredential**, int> GetCredentialAt;
        }
    }
}
