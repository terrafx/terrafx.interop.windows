// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6F5E63C7-E3AA-4EAE-B0E0-DCF321CA4B2F")]
    [NativeTypeName("struct ICoreDispatcher2 : IInspectable")]
    public unsafe partial struct ICoreDispatcher2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreDispatcher2*, Guid*, void**, int>)(lpVtbl[0]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreDispatcher2*, uint>)(lpVtbl[1]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreDispatcher2*, uint>)(lpVtbl[2]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreDispatcher2*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreDispatcher2*, IntPtr*, int>)(lpVtbl[4]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreDispatcher2*, TrustLevel*, int>)(lpVtbl[5]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryRunAsync([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority priority, [NativeTypeName("ABI::Windows::UI::Core::IDispatchedHandler *")] IDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** asyncOperation)
        {
            return ((delegate* unmanaged<ICoreDispatcher2*, CoreDispatcherPriority, IDispatchedHandler*, IAsyncOperation<byte>**, int>)(lpVtbl[6]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), priority, agileCallback, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryRunIdleAsync([NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandler *")] IIdleDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** asyncOperation)
        {
            return ((delegate* unmanaged<ICoreDispatcher2*, IIdleDispatchedHandler*, IAsyncOperation<byte>**, int>)(lpVtbl[7]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), agileCallback, asyncOperation);
        }
    }
}
