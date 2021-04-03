// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A5-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IQualityControl : IUnknown")]
    public unsafe partial struct IQualityControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IQualityControl*, Guid*, void**, int>)(lpVtbl[0]))((IQualityControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQualityControl*, uint>)(lpVtbl[1]))((IQualityControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQualityControl*, uint>)(lpVtbl[2]))((IQualityControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Notify(IBaseFilter* pSelf, Quality q)
        {
            return ((delegate* unmanaged<IQualityControl*, IBaseFilter*, Quality, int>)(lpVtbl[3]))((IQualityControl*)Unsafe.AsPointer(ref this), pSelf, q);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSink(IQualityControl* piqc)
        {
            return ((delegate* unmanaged<IQualityControl*, IQualityControl*, int>)(lpVtbl[4]))((IQualityControl*)Unsafe.AsPointer(ref this), piqc);
        }
    }
}
