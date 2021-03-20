// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("35CAF0D0-47F0-436C-AF97-0DD88F6F5F02")]
    [NativeTypeName("struct ICoreWindow4 : IInspectable")]
    public unsafe partial struct ICoreWindow4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreWindow4*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindow4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreWindow4*, uint>)(lpVtbl[1]))((ICoreWindow4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreWindow4*, uint>)(lpVtbl[2]))((ICoreWindow4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreWindow4*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindow4*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreWindow4*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindow4*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreWindow4*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindow4*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ResizeStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow4*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreWindow4*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ResizeStarted(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow4*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreWindow4*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ResizeCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow4*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICoreWindow4*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ResizeCompleted(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow4*, EventRegistrationToken, int>)(lpVtbl[9]))((ICoreWindow4*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
