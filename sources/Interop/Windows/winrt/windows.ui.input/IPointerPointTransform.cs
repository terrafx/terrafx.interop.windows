// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4D5FE14F-B87C-4028-BC9C-59E9947FB056")]
    [NativeTypeName("struct IPointerPointTransform : IInspectable")]
    public unsafe partial struct IPointerPointTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPointerPointTransform*, Guid*, void**, int>)(lpVtbl[0]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPointerPointTransform*, uint>)(lpVtbl[1]))((IPointerPointTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPointerPointTransform*, uint>)(lpVtbl[2]))((IPointerPointTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPointerPointTransform*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPointerPointTransform*, IntPtr*, int>)(lpVtbl[4]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPointerPointTransform*, TrustLevel*, int>)(lpVtbl[5]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Inverse([NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform **")] IPointerPointTransform** value)
        {
            return ((delegate* unmanaged<IPointerPointTransform*, IPointerPointTransform**, int>)(lpVtbl[6]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryTransform([NativeTypeName("ABI::Windows::Foundation::Point")] Point inPoint, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* outPoint, [NativeTypeName("boolean *")] byte* returnValue)
        {
            return ((delegate* unmanaged<IPointerPointTransform*, Point, Point*, byte*, int>)(lpVtbl[7]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), inPoint, outPoint, returnValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TransformBounds([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect rect, [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* returnValue)
        {
            return ((delegate* unmanaged<IPointerPointTransform*, Rect, Rect*, int>)(lpVtbl[8]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), rect, returnValue);
        }
    }
}
