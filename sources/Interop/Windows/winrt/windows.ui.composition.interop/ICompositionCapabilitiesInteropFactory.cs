// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C9DB356-E70D-4642-8298-BC4AA5B4865C")]
    [NativeTypeName("struct ICompositionCapabilitiesInteropFactory : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct ICompositionCapabilitiesInteropFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICompositionCapabilitiesInteropFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICompositionCapabilitiesInteropFactory*, uint>)(lpVtbl[1]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICompositionCapabilitiesInteropFactory*, uint>)(lpVtbl[2]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICompositionCapabilitiesInteropFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<ICompositionCapabilitiesInteropFactory*, HSTRING*, int>)(lpVtbl[4]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICompositionCapabilitiesInteropFactory*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetForWindow(HWND hwnd, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionCapabilities **")] void** result)
        {
            return ((delegate* unmanaged<ICompositionCapabilitiesInteropFactory*, HWND, void**, int>)(lpVtbl[6]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this), hwnd, result);
        }
    }
}
