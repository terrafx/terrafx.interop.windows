// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("13793285-3EA6-40FD-B420-15F47DA41FBB")]
    [NativeTypeName("struct ICredentialProviderUser : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICredentialProviderUser
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, uint>)(lpVtbl[1]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, uint>)(lpVtbl[2]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetSid([NativeTypeName("LPWSTR *")] ushort** sid)
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, ushort**, int>)(lpVtbl[3]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this), sid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetProviderID([NativeTypeName("GUID *")] Guid* providerID)
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, Guid*, int>)(lpVtbl[4]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this), providerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("LPWSTR *")] ushort** stringValue)
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, PROPERTYKEY*, ushort**, int>)(lpVtbl[5]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this), key, stringValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* value)
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[6]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this), key, value);
        }
    }
}
