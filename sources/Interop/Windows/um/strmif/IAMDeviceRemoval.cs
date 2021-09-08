// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F90A6130-B658-11D2-AE49-0000F8754B99")]
    [NativeTypeName("struct IAMDeviceRemoval : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMDeviceRemoval
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMDeviceRemoval*, Guid*, void**, int>)(lpVtbl[0]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMDeviceRemoval*, uint>)(lpVtbl[1]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMDeviceRemoval*, uint>)(lpVtbl[2]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int DeviceInfo([NativeTypeName("CLSID *")] Guid* pclsidInterfaceClass, [NativeTypeName("LPWSTR *")] ushort** pwszSymbolicLink)
        {
            return ((delegate* unmanaged<IAMDeviceRemoval*, Guid*, ushort**, int>)(lpVtbl[3]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this), pclsidInterfaceClass, pwszSymbolicLink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Reassociate()
        {
            return ((delegate* unmanaged<IAMDeviceRemoval*, int>)(lpVtbl[4]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Disassociate()
        {
            return ((delegate* unmanaged<IAMDeviceRemoval*, int>)(lpVtbl[5]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this));
        }
    }
}
