// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A506638D-2A1A-413E-BC75-9F38381CC069")]
    [NativeTypeName("struct IPointerPointStatics : IInspectable")]
    public unsafe partial struct IPointerPointStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPointerPointStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPointerPointStatics*, uint>)(lpVtbl[1]))((IPointerPointStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPointerPointStatics*, uint>)(lpVtbl[2]))((IPointerPointStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPointerPointStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPointerPointStatics*, IntPtr*, int>)(lpVtbl[4]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPointerPointStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPoint([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint** pointerPoint)
        {
            return ((delegate* unmanaged<IPointerPointStatics*, uint, IPointerPoint**, int>)(lpVtbl[6]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), pointerId, pointerPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIntermediatePoints([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **")] IVector<IntPtr>** pointerPoints)
        {
            return ((delegate* unmanaged<IPointerPointStatics*, uint, IVector<IntPtr>**, int>)(lpVtbl[7]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), pointerId, pointerPoints);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPointTransformed([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform *")] IPointerPointTransform* transform, [NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint** pointerPoint)
        {
            return ((delegate* unmanaged<IPointerPointStatics*, uint, IPointerPointTransform*, IPointerPoint**, int>)(lpVtbl[8]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), pointerId, transform, pointerPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIntermediatePointsTransformed([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform *")] IPointerPointTransform* transform, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **")] IVector<IntPtr>** pointerPoints)
        {
            return ((delegate* unmanaged<IPointerPointStatics*, uint, IPointerPointTransform*, IVector<IntPtr>**, int>)(lpVtbl[9]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), pointerId, transform, pointerPoints);
        }
    }
}
