// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("90C119AE-0F18-4520-A1F1-114366A40FE8")]
    [NativeTypeName("struct ICredentialProviderUserArray : IUnknown")]
    public unsafe partial struct ICredentialProviderUserArray
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICredentialProviderUserArray*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderUserArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICredentialProviderUserArray*, uint>)(lpVtbl[1]))((ICredentialProviderUserArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICredentialProviderUserArray*, uint>)(lpVtbl[2]))((ICredentialProviderUserArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetProviderFilter([NativeTypeName("const GUID &")] Guid* guidProviderToFilterTo)
        {
            return ((delegate* unmanaged<ICredentialProviderUserArray*, Guid*, int>)(lpVtbl[3]))((ICredentialProviderUserArray*)Unsafe.AsPointer(ref this), guidProviderToFilterTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAccountOptions(CREDENTIAL_PROVIDER_ACCOUNT_OPTIONS* credentialProviderAccountOptions)
        {
            return ((delegate* unmanaged<ICredentialProviderUserArray*, CREDENTIAL_PROVIDER_ACCOUNT_OPTIONS*, int>)(lpVtbl[4]))((ICredentialProviderUserArray*)Unsafe.AsPointer(ref this), credentialProviderAccountOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("DWORD *")] uint* userCount)
        {
            return ((delegate* unmanaged<ICredentialProviderUserArray*, uint*, int>)(lpVtbl[5]))((ICredentialProviderUserArray*)Unsafe.AsPointer(ref this), userCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAt([NativeTypeName("DWORD")] uint userIndex, ICredentialProviderUser** user)
        {
            return ((delegate* unmanaged<ICredentialProviderUserArray*, uint, ICredentialProviderUser**, int>)(lpVtbl[6]))((ICredentialProviderUserArray*)Unsafe.AsPointer(ref this), userIndex, user);
        }
    }
}
