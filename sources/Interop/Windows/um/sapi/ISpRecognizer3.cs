// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DF1B943C-5838-4AA2-8706-D7CD5B333499")]
    [NativeTypeName("struct ISpRecognizer3 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpRecognizer3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecognizer3*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecognizer3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecognizer3*, uint>)(lpVtbl[1]))((ISpRecognizer3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecognizer3*, uint>)(lpVtbl[2]))((ISpRecognizer3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCategory(SPCATEGORYTYPE categoryType, ISpRecoCategory** ppCategory)
        {
            return ((delegate* unmanaged<ISpRecognizer3*, SPCATEGORYTYPE, ISpRecoCategory**, int>)(lpVtbl[3]))((ISpRecognizer3*)Unsafe.AsPointer(ref this), categoryType, ppCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetActiveCategory(ISpRecoCategory* pCategory)
        {
            return ((delegate* unmanaged<ISpRecognizer3*, ISpRecoCategory*, int>)(lpVtbl[4]))((ISpRecognizer3*)Unsafe.AsPointer(ref this), pCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetActiveCategory(ISpRecoCategory** ppCategory)
        {
            return ((delegate* unmanaged<ISpRecognizer3*, ISpRecoCategory**, int>)(lpVtbl[5]))((ISpRecognizer3*)Unsafe.AsPointer(ref this), ppCategory);
        }
    }
}
