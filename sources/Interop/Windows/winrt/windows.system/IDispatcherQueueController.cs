// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F34E66-50DB-4E36-A98D-61C01B384D20")]
    [NativeTypeName("struct IDispatcherQueueController : IInspectable")]
    public unsafe partial struct IDispatcherQueueController
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDispatcherQueueController*, Guid*, void**, int>)(lpVtbl[0]))((IDispatcherQueueController*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDispatcherQueueController*, uint>)(lpVtbl[1]))((IDispatcherQueueController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDispatcherQueueController*, uint>)(lpVtbl[2]))((IDispatcherQueueController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDispatcherQueueController*, uint*, Guid**, int>)(lpVtbl[3]))((IDispatcherQueueController*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDispatcherQueueController*, IntPtr*, int>)(lpVtbl[4]))((IDispatcherQueueController*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDispatcherQueueController*, TrustLevel*, int>)(lpVtbl[5]))((IDispatcherQueueController*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue** value)
        {
            return ((delegate* unmanaged<IDispatcherQueueController*, IDispatcherQueue**, int>)(lpVtbl[6]))((IDispatcherQueueController*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShutdownQueueAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IDispatcherQueueController*, IAsyncAction**, int>)(lpVtbl[7]))((IDispatcherQueueController*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
