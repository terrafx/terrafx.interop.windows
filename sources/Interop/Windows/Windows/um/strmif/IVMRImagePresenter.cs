// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("CE704FE7-E71E-41FB-BAA2-C4403E1182F5")]
    [NativeTypeName("struct IVMRImagePresenter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVMRImagePresenter : IVMRImagePresenter.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRImagePresenter*, Guid*, void**, int>)(lpVtbl[0]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRImagePresenter*, uint>)(lpVtbl[1]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRImagePresenter*, uint>)(lpVtbl[2]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT StartPresenting([NativeTypeName("DWORD_PTR")] nuint dwUserID)
        {
            return ((delegate* unmanaged<IVMRImagePresenter*, nuint, int>)(lpVtbl[3]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this), dwUserID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT StopPresenting([NativeTypeName("DWORD_PTR")] nuint dwUserID)
        {
            return ((delegate* unmanaged<IVMRImagePresenter*, nuint, int>)(lpVtbl[4]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this), dwUserID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT PresentImage([NativeTypeName("DWORD_PTR")] nuint dwUserID, VMRPRESENTATIONINFO* lpPresInfo)
        {
            return ((delegate* unmanaged<IVMRImagePresenter*, nuint, VMRPRESENTATIONINFO*, int>)(lpVtbl[5]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this), dwUserID, lpPresInfo);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT StartPresenting([NativeTypeName("DWORD_PTR")] nuint dwUserID);

            [VtblIndex(4)]
            HRESULT StopPresenting([NativeTypeName("DWORD_PTR")] nuint dwUserID);

            [VtblIndex(5)]
            HRESULT PresentImage([NativeTypeName("DWORD_PTR")] nuint dwUserID, VMRPRESENTATIONINFO* lpPresInfo);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRImagePresenter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRImagePresenter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRImagePresenter*, uint> Release;

            [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRImagePresenter*, nuint, int> StartPresenting;

            [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRImagePresenter*, nuint, int> StopPresenting;

            [NativeTypeName("HRESULT (DWORD_PTR, VMRPRESENTATIONINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRImagePresenter*, nuint, VMRPRESENTATIONINFO*, int> PresentImage;
        }
    }
}
