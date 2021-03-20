// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("59B893A9-73BC-52B5-BA41-82511B2CB46C")]
    [NativeTypeName("struct ISystemButtonEventController : IInspectable")]
    public unsafe partial struct ISystemButtonEventController
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, Guid*, void**, int>)(lpVtbl[0]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, uint>)(lpVtbl[1]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, uint>)(lpVtbl[2]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, IntPtr*, int>)(lpVtbl[4]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, TrustLevel*, int>)(lpVtbl[5]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_SystemFunctionButtonPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionButtonEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_SystemFunctionButtonPressed(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, EventRegistrationToken, int>)(lpVtbl[7]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_SystemFunctionButtonReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionButtonEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_SystemFunctionButtonReleased(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, EventRegistrationToken, int>)(lpVtbl[9]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_SystemFunctionLockChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionLockChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_SystemFunctionLockChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, EventRegistrationToken, int>)(lpVtbl[11]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_SystemFunctionLockIndicatorChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionLockIndicatorChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_SystemFunctionLockIndicatorChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ISystemButtonEventController*, EventRegistrationToken, int>)(lpVtbl[13]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), token);
        }
    }
}
