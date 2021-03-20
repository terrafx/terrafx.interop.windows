// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C79D8A4B-C163-4EE7-803F-67CE79F9972D")]
    [NativeTypeName("struct IPointerPointProperties : IInspectable")]
    public unsafe partial struct IPointerPointProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, Guid*, void**, int>)(lpVtbl[0]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPointerPointProperties*, uint>)(lpVtbl[1]))((IPointerPointProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPointerPointProperties*, uint>)(lpVtbl[2]))((IPointerPointProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, IntPtr*, int>)(lpVtbl[4]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, TrustLevel*, int>)(lpVtbl[5]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Pressure([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, float*, int>)(lpVtbl[6]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsInverted([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[7]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsEraser([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[8]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Orientation([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, float*, int>)(lpVtbl[9]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_XTilt([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, float*, int>)(lpVtbl[10]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_YTilt([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, float*, int>)(lpVtbl[11]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Twist([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, float*, int>)(lpVtbl[12]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ContactRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, Rect*, int>)(lpVtbl[13]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ContactRectRaw([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, Rect*, int>)(lpVtbl[14]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TouchConfidence([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[15]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsLeftButtonPressed([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[16]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsRightButtonPressed([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[17]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsMiddleButtonPressed([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[18]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MouseWheelDelta([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, int*, int>)(lpVtbl[19]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsHorizontalMouseWheel([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[20]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsPrimary([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[21]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsInRange([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[22]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsCanceled([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[23]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsBarrelButtonPressed([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[24]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsXButton1Pressed([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[25]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsXButton2Pressed([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, byte*, int>)(lpVtbl[26]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerUpdateKind([NativeTypeName("ABI::Windows::UI::Input::PointerUpdateKind *")] PointerUpdateKind* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, PointerUpdateKind*, int>)(lpVtbl[27]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasUsage([NativeTypeName("UINT32")] uint usagePage, [NativeTypeName("UINT32")] uint usageId, [NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, uint, uint, byte*, int>)(lpVtbl[28]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), usagePage, usageId, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUsageValue([NativeTypeName("UINT32")] uint usagePage, [NativeTypeName("UINT32")] uint usageId, [NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IPointerPointProperties*, uint, uint, int*, int>)(lpVtbl[29]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), usagePage, usageId, value);
        }
    }
}
