// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserConsentVerifierInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("39E050C3-4E74-441A-8DC0-B81104DF949C")]
    [NativeTypeName("struct IUserConsentVerifierInterop : IInspectable")]
    public unsafe partial struct IUserConsentVerifierInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUserConsentVerifierInterop*, Guid*, void**, int>)(lpVtbl[0]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUserConsentVerifierInterop*, uint>)(lpVtbl[1]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUserConsentVerifierInterop*, uint>)(lpVtbl[2]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged[Stdcall]<IUserConsentVerifierInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged[Stdcall]<IUserConsentVerifierInterop*, IntPtr*, int>)(lpVtbl[4]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IUserConsentVerifierInterop*, TrustLevel*, int>)(lpVtbl[5]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestVerificationForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("HSTRING")] IntPtr message, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** asyncOperation)
        {
            return ((delegate* unmanaged[Stdcall]<IUserConsentVerifierInterop*, IntPtr, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), appWindow, message, riid, asyncOperation);
        }
    }
}
