// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C9DB356-E70D-4642-8298-BC4AA5B4865C")]
    public unsafe partial struct ICompositionCapabilitiesInteropFactory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICompositionCapabilitiesInteropFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICompositionCapabilitiesInteropFactory*, uint>)(lpVtbl[1]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICompositionCapabilitiesInteropFactory*, uint>)(lpVtbl[2]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* stdcall<ICompositionCapabilitiesInteropFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* stdcall<ICompositionCapabilitiesInteropFactory*, IntPtr*, int>)(lpVtbl[4]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this), className);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* stdcall<ICompositionCapabilitiesInteropFactory*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetForWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionCapabilities **")] void** result)
        {
            return ((delegate* stdcall<ICompositionCapabilitiesInteropFactory*, IntPtr, void**, int>)(lpVtbl[6]))((ICompositionCapabilitiesInteropFactory*)Unsafe.AsPointer(ref this), hwnd, result);
        }
    }
}
