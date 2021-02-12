// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7CFF842C-7E97-4807-8304-910DD8F7C051")]
    [NativeTypeName("struct IFileSystemImage3 : IFileSystemImage2")]
    public unsafe partial struct IFileSystemImage3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, Guid*, void**, int>)(lpVtbl[0]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileSystemImage3*, uint>)(lpVtbl[1]))((IFileSystemImage3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileSystemImage3*, uint>)(lpVtbl[2]))((IFileSystemImage3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, uint*, int>)(lpVtbl[3]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Root([NativeTypeName("IFsiDirectoryItem **")] IFsiDirectoryItem** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, IFsiDirectoryItem**, int>)(lpVtbl[7]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SessionStartBlock([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int*, int>)(lpVtbl[8]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_SessionStartBlock([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int, int>)(lpVtbl[9]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FreeMediaBlocks([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int*, int>)(lpVtbl[10]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_FreeMediaBlocks([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int, int>)(lpVtbl[11]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxMediaBlocksFromDevice([NativeTypeName("IDiscRecorder2 *")] IDiscRecorder2* discRecorder)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, IDiscRecorder2*, int>)(lpVtbl[12]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), discRecorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UsedBlocks([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int*, int>)(lpVtbl[13]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeName([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int>)(lpVtbl[14]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_VolumeName([NativeTypeName("BSTR")] ushort* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort*, int>)(lpVtbl[15]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ImportedVolumeName([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int>)(lpVtbl[16]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BootImageOptions([NativeTypeName("IBootOptions **")] IBootOptions** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, IBootOptions**, int>)(lpVtbl[17]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BootImageOptions([NativeTypeName("IBootOptions *")] IBootOptions* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, IBootOptions*, int>)(lpVtbl[18]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileCount([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int*, int>)(lpVtbl[19]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DirectoryCount([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int*, int>)(lpVtbl[20]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WorkingDirectory([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int>)(lpVtbl[21]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_WorkingDirectory([NativeTypeName("BSTR")] ushort* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort*, int>)(lpVtbl[22]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ChangePoint([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int*, int>)(lpVtbl[23]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, short*, int>)(lpVtbl[24]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, short, int>)(lpVtbl[25]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, short*, int>)(lpVtbl[26]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, short, int>)(lpVtbl[27]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileSystemsToCreate([NativeTypeName("FsiFileSystems *")] FsiFileSystems* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems*, int>)(lpVtbl[28]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_FileSystemsToCreate(FsiFileSystems newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems, int>)(lpVtbl[29]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileSystemsSupported([NativeTypeName("FsiFileSystems *")] FsiFileSystems* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems*, int>)(lpVtbl[30]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_UDFRevision([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int, int>)(lpVtbl[31]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UDFRevision([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int*, int>)(lpVtbl[32]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UDFRevisionsSupported([NativeTypeName("SAFEARRAY **")] SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY**, int>)(lpVtbl[33]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChooseImageDefaults([NativeTypeName("IDiscRecorder2 *")] IDiscRecorder2* discRecorder)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, IDiscRecorder2*, int>)(lpVtbl[34]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), discRecorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChooseImageDefaultsForMediaType(IMAPI_MEDIA_PHYSICAL_TYPE value)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, IMAPI_MEDIA_PHYSICAL_TYPE, int>)(lpVtbl[35]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ISO9660InterchangeLevel([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int, int>)(lpVtbl[36]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ISO9660InterchangeLevel([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int*, int>)(lpVtbl[37]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ISO9660InterchangeLevelsSupported([NativeTypeName("SAFEARRAY **")] SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY**, int>)(lpVtbl[38]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateResultImage([NativeTypeName("IFileSystemImageResult **")] IFileSystemImageResult** resultStream)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, IFileSystemImageResult**, int>)(lpVtbl[39]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), resultStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Exists([NativeTypeName("BSTR")] ushort* fullPath, [NativeTypeName("FsiItemType *")] FsiItemType* itemType)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort*, FsiItemType*, int>)(lpVtbl[40]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), fullPath, itemType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CalculateDiscIdentifier([NativeTypeName("BSTR *")] ushort** discIdentifier)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int>)(lpVtbl[41]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), discIdentifier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IdentifyFileSystemsOnDisc([NativeTypeName("IDiscRecorder2 *")] IDiscRecorder2* discRecorder, [NativeTypeName("FsiFileSystems *")] FsiFileSystems* fileSystems)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, IDiscRecorder2*, FsiFileSystems*, int>)(lpVtbl[42]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), discRecorder, fileSystems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFileSystemForImport(FsiFileSystems fileSystems, [NativeTypeName("FsiFileSystems *")] FsiFileSystems* importDefault)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems, FsiFileSystems*, int>)(lpVtbl[43]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), fileSystems, importDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ImportFileSystem([NativeTypeName("FsiFileSystems *")] FsiFileSystems* importedFileSystem)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems*, int>)(lpVtbl[44]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), importedFileSystem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ImportSpecificFileSystem(FsiFileSystems fileSystemToUse)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems, int>)(lpVtbl[45]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), fileSystemToUse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RollbackToChangePoint([NativeTypeName("LONG")] int changePoint)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int, int>)(lpVtbl[46]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), changePoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockInChangePoint()
        {
            return ((delegate* unmanaged<IFileSystemImage3*, int>)(lpVtbl[47]))((IFileSystemImage3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDirectoryItem([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IFsiDirectoryItem **")] IFsiDirectoryItem** newItem)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort*, IFsiDirectoryItem**, int>)(lpVtbl[48]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), name, newItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileItem([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IFsiFileItem **")] IFsiFileItem** newItem)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort*, IFsiFileItem**, int>)(lpVtbl[49]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), name, newItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeNameUDF([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int>)(lpVtbl[50]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeNameJoliet([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int>)(lpVtbl[51]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeNameISO9660([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int>)(lpVtbl[52]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StageFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, short*, int>)(lpVtbl[53]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_StageFiles([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, short, int>)(lpVtbl[54]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MultisessionInterfaces([NativeTypeName("SAFEARRAY **")] SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY**, int>)(lpVtbl[55]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_MultisessionInterfaces([NativeTypeName("SAFEARRAY *")] SAFEARRAY* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY*, int>)(lpVtbl[56]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BootImageOptionsArray([NativeTypeName("SAFEARRAY **")] SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY**, int>)(lpVtbl[57]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BootImageOptionsArray([NativeTypeName("SAFEARRAY *")] SAFEARRAY* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY*, int>)(lpVtbl[58]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CreateRedundantUdfMetadataFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, short*, int>)(lpVtbl[59]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CreateRedundantUdfMetadataFiles([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, short, int>)(lpVtbl[60]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProbeSpecificFileSystem(FsiFileSystems fileSystemToProbe, [NativeTypeName("VARIANT_BOOL *")] short* isAppendable)
        {
            return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems, short*, int>)(lpVtbl[61]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), fileSystemToProbe, isAppendable);
        }
    }
}
