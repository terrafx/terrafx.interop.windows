// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B9AC5783-FCD0-4B21-B119-B4F8DA8FD2C3")]
    [NativeTypeName("struct ISpeechResourceLoader : IDispatch")]
    public unsafe partial struct ISpeechResourceLoader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechResourceLoader*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechResourceLoader*, uint>)(lpVtbl[1]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechResourceLoader*, uint>)(lpVtbl[2]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechResourceLoader*, uint*, int>)(lpVtbl[3]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechResourceLoader*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechResourceLoader*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechResourceLoader*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadResource([NativeTypeName("BSTR")] ushort* bstrResourceUri, [NativeTypeName("VARIANT_BOOL")] short fAlwaysReload, IUnknown** pStream, [NativeTypeName("BSTR *")] ushort** pbstrMIMEType, [NativeTypeName("VARIANT_BOOL *")] short* pfModified, [NativeTypeName("BSTR *")] ushort** pbstrRedirectUrl)
        {
            return ((delegate* unmanaged<ISpeechResourceLoader*, ushort*, short, IUnknown**, ushort**, short*, ushort**, int>)(lpVtbl[7]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), bstrResourceUri, fAlwaysReload, pStream, pbstrMIMEType, pfModified, pbstrRedirectUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocalCopy([NativeTypeName("BSTR")] ushort* bstrResourceUri, [NativeTypeName("BSTR *")] ushort** pbstrLocalPath, [NativeTypeName("BSTR *")] ushort** pbstrMIMEType, [NativeTypeName("BSTR *")] ushort** pbstrRedirectUrl)
        {
            return ((delegate* unmanaged<ISpeechResourceLoader*, ushort*, ushort**, ushort**, ushort**, int>)(lpVtbl[8]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), bstrResourceUri, pbstrLocalPath, pbstrMIMEType, pbstrRedirectUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseLocalCopy([NativeTypeName("BSTR")] ushort* pbstrLocalPath)
        {
            return ((delegate* unmanaged<ISpeechResourceLoader*, ushort*, int>)(lpVtbl[9]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), pbstrLocalPath);
        }
    }
}
