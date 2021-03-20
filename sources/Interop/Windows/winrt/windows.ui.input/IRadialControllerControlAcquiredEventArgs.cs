// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("206AA439-E651-11E5-BF62-2C27D7404E85")]
    [NativeTypeName("struct IRadialControllerControlAcquiredEventArgs : IInspectable")]
    public unsafe partial struct IRadialControllerControlAcquiredEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerControlAcquiredEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerControlAcquiredEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerControlAcquiredEventArgs*, uint>)(lpVtbl[1]))((IRadialControllerControlAcquiredEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerControlAcquiredEventArgs*, uint>)(lpVtbl[2]))((IRadialControllerControlAcquiredEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerControlAcquiredEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerControlAcquiredEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerControlAcquiredEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerControlAcquiredEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerControlAcquiredEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerControlAcquiredEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Contact([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerScreenContact **")] IRadialControllerScreenContact** value)
        {
            return ((delegate* unmanaged<IRadialControllerControlAcquiredEventArgs*, IRadialControllerScreenContact**, int>)(lpVtbl[6]))((IRadialControllerControlAcquiredEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
