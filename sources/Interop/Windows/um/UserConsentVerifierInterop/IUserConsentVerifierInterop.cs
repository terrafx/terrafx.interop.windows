// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserConsentVerifierInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("39E050C3-4E74-441A-8DC0-B81104DF949C")]
    [NativeTypeName("struct IUserConsentVerifierInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IUserConsentVerifierInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUserConsentVerifierInterop*, Guid*, void**, int>)(lpVtbl[0]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserConsentVerifierInterop*, uint>)(lpVtbl[1]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserConsentVerifierInterop*, uint>)(lpVtbl[2]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserConsentVerifierInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IUserConsentVerifierInterop*, HSTRING*, int>)(lpVtbl[4]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserConsentVerifierInterop*, TrustLevel*, int>)(lpVtbl[5]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RequestVerificationForWindowAsync(HWND appWindow, HSTRING message, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IUserConsentVerifierInterop*, HWND, HSTRING, Guid*, void**, int>)(lpVtbl[6]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), appWindow, message, riid, asyncOperation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserConsentVerifierInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUserConsentVerifierInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUserConsentVerifierInterop*, uint> Release;

            [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserConsentVerifierInterop*, uint*, Guid**, int> GetIids;

            [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserConsentVerifierInterop*, HSTRING*, int> GetRuntimeClassName;

            [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserConsentVerifierInterop*, TrustLevel*, int> GetTrustLevel;

            [NativeTypeName("HRESULT (HWND, HSTRING, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserConsentVerifierInterop*, HWND, HSTRING, Guid*, void**, int> RequestVerificationForWindowAsync;
        }
    }
}
