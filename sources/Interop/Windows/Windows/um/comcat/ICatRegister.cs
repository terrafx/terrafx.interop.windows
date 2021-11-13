// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/comcat.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("0002E012-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ICatRegister : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICatRegister : ICatRegister.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICatRegister*, Guid*, void**, int>)(lpVtbl[0]))((ICatRegister*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICatRegister*, uint>)(lpVtbl[1]))((ICatRegister*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICatRegister*, uint>)(lpVtbl[2]))((ICatRegister*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterCategories([NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATEGORYINFO []")] CATEGORYINFO* rgCategoryInfo)
        {
            return ((delegate* unmanaged<ICatRegister*, uint, CATEGORYINFO*, int>)(lpVtbl[3]))((ICatRegister*)Unsafe.AsPointer(ref this), cCategories, rgCategoryInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnRegisterCategories([NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATID []")] Guid* rgcatid)
        {
            return ((delegate* unmanaged<ICatRegister*, uint, Guid*, int>)(lpVtbl[4]))((ICatRegister*)Unsafe.AsPointer(ref this), cCategories, rgcatid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RegisterClassImplCategories([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATID []")] Guid* rgcatid)
        {
            return ((delegate* unmanaged<ICatRegister*, Guid*, uint, Guid*, int>)(lpVtbl[5]))((ICatRegister*)Unsafe.AsPointer(ref this), rclsid, cCategories, rgcatid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT UnRegisterClassImplCategories([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATID []")] Guid* rgcatid)
        {
            return ((delegate* unmanaged<ICatRegister*, Guid*, uint, Guid*, int>)(lpVtbl[6]))((ICatRegister*)Unsafe.AsPointer(ref this), rclsid, cCategories, rgcatid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RegisterClassReqCategories([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATID []")] Guid* rgcatid)
        {
            return ((delegate* unmanaged<ICatRegister*, Guid*, uint, Guid*, int>)(lpVtbl[7]))((ICatRegister*)Unsafe.AsPointer(ref this), rclsid, cCategories, rgcatid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT UnRegisterClassReqCategories([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATID []")] Guid* rgcatid)
        {
            return ((delegate* unmanaged<ICatRegister*, Guid*, uint, Guid*, int>)(lpVtbl[8]))((ICatRegister*)Unsafe.AsPointer(ref this), rclsid, cCategories, rgcatid);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT RegisterCategories([NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATEGORYINFO []")] CATEGORYINFO* rgCategoryInfo);

            [VtblIndex(4)]
            HRESULT UnRegisterCategories([NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATID []")] Guid* rgcatid);

            [VtblIndex(5)]
            HRESULT RegisterClassImplCategories([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATID []")] Guid* rgcatid);

            [VtblIndex(6)]
            HRESULT UnRegisterClassImplCategories([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATID []")] Guid* rgcatid);

            [VtblIndex(7)]
            HRESULT RegisterClassReqCategories([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATID []")] Guid* rgcatid);

            [VtblIndex(8)]
            HRESULT UnRegisterClassReqCategories([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("ULONG")] uint cCategories, [NativeTypeName("CATID []")] Guid* rgcatid);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICatRegister*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICatRegister*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICatRegister*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, CATEGORYINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICatRegister*, uint, CATEGORYINFO*, int> RegisterCategories;

            [NativeTypeName("HRESULT (ULONG, CATID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICatRegister*, uint, Guid*, int> UnRegisterCategories;

            [NativeTypeName("HRESULT (const IID &, ULONG, CATID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICatRegister*, Guid*, uint, Guid*, int> RegisterClassImplCategories;

            [NativeTypeName("HRESULT (const IID &, ULONG, CATID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICatRegister*, Guid*, uint, Guid*, int> UnRegisterClassImplCategories;

            [NativeTypeName("HRESULT (const IID &, ULONG, CATID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICatRegister*, Guid*, uint, Guid*, int> RegisterClassReqCategories;

            [NativeTypeName("HRESULT (const IID &, ULONG, CATID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICatRegister*, Guid*, uint, Guid*, int> UnRegisterClassReqCategories;
        }
    }
}
