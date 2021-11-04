// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9EB8A55A-F04B-4D0D-808D-686185D4847A")]
    [NativeTypeName("struct IAppxManifestApplicationsEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestApplicationsEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCurrent(IAppxManifestApplication** application)
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, IAppxManifestApplication**, int>)(lpVtbl[3]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this), application);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetHasCurrent(BOOL* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT MoveNext(BOOL* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestApplicationsEnumerator*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestApplicationsEnumerator*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestApplicationsEnumerator*, uint> Release;

            [NativeTypeName("HRESULT (IAppxManifestApplication **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestApplicationsEnumerator*, IAppxManifestApplication**, int> GetCurrent;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestApplicationsEnumerator*, BOOL*, int> GetHasCurrent;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestApplicationsEnumerator*, BOOL*, int> MoveNext;
        }
    }
}
