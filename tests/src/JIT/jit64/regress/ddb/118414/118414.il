// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

.assembly ILGEN_0x3243f637 {}
.assembly extern mscorlib{auto}

.class ILGEN_0x3243f637 {

    .method static int64  Method_0xa31c545(native int Arg_0x1) {
        .zeroinit 
        .maxstack	9
        .locals (int32 count)

        //BEGIN INIT LOCALS
        ldc.i4.4
        stloc.0
        //END INIT LOCALS

Loop_0x0:
        ldloc.0
        ldc.i4 1 
        sub
        stloc.0

        ldarga Arg_0x1
        ldc.i4 0xeece6911
        stind.i4

        ldarga Arg_0x1
        ldc.i4 0xeece6911
        stind.i

        ldloc.0
        brtrue Loop_0x0

        ldc.i8 100 
        ret
    }

    .method static int32 Main() {
        .entrypoint
        .maxstack	5

        ldc.i4 0xf28bc4c7 
        call int64  ILGEN_0x3243f637::Method_0xa31c545(native int Arg_0x1)
        conv.i4
        ret
    }

}
