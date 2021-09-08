// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6BA4205-E59E-4E71-B25B-4E436D21EE3D")]
    [NativeTypeName("struct IDisplayPathInterop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDisplayPathInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDisplayPathInterop*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayPathInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDisplayPathInterop*, uint>)(lpVtbl[1]))((IDisplayPathInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDisplayPathInterop*, uint>)(lpVtbl[2]))((IDisplayPathInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSourcePresentationHandle([NativeTypeName("HANDLE *")] IntPtr* pValue)
        {
            return ((delegate* unmanaged<IDisplayPathInterop*, IntPtr*, int>)(lpVtbl[3]))((IDisplayPathInterop*)Unsafe.AsPointer(ref this), pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceId([NativeTypeName("UINT *")] uint* pSourceId)
        {
            return ((delegate* unmanaged<IDisplayPathInterop*, uint*, int>)(lpVtbl[4]))((IDisplayPathInterop*)Unsafe.AsPointer(ref this), pSourceId);
        }
    }
}
