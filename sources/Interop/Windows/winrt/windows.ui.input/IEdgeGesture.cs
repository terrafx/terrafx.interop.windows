// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("580D5292-2AB1-49AA-A7F0-33BD3F8DF9F1")]
    [NativeTypeName("struct IEdgeGesture : IInspectable")]
    public unsafe partial struct IEdgeGesture
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IEdgeGesture*, Guid*, void**, int>)(lpVtbl[0]))((IEdgeGesture*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEdgeGesture*, uint>)(lpVtbl[1]))((IEdgeGesture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEdgeGesture*, uint>)(lpVtbl[2]))((IEdgeGesture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IEdgeGesture*, uint*, Guid**, int>)(lpVtbl[3]))((IEdgeGesture*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IEdgeGesture*, IntPtr*, int>)(lpVtbl[4]))((IEdgeGesture*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IEdgeGesture*, TrustLevel*, int>)(lpVtbl[5]))((IEdgeGesture*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Starting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IEdgeGesture*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IEdgeGesture*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Starting(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IEdgeGesture*, EventRegistrationToken, int>)(lpVtbl[7]))((IEdgeGesture*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Completed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IEdgeGesture*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IEdgeGesture*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Completed(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IEdgeGesture*, EventRegistrationToken, int>)(lpVtbl[9]))((IEdgeGesture*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Canceled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IEdgeGesture*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IEdgeGesture*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Canceled(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IEdgeGesture*, EventRegistrationToken, int>)(lpVtbl[11]))((IEdgeGesture*)Unsafe.AsPointer(ref this), token);
        }
    }
}
