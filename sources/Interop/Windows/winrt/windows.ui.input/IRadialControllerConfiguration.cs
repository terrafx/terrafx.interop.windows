// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6B79ECB-6A52-4430-910C-56370A9D6B42")]
    [NativeTypeName("struct IRadialControllerConfiguration : IInspectable")]
    public unsafe partial struct IRadialControllerConfiguration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration*, uint>)(lpVtbl[1]))((IRadialControllerConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration*, uint>)(lpVtbl[2]))((IRadialControllerConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerConfiguration*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerConfiguration*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerConfiguration*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultMenuItems([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CUI__CInput__CRadialControllerSystemMenuItemKind_t *")] IIterable<RadialControllerSystemMenuItemKind>* buttons)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration*, IIterable<RadialControllerSystemMenuItemKind>*, int>)(lpVtbl[6]))((IRadialControllerConfiguration*)Unsafe.AsPointer(ref this), buttons);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResetToDefaultMenuItems()
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration*, int>)(lpVtbl[7]))((IRadialControllerConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TrySelectDefaultMenuItem([NativeTypeName("ABI::Windows::UI::Input::RadialControllerSystemMenuItemKind")] RadialControllerSystemMenuItemKind type, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration*, RadialControllerSystemMenuItemKind, byte*, int>)(lpVtbl[8]))((IRadialControllerConfiguration*)Unsafe.AsPointer(ref this), type, result);
        }
    }
}
