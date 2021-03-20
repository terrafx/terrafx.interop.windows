// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8506B35D-F640-4412-ABA0-BAD077E5EA8A")]
    [NativeTypeName("struct IRadialControllerMenu : IInspectable")]
    public unsafe partial struct IRadialControllerMenu
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, uint>)(lpVtbl[1]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, uint>)(lpVtbl[2]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Items([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CRadialControllerMenuItem_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, IVector<IntPtr>**, int>)(lpVtbl[6]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsEnabled([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, byte*, int>)(lpVtbl[7]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsEnabled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, byte, int>)(lpVtbl[8]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectedMenuItem([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result)
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, IRadialControllerMenuItem**, int>)(lpVtbl[9]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SelectMenuItem([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem *")] IRadialControllerMenuItem* menuItem)
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, IRadialControllerMenuItem*, int>)(lpVtbl[10]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), menuItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TrySelectPreviouslySelectedMenuItem([NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IRadialControllerMenu*, byte*, int>)(lpVtbl[11]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), result);
        }
    }
}
