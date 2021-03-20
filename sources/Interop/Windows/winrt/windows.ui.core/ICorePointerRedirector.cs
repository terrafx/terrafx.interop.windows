// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8F9D0C94-5688-4B0C-A9F1-F931F7FA3DC3")]
    [NativeTypeName("struct ICorePointerRedirector : IInspectable")]
    public unsafe partial struct ICorePointerRedirector
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, Guid*, void**, int>)(lpVtbl[0]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, uint>)(lpVtbl[1]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, uint>)(lpVtbl[2]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, uint*, Guid**, int>)(lpVtbl[3]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, IntPtr*, int>)(lpVtbl[4]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, TrustLevel*, int>)(lpVtbl[5]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerRoutedAway([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerRoutedAway(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, EventRegistrationToken, int>)(lpVtbl[7]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerRoutedTo([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerRoutedTo(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, EventRegistrationToken, int>)(lpVtbl[9]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerRoutedReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerRoutedReleased(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICorePointerRedirector*, EventRegistrationToken, int>)(lpVtbl[11]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
