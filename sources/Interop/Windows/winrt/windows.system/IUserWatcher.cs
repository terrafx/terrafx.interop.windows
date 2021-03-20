// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("155EB23B-242A-45E0-A2E9-3171FC6A7FBB")]
    [NativeTypeName("struct IUserWatcher : IInspectable")]
    public unsafe partial struct IUserWatcher
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IUserWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserWatcher*, uint>)(lpVtbl[1]))((IUserWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserWatcher*, uint>)(lpVtbl[2]))((IUserWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IUserWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserWatcher*, IntPtr*, int>)(lpVtbl[4]))((IUserWatcher*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IUserWatcher*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Status([NativeTypeName("ABI::Windows::System::UserWatcherStatus *")] UserWatcherStatus* value)
        {
            return ((delegate* unmanaged<IUserWatcher*, UserWatcherStatus*, int>)(lpVtbl[6]))((IUserWatcher*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<IUserWatcher*, int>)(lpVtbl[7]))((IUserWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IUserWatcher*, int>)(lpVtbl[8]))((IUserWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IUserWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Added(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[10]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IUserWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Removed(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[12]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IUserWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Updated(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[14]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_AuthenticationStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IUserWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_AuthenticationStatusChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[16]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_AuthenticationStatusChanging([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserAuthenticationStatusChangingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IUserWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_AuthenticationStatusChanging(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[18]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IUserWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[19]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_EnumerationCompleted(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[20]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IUserWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[21]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Stopped(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[22]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
        }
    }
}
