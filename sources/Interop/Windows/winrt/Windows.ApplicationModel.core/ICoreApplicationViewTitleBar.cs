// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("006D35E3-E1F1-431B-9508-29B96926AC53")]
    [NativeTypeName("struct ICoreApplicationViewTitleBar : IInspectable")]
    public unsafe partial struct ICoreApplicationViewTitleBar
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, uint>)(lpVtbl[1]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, uint>)(lpVtbl[2]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, IntPtr*, int>)(lpVtbl[4]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ExtendViewIntoTitleBar([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, byte, int>)(lpVtbl[6]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ExtendViewIntoTitleBar([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, byte*, int>)(lpVtbl[7]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SystemOverlayLeftInset([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, double*, int>)(lpVtbl[8]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SystemOverlayRightInset([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, double*, int>)(lpVtbl[9]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, double*, int>)(lpVtbl[10]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_LayoutMetricsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationViewTitleBar_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_LayoutMetricsChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, EventRegistrationToken, int>)(lpVtbl[12]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsVisible([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, byte*, int>)(lpVtbl[13]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_IsVisibleChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationViewTitleBar_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_IsVisibleChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ICoreApplicationViewTitleBar*, EventRegistrationToken, int>)(lpVtbl[15]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), token);
        }
    }
}
