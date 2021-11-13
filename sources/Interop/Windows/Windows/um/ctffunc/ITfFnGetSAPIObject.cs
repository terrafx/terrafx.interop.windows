// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("5C0AB7EA-167D-4F59-BFB5-4693755E90CA")]
    [NativeTypeName("struct ITfFnGetSAPIObject : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnGetSAPIObject : ITfFnGetSAPIObject.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnGetSAPIObject*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnGetSAPIObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnGetSAPIObject*, uint>)(lpVtbl[1]))((ITfFnGetSAPIObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnGetSAPIObject*, uint>)(lpVtbl[2]))((ITfFnGetSAPIObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnGetSAPIObject*, ushort**, int>)(lpVtbl[3]))((ITfFnGetSAPIObject*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Get(TfSapiObject sObj, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITfFnGetSAPIObject*, TfSapiObject, IUnknown**, int>)(lpVtbl[4]))((ITfFnGetSAPIObject*)Unsafe.AsPointer(ref this), sObj, ppunk);
        }

        public interface Interface : ITfFunction.Interface
        {
            [VtblIndex(4)]
            HRESULT Get(TfSapiObject sObj, IUnknown** ppunk);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnGetSAPIObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnGetSAPIObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnGetSAPIObject*, uint> Release;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnGetSAPIObject*, ushort**, int> GetDisplayName;

            [NativeTypeName("HRESULT (TfSapiObject, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnGetSAPIObject*, TfSapiObject, IUnknown**, int> Get;
        }
    }
}
