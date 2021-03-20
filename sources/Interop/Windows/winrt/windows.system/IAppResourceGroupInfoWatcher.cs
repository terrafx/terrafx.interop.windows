// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D9B0A0FD-6E5A-4C72-8B17-09FEC4A212BD")]
    [NativeTypeName("struct IAppResourceGroupInfoWatcher : IInspectable")]
    public unsafe partial struct IAppResourceGroupInfoWatcher
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, uint>)(lpVtbl[1]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, uint>)(lpVtbl[2]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, IntPtr*, int>)(lpVtbl[4]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Added(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[7]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Removed(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[9]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_EnumerationCompleted(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[11]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Stopped(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[13]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ExecutionStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherExecutionStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ExecutionStateChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[15]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Status([NativeTypeName("ABI::Windows::System::AppResourceGroupInfoWatcherStatus *")] AppResourceGroupInfoWatcherStatus* status)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, AppResourceGroupInfoWatcherStatus*, int>)(lpVtbl[16]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, int>)(lpVtbl[17]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcher*, int>)(lpVtbl[18]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this));
        }
    }
}
