// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B722BCC8-4E68-101B-A2BC-00AA00404770")]
    [NativeTypeName("struct IEnumOleDocumentViews : IUnknown")]
    public unsafe partial struct IEnumOleDocumentViews
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumOleDocumentViews*, Guid*, void**, int>)(lpVtbl[0]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumOleDocumentViews*, uint>)(lpVtbl[1]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumOleDocumentViews*, uint>)(lpVtbl[2]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cViews, IOleDocumentView** rgpView, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumOleDocumentViews*, uint, IOleDocumentView**, uint*, int>)(lpVtbl[3]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this), cViews, rgpView, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cViews)
        {
            return ((delegate* unmanaged<IEnumOleDocumentViews*, uint, int>)(lpVtbl[4]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this), cViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumOleDocumentViews*, int>)(lpVtbl[5]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumOleDocumentViews** ppEnum)
        {
            return ((delegate* unmanaged<IEnumOleDocumentViews*, IEnumOleDocumentViews**, int>)(lpVtbl[6]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
