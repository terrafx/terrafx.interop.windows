// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AD7C73CF-6DD5-4855-ABC2-B04BAD5B9153")]
    [NativeTypeName("struct IAccServerDocMgr : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAccServerDocMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAccServerDocMgr*, Guid*, void**, int>)(lpVtbl[0]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAccServerDocMgr*, uint>)(lpVtbl[1]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAccServerDocMgr*, uint>)(lpVtbl[2]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT NewDocument([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
        {
            return ((delegate* unmanaged<IAccServerDocMgr*, Guid*, IUnknown*, int>)(lpVtbl[3]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this), riid, punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT RevokeDocument(IUnknown* punk)
        {
            return ((delegate* unmanaged<IAccServerDocMgr*, IUnknown*, int>)(lpVtbl[4]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnDocumentFocus(IUnknown* punk)
        {
            return ((delegate* unmanaged<IAccServerDocMgr*, IUnknown*, int>)(lpVtbl[5]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this), punk);
        }
    }
}
