// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0A6C98E0-5198-49A2-A313-3F70D1F13C27")]
    [NativeTypeName("struct IDispatcherQueueControllerStatics : IInspectable")]
    public unsafe partial struct IDispatcherQueueControllerStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDispatcherQueueControllerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDispatcherQueueControllerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDispatcherQueueControllerStatics*, uint>)(lpVtbl[1]))((IDispatcherQueueControllerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDispatcherQueueControllerStatics*, uint>)(lpVtbl[2]))((IDispatcherQueueControllerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDispatcherQueueControllerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDispatcherQueueControllerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDispatcherQueueControllerStatics*, IntPtr*, int>)(lpVtbl[4]))((IDispatcherQueueControllerStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDispatcherQueueControllerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDispatcherQueueControllerStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateOnDedicatedThread([NativeTypeName("ABI::Windows::System::IDispatcherQueueController **")] IDispatcherQueueController** result)
        {
            return ((delegate* unmanaged<IDispatcherQueueControllerStatics*, IDispatcherQueueController**, int>)(lpVtbl[6]))((IDispatcherQueueControllerStatics*)Unsafe.AsPointer(ref this), result);
        }
    }
}
