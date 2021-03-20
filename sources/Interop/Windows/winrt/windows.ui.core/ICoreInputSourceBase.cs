// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9F488807-4580-4BE8-BE68-92A9311713BB")]
    [NativeTypeName("struct ICoreInputSourceBase : IInspectable")]
    public unsafe partial struct ICoreInputSourceBase
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, uint>)(lpVtbl[1]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, uint>)(lpVtbl[2]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, IntPtr*, int>)(lpVtbl[4]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, TrustLevel*, int>)(lpVtbl[5]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Dispatcher([NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher** value)
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, ICoreDispatcher**, int>)(lpVtbl[6]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsInputEnabled([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, byte*, int>)(lpVtbl[7]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsInputEnabled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, byte, int>)(lpVtbl[8]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_InputEnabled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CInputEnabledEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_InputEnabled(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreInputSourceBase*, EventRegistrationToken, int>)(lpVtbl[10]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
