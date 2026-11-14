// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SPTLAUD
{
    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_COMMAND_NOT_FOUND"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_COMMAND_NOT_FOUND AUDCLNT_ERR(0x0200)")]
    public const int SPTLAUD_MD_CLNT_E_COMMAND_NOT_FOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0200))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_OBJECT_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_OBJECT_NOT_INITIALIZED AUDCLNT_ERR(0x0201)")]
    public const int SPTLAUD_MD_CLNT_E_OBJECT_NOT_INITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0201))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_INVALID_ARGS"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_INVALID_ARGS AUDCLNT_ERR(0x0202)")]
    public const int SPTLAUD_MD_CLNT_E_INVALID_ARGS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0202))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_METADATA_FORMAT_NOT_FOUND"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_METADATA_FORMAT_NOT_FOUND AUDCLNT_ERR(0x0203)")]
    public const int SPTLAUD_MD_CLNT_E_METADATA_FORMAT_NOT_FOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0203))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_VALUE_BUFFER_INCORRECT_SIZE"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_VALUE_BUFFER_INCORRECT_SIZE AUDCLNT_ERR(0x0204)")]
    public const int SPTLAUD_MD_CLNT_E_VALUE_BUFFER_INCORRECT_SIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0204))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_MEMORY_BOUNDS"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_MEMORY_BOUNDS AUDCLNT_ERR(0x0205)")]
    public const int SPTLAUD_MD_CLNT_E_MEMORY_BOUNDS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0205))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_NO_MORE_COMMANDS"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_MORE_COMMANDS AUDCLNT_ERR(0x0206)")]
    public const int SPTLAUD_MD_CLNT_E_NO_MORE_COMMANDS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0206))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_BUFFER_ALREADY_ATTACHED"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_BUFFER_ALREADY_ATTACHED AUDCLNT_ERR(0x0207)")]
    public const int SPTLAUD_MD_CLNT_E_BUFFER_ALREADY_ATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0207))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_BUFFER_NOT_ATTACHED"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_BUFFER_NOT_ATTACHED AUDCLNT_ERR(0x0208)")]
    public const int SPTLAUD_MD_CLNT_E_BUFFER_NOT_ATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0208))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_FRAMECOUNT_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_FRAMECOUNT_OUT_OF_RANGE AUDCLNT_ERR(0x0209)")]
    public const int SPTLAUD_MD_CLNT_E_FRAMECOUNT_OUT_OF_RANGE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0209))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_NO_ITEMS_FOUND"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_ITEMS_FOUND AUDCLNT_ERR(0x0210)")]
    public const int SPTLAUD_MD_CLNT_E_NO_ITEMS_FOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0210))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_ITEM_COPY_OVERFLOW"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_ITEM_COPY_OVERFLOW AUDCLNT_ERR(0x0211)")]
    public const int SPTLAUD_MD_CLNT_E_ITEM_COPY_OVERFLOW = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0211))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_NO_ITEMS_OPEN"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_ITEMS_OPEN AUDCLNT_ERR(0x0212)")]
    public const int SPTLAUD_MD_CLNT_E_NO_ITEMS_OPEN = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0212))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_ITEMS_ALREADY_OPEN"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_ITEMS_ALREADY_OPEN AUDCLNT_ERR(0x0213)")]
    public const int SPTLAUD_MD_CLNT_E_ITEMS_ALREADY_OPEN = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0213))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_ATTACH_FAILED_INTERNAL_BUFFER"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_ATTACH_FAILED_INTERNAL_BUFFER AUDCLNT_ERR(0x0214)")]
    public const int SPTLAUD_MD_CLNT_E_ATTACH_FAILED_INTERNAL_BUFFER = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0214))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_DETACH_FAILED_INTERNAL_BUFFER"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_DETACH_FAILED_INTERNAL_BUFFER AUDCLNT_ERR(0x0215)")]
    public const int SPTLAUD_MD_CLNT_E_DETACH_FAILED_INTERNAL_BUFFER = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0215))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_NO_BUFFER_ATTACHED"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_BUFFER_ATTACHED AUDCLNT_ERR(0x0216)")]
    public const int SPTLAUD_MD_CLNT_E_NO_BUFFER_ATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0216))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_NO_MORE_ITEMS"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_MORE_ITEMS AUDCLNT_ERR(0x0217)")]
    public const int SPTLAUD_MD_CLNT_E_NO_MORE_ITEMS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0217))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_FRAMEOFFSET_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_FRAMEOFFSET_OUT_OF_RANGE AUDCLNT_ERR(0x0218)")]
    public const int SPTLAUD_MD_CLNT_E_FRAMEOFFSET_OUT_OF_RANGE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0218))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_ITEM_MUST_HAVE_COMMANDS"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_ITEM_MUST_HAVE_COMMANDS AUDCLNT_ERR(0x0219)")]
    public const int SPTLAUD_MD_CLNT_E_ITEM_MUST_HAVE_COMMANDS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0219))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_NO_ITEMOFFSET_WRITTEN"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_ITEMOFFSET_WRITTEN AUDCLNT_ERR(0x0220)")]
    public const int SPTLAUD_MD_CLNT_E_NO_ITEMOFFSET_WRITTEN = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0220))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_NO_ITEMS_WRITTEN"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_ITEMS_WRITTEN AUDCLNT_ERR(0x0221)")]
    public const int SPTLAUD_MD_CLNT_E_NO_ITEMS_WRITTEN = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0221))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_COMMAND_ALREADY_WRITTEN"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_COMMAND_ALREADY_WRITTEN AUDCLNT_ERR(0x0222)")]
    public const int SPTLAUD_MD_CLNT_E_COMMAND_ALREADY_WRITTEN = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0222))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_FORMAT_MISMATCH"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_FORMAT_MISMATCH AUDCLNT_ERR(0x0223)")]
    public const int SPTLAUD_MD_CLNT_E_FORMAT_MISMATCH = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0223))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_BUFFER_STILL_ATTACHED"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_BUFFER_STILL_ATTACHED AUDCLNT_ERR(0x0224)")]
    public const int SPTLAUD_MD_CLNT_E_BUFFER_STILL_ATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0224))));

    /// <include file='SPTLAUD.xml' path='doc/member[@name="SPTLAUD.SPTLAUD_MD_CLNT_E_ITEMS_LOCKED_FOR_WRITING"]/*' />
    [NativeTypeName("#define SPTLAUD_MD_CLNT_E_ITEMS_LOCKED_FOR_WRITING AUDCLNT_ERR(0x0225)")]
    public const int SPTLAUD_MD_CLNT_E_ITEMS_LOCKED_FOR_WRITING = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0225))));
}
