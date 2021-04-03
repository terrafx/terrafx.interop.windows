// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("64338358-366A-471B-BD56-DD8EF48E439B")]
    [NativeTypeName("struct IDisplayDeviceInterop : IUnknown")]
    public unsafe partial struct IDisplayDeviceInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDisplayDeviceInterop*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDisplayDeviceInterop*, uint>)(lpVtbl[1]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDisplayDeviceInterop*, uint>)(lpVtbl[2]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle(IInspectable* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pSecurityAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("HSTRING")] IntPtr Name, [NativeTypeName("HANDLE *")] IntPtr* pHandle)
        {
            return ((delegate* unmanaged<IDisplayDeviceInterop*, IInspectable*, SECURITY_ATTRIBUTES*, uint, IntPtr, IntPtr*, int>)(lpVtbl[3]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this), pObject, pSecurityAttributes, Access, Name, pHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandle([NativeTypeName("HANDLE")] IntPtr NTHandle, [NativeTypeName("IID")] Guid riid, void** ppvObj)
        {
            return ((delegate* unmanaged<IDisplayDeviceInterop*, IntPtr, Guid, void**, int>)(lpVtbl[4]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
        }
    }
}
