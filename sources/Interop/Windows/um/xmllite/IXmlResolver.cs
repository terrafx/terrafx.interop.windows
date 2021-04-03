// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7279FC82-709D-4095-B63D-69FE4B0D9030")]
    [NativeTypeName("struct IXmlResolver : IUnknown")]
    public unsafe partial struct IXmlResolver
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXmlResolver*, Guid*, void**, int>)(lpVtbl[0]))((IXmlResolver*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXmlResolver*, uint>)(lpVtbl[1]))((IXmlResolver*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXmlResolver*, uint>)(lpVtbl[2]))((IXmlResolver*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResolveUri([NativeTypeName("LPCWSTR")] ushort* pwszBaseUri, [NativeTypeName("LPCWSTR")] ushort* pwszPublicIdentifier, [NativeTypeName("LPCWSTR")] ushort* pwszSystemIdentifier, IUnknown** ppResolvedInput)
        {
            return ((delegate* unmanaged<IXmlResolver*, ushort*, ushort*, ushort*, IUnknown**, int>)(lpVtbl[3]))((IXmlResolver*)Unsafe.AsPointer(ref this), pwszBaseUri, pwszPublicIdentifier, pwszSystemIdentifier, ppResolvedInput);
        }
    }
}
