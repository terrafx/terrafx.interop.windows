// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("027947E1-D731-11CE-A357-000000000001")]
    [NativeTypeName("struct IEnumWbemClassObject : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumWbemClassObject : IEnumWbemClassObject.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumWbemClassObject*, Guid*, void**, int>)(lpVtbl[0]))((IEnumWbemClassObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumWbemClassObject*, uint>)(lpVtbl[1]))((IEnumWbemClassObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumWbemClassObject*, uint>)(lpVtbl[2]))((IEnumWbemClassObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumWbemClassObject*, int>)(lpVtbl[3]))((IEnumWbemClassObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Next([NativeTypeName("long")] int lTimeout, [NativeTypeName("ULONG")] uint uCount, IWbemClassObject** apObjects, [NativeTypeName("ULONG *")] uint* puReturned)
        {
            return ((delegate* unmanaged<IEnumWbemClassObject*, int, uint, IWbemClassObject**, uint*, int>)(lpVtbl[4]))((IEnumWbemClassObject*)Unsafe.AsPointer(ref this), lTimeout, uCount, apObjects, puReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT NextAsync([NativeTypeName("ULONG")] uint uCount, IWbemObjectSink* pSink)
        {
            return ((delegate* unmanaged<IEnumWbemClassObject*, uint, IWbemObjectSink*, int>)(lpVtbl[5]))((IEnumWbemClassObject*)Unsafe.AsPointer(ref this), uCount, pSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumWbemClassObject** ppEnum)
        {
            return ((delegate* unmanaged<IEnumWbemClassObject*, IEnumWbemClassObject**, int>)(lpVtbl[6]))((IEnumWbemClassObject*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Skip([NativeTypeName("long")] int lTimeout, [NativeTypeName("ULONG")] uint nCount)
        {
            return ((delegate* unmanaged<IEnumWbemClassObject*, int, uint, int>)(lpVtbl[7]))((IEnumWbemClassObject*)Unsafe.AsPointer(ref this), lTimeout, nCount);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Reset();

            [VtblIndex(4)]
            HRESULT Next([NativeTypeName("long")] int lTimeout, [NativeTypeName("ULONG")] uint uCount, IWbemClassObject** apObjects, [NativeTypeName("ULONG *")] uint* puReturned);

            [VtblIndex(5)]
            HRESULT NextAsync([NativeTypeName("ULONG")] uint uCount, IWbemObjectSink* pSink);

            [VtblIndex(6)]
            HRESULT Clone(IEnumWbemClassObject** ppEnum);

            [VtblIndex(7)]
            HRESULT Skip([NativeTypeName("long")] int lTimeout, [NativeTypeName("ULONG")] uint nCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumWbemClassObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumWbemClassObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumWbemClassObject*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumWbemClassObject*, int> Reset;

            [NativeTypeName("HRESULT (long, ULONG, IWbemClassObject **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumWbemClassObject*, int, uint, IWbemClassObject**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG, IWbemObjectSink *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumWbemClassObject*, uint, IWbemObjectSink*, int> NextAsync;

            [NativeTypeName("HRESULT (IEnumWbemClassObject **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumWbemClassObject*, IEnumWbemClassObject**, int> Clone;

            [NativeTypeName("HRESULT (long, ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumWbemClassObject*, int, uint, int> Skip;
        }
    }
}
