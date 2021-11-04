// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("11D22258-F470-42C1-B291-8361C5437E41")]
    [NativeTypeName("struct IAppxManifestCapabilitiesEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestCapabilitiesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCurrent([NativeTypeName("LPWSTR *")] ushort** capability)
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, ushort**, int>)(lpVtbl[3]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), capability);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetHasCurrent(BOOL* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT MoveNext(BOOL* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, ushort**, int> GetCurrent;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, BOOL*, int> GetHasCurrent;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, BOOL*, int> MoveNext;
        }
    }
}
