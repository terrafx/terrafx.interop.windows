// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("920D9CB1-A5FC-4A21-8C09-49DFE6FFE25F")]
    [NativeTypeName("struct IPointerEventArgs : IInspectable")]
    public unsafe partial struct IPointerEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPointerEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPointerEventArgs*, uint>)(lpVtbl[1]))((IPointerEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPointerEventArgs*, uint>)(lpVtbl[2]))((IPointerEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPointerEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPointerEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPointerEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentPoint([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint** value)
        {
            return ((delegate* unmanaged<IPointerEventArgs*, IPointerPoint**, int>)(lpVtbl[6]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value)
        {
            return ((delegate* unmanaged<IPointerEventArgs*, VirtualKeyModifiers*, int>)(lpVtbl[7]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIntermediatePoints([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IPointerEventArgs*, IVector<IntPtr>**, int>)(lpVtbl[8]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
