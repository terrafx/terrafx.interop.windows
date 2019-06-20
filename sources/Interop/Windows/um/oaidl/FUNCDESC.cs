// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct FUNCDESC
    {
        #region Fields
        [NativeTypeName("MEMBERID")]
        public int memid;

        [NativeTypeName("SCODE")]
        public int* lprgscode;

        [NativeTypeName("ELEMDESC[]")]
        public ELEMDESC* lprgelemdescParam;

        public FUNCKIND funckind;

        public INVOKEKIND invkind;

        public CALLCONV callconv;

        [NativeTypeName("SHORT")]
        public short cParams;

        [NativeTypeName("SHORT")]
        public short cParamsOpt;

        [NativeTypeName("SHORT")]
        public short oVft;

        [NativeTypeName("SHORT")]
        public short cScodes;

        public ELEMDESC elemdescFunc;

        [NativeTypeName("WORD")]
        public ushort wFuncFlags;
        #endregion
    }
}
