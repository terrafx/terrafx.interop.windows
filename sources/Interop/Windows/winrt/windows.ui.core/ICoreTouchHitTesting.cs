// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B1D8A289-3ACF-4124-9FA3-EA8ABA353C21")]
    [NativeTypeName("struct ICoreTouchHitTesting : IInspectable")]
    public unsafe partial struct ICoreTouchHitTesting
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreTouchHitTesting*, Guid*, void**, int>)(lpVtbl[0]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreTouchHitTesting*, uint>)(lpVtbl[1]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreTouchHitTesting*, uint>)(lpVtbl[2]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreTouchHitTesting*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreTouchHitTesting*, IntPtr*, int>)(lpVtbl[4]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreTouchHitTesting*, TrustLevel*, int>)(lpVtbl[5]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_TouchHitTesting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CTouchHitTestingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreTouchHitTesting*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_TouchHitTesting(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreTouchHitTesting*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
