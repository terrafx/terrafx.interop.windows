// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("60DB2FA8-B705-4FDE-A7D6-EBBB1891D39E")]
    [NativeTypeName("struct ICoreDispatcher : IInspectable")]
    public unsafe partial struct ICoreDispatcher
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreDispatcher*, Guid*, void**, int>)(lpVtbl[0]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreDispatcher*, uint>)(lpVtbl[1]))((ICoreDispatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreDispatcher*, uint>)(lpVtbl[2]))((ICoreDispatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreDispatcher*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreDispatcher*, IntPtr*, int>)(lpVtbl[4]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreDispatcher*, TrustLevel*, int>)(lpVtbl[5]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HasThreadAccess([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreDispatcher*, byte*, int>)(lpVtbl[6]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessEvents([NativeTypeName("ABI::Windows::UI::Core::CoreProcessEventsOption")] CoreProcessEventsOption options)
        {
            return ((delegate* unmanaged<ICoreDispatcher*, CoreProcessEventsOption, int>)(lpVtbl[7]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RunAsync([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority priority, [NativeTypeName("ABI::Windows::UI::Core::IDispatchedHandler *")] IDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
        {
            return ((delegate* unmanaged<ICoreDispatcher*, CoreDispatcherPriority, IDispatchedHandler*, IAsyncAction**, int>)(lpVtbl[8]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), priority, agileCallback, asyncAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RunIdleAsync([NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandler *")] IIdleDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
        {
            return ((delegate* unmanaged<ICoreDispatcher*, IIdleDispatchedHandler*, IAsyncAction**, int>)(lpVtbl[9]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), agileCallback, asyncAction);
        }
    }
}
