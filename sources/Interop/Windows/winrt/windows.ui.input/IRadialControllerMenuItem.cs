// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C80FC98D-AD0B-4C9C-8F2F-136A2373A6BA")]
    [NativeTypeName("struct IRadialControllerMenuItem : IInspectable")]
    public unsafe partial struct IRadialControllerMenuItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, uint>)(lpVtbl[1]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, uint>)(lpVtbl[2]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisplayText([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, IntPtr*, int>)(lpVtbl[6]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Tag([NativeTypeName("IInspectable **")] IInspectable** value)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, IInspectable**, int>)(lpVtbl[7]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Tag([NativeTypeName("IInspectable *")] IInspectable* value)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, IInspectable*, int>)(lpVtbl[8]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Invoked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialControllerMenuItem_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Invoked(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItem*, EventRegistrationToken, int>)(lpVtbl[10]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), token);
        }
    }
}
