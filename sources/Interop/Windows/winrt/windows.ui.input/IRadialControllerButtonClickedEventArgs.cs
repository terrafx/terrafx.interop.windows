// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("206AA438-E651-11E5-BF62-2C27D7404E85")]
    [NativeTypeName("struct IRadialControllerButtonClickedEventArgs : IInspectable")]
    public unsafe partial struct IRadialControllerButtonClickedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerButtonClickedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerButtonClickedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerButtonClickedEventArgs*, uint>)(lpVtbl[1]))((IRadialControllerButtonClickedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerButtonClickedEventArgs*, uint>)(lpVtbl[2]))((IRadialControllerButtonClickedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerButtonClickedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerButtonClickedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerButtonClickedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerButtonClickedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerButtonClickedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerButtonClickedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Contact([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerScreenContact **")] IRadialControllerScreenContact** value)
        {
            return ((delegate* unmanaged<IRadialControllerButtonClickedEventArgs*, IRadialControllerScreenContact**, int>)(lpVtbl[6]))((IRadialControllerButtonClickedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
