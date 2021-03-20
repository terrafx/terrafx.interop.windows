// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EAD0CA44-9DED-4037-8149-5E4CC2564468")]
    [NativeTypeName("struct IMouseWheelParameters : IInspectable")]
    public unsafe partial struct IMouseWheelParameters
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, Guid*, void**, int>)(lpVtbl[0]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, uint>)(lpVtbl[1]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, uint>)(lpVtbl[2]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, uint*, Guid**, int>)(lpVtbl[3]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, IntPtr*, int>)(lpVtbl[4]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, TrustLevel*, int>)(lpVtbl[5]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CharTranslation([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, Point*, int>)(lpVtbl[6]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CharTranslation([NativeTypeName("ABI::Windows::Foundation::Point")] Point value)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, Point, int>)(lpVtbl[7]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DeltaScale([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, float*, int>)(lpVtbl[8]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DeltaScale([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, float, int>)(lpVtbl[9]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DeltaRotationAngle([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, float*, int>)(lpVtbl[10]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DeltaRotationAngle([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, float, int>)(lpVtbl[11]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PageTranslation([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, Point*, int>)(lpVtbl[12]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PageTranslation([NativeTypeName("ABI::Windows::Foundation::Point")] Point value)
        {
            return ((delegate* unmanaged<IMouseWheelParameters*, Point, int>)(lpVtbl[13]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
        }
    }
}
