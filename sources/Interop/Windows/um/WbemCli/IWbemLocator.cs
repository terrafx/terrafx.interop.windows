// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC12A687-737F-11CF-884D-00AA004B2E24")]
    [NativeTypeName("struct IWbemLocator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWbemLocator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemLocator*, Guid*, void**, int>)(lpVtbl[0]))((IWbemLocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemLocator*, uint>)(lpVtbl[1]))((IWbemLocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemLocator*, uint>)(lpVtbl[2]))((IWbemLocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ConnectServer([NativeTypeName("const BSTR")] ushort* strNetworkResource, [NativeTypeName("const BSTR")] ushort* strUser, [NativeTypeName("const BSTR")] ushort* strPassword, [NativeTypeName("const BSTR")] ushort* strLocale, [NativeTypeName("long")] int lSecurityFlags, [NativeTypeName("const BSTR")] ushort* strAuthority, IWbemContext* pCtx, IWbemServices** ppNamespace)
        {
            return ((delegate* unmanaged<IWbemLocator*, ushort*, ushort*, ushort*, ushort*, int, ushort*, IWbemContext*, IWbemServices**, int>)(lpVtbl[3]))((IWbemLocator*)Unsafe.AsPointer(ref this), strNetworkResource, strUser, strPassword, strLocale, lSecurityFlags, strAuthority, pCtx, ppNamespace);
        }
    }
}
