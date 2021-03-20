// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFA126E4-253A-4C3C-953B-395C37AED309")]
    [NativeTypeName("struct ITappedEventArgs : IInspectable")]
    public unsafe partial struct ITappedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITappedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ITappedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITappedEventArgs*, uint>)(lpVtbl[1]))((ITappedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITappedEventArgs*, uint>)(lpVtbl[2]))((ITappedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ITappedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ITappedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ITappedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((ITappedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ITappedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ITappedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerDeviceType([NativeTypeName("ABI::Windows::Devices::Input::PointerDeviceType *")] PointerDeviceType* value)
        {
            return ((delegate* unmanaged<ITappedEventArgs*, PointerDeviceType*, int>)(lpVtbl[6]))((ITappedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<ITappedEventArgs*, Point*, int>)(lpVtbl[7]))((ITappedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TapCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ITappedEventArgs*, uint*, int>)(lpVtbl[8]))((ITappedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
