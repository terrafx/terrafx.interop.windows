// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("632FB07B-20BD-5E15-AF4A-00DBF2064FFA")]
    [NativeTypeName("struct ISystemButtonEventControllerStatics : IInspectable")]
    public unsafe partial struct ISystemButtonEventControllerStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemButtonEventControllerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemButtonEventControllerStatics*, uint>)(lpVtbl[1]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemButtonEventControllerStatics*, uint>)(lpVtbl[2]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemButtonEventControllerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemButtonEventControllerStatics*, IntPtr*, int>)(lpVtbl[4]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemButtonEventControllerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateForDispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue *")] IDispatcherQueue* queue, [NativeTypeName("ABI::Windows::UI::Input::ISystemButtonEventController **")] ISystemButtonEventController** result)
        {
            return ((delegate* unmanaged<ISystemButtonEventControllerStatics*, IDispatcherQueue*, ISystemButtonEventController**, int>)(lpVtbl[6]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this), queue, result);
        }
    }
}
