// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8EF6ADFE-3762-4A8F-9373-2FC5D444C8D2")]
    [NativeTypeName("struct IAppxManifestQualifiedResourcesEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestQualifiedResourcesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCurrent(IAppxManifestQualifiedResource** resource)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, IAppxManifestQualifiedResource**, int>)(lpVtbl[3]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), resource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetHasCurrent(BOOL* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT MoveNext(BOOL* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, uint> Release;

            [NativeTypeName("HRESULT (IAppxManifestQualifiedResource **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, IAppxManifestQualifiedResource**, int> GetCurrent;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, BOOL*, int> GetHasCurrent;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, BOOL*, int> MoveNext;
        }
    }
}
