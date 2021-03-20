// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E995317D-7296-42D9-8233-C5BE73B74A4A")]
    [NativeTypeName("struct IPointerPoint : IInspectable")]
    public unsafe partial struct IPointerPoint
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPointerPoint*, Guid*, void**, int>)(lpVtbl[0]))((IPointerPoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPointerPoint*, uint>)(lpVtbl[1]))((IPointerPoint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPointerPoint*, uint>)(lpVtbl[2]))((IPointerPoint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPointerPoint*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerPoint*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPointerPoint*, IntPtr*, int>)(lpVtbl[4]))((IPointerPoint*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPointerPoint*, TrustLevel*, int>)(lpVtbl[5]))((IPointerPoint*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerDevice([NativeTypeName("ABI::Windows::Devices::Input::IPointerDevice **")] IPointerDevice** value)
        {
            return ((delegate* unmanaged<IPointerPoint*, IPointerDevice**, int>)(lpVtbl[6]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<IPointerPoint*, Point*, int>)(lpVtbl[7]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RawPosition([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<IPointerPoint*, Point*, int>)(lpVtbl[8]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerId([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IPointerPoint*, uint*, int>)(lpVtbl[9]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FrameId([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IPointerPoint*, uint*, int>)(lpVtbl[10]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Timestamp([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IPointerPoint*, ulong*, int>)(lpVtbl[11]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsInContact([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPoint*, byte*, int>)(lpVtbl[12]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Properties([NativeTypeName("ABI::Windows::UI::Input::IPointerPointProperties **")] IPointerPointProperties** value)
        {
            return ((delegate* unmanaged<IPointerPoint*, IPointerPointProperties**, int>)(lpVtbl[13]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
        }
    }
}
