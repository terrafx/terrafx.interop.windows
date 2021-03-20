// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F9F63BA2-CEBA-4755-8A7E-14C0FFECD239")]
    [NativeTypeName("struct IKeyboardDeliveryInterceptorStatics : IInspectable")]
    public unsafe partial struct IKeyboardDeliveryInterceptorStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptorStatics*, uint>)(lpVtbl[1]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptorStatics*, uint>)(lpVtbl[2]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptorStatics*, IntPtr*, int>)(lpVtbl[4]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForCurrentView([NativeTypeName("ABI::Windows::UI::Input::IKeyboardDeliveryInterceptor **")] IKeyboardDeliveryInterceptor** keyboardDeliverySettings)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptorStatics*, IKeyboardDeliveryInterceptor**, int>)(lpVtbl[6]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this), keyboardDeliverySettings);
        }
    }
}
