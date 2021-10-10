// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DBC6FB30-C843-49E3-A645-573E6F39446A")]
    [NativeTypeName("struct ICredentialProviderCredentialWithFieldOptions : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICredentialProviderCredentialWithFieldOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialWithFieldOptions*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderCredentialWithFieldOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialWithFieldOptions*, uint>)(lpVtbl[1]))((ICredentialProviderCredentialWithFieldOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialWithFieldOptions*, uint>)(lpVtbl[2]))((ICredentialProviderCredentialWithFieldOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetFieldOptions([NativeTypeName("DWORD")] uint fieldID, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS* options)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialWithFieldOptions*, uint, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS*, int>)(lpVtbl[3]))((ICredentialProviderCredentialWithFieldOptions*)Unsafe.AsPointer(ref this), fieldID, options);
        }
    }
}
