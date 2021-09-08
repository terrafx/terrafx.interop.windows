// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B9075C7C-D48E-403F-AB99-D6C77A1084AC")]
    [NativeTypeName("struct IBandHost : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBandHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBandHost*, Guid*, void**, int>)(lpVtbl[0]))((IBandHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBandHost*, uint>)(lpVtbl[1]))((IBandHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBandHost*, uint>)(lpVtbl[2]))((IBandHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBand([NativeTypeName("const IID &")] Guid* rclsidBand, [NativeTypeName("BOOL")] int fAvailable, [NativeTypeName("BOOL")] int fVisible, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IBandHost*, Guid*, int, int, Guid*, void**, int>)(lpVtbl[3]))((IBandHost*)Unsafe.AsPointer(ref this), rclsidBand, fAvailable, fVisible, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetBandAvailability([NativeTypeName("const IID &")] Guid* rclsidBand, [NativeTypeName("BOOL")] int fAvailable)
        {
            return ((delegate* unmanaged<IBandHost*, Guid*, int, int>)(lpVtbl[4]))((IBandHost*)Unsafe.AsPointer(ref this), rclsidBand, fAvailable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int DestroyBand([NativeTypeName("const IID &")] Guid* rclsidBand)
        {
            return ((delegate* unmanaged<IBandHost*, Guid*, int>)(lpVtbl[5]))((IBandHost*)Unsafe.AsPointer(ref this), rclsidBand);
        }
    }
}
