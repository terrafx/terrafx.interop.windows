// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SystemMediaTransportControlsInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DDB0472D-C911-4A1F-86D9-DC3D71A95F5A")]
    [NativeTypeName("struct ISystemMediaTransportControlsInterop : IInspectable")]
    public unsafe partial struct ISystemMediaTransportControlsInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISystemMediaTransportControlsInterop*, Guid*, void**, int>)(lpVtbl[0]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISystemMediaTransportControlsInterop*, uint>)(lpVtbl[1]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISystemMediaTransportControlsInterop*, uint>)(lpVtbl[2]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged[Stdcall]<ISystemMediaTransportControlsInterop*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged[Stdcall]<ISystemMediaTransportControlsInterop*, IntPtr*, int>)(lpVtbl[4]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged[Stdcall]<ISystemMediaTransportControlsInterop*, TrustLevel*, int>)(lpVtbl[5]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForWindow([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** mediaTransportControl)
        {
            return ((delegate* unmanaged[Stdcall]<ISystemMediaTransportControlsInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((ISystemMediaTransportControlsInterop*)Unsafe.AsPointer(ref this), appWindow, riid, mediaTransportControl);
        }
    }
}
