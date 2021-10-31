// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SystemMediaTransportControlsInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DDB0472D-C911-4A1F-86D9-DC3D71A95F5A")]
    [NativeTypeName("struct ISystemMediaTransportControlsInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct ISystemMediaTransportControlsInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemMediaTransportControlsInterop*, Guid*, void**, int>)(lpVtbl[0]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemMediaTransportControlsInterop*, uint>)(lpVtbl[1]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemMediaTransportControlsInterop*, uint>)(lpVtbl[2]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemMediaTransportControlsInterop*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemMediaTransportControlsInterop*, IntPtr*, int>)(lpVtbl[4]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemMediaTransportControlsInterop*, TrustLevel*, int>)(lpVtbl[5]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetForWindow([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, void** mediaTransportControl)
        {
            return ((delegate* unmanaged<ISystemMediaTransportControlsInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this), appWindow, riid, mediaTransportControl);
        }
    }
}
