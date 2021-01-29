// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA1EA138-19DF-11D7-A6D2-00065B84435C")]
    [NativeTypeName("struct ITfCandidateListUIElement : ITfUIElement")]
    public unsafe partial struct ITfCandidateListUIElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, Guid*, void**, int>)(lpVtbl[0]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, uint>)(lpVtbl[1]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, uint>)(lpVtbl[2]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, ushort**, int>)(lpVtbl[3]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pbstrDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, Guid*, int>)(lpVtbl[4]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("BOOL")] int bShow)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, int, int>)(lpVtbl[5]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), bShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsShown([NativeTypeName("BOOL *")] int* pbShow)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, int*, int>)(lpVtbl[6]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pbShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, int>)(lpVtbl[7]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDocumentMgr([NativeTypeName("ITfDocumentMgr **")] ITfDocumentMgr** ppdim)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, ITfDocumentMgr**, int>)(lpVtbl[8]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), ppdim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* puCount)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, int>)(lpVtbl[9]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), puCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelection([NativeTypeName("UINT *")] uint* puIndex)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, int>)(lpVtbl[10]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), puIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("UINT")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pstr)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, uint, ushort**, int>)(lpVtbl[11]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), uIndex, pstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPageIndex([NativeTypeName("UINT *")] uint* pIndex, [NativeTypeName("UINT")] uint uSize, [NativeTypeName("UINT *")] uint* puPageCnt)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, uint, uint*, int>)(lpVtbl[12]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pIndex, uSize, puPageCnt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPageIndex([NativeTypeName("UINT *")] uint* pIndex, [NativeTypeName("UINT")] uint uPageCnt)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, uint, int>)(lpVtbl[13]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pIndex, uPageCnt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPage([NativeTypeName("UINT *")] uint* puPage)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, int>)(lpVtbl[14]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), puPage);
        }
    }
}
