// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BCA5E023-7DD9-4B6B-9A92-55D43CB38F73")]
    [NativeTypeName("struct IMouseCapabilities : IInspectable")]
    public unsafe partial struct IMouseCapabilities
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMouseCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IMouseCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMouseCapabilities*, uint>)(lpVtbl[1]))((IMouseCapabilities*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMouseCapabilities*, uint>)(lpVtbl[2]))((IMouseCapabilities*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IMouseCapabilities*, uint*, Guid**, int>)(lpVtbl[3]))((IMouseCapabilities*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IMouseCapabilities*, IntPtr*, int>)(lpVtbl[4]))((IMouseCapabilities*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IMouseCapabilities*, TrustLevel*, int>)(lpVtbl[5]))((IMouseCapabilities*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MousePresent([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IMouseCapabilities*, int*, int>)(lpVtbl[6]))((IMouseCapabilities*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VerticalWheelPresent([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IMouseCapabilities*, int*, int>)(lpVtbl[7]))((IMouseCapabilities*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HorizontalWheelPresent([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IMouseCapabilities*, int*, int>)(lpVtbl[8]))((IMouseCapabilities*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SwapButtons([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IMouseCapabilities*, int*, int>)(lpVtbl[9]))((IMouseCapabilities*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NumberOfButtons([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IMouseCapabilities*, uint*, int>)(lpVtbl[10]))((IMouseCapabilities*)Unsafe.AsPointer(ref this), value);
        }
    }
}
