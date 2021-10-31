// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("858F956A-972F-42A2-A2F2-0321E1ABE209")]
    [NativeTypeName("struct ITfTransitoryExtensionUIElement : ITfUIElement")]
    [NativeInheritance("ITfUIElement")]
    public unsafe partial struct ITfTransitoryExtensionUIElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionUIElement*, Guid*, void**, int>)(lpVtbl[0]))((ITfTransitoryExtensionUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionUIElement*, uint>)(lpVtbl[1]))((ITfTransitoryExtensionUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionUIElement*, uint>)(lpVtbl[2]))((ITfTransitoryExtensionUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionUIElement*, ushort**, int>)(lpVtbl[3]))((ITfTransitoryExtensionUIElement*)Unsafe.AsPointer(ref this), pbstrDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetGUID([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionUIElement*, Guid*, int>)(lpVtbl[4]))((ITfTransitoryExtensionUIElement*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Show(BOOL bShow)
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionUIElement*, BOOL, int>)(lpVtbl[5]))((ITfTransitoryExtensionUIElement*)Unsafe.AsPointer(ref this), bShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT IsShown(BOOL* pbShow)
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionUIElement*, BOOL*, int>)(lpVtbl[6]))((ITfTransitoryExtensionUIElement*)Unsafe.AsPointer(ref this), pbShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDocumentMgr(ITfDocumentMgr** ppdim)
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionUIElement*, ITfDocumentMgr**, int>)(lpVtbl[7]))((ITfTransitoryExtensionUIElement*)Unsafe.AsPointer(ref this), ppdim);
        }
    }
}
