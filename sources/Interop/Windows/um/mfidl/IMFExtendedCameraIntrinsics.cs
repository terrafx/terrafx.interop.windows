// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("687F6DAC-6987-4750-A16A-734D1E7A10FE")]
    [NativeTypeName("struct IMFExtendedCameraIntrinsics : IUnknown")]
    public unsafe partial struct IMFExtendedCameraIntrinsics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsics*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsics*, uint>)(lpVtbl[1]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsics*, uint>)(lpVtbl[2]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBuffer([NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("DWORD")] uint dwBufferSize)
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsics*, byte*, uint, int>)(lpVtbl[3]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), pbBuffer, dwBufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferSize([NativeTypeName("DWORD *")] uint* pdwBufferSize)
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsics*, uint*, int>)(lpVtbl[4]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), pdwBufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SerializeToBuffer([NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("DWORD *")] uint* pdwBufferSize)
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsics*, byte*, uint*, int>)(lpVtbl[5]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), pbBuffer, pdwBufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIntrinsicModelCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsics*, uint*, int>)(lpVtbl[6]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIntrinsicModelByIndex([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("IMFExtendedCameraIntrinsicModel **")] IMFExtendedCameraIntrinsicModel** ppIntrinsicModel)
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsics*, uint, IMFExtendedCameraIntrinsicModel**, int>)(lpVtbl[7]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), dwIndex, ppIntrinsicModel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddIntrinsicModel([NativeTypeName("IMFExtendedCameraIntrinsicModel *")] IMFExtendedCameraIntrinsicModel* pIntrinsicModel)
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsics*, IMFExtendedCameraIntrinsicModel*, int>)(lpVtbl[8]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), pIntrinsicModel);
        }
    }
}
