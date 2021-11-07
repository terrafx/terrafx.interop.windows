// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("6B429B5B-36EF-479E-B9EB-0C1482B49E16")]
    [NativeTypeName("struct IAppxBlockMapBlocksEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBlockMapBlocksEnumerator : IAppxBlockMapBlocksEnumerator.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, uint>)(lpVtbl[1]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, uint>)(lpVtbl[2]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCurrent(IAppxBlockMapBlock** block)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, IAppxBlockMapBlock**, int>)(lpVtbl[3]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetHasCurrent(BOOL* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT MoveNext(BOOL* hasNext)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetCurrent(IAppxBlockMapBlock** block);

            [VtblIndex(4)]
            HRESULT GetHasCurrent(BOOL* hasCurrent);

            [VtblIndex(5)]
            HRESULT MoveNext(BOOL* hasNext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, uint> Release;

            [NativeTypeName("HRESULT (IAppxBlockMapBlock **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, IAppxBlockMapBlock**, int> GetCurrent;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, BOOL*, int> GetHasCurrent;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, BOOL*, int> MoveNext;
        }
    }
}
