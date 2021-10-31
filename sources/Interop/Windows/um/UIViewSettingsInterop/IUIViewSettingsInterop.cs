// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIViewSettingsInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3694DBF9-8F68-44BE-8FF5-195C98EDE8A6")]
    [NativeTypeName("struct IUIViewSettingsInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IUIViewSettingsInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIViewSettingsInterop*, Guid*, void**, int>)(lpVtbl[0]))((IUIViewSettingsInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIViewSettingsInterop*, uint>)(lpVtbl[1]))((IUIViewSettingsInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIViewSettingsInterop*, uint>)(lpVtbl[2]))((IUIViewSettingsInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUIViewSettingsInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IUIViewSettingsInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IUIViewSettingsInterop*, HSTRING*, int>)(lpVtbl[4]))((IUIViewSettingsInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUIViewSettingsInterop*, TrustLevel*, int>)(lpVtbl[5]))((IUIViewSettingsInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetForWindow(HWND hwnd, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IUIViewSettingsInterop*, HWND, Guid*, void**, int>)(lpVtbl[6]))((IUIViewSettingsInterop*)Unsafe.AsPointer(ref this), hwnd, riid, ppv);
        }
    }
}
