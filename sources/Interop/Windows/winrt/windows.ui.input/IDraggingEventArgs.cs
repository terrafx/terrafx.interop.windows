// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1C905384-083C-4BD3-B559-179CDDEB33EC")]
    [NativeTypeName("struct IDraggingEventArgs : IInspectable")]
    public unsafe partial struct IDraggingEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDraggingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDraggingEventArgs*, uint>)(lpVtbl[1]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDraggingEventArgs*, uint>)(lpVtbl[2]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDraggingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDraggingEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDraggingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerDeviceType([NativeTypeName("ABI::Windows::Devices::Input::PointerDeviceType *")] PointerDeviceType* value)
        {
            return ((delegate* unmanaged<IDraggingEventArgs*, PointerDeviceType*, int>)(lpVtbl[6]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<IDraggingEventArgs*, Point*, int>)(lpVtbl[7]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DraggingState([NativeTypeName("ABI::Windows::UI::Input::DraggingState *")] DraggingState* value)
        {
            return ((delegate* unmanaged<IDraggingEventArgs*, DraggingState*, int>)(lpVtbl[8]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
